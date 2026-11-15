#nullable enable

namespace Loud.Technology.Dje.Sdk
{
    public partial interface IFilialClient
    {
        /// <summary>
        /// Remover o vinculo entre uma matriz e uma filial.<br/>
        /// Remover o vinculo entre uma matriz e uma filial.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idMatriz"></param>
        /// <param name="idFilial"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> Deletar1Async(
            global::System.Guid tenantId,
            long idMatriz,
            long idFilial,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remover o vinculo entre uma matriz e uma filial.<br/>
        /// Remover o vinculo entre uma matriz e uma filial.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idMatriz"></param>
        /// <param name="idFilial"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> Deletar1AsStreamAsync(
            global::System.Guid tenantId,
            long idMatriz,
            long idFilial,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remover o vinculo entre uma matriz e uma filial.<br/>
        /// Remover o vinculo entre uma matriz e uma filial.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idMatriz"></param>
        /// <param name="idFilial"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Dje.Sdk.AutoSDKHttpResponse<byte[]>> Deletar1AsResponseAsync(
            global::System.Guid tenantId,
            long idMatriz,
            long idFilial,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}