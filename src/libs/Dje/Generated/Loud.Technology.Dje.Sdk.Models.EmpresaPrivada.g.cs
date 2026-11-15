
#nullable enable

namespace Loud.Technology.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EmpresaPrivada
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("atividadeEconomica")]
        public global::Loud.Technology.Dje.Sdk.AtividadeEconomicaVO? AtividadeEconomica { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ativo")]
        public bool? Ativo { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cnpj")]
        public string? Cnpj { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("coligadas")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.EmpresaPrivada>? Coligadas { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("coliganda")]
        public global::Loud.Technology.Dje.Sdk.IColiganda? Coliganda { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpfCnpj")]
        public string? CpfCnpj { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataHabilitacao")]
        public global::System.DateTime? DataHabilitacao { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataUltimaDesabiltiacao")]
        public global::System.DateTime? DataUltimaDesabiltiacao { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emailSpecification")]
        public global::Loud.Technology.Dje.Sdk.EmailSpecification? EmailSpecification { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endereco")]
        public global::Loud.Technology.Dje.Sdk.EnderecoVO? Endereco { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excluidoEm")]
        public global::System.DateTime? ExcluidoEm { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filiais")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.EmpresaPrivada>? Filiais { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("habilitada")]
        public bool? Habilitada { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("habilitador")]
        public string? Habilitador { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hashTermoAceite")]
        public string? HashTermoAceite { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("infoAuditoriaVO")]
        public global::Loud.Technology.Dje.Sdk.InfoAuditoriaVO? InfoAuditoriaVO { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("infoValidacaoValueObject")]
        public global::Loud.Technology.Dje.Sdk.InfoValidacaoValueObject? InfoValidacaoValueObject { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matriz")]
        public global::Loud.Technology.Dje.Sdk.EmpresaPrivada? Matriz { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("naturezaJuridica")]
        public global::Loud.Technology.Dje.Sdk.NaturezaJuridicaVO? NaturezaJuridica { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nomeFantasia")]
        public string? NomeFantasia { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notificacao")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.INotification>? Notificacao { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgaoPublico")]
        public bool? OrgaoPublico { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("perfilRepresentante")]
        public global::Loud.Technology.Dje.Sdk.Perfil? PerfilRepresentante { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("porte")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.EmpresaPrivadaPorteJsonConverter))]
        public global::Loud.Technology.Dje.Sdk.EmpresaPrivadaPorte? Porte { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("razaoSocial")]
        public string? RazaoSocial { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("representanteJuridico")]
        public global::Loud.Technology.Dje.Sdk.RepresentanteJuridicoVO? RepresentanteJuridico { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("solicitacoes")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.SolicitacaoVinculo>? Solicitacoes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusCadastro")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.EmpresaPrivadaStatusCadastroJsonConverter))]
        public global::Loud.Technology.Dje.Sdk.EmpresaPrivadaStatusCadastro? StatusCadastro { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenantId")]
        public global::System.Guid? TenantId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("termoAceito")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.ITermoAceite>? TermoAceito { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("termos")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.PessoaTermo>? Termos { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipoEmpresa")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.EmpresaPrivadaTipoEmpresaJsonConverter))]
        public global::Loud.Technology.Dje.Sdk.EmpresaPrivadaTipoEmpresa? TipoEmpresa { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipoEspecializacao")]
        public long? TipoEspecializacao { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipoOrgaoPublico")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.EmpresaPrivadaTipoOrgaoPublicoJsonConverter))]
        public global::Loud.Technology.Dje.Sdk.EmpresaPrivadaTipoOrgaoPublico? TipoOrgaoPublico { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipoPessoa")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.EmpresaPrivadaTipoPessoaJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.Dje.Sdk.EmpresaPrivadaTipoPessoa TipoPessoa { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usuario")]
        public global::Loud.Technology.Dje.Sdk.Usuario? Usuario { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validatorPerfilInfoInput")]
        public global::Loud.Technology.Dje.Sdk.ValidatorPerfilInfoInput? ValidatorPerfilInfoInput { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmpresaPrivada" /> class.
        /// </summary>
        /// <param name="tipoPessoa"></param>
        /// <param name="atividadeEconomica"></param>
        /// <param name="ativo"></param>
        /// <param name="cnpj"></param>
        /// <param name="coligadas"></param>
        /// <param name="coliganda"></param>
        /// <param name="cpfCnpj"></param>
        /// <param name="dataHabilitacao"></param>
        /// <param name="dataUltimaDesabiltiacao"></param>
        /// <param name="email"></param>
        /// <param name="emailSpecification"></param>
        /// <param name="endereco"></param>
        /// <param name="excluidoEm"></param>
        /// <param name="filiais"></param>
        /// <param name="habilitada"></param>
        /// <param name="habilitador"></param>
        /// <param name="hashTermoAceite"></param>
        /// <param name="id"></param>
        /// <param name="infoAuditoriaVO"></param>
        /// <param name="infoValidacaoValueObject"></param>
        /// <param name="matriz"></param>
        /// <param name="naturezaJuridica"></param>
        /// <param name="nomeFantasia"></param>
        /// <param name="notificacao"></param>
        /// <param name="orgaoPublico"></param>
        /// <param name="perfilRepresentante"></param>
        /// <param name="porte"></param>
        /// <param name="razaoSocial"></param>
        /// <param name="representanteJuridico"></param>
        /// <param name="solicitacoes"></param>
        /// <param name="statusCadastro"></param>
        /// <param name="tenantId"></param>
        /// <param name="termoAceito"></param>
        /// <param name="termos"></param>
        /// <param name="tipoEmpresa"></param>
        /// <param name="tipoEspecializacao"></param>
        /// <param name="tipoOrgaoPublico"></param>
        /// <param name="usuario"></param>
        /// <param name="validatorPerfilInfoInput"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmpresaPrivada(
            global::Loud.Technology.Dje.Sdk.EmpresaPrivadaTipoPessoa tipoPessoa,
            global::Loud.Technology.Dje.Sdk.AtividadeEconomicaVO? atividadeEconomica,
            bool? ativo,
            string? cnpj,
            global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.EmpresaPrivada>? coligadas,
            global::Loud.Technology.Dje.Sdk.IColiganda? coliganda,
            string? cpfCnpj,
            global::System.DateTime? dataHabilitacao,
            global::System.DateTime? dataUltimaDesabiltiacao,
            string? email,
            global::Loud.Technology.Dje.Sdk.EmailSpecification? emailSpecification,
            global::Loud.Technology.Dje.Sdk.EnderecoVO? endereco,
            global::System.DateTime? excluidoEm,
            global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.EmpresaPrivada>? filiais,
            bool? habilitada,
            string? habilitador,
            string? hashTermoAceite,
            long? id,
            global::Loud.Technology.Dje.Sdk.InfoAuditoriaVO? infoAuditoriaVO,
            global::Loud.Technology.Dje.Sdk.InfoValidacaoValueObject? infoValidacaoValueObject,
            global::Loud.Technology.Dje.Sdk.EmpresaPrivada? matriz,
            global::Loud.Technology.Dje.Sdk.NaturezaJuridicaVO? naturezaJuridica,
            string? nomeFantasia,
            global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.INotification>? notificacao,
            bool? orgaoPublico,
            global::Loud.Technology.Dje.Sdk.Perfil? perfilRepresentante,
            global::Loud.Technology.Dje.Sdk.EmpresaPrivadaPorte? porte,
            string? razaoSocial,
            global::Loud.Technology.Dje.Sdk.RepresentanteJuridicoVO? representanteJuridico,
            global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.SolicitacaoVinculo>? solicitacoes,
            global::Loud.Technology.Dje.Sdk.EmpresaPrivadaStatusCadastro? statusCadastro,
            global::System.Guid? tenantId,
            global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.ITermoAceite>? termoAceito,
            global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.PessoaTermo>? termos,
            global::Loud.Technology.Dje.Sdk.EmpresaPrivadaTipoEmpresa? tipoEmpresa,
            long? tipoEspecializacao,
            global::Loud.Technology.Dje.Sdk.EmpresaPrivadaTipoOrgaoPublico? tipoOrgaoPublico,
            global::Loud.Technology.Dje.Sdk.Usuario? usuario,
            global::Loud.Technology.Dje.Sdk.ValidatorPerfilInfoInput? validatorPerfilInfoInput)
        {
            this.AtividadeEconomica = atividadeEconomica;
            this.Ativo = ativo;
            this.Cnpj = cnpj;
            this.Coligadas = coligadas;
            this.Coliganda = coliganda;
            this.CpfCnpj = cpfCnpj;
            this.DataHabilitacao = dataHabilitacao;
            this.DataUltimaDesabiltiacao = dataUltimaDesabiltiacao;
            this.Email = email;
            this.EmailSpecification = emailSpecification;
            this.Endereco = endereco;
            this.ExcluidoEm = excluidoEm;
            this.Filiais = filiais;
            this.Habilitada = habilitada;
            this.Habilitador = habilitador;
            this.HashTermoAceite = hashTermoAceite;
            this.Id = id;
            this.InfoAuditoriaVO = infoAuditoriaVO;
            this.InfoValidacaoValueObject = infoValidacaoValueObject;
            this.Matriz = matriz;
            this.NaturezaJuridica = naturezaJuridica;
            this.NomeFantasia = nomeFantasia;
            this.Notificacao = notificacao;
            this.OrgaoPublico = orgaoPublico;
            this.PerfilRepresentante = perfilRepresentante;
            this.Porte = porte;
            this.RazaoSocial = razaoSocial;
            this.RepresentanteJuridico = representanteJuridico;
            this.Solicitacoes = solicitacoes;
            this.StatusCadastro = statusCadastro;
            this.TenantId = tenantId;
            this.TermoAceito = termoAceito;
            this.Termos = termos;
            this.TipoEmpresa = tipoEmpresa;
            this.TipoEspecializacao = tipoEspecializacao;
            this.TipoOrgaoPublico = tipoOrgaoPublico;
            this.TipoPessoa = tipoPessoa;
            this.Usuario = usuario;
            this.ValidatorPerfilInfoInput = validatorPerfilInfoInput;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmpresaPrivada" /> class.
        /// </summary>
        public EmpresaPrivada()
        {
        }

    }
}