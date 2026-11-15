#nullable enable

namespace Loud.Technology.Dje.Sdk
{
    public partial interface IRepresentantesClient
    {
        /// <summary>
        /// Retorna a lista dos representados para o intervalo de datas especificado.<br/>
        /// Retorna a lista dos representados para o intervalo de datas especificado
        /// </summary>
        /// <param name="dataInicio"></param>
        /// <param name="dataFim"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Dje.Sdk.ComunicacaoProcessualViewModel> ListarRepresentadosAsync(
            global::System.DateTime? dataInicio = default,
            global::System.DateTime? dataFim = default,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retorna a lista dos representados para o intervalo de datas especificado.<br/>
        /// Retorna a lista dos representados para o intervalo de datas especificado
        /// </summary>
        /// <param name="dataInicio"></param>
        /// <param name="dataFim"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Dje.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Dje.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Dje.Sdk.ComunicacaoProcessualViewModel>> ListarRepresentadosAsResponseAsync(
            global::System.DateTime? dataInicio = default,
            global::System.DateTime? dataFim = default,
            global::Loud.Technology.Dje.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}