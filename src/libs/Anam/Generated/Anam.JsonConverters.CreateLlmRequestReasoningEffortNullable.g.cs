#nullable enable

namespace Anam.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateLlmRequestReasoningEffortNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anam.CreateLlmRequestReasoningEffort?>
    {
        /// <inheritdoc />
        public override global::Anam.CreateLlmRequestReasoningEffort? Read(
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
                        return global::Anam.CreateLlmRequestReasoningEffortExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anam.CreateLlmRequestReasoningEffort)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Anam.CreateLlmRequestReasoningEffort?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anam.CreateLlmRequestReasoningEffort? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Anam.CreateLlmRequestReasoningEffortExtensions.ToValueString(value.Value));
            }
        }
    }
}
