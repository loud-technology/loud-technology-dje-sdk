#nullable enable

namespace Loud.Technology.Dje.Sdk
{
    public partial interface IPessoaFísicaClient
    {
        /// <summary>
        /// Alterar uma pessoa física.<br/>
        /// Alterar uma pessoa física.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task Editar2Async(
            global::System.Guid tenantId,
            long id,

            global::Loud.Technology.Dje.Sdk.AtualizarPessoaFisicaInputModel request,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Alterar uma pessoa física.<br/>
        /// Alterar uma pessoa física.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Dje.Sdk.AutoSDKHttpResponse> Editar2AsResponseAsync(
            global::System.Guid tenantId,
            long id,

            global::Loud.Technology.Dje.Sdk.AtualizarPessoaFisicaInputModel request,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Alterar uma pessoa física.<br/>
        /// Alterar uma pessoa física.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="id"></param>
        /// <param name="email">
        /// E-mail (endereço eletrônico) da pessoa
        /// </param>
        /// <param name="habilitada">
        /// Se já está habilitada para receber citações/intimações pelo Domicílio Eletrônico (ou seja, se já assinou o termo de aceite e responsabilidade de uso do sistema)
        /// </param>
        /// <param name="nomeSocial">
        /// Nome social da pessoa física, nos termos da Resolução nº 270/2018 do CNJ
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task Editar2Async(
            global::System.Guid tenantId,
            long id,
            bool habilitada,
            string? email = default,
            string? nomeSocial = default,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}