#nullable enable

namespace Loud.Technology.Dje.Sdk
{
    public partial interface ISolicitacaoDeVinculoClient
    {
        /// <summary>
        /// Obter detalhes solicitação.<br/>
        /// Obter detalhes solicitação.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idMatriz"></param>
        /// <param name="idSolicitacao"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> ObterDetalhesSolicitacaoAsync(
            global::System.Guid tenantId,
            long idMatriz,
            long idSolicitacao,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obter detalhes solicitação.<br/>
        /// Obter detalhes solicitação.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idMatriz"></param>
        /// <param name="idSolicitacao"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> ObterDetalhesSolicitacaoAsStreamAsync(
            global::System.Guid tenantId,
            long idMatriz,
            long idSolicitacao,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obter detalhes solicitação.<br/>
        /// Obter detalhes solicitação.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idMatriz"></param>
        /// <param name="idSolicitacao"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Dje.Sdk.AutoSDKHttpResponse<byte[]>> ObterDetalhesSolicitacaoAsResponseAsync(
            global::System.Guid tenantId,
            long idMatriz,
            long idSolicitacao,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}