#nullable enable

namespace Loud.Technology.Dje.Sdk
{
    public partial interface IPessoaJúridicaClient
    {
        /// <summary>
        /// Obter lista de pessoas juridicas a partir de um filtro.<br/>
        /// Obter lista de pessoas juridicas a partir de um filtro.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="spec"></param>
        /// <param name="pageable"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> FiltrarAsync(
            global::System.Guid tenantId,
            global::Loud.Technology.Dje.Sdk.SpecificationEmpresaPrivada spec,
            global::Loud.Technology.Dje.Sdk.Pageable pageable,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obter lista de pessoas juridicas a partir de um filtro.<br/>
        /// Obter lista de pessoas juridicas a partir de um filtro.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="spec"></param>
        /// <param name="pageable"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> FiltrarAsStreamAsync(
            global::System.Guid tenantId,
            global::Loud.Technology.Dje.Sdk.SpecificationEmpresaPrivada spec,
            global::Loud.Technology.Dje.Sdk.Pageable pageable,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obter lista de pessoas juridicas a partir de um filtro.<br/>
        /// Obter lista de pessoas juridicas a partir de um filtro.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="spec"></param>
        /// <param name="pageable"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Dje.Sdk.AutoSDKHttpResponse<byte[]>> FiltrarAsResponseAsync(
            global::System.Guid tenantId,
            global::Loud.Technology.Dje.Sdk.SpecificationEmpresaPrivada spec,
            global::Loud.Technology.Dje.Sdk.Pageable pageable,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}