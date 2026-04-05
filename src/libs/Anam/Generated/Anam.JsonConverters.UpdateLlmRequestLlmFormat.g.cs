#nullable enable

namespace Anam.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateLlmRequestLlmFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anam.UpdateLlmRequestLlmFormat>
    {
        /// <inheritdoc />
        public override global::Anam.UpdateLlmRequestLlmFormat Read(
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
                        return global::Anam.UpdateLlmRequestLlmFormatExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anam.UpdateLlmRequestLlmFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Anam.UpdateLlmRequestLlmFormat);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anam.UpdateLlmRequestLlmFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Anam.UpdateLlmRequestLlmFormatExtensions.ToValueString(value));
        }
    }
}
