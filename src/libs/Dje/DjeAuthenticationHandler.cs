using System.Net;
using System.Net.Http.Headers;
using System.Text.Json;

namespace Loud.Technology.Dje.Sdk;

internal sealed class DjeAuthenticationHandler : DelegatingHandler
{
    private const int DefaultTokenLifetimeSeconds = 300;
    private static readonly TimeSpan RenewalMargin = TimeSpan.FromSeconds(60);

    private readonly DjeClientCredentials _credentials;
    private readonly TimeProvider _timeProvider;
    private readonly SemaphoreSlim _gate = new(1, 1);
    private CachedToken? _cached;

    public DjeAuthenticationHandler(
        DjeClientCredentials credentials,
        HttpMessageHandler innerHandler,
        TimeProvider timeProvider)
        : base(innerHandler)
    {
        _credentials = credentials;
        _timeProvider = timeProvider;
    }

    protected override async Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        if (request.Content is not null)
        {
            await request.Content.LoadIntoBufferAsync(cancellationToken).ConfigureAwait(false);
        }

        var token = await GetTokenAsync(rejectedToken: null, cancellationToken).ConfigureAwait(false);
        var response = await SendWithTokenAsync(request, token, cancellationToken).ConfigureAwait(false);
        if (response.StatusCode != HttpStatusCode.Unauthorized)
        {
            return response;
        }

        response.Dispose();
        token = await GetTokenAsync(rejectedToken: token, cancellationToken).ConfigureAwait(false);
        using var retry = await CloneAsync(request, cancellationToken).ConfigureAwait(false);
        response = await SendWithTokenAsync(retry, token, cancellationToken).ConfigureAwait(false);
        response.RequestMessage = request;
        return response;
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            _gate.Dispose();
        }

        base.Dispose(disposing);
    }

    private static async Task<HttpRequestMessage> CloneAsync(
        HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        var clone = new HttpRequestMessage(request.Method, request.RequestUri)
        {
            Version = request.Version,
            VersionPolicy = request.VersionPolicy,
        };

        foreach (var header in request.Headers)
        {
            clone.Headers.TryAddWithoutValidation(header.Key, header.Value);
        }

        if (request.Content is not null)
        {
            var content = new ByteArrayContent(
                await request.Content.ReadAsByteArrayAsync(cancellationToken).ConfigureAwait(false));
            foreach (var header in request.Content.Headers)
            {
                content.Headers.TryAddWithoutValidation(header.Key, header.Value);
            }

            clone.Content = content;
        }

        return clone;
    }

    private Task<HttpResponseMessage> SendWithTokenAsync(
        HttpRequestMessage request,
        string token,
        CancellationToken cancellationToken)
    {
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
        request.Headers.Remove("User-Agent");
        request.Headers.TryAddWithoutValidation("User-Agent", _credentials.UserAgent);
        return base.SendAsync(request, cancellationToken);
    }

    private async Task<string> GetTokenAsync(string? rejectedToken, CancellationToken cancellationToken)
    {
        await _gate.WaitAsync(cancellationToken).ConfigureAwait(false);
        try
        {
            if (_cached is { } cached && cached.Value != rejectedToken && !cached.IsExpired(_timeProvider))
            {
                return cached.Value;
            }

            _cached = await RequestTokenAsync(cancellationToken).ConfigureAwait(false);
            return _cached.Value;
        }
        finally
        {
            _gate.Release();
        }
    }

    private async Task<CachedToken> RequestTokenAsync(CancellationToken cancellationToken)
    {
        List<KeyValuePair<string, string>> form =
        [
            new("grant_type", "client_credentials"),
            new("client_id", _credentials.ClientId),
            new("client_secret", _credentials.ClientSecret),
        ];
        if (!string.IsNullOrWhiteSpace(_credentials.Scope))
        {
            form.Add(new("scope", _credentials.Scope));
        }

        using var request = new HttpRequestMessage(HttpMethod.Post, _credentials.TokenUrl)
        {
            Content = new FormUrlEncodedContent(form),
        };
        request.Headers.TryAddWithoutValidation("User-Agent", _credentials.UserAgent);

        var issuedAt = _timeProvider.GetTimestamp();
        using var response = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
        if (!response.IsSuccessStatusCode)
        {
            throw new HttpRequestException(
                $"The DJE token request failed with {(int)response.StatusCode} {response.StatusCode}.",
                inner: null,
                response.StatusCode);
        }

        var body = await response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
        using var document = await JsonDocument.ParseAsync(body, cancellationToken: cancellationToken).ConfigureAwait(false);
        var root = document.RootElement;
        var accessToken = root.TryGetProperty("access_token", out var value) && value.ValueKind == JsonValueKind.String
            ? value.GetString()
            : null;
        if (string.IsNullOrEmpty(accessToken))
        {
            throw new HttpRequestException("The DJE token response has no access_token.");
        }

        var expiresIn = root.TryGetProperty("expires_in", out var seconds) && seconds.TryGetInt32(out var parsed)
            ? parsed
            : DefaultTokenLifetimeSeconds;
        return new CachedToken(accessToken, issuedAt, TimeSpan.FromSeconds(expiresIn) - RenewalMargin);
    }

    private sealed record CachedToken(string Value, long IssuedAt, TimeSpan Lifetime)
    {
        public bool IsExpired(TimeProvider timeProvider) => timeProvider.GetElapsedTime(IssuedAt) >= Lifetime;
    }
}
