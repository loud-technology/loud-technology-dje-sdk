#nullable enable

namespace Loud.Technology.Dje.Sdk
{
    public partial interface IExportarPessoasClient
    {
        /// <summary>
        /// Exportar pessoas por passando 1 ou mais datas.<br/>
        /// Exportar pessoas por passando 1 ou mais datas.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task Executar2Async(

            global::System.Collections.Generic.IList<string> request,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Exportar pessoas por passando 1 ou mais datas.<br/>
        /// Exportar pessoas por passando 1 ou mais datas.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Dje.Sdk.AutoSDKHttpResponse> Executar2AsResponseAsync(

            global::System.Collections.Generic.IList<string> request,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}