#nullable enable

namespace Loud.Technology.Dje.Sdk
{
    public partial interface IEmpresaIncorporadaClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="id"></param>
        /// <param name="idSolicitacao"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task CancelarSolicitacaoAsync(
            global::System.Guid tenantId,
            long id,
            long idSolicitacao,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="id"></param>
        /// <param name="idSolicitacao"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Dje.Sdk.AutoSDKHttpResponse> CancelarSolicitacaoAsResponseAsync(
            global::System.Guid tenantId,
            long id,
            long idSolicitacao,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}