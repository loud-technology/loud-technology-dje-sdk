
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Loud.Technology.Dje.Sdk
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.AtualizarPerfilInputModelDeveNotificarJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.AtualizarPerfilInputModelDeveNotificarNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.AtualizarPerfilInputModelHabilitarTodosJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.AtualizarPerfilInputModelHabilitarTodosNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.EscopoPermissaoInputModelAcaoJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.EscopoPermissaoInputModelAcaoNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.EmpresaPrivadaPorteJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.EmpresaPrivadaPorteNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.EmpresaPrivadaStatusCadastroJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.EmpresaPrivadaStatusCadastroNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.EmpresaPrivadaTipoEmpresaJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.EmpresaPrivadaTipoEmpresaNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.EmpresaPrivadaTipoOrgaoPublicoJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.EmpresaPrivadaTipoOrgaoPublicoNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.EmpresaPrivadaTipoPessoaJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.EmpresaPrivadaTipoPessoaNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.EnderecoVOEstadoJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.EnderecoVOEstadoNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.INotificationTypeNotificationJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.INotificationTypeNotificationNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.IProfileRoleJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.IProfileRoleNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.PerfilNotificarJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.PerfilNotificarNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.PerfilRoleJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.PerfilRoleNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.PessoaTipoPessoaJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.PessoaTipoPessoaNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ValidationMessageTypeJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ValidationMessageTypeNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.SolicitarAberturaTicketInputModelClassificacaoJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.SolicitarAberturaTicketInputModelClassificacaoNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.CriarPessoaFisicaInputModelDeveNotificarJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.CriarPessoaFisicaInputModelDeveNotificarNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.AdicionarPerfilInputModelCargoJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.AdicionarPerfilInputModelCargoNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.AdicionarPerfilInputModelDeveNotificarJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.AdicionarPerfilInputModelDeveNotificarNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ObterVinculosOrgaoPublicoStatusJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ObterVinculosOrgaoPublicoStatusNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.DetalheVinculoOrgaoPublicoViewModelSituacaoJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.DetalheVinculoOrgaoPublicoViewModelSituacaoNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.AudienciaViewModelFormatoJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.AudienciaViewModelFormatoNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.AudienciaViewModelTipoJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.AudienciaViewModelTipoNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelCienciaAutomaticaJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelCienciaAutomaticaNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelFormatoSessaojulgamentoJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelFormatoSessaojulgamentoNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelInstanciaJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelInstanciaNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelMeioEnvioJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelMeioEnvioNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelNivelSigiloJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelNivelSigiloNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelParteInteressadaJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelParteInteressadaNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelStatusJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelStatusNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelTipoAcaoJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelTipoAcaoNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelTipoComunicacaoJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelTipoComunicacaoNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelTipoIntimacaoJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelTipoIntimacaoNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelTipoPrazoJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelTipoPrazoNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelTipoSessaojulgamentoJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualViewModelTipoSessaojulgamentoNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.PessoaViewModelTipoDocumentoJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.PessoaViewModelTipoDocumentoNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.RepresentanteViewModelStatusJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.RepresentanteViewModelStatusNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.RepresentanteViewModelTipoDocumentoJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.RepresentanteViewModelTipoDocumentoNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ObterTicketViewModelClassificacaoJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ObterTicketViewModelClassificacaoNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ObterTicketViewModelStatusJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ObterTicketViewModelStatusNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.PessoaInfoViewModelTipoPessoaJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.PessoaInfoViewModelTipoPessoaNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.GestorViewModelCargoJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.GestorViewModelCargoNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.OrgaoPublicoRepresentanteViewModelSituacaoJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.OrgaoPublicoRepresentanteViewModelSituacaoNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.PessoaPerfilViewModelStatusCadastroJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.PessoaPerfilViewModelStatusCadastroNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelCienciaAutomaticaJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelCienciaAutomaticaNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelFormatoSessaojulgamentoJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelFormatoSessaojulgamentoNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelInstanciaJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelInstanciaNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelMeioEnvioJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelMeioEnvioNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelNivelSigiloJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelNivelSigiloNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelParteInteressadaJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelParteInteressadaNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelRamoJusticaJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelRamoJusticaNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelStatusJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelStatusNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelTipoAcaoJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelTipoAcaoNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelTipoComunicacaoJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelTipoComunicacaoNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelTipoIntimacaoJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelTipoIntimacaoNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelTipoPrazoJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelTipoPrazoNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelTipoSessaojulgamentoJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ComunicacaoProcessualOrgaoPublicoViewModelTipoSessaojulgamentoNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.PessoaProcessualOrgaoPublicoViewModelTipoDocumentoJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.PessoaProcessualOrgaoPublicoViewModelTipoDocumentoNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.PessoaRelacionadaViewModelTipoDocumentoJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.PessoaRelacionadaViewModelTipoDocumentoNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.MensagemTipoMensagemJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.MensagemTipoMensagemNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ListarCargoJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ListarCargoNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ObterComunicacoesTipoComunicacaoJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ObterComunicacoesTipoComunicacaoNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ObterComunicacoesStatusCienteJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ObterComunicacoesStatusCienteNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ObterComunicacoesParteInteressadaJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ObterComunicacoesParteInteressadaNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ObterComunicacoesModalidadeComunicacaoProcessualJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ObterComunicacoesModalidadeComunicacaoProcessualNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ObterComunicacoesOrgaoPublicoTipoComunicacaoJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ObterComunicacoesOrgaoPublicoTipoComunicacaoNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ObterComunicacoesOrgaoPublicoStatusCienteJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ObterComunicacoesOrgaoPublicoStatusCienteNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ObterComunicacoesOrgaoPublicoParteInteressadaJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ObterComunicacoesOrgaoPublicoParteInteressadaNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ObterComunicacoesOrgaoPublicoRamoJusticaJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ObterComunicacoesOrgaoPublicoRamoJusticaNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ObterComunicacoesOrgaoPublicoModalidadeComunicacaoProcessualJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ObterComunicacoesOrgaoPublicoModalidadeComunicacaoProcessualNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ListarComunicacaoTipoComunicacaoJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ListarComunicacaoTipoComunicacaoNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ListarComunicacaoCienteJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ListarComunicacaoCienteNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ListarComunicacaoParteInteressadaJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ListarComunicacaoParteInteressadaNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ListarComunicacaoModalidadeComunicacaoProcessualJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.ListarComunicacaoModalidadeComunicacaoProcessualNullableJsonConverter),

            typeof(global::Loud.Technology.Dje.Sdk.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.InformarCienciaInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ObterInteiroTeorModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.AtualizarPerfilInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.AtualizarPerfilInputModelDeveNotificar), TypeInfoPropertyName = "AtualizarPerfilInputModelDeveNotificar2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.EscopoPermissaoInputModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.EscopoPermissaoInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.AtualizarPerfilInputModelHabilitarTodos), TypeInfoPropertyName = "AtualizarPerfilInputModelHabilitarTodos2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.EscopoPermissaoInputModelAcao), TypeInfoPropertyName = "EscopoPermissaoInputModelAcao2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.AtualizarFilialInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.EditarEnderecoInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.AtividadeEconomicaVO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.Cargo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.InfoAuditoriaVO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.InfoValidacaoValueObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.INotification>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.INotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.RecursoCargo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.RecursoCargo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.EmailSpecification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.EmpresaPrivada))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.EmpresaPrivada>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.IColiganda))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.EnderecoVO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.NaturezaJuridicaVO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.Perfil))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.EmpresaPrivadaPorte), TypeInfoPropertyName = "EmpresaPrivadaPorte2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.RepresentanteJuridicoVO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.SolicitacaoVinculo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.SolicitacaoVinculo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.EmpresaPrivadaStatusCadastro), TypeInfoPropertyName = "EmpresaPrivadaStatusCadastro2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.ITermoAceite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ITermoAceite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.PessoaTermo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.PessoaTermo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.EmpresaPrivadaTipoEmpresa), TypeInfoPropertyName = "EmpresaPrivadaTipoEmpresa2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.EmpresaPrivadaTipoOrgaoPublico), TypeInfoPropertyName = "EmpresaPrivadaTipoOrgaoPublico2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.EmpresaPrivadaTipoPessoa), TypeInfoPropertyName = "EmpresaPrivadaTipoPessoa2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.Usuario))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ValidatorPerfilInfoInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.EnderecoVOEstado), TypeInfoPropertyName = "EnderecoVOEstado2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.EscopoPermissaoVO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.INotificationTypeNotification), TypeInfoPropertyName = "INotificationTypeNotification2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.IProfile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.IResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.IResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.IProfileRole), TypeInfoPropertyName = "IProfileRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.ValidationMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ValidationMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.Paginacao))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.EscopoPermissaoVO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.PerfilNotificar), TypeInfoPropertyName = "PerfilNotificar2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.PerfilRole), TypeInfoPropertyName = "PerfilRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.Pessoa))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.PessoaTipoPessoa), TypeInfoPropertyName = "PessoaTipoPessoa2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.PessoaTermoId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.Recurso))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.RespostaPaginadaEmpresaPrivada))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.Perfil>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.IProfile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ValidationMessageType), TypeInfoPropertyName = "ValidationMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.EditarEmailSolicitacaoVinculoInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.SolicitarAberturaTicketInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.SolicitarAberturaTicketInputModelClassificacao), TypeInfoPropertyName = "SolicitarAberturaTicketInputModelClassificacao2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.OperationResultFailViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.TermoAceiteInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.TermoAceiteViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.CriarPessoaFisicaInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.CriarPessoaFisicaInputModelDeveNotificar), TypeInfoPropertyName = "CriarPessoaFisicaInputModelDeveNotificar2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.PessoaFisicaViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.AdicionarPerfilInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.AdicionarPerfilInputModelCargo), TypeInfoPropertyName = "AdicionarPerfilInputModelCargo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.AdicionarPerfilInputModelDeveNotificar), TypeInfoPropertyName = "AdicionarPerfilInputModelDeveNotificar2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.AdicionarRepresentanteInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.VincularOrgaoPublicoInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.AdicionarMatrizInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.RepresentanteJuridicoInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.CriarMatrizViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.DocumentoEmpresaIncorporadaInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.SolicitarEmpresaIncorporadaInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.DocumentoEmpresaIncorporadaInputModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.EmpresaIncorporadaDocumentoViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.EmpresaIncorporadaSolicitacaoViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.EmpresaIncorporadaDocumentoViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.SolicitarVinculoColigacaoInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.AdicionarFilialInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ImportarFilialLoteInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.AdminRealizarAdesaoInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.AdministradorInforInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.MatrizInfoInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.OABInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.AtualizarPessoaFisicaInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.PessoaFisicaPDPJViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.AlterarMatrizInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.EditarRepresentanteJuridicoInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.RejeitarEmpresaIncorporadaInputModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ObterVinculosOrgaoPublico))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ObterVinculosOrgaoPublicoStatus), TypeInfoPropertyName = "ObterVinculosOrgaoPublicoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.Pageable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.DetalheVinculoOrgaoPublicoViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.DetalheVinculoOrgaoPublicoViewModelSituacao), TypeInfoPropertyName = "DetalheVinculoOrgaoPublicoViewModelSituacao2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.RespostaPaginadaDetalheVinculoOrgaoPublicoViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.DetalheVinculoOrgaoPublicoViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.AudienciaViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.AudienciaViewModelFormato), TypeInfoPropertyName = "AudienciaViewModelFormato2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.AudienciaViewModelTipo), TypeInfoPropertyName = "AudienciaViewModelTipo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ComunicacaoProcessualViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.PessoaViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.PessoaViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ComunicacaoProcessualViewModelCienciaAutomatica), TypeInfoPropertyName = "ComunicacaoProcessualViewModelCienciaAutomatica2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ComunicacaoProcessualViewModelFormatoSessaojulgamento), TypeInfoPropertyName = "ComunicacaoProcessualViewModelFormatoSessaojulgamento2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ComunicacaoProcessualViewModelInstancia), TypeInfoPropertyName = "ComunicacaoProcessualViewModelInstancia2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ComunicacaoProcessualViewModelMeioEnvio), TypeInfoPropertyName = "ComunicacaoProcessualViewModelMeioEnvio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ComunicacaoProcessualViewModelNivelSigilo), TypeInfoPropertyName = "ComunicacaoProcessualViewModelNivelSigilo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ComunicacaoProcessualViewModelParteInteressada), TypeInfoPropertyName = "ComunicacaoProcessualViewModelParteInteressada2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.PeticaoViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.RepresentanteViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.RepresentanteViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ServidorViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ComunicacaoProcessualViewModelStatus), TypeInfoPropertyName = "ComunicacaoProcessualViewModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ComunicacaoProcessualViewModelTipoAcao), TypeInfoPropertyName = "ComunicacaoProcessualViewModelTipoAcao2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ComunicacaoProcessualViewModelTipoComunicacao), TypeInfoPropertyName = "ComunicacaoProcessualViewModelTipoComunicacao2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ComunicacaoProcessualViewModelTipoIntimacao), TypeInfoPropertyName = "ComunicacaoProcessualViewModelTipoIntimacao2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ComunicacaoProcessualViewModelTipoPrazo), TypeInfoPropertyName = "ComunicacaoProcessualViewModelTipoPrazo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ComunicacaoProcessualViewModelTipoSessaojulgamento), TypeInfoPropertyName = "ComunicacaoProcessualViewModelTipoSessaojulgamento2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.PessoaViewModelTipoDocumento), TypeInfoPropertyName = "PessoaViewModelTipoDocumento2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.RepresentanteViewModelStatus), TypeInfoPropertyName = "RepresentanteViewModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.RepresentanteViewModelTipoDocumento), TypeInfoPropertyName = "RepresentanteViewModelTipoDocumento2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ComunicacaoLogModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.RespostaPaginadaComunicacaoLogModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.ComunicacaoLogModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ObterTicketViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ObterTicketViewModelClassificacao), TypeInfoPropertyName = "ObterTicketViewModelClassificacao2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ObterTicketViewModelStatus), TypeInfoPropertyName = "ObterTicketViewModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.PessoaInfoViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.PessoaInfoViewModelTipoPessoa), TypeInfoPropertyName = "PessoaInfoViewModelTipoPessoa2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.TermoAceitoViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.PessoaHabilitadaViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.SpecificationEmpresaPrivada))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.AtividadeEconomicaViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.EnderecoViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.NaturezaJuridicaViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.PessoaJuridicaViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.RepresentanteJuridicoViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.RespostaPaginadaPessoaJuridicaViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.PessoaJuridicaViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.SpecificationPessoaFisica))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.PessoaFisicaSimplesViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.RespostaPaginadaPessoaFisicaSimplesViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.PessoaFisicaSimplesViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.GestorViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.GestorViewModelCargo), TypeInfoPropertyName = "GestorViewModelCargo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ListarPerfilViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.RespostaPaginadaListarPerfilViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.ListarPerfilViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.CargoPerfilViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.EscopoPermissaoViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.PerfilViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.EscopoPermissaoViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.RecursosViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.RecursosViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.OrgaoPublicoRepresentanteViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.OrgaoPublicoRepresentanteViewModelSituacao), TypeInfoPropertyName = "OrgaoPublicoRepresentanteViewModelSituacao2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.RespostaPaginadaOrgaoPublicoRepresentanteViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.OrgaoPublicoRepresentanteViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ColigadaNotificacaoViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.EmpresaIncorporadaVinculoViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.RespostaPaginadaEmpresaIncorporadaVinculoViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.EmpresaIncorporadaVinculoViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.RespostaPaginadaEmpresaIncorporadaSolicitacaoViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.EmpresaIncorporadaSolicitacaoViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ColigadasPessoaJuridicaViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.RespostaPaginadaColigadasPessoaJuridicaViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.ColigadasPessoaJuridicaViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.DetalhesSolicitacaoViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.SolicitacaoVinculoViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.FilialViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.RespostaPaginadaFilialViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.FilialViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.DetalhesColigadaViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.FiliaisMatrizPorBCnpjViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.FilialBCnpjViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.FilialBCnpjViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.PaginaUsuarioPessoaJuridicaViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.RespostaPaginadaPaginaUsuarioPessoaJuridicaViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.PaginaUsuarioPessoaJuridicaViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.PessoaPerfilViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.PessoaPerfilViewModelStatusCadastro), TypeInfoPropertyName = "PessoaPerfilViewModelStatusCadastro2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.UsuarioPerfilViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.PerfilViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.UsuarioTermoViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.RespostaPaginadaComunicacaoProcessualViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.ComunicacaoProcessualViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ComunicacaoProcessualOrgaoPublicoViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.PessoaProcessualOrgaoPublicoViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.PessoaProcessualOrgaoPublicoViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ComunicacaoProcessualOrgaoPublicoViewModelCienciaAutomatica), TypeInfoPropertyName = "ComunicacaoProcessualOrgaoPublicoViewModelCienciaAutomatica2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ComunicacaoProcessualOrgaoPublicoViewModelFormatoSessaojulgamento), TypeInfoPropertyName = "ComunicacaoProcessualOrgaoPublicoViewModelFormatoSessaojulgamento2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ComunicacaoProcessualOrgaoPublicoViewModelInstancia), TypeInfoPropertyName = "ComunicacaoProcessualOrgaoPublicoViewModelInstancia2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ComunicacaoProcessualOrgaoPublicoViewModelMeioEnvio), TypeInfoPropertyName = "ComunicacaoProcessualOrgaoPublicoViewModelMeioEnvio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ComunicacaoProcessualOrgaoPublicoViewModelNivelSigilo), TypeInfoPropertyName = "ComunicacaoProcessualOrgaoPublicoViewModelNivelSigilo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ComunicacaoProcessualOrgaoPublicoViewModelParteInteressada), TypeInfoPropertyName = "ComunicacaoProcessualOrgaoPublicoViewModelParteInteressada2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ComunicacaoProcessualOrgaoPublicoViewModelRamoJustica), TypeInfoPropertyName = "ComunicacaoProcessualOrgaoPublicoViewModelRamoJustica2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ComunicacaoProcessualOrgaoPublicoViewModelStatus), TypeInfoPropertyName = "ComunicacaoProcessualOrgaoPublicoViewModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ComunicacaoProcessualOrgaoPublicoViewModelTipoAcao), TypeInfoPropertyName = "ComunicacaoProcessualOrgaoPublicoViewModelTipoAcao2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ComunicacaoProcessualOrgaoPublicoViewModelTipoComunicacao), TypeInfoPropertyName = "ComunicacaoProcessualOrgaoPublicoViewModelTipoComunicacao2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ComunicacaoProcessualOrgaoPublicoViewModelTipoIntimacao), TypeInfoPropertyName = "ComunicacaoProcessualOrgaoPublicoViewModelTipoIntimacao2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ComunicacaoProcessualOrgaoPublicoViewModelTipoPrazo), TypeInfoPropertyName = "ComunicacaoProcessualOrgaoPublicoViewModelTipoPrazo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ComunicacaoProcessualOrgaoPublicoViewModelTipoSessaojulgamento), TypeInfoPropertyName = "ComunicacaoProcessualOrgaoPublicoViewModelTipoSessaojulgamento2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.PessoaRelacionadaViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.PessoaRelacionadaViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.PessoaProcessualOrgaoPublicoViewModelTipoDocumento), TypeInfoPropertyName = "PessoaProcessualOrgaoPublicoViewModelTipoDocumento2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.PessoaRelacionadaViewModelTipoDocumento), TypeInfoPropertyName = "PessoaRelacionadaViewModelTipoDocumento2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.RespostaPaginadaComunicacaoProcessualOrgaoPublicoViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.ComunicacaoProcessualOrgaoPublicoViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ColigandaViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.EmpresaIncorporadaDocumentoCnpjViewModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.Mensagem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.MensagemTipoMensagem), TypeInfoPropertyName = "MensagemTipoMensagem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.RespostaString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.Mensagem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ResponseBoolean))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.CriarSolicitacaoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ListarCargo), TypeInfoPropertyName = "ListarCargo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ObterComunicacoesTipoComunicacao), TypeInfoPropertyName = "ObterComunicacoesTipoComunicacao2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ObterComunicacoesStatusCiente), TypeInfoPropertyName = "ObterComunicacoesStatusCiente2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ObterComunicacoesParteInteressada), TypeInfoPropertyName = "ObterComunicacoesParteInteressada2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ObterComunicacoesModalidadeComunicacaoProcessual), TypeInfoPropertyName = "ObterComunicacoesModalidadeComunicacaoProcessual2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ObterComunicacoesOrgaoPublicoTipoComunicacao), TypeInfoPropertyName = "ObterComunicacoesOrgaoPublicoTipoComunicacao2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ObterComunicacoesOrgaoPublicoStatusCiente), TypeInfoPropertyName = "ObterComunicacoesOrgaoPublicoStatusCiente2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ObterComunicacoesOrgaoPublicoParteInteressada), TypeInfoPropertyName = "ObterComunicacoesOrgaoPublicoParteInteressada2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ObterComunicacoesOrgaoPublicoRamoJustica), TypeInfoPropertyName = "ObterComunicacoesOrgaoPublicoRamoJustica2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ObterComunicacoesOrgaoPublicoModalidadeComunicacaoProcessual), TypeInfoPropertyName = "ObterComunicacoesOrgaoPublicoModalidadeComunicacaoProcessual2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ListarComunicacaoTipoComunicacao), TypeInfoPropertyName = "ListarComunicacaoTipoComunicacao2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ListarComunicacaoCiente), TypeInfoPropertyName = "ListarComunicacaoCiente2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ListarComunicacaoParteInteressada), TypeInfoPropertyName = "ListarComunicacaoParteInteressada2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Dje.Sdk.ListarComunicacaoModalidadeComunicacaoProcessual), TypeInfoPropertyName = "ListarComunicacaoModalidadeComunicacaoProcessual2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.TermoAceitoViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.ColigadaNotificacaoViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.ColigandaViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Dje.Sdk.EmpresaIncorporadaDocumentoCnpjViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Dje.Sdk.EscopoPermissaoInputModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Dje.Sdk.INotification>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Dje.Sdk.RecursoCargo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Dje.Sdk.EmpresaPrivada>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Dje.Sdk.SolicitacaoVinculo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Dje.Sdk.ITermoAceite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Dje.Sdk.PessoaTermo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Dje.Sdk.IResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Dje.Sdk.ValidationMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Dje.Sdk.EscopoPermissaoVO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Dje.Sdk.Perfil>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Dje.Sdk.IProfile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Dje.Sdk.DocumentoEmpresaIncorporadaInputModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Dje.Sdk.EmpresaIncorporadaDocumentoViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Dje.Sdk.DetalheVinculoOrgaoPublicoViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Dje.Sdk.PessoaViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Dje.Sdk.RepresentanteViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Dje.Sdk.ComunicacaoLogModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Dje.Sdk.PessoaJuridicaViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Dje.Sdk.PessoaFisicaSimplesViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Dje.Sdk.ListarPerfilViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Dje.Sdk.EscopoPermissaoViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Dje.Sdk.RecursosViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Dje.Sdk.OrgaoPublicoRepresentanteViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Dje.Sdk.EmpresaIncorporadaVinculoViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Dje.Sdk.EmpresaIncorporadaSolicitacaoViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Dje.Sdk.ColigadasPessoaJuridicaViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Dje.Sdk.FilialViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Dje.Sdk.FilialBCnpjViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Dje.Sdk.PaginaUsuarioPessoaJuridicaViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Dje.Sdk.PerfilViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Dje.Sdk.ComunicacaoProcessualViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Dje.Sdk.PessoaProcessualOrgaoPublicoViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Dje.Sdk.PessoaRelacionadaViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Dje.Sdk.ComunicacaoProcessualOrgaoPublicoViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Dje.Sdk.Mensagem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Dje.Sdk.TermoAceitoViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Dje.Sdk.ColigadaNotificacaoViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Dje.Sdk.ColigandaViewModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Dje.Sdk.EmpresaIncorporadaDocumentoCnpjViewModel>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}