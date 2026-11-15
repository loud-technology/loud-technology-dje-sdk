#nullable enable

namespace Loud.Technology.Dje.Sdk
{
    public partial interface IMatrizClient
    {
        /// <summary>
        /// Alterar uma matriz.<br/>
        /// Alterar uma matriz.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idMatriz"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task Editar3Async(
            global::System.Guid tenantId,
            long idMatriz,

            global::Loud.Technology.Dje.Sdk.AlterarMatrizInputModel request,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Alterar uma matriz.<br/>
        /// Alterar uma matriz.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idMatriz"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Dje.Sdk.AutoSDKHttpResponse> Editar3AsResponseAsync(
            global::System.Guid tenantId,
            long idMatriz,

            global::Loud.Technology.Dje.Sdk.AlterarMatrizInputModel request,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Alterar uma matriz.<br/>
        /// Alterar uma matriz.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idMatriz"></param>
        /// <param name="email">
        /// E-mail (endereço eletrônico) da pessoa
        /// </param>
        /// <param name="endereco">
        /// Endereço da pessoa jurídica
        /// </param>
        /// <param name="representanteJuridico">
        /// Informações do representante júridico
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task Editar3Async(
            global::System.Guid tenantId,
            long idMatriz,
            global::Loud.Technology.Dje.Sdk.EditarRepresentanteJuridicoInputModel representanteJuridico,
            string? email = default,
            global::Loud.Technology.Dje.Sdk.EditarEnderecoInputModel? endereco = default,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}