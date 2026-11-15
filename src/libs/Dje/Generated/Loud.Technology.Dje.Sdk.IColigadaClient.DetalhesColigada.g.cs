#nullable enable

namespace Loud.Technology.Dje.Sdk
{
    public partial interface IColigadaClient
    {
        /// <summary>
        /// Obter coligada de uma matriz.<br/>
        /// Obter coligada de uma matriz.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idMatriz"></param>
        /// <param name="idColigada"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> DetalhesColigadaAsync(
            global::System.Guid tenantId,
            long idMatriz,
            long idColigada,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obter coligada de uma matriz.<br/>
        /// Obter coligada de uma matriz.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idMatriz"></param>
        /// <param name="idColigada"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> DetalhesColigadaAsStreamAsync(
            global::System.Guid tenantId,
            long idMatriz,
            long idColigada,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obter coligada de uma matriz.<br/>
        /// Obter coligada de uma matriz.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idMatriz"></param>
        /// <param name="idColigada"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Dje.Sdk.AutoSDKHttpResponse<byte[]>> DetalhesColigadaAsResponseAsync(
            global::System.Guid tenantId,
            long idMatriz,
            long idColigada,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}