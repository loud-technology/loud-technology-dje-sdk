#nullable enable

namespace Loud.Technology.Dje.Sdk
{
    public partial interface IPessoaFísicaClient
    {
        /// <summary>
        /// Remover uma pessoa física pelo id.<br/>
        /// Remover uma pessoa física pelo id.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> RemoverAsync(
            global::System.Guid tenantId,
            long id,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remover uma pessoa física pelo id.<br/>
        /// Remover uma pessoa física pelo id.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> RemoverAsStreamAsync(
            global::System.Guid tenantId,
            long id,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remover uma pessoa física pelo id.<br/>
        /// Remover uma pessoa física pelo id.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Dje.Sdk.AutoSDKHttpResponse<byte[]>> RemoverAsResponseAsync(
            global::System.Guid tenantId,
            long id,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}