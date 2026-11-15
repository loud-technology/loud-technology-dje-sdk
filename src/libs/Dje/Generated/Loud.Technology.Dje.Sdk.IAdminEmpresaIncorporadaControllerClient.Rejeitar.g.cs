#nullable enable

namespace Loud.Technology.Dje.Sdk
{
    public partial interface IAdminEmpresaIncorporadaControllerClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="idAdmin"></param>
        /// <param name="tenantId"></param>
        /// <param name="idSolicitacao"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task RejeitarAsync(
            long idAdmin,
            global::System.Guid tenantId,
            long idSolicitacao,

            global::Loud.Technology.Dje.Sdk.RejeitarEmpresaIncorporadaInputModel request,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="idAdmin"></param>
        /// <param name="tenantId"></param>
        /// <param name="idSolicitacao"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Dje.Sdk.AutoSDKHttpResponse> RejeitarAsResponseAsync(
            long idAdmin,
            global::System.Guid tenantId,
            long idSolicitacao,

            global::Loud.Technology.Dje.Sdk.RejeitarEmpresaIncorporadaInputModel request,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="idAdmin"></param>
        /// <param name="tenantId"></param>
        /// <param name="idSolicitacao"></param>
        /// <param name="motivo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task RejeitarAsync(
            long idAdmin,
            global::System.Guid tenantId,
            long idSolicitacao,
            string motivo,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}