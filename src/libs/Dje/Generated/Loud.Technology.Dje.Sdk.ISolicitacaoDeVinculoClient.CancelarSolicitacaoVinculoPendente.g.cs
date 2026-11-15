#nullable enable

namespace Loud.Technology.Dje.Sdk
{
    public partial interface ISolicitacaoDeVinculoClient
    {
        /// <summary>
        /// Cancelar solicitação com status pendente.<br/>
        /// Cancelar solicitação com status pendente.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idMatriz"></param>
        /// <param name="idSolicitacao"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> CancelarSolicitacaoVinculoPendenteAsync(
            global::System.Guid tenantId,
            long idMatriz,
            long idSolicitacao,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancelar solicitação com status pendente.<br/>
        /// Cancelar solicitação com status pendente.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idMatriz"></param>
        /// <param name="idSolicitacao"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> CancelarSolicitacaoVinculoPendenteAsStreamAsync(
            global::System.Guid tenantId,
            long idMatriz,
            long idSolicitacao,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancelar solicitação com status pendente.<br/>
        /// Cancelar solicitação com status pendente.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idMatriz"></param>
        /// <param name="idSolicitacao"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Dje.Sdk.AutoSDKHttpResponse<byte[]>> CancelarSolicitacaoVinculoPendenteAsResponseAsync(
            global::System.Guid tenantId,
            long idMatriz,
            long idSolicitacao,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}