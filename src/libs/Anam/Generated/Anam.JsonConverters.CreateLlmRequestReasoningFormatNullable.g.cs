#nullable enable

namespace Anam.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateLlmRequestReasoningFormatNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anam.CreateLlmRequestReasoningFormat?>
    {
        /// <inheritdoc />
        public override global::Anam.CreateLlmRequestReasoningFormat? Read(
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
                        return global::Anam.CreateLlmRequestReasoningFormatExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anam.CreateLlmRequestReasoningFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Anam.CreateLlmRequestReasoningFormat?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anam.CreateLlmRequestReasoningFormat? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Anam.CreateLlmRequestReasoningFormatExtensions.ToValueString(value.Value));
            }
        }
    }
}
