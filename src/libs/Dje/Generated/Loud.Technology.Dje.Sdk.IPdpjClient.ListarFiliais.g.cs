#nullable enable

namespace Loud.Technology.Dje.Sdk
{
    public partial interface IPdpjClient
    {
        /// <summary>
        /// Obter lista de filiais de uma matriz por CNPJ a partir da base do PDPJ.<br/>
        /// Obter lista de filiais de uma matriz por CNPJ a partir da base do PDPJ.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idMatriz"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> ListarFiliaisAsync(
            global::System.Guid tenantId,
            long idMatriz,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obter lista de filiais de uma matriz por CNPJ a partir da base do PDPJ.<br/>
        /// Obter lista de filiais de uma matriz por CNPJ a partir da base do PDPJ.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idMatriz"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> ListarFiliaisAsStreamAsync(
            global::System.Guid tenantId,
            long idMatriz,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obter lista de filiais de uma matriz por CNPJ a partir da base do PDPJ.<br/>
        /// Obter lista de filiais de uma matriz por CNPJ a partir da base do PDPJ.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idMatriz"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Dje.Sdk.AutoSDKHttpResponse<byte[]>> ListarFiliaisAsResponseAsync(
            global::System.Guid tenantId,
            long idMatriz,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}