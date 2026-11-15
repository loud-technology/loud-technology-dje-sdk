#nullable enable

namespace Loud.Technology.Dje.Sdk.JsonConverters
{
    /// <inheritdoc />
    public sealed class ObterComunicacoesOrgaoPublicoModalidadeComunicacaoProcessualNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Loud.Technology.Dje.Sdk.ObterComunicacoesOrgaoPublicoModalidadeComunicacaoProcessual?>
    {
        /// <inheritdoc />
        public override global::Loud.Technology.Dje.Sdk.ObterComunicacoesOrgaoPublicoModalidadeComunicacaoProcessual? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Loud.Technology.Dje.Sdk.ObterComunicacoesOrgaoPublicoModalidadeComunicacaoProcessualExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Loud.Technology.Dje.Sdk.ObterComunicacoesOrgaoPublicoModalidadeComunicacaoProcessual)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Loud.Technology.Dje.Sdk.ObterComunicacoesOrgaoPublicoModalidadeComunicacaoProcessual?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Loud.Technology.Dje.Sdk.ObterComunicacoesOrgaoPublicoModalidadeComunicacaoProcessual? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Loud.Technology.Dje.Sdk.ObterComunicacoesOrgaoPublicoModalidadeComunicacaoProcessualExtensions.ToValueString(value.Value));
            }
        }
    }
}
