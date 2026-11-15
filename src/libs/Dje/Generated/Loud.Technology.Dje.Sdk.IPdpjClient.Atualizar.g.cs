#nullable enable

namespace Loud.Technology.Dje.Sdk
{
    public partial interface IPdpjClient
    {
        /// <summary>
        /// Atualizar uma pessoa física conforme dados da Receita Federal.<br/>
        /// Atualizar uma pessoa física conforme dados da Receita Federal.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idPessoa"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> AtualizarAsync(
            global::System.Guid tenantId,
            long idPessoa,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Atualizar uma pessoa física conforme dados da Receita Federal.<br/>
        /// Atualizar uma pessoa física conforme dados da Receita Federal.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idPessoa"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> AtualizarAsStreamAsync(
            global::System.Guid tenantId,
            long idPessoa,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Atualizar uma pessoa física conforme dados da Receita Federal.<br/>
        /// Atualizar uma pessoa física conforme dados da Receita Federal.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="idPessoa"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Dje.Sdk.AutoSDKHttpResponse<byte[]>> AtualizarAsResponseAsync(
            global::System.Guid tenantId,
            long idPessoa,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}