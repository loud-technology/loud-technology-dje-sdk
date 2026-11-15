#nullable enable

namespace Loud.Technology.Dje.Sdk
{
    public partial interface IPessoaFisicaClient
    {
        /// <summary>
        /// Adicionar uma pessoa física.<br/>
        /// Adicionar uma pessoa física.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> AdicionarAsync(

            global::Loud.Technology.Dje.Sdk.CriarPessoaFisicaInputModel request,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Adicionar uma pessoa física.<br/>
        /// Adicionar uma pessoa física.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> AdicionarAsStreamAsync(

            global::Loud.Technology.Dje.Sdk.CriarPessoaFisicaInputModel request,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Adicionar uma pessoa física.<br/>
        /// Adicionar uma pessoa física.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Dje.Sdk.AutoSDKHttpResponse<byte[]>> AdicionarAsResponseAsync(

            global::Loud.Technology.Dje.Sdk.CriarPessoaFisicaInputModel request,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Adicionar uma pessoa física.<br/>
        /// Adicionar uma pessoa física.
        /// </summary>
        /// <param name="cpf">
        /// Número do Cadastro de Pessoas Físicas da Receita Federal
        /// </param>
        /// <param name="deveNotificar">
        /// Se a pessoa deseja receber notificações por email<br/>
        /// Example: TODAS
        /// </param>
        /// <param name="email">
        /// E-mail (endereço eletrônico) da pessoa
        /// </param>
        /// <param name="hashTermo">
        /// Hash do termo de aceite
        /// </param>
        /// <param name="nomeSocial">
        /// Nome social da pessoa física, nos termos da Resolução nº 270/2018 do CNJ
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> AdicionarAsync(
            string cpf,
            string hashTermo,
            global::Loud.Technology.Dje.Sdk.CriarPessoaFisicaInputModelDeveNotificar? deveNotificar = default,
            string? email = default,
            string? nomeSocial = default,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}