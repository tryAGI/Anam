#nullable enable

namespace Anam.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateLlmRequestReasoningEffortNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anam.UpdateLlmRequestReasoningEffort?>
    {
        /// <inheritdoc />
        public override global::Anam.UpdateLlmRequestReasoningEffort? Read(
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
                        return global::Anam.UpdateLlmRequestReasoningEffortExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anam.UpdateLlmRequestReasoningEffort)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Anam.UpdateLlmRequestReasoningEffort?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anam.UpdateLlmRequestReasoningEffort? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Anam.UpdateLlmRequestReasoningEffortExtensions.ToValueString(value.Value));
            }
        }
    }
}
