#nullable enable

namespace Loud.Technology.Dje.Sdk
{
    public partial interface IPdpjClient
    {
        /// <summary>
        /// Obter informações de uma pessoa Jurídica a partir da base do PDPJ.<br/>
        /// Obter informações de uma pessoa Jurídica a partir da base do PDPJ.
        /// </summary>
        /// <param name="cnpj"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> ObterPessoaJuridicaPDPJAsync(
            string cnpj,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obter informações de uma pessoa Jurídica a partir da base do PDPJ.<br/>
        /// Obter informações de uma pessoa Jurídica a partir da base do PDPJ.
        /// </summary>
        /// <param name="cnpj"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> ObterPessoaJuridicaPDPJAsStreamAsync(
            string cnpj,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obter informações de uma pessoa Jurídica a partir da base do PDPJ.<br/>
        /// Obter informações de uma pessoa Jurídica a partir da base do PDPJ.
        /// </summary>
        /// <param name="cnpj"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Dje.Sdk.AutoSDKHttpResponse<byte[]>> ObterPessoaJuridicaPDPJAsResponseAsync(
            string cnpj,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}