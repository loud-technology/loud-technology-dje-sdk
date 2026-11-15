#nullable enable

namespace Loud.Technology.Dje.Sdk
{
    public partial interface IFilialClient
    {
        /// <summary>
        /// Adicionar uma filial a uma matriz.<br/>
        /// Adicionar uma filial a uma matriz.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idMatriz"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task Adicionar2Async(
            global::System.Guid tenantId,
            long idMatriz,

            global::Loud.Technology.Dje.Sdk.AdicionarFilialInputModel request,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Adicionar uma filial a uma matriz.<br/>
        /// Adicionar uma filial a uma matriz.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idMatriz"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Dje.Sdk.AutoSDKHttpResponse> Adicionar2AsResponseAsync(
            global::System.Guid tenantId,
            long idMatriz,

            global::Loud.Technology.Dje.Sdk.AdicionarFilialInputModel request,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Adicionar uma filial a uma matriz.<br/>
        /// Adicionar uma filial a uma matriz.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idMatriz"></param>
        /// <param name="cnpj">
        /// Número do Cadastro Nacional de Pessoas Jurídicas da Receita Federal
        /// </param>
        /// <param name="email">
        /// E-mail (endereço eletrônico) da pessoa
        /// </param>
        /// <param name="endereco">
        /// Endereço da pessoa jurídica
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task Adicionar2Async(
            global::System.Guid tenantId,
            long idMatriz,
            string cnpj,
            string? email = default,
            global::Loud.Technology.Dje.Sdk.EditarEnderecoInputModel? endereco = default,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}