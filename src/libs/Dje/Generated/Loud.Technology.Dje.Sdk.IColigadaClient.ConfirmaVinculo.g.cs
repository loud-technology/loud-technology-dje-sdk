#nullable enable

namespace Loud.Technology.Dje.Sdk
{
    public partial interface IColigadaClient
    {
        /// <summary>
        /// Confirmar solicitação de vinculo de coligação a uma matriz.<br/>
        /// Confirmar solicitação de vinculo de coligação a uma matriz.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idMatrizSolicitante"></param>
        /// <param name="idMatrizSolicitada"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> ConfirmaVinculoAsync(
            global::System.Guid tenantId,
            long idMatrizSolicitante,
            long idMatrizSolicitada,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Confirmar solicitação de vinculo de coligação a uma matriz.<br/>
        /// Confirmar solicitação de vinculo de coligação a uma matriz.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idMatrizSolicitante"></param>
        /// <param name="idMatrizSolicitada"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> ConfirmaVinculoAsStreamAsync(
            global::System.Guid tenantId,
            long idMatrizSolicitante,
            long idMatrizSolicitada,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Confirmar solicitação de vinculo de coligação a uma matriz.<br/>
        /// Confirmar solicitação de vinculo de coligação a uma matriz.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idMatrizSolicitante"></param>
        /// <param name="idMatrizSolicitada"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Dje.Sdk.AutoSDKHttpResponse<byte[]>> ConfirmaVinculoAsResponseAsync(
            global::System.Guid tenantId,
            long idMatrizSolicitante,
            long idMatrizSolicitada,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}