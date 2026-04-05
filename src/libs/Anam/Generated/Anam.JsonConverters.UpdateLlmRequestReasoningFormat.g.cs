#nullable enable

namespace Anam.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateLlmRequestReasoningFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anam.UpdateLlmRequestReasoningFormat>
    {
        /// <inheritdoc />
        public override global::Anam.UpdateLlmRequestReasoningFormat Read(
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
                        return global::Anam.UpdateLlmRequestReasoningFormatExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anam.UpdateLlmRequestReasoningFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Anam.UpdateLlmRequestReasoningFormat);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anam.UpdateLlmRequestReasoningFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Anam.UpdateLlmRequestReasoningFormatExtensions.ToValueString(value));
        }
    }
}
