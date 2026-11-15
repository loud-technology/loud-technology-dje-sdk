#nullable enable

namespace Loud.Technology.Dje.Sdk
{
    public partial interface IOrgaoPublicoControllerClient
    {
        /// <summary>
        /// Obter orgaos vinculados.<br/>
        /// Obter orgaos vinculados.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="id"></param>
        /// <param name="input"></param>
        /// <param name="pageable"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> ObterVinculosOrgaoPublicoAsync(
            global::System.Guid tenantId,
            long id,
            global::Loud.Technology.Dje.Sdk.ObterVinculosOrgaoPublico input,
            global::Loud.Technology.Dje.Sdk.Pageable pageable,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obter orgaos vinculados.<br/>
        /// Obter orgaos vinculados.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="id"></param>
        /// <param name="input"></param>
        /// <param name="pageable"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> ObterVinculosOrgaoPublicoAsStreamAsync(
            global::System.Guid tenantId,
            long id,
            global::Loud.Technology.Dje.Sdk.ObterVinculosOrgaoPublico input,
            global::Loud.Technology.Dje.Sdk.Pageable pageable,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obter orgaos vinculados.<br/>
        /// Obter orgaos vinculados.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="id"></param>
        /// <param name="input"></param>
        /// <param name="pageable"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Dje.Sdk.AutoSDKHttpResponse<byte[]>> ObterVinculosOrgaoPublicoAsResponseAsync(
            global::System.Guid tenantId,
            long id,
            global::Loud.Technology.Dje.Sdk.ObterVinculosOrgaoPublico input,
            global::Loud.Technology.Dje.Sdk.Pageable pageable,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}