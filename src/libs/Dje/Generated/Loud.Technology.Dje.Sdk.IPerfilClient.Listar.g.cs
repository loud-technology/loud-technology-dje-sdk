#nullable enable

namespace Loud.Technology.Dje.Sdk
{
    public partial interface IPerfilClient
    {
        /// <summary>
        /// Obter perfis da pessoa informada.<br/>
        /// Obter perfis da pessoa informada.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="cargo"></param>
        /// <param name="nome"></param>
        /// <param name="cpf"></param>
        /// <param name="page">
        /// Default Value: 0
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="sort"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> ListarAsync(
            global::System.Guid tenantId,
            global::Loud.Technology.Dje.Sdk.ListarCargo? cargo = default,
            string? nome = default,
            string? cpf = default,
            int? page = default,
            int? size = default,
            global::System.Collections.Generic.IList<string>? sort = default,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obter perfis da pessoa informada.<br/>
        /// Obter perfis da pessoa informada.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="cargo"></param>
        /// <param name="nome"></param>
        /// <param name="cpf"></param>
        /// <param name="page">
        /// Default Value: 0
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="sort"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> ListarAsStreamAsync(
            global::System.Guid tenantId,
            global::Loud.Technology.Dje.Sdk.ListarCargo? cargo = default,
            string? nome = default,
            string? cpf = default,
            int? page = default,
            int? size = default,
            global::System.Collections.Generic.IList<string>? sort = default,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obter perfis da pessoa informada.<br/>
        /// Obter perfis da pessoa informada.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="cargo"></param>
        /// <param name="nome"></param>
        /// <param name="cpf"></param>
        /// <param name="page">
        /// Default Value: 0
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="sort"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Dje.Sdk.AutoSDKHttpResponse<byte[]>> ListarAsResponseAsync(
            global::System.Guid tenantId,
            global::Loud.Technology.Dje.Sdk.ListarCargo? cargo = default,
            string? nome = default,
            string? cpf = default,
            int? page = default,
            int? size = default,
            global::System.Collections.Generic.IList<string>? sort = default,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}