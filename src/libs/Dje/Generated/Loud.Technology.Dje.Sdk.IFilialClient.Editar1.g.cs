#nullable enable

namespace Loud.Technology.Dje.Sdk
{
    public partial interface IFilialClient
    {
        /// <summary>
        /// Alterar uma filial.<br/>
        /// Alterar uma filial.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idMatriz"></param>
        /// <param name="idFilial"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> Editar1Async(
            global::System.Guid tenantId,
            long idMatriz,
            long idFilial,

            global::Loud.Technology.Dje.Sdk.AtualizarFilialInputModel request,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Alterar uma filial.<br/>
        /// Alterar uma filial.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idMatriz"></param>
        /// <param name="idFilial"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> Editar1AsStreamAsync(
            global::System.Guid tenantId,
            long idMatriz,
            long idFilial,

            global::Loud.Technology.Dje.Sdk.AtualizarFilialInputModel request,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Alterar uma filial.<br/>
        /// Alterar uma filial.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idMatriz"></param>
        /// <param name="idFilial"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Dje.Sdk.AutoSDKHttpResponse<byte[]>> Editar1AsResponseAsync(
            global::System.Guid tenantId,
            long idMatriz,
            long idFilial,

            global::Loud.Technology.Dje.Sdk.AtualizarFilialInputModel request,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Alterar uma filial.<br/>
        /// Alterar uma filial.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idMatriz"></param>
        /// <param name="idFilial"></param>
        /// <param name="email"></param>
        /// <param name="endereco">
        /// Endereço da pessoa jurídica
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> Editar1Async(
            global::System.Guid tenantId,
            long idMatriz,
            long idFilial,
            string email,
            global::Loud.Technology.Dje.Sdk.EditarEnderecoInputModel? endereco = default,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}