
#nullable enable

namespace Loud.Technology.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RespostaPaginadaEmpresaPrivada
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.EmpresaPrivada>? Data { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        public global::Loud.Technology.Dje.Sdk.Paginacao? Page { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RespostaPaginadaEmpresaPrivada" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="page"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RespostaPaginadaEmpresaPrivada(
            global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.EmpresaPrivada>? data,
            global::Loud.Technology.Dje.Sdk.Paginacao? page)
        {
            this.Data = data;
            this.Page = page;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RespostaPaginadaEmpresaPrivada" /> class.
        /// </summary>
        public RespostaPaginadaEmpresaPrivada()
        {
        }

    }
}