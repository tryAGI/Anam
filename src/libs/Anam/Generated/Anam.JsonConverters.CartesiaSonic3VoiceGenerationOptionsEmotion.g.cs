#nullable enable

namespace Anam.JsonConverters
{
    /// <inheritdoc />
    public sealed class CartesiaSonic3VoiceGenerationOptionsEmotionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anam.CartesiaSonic3VoiceGenerationOptionsEmotion>
    {
        /// <inheritdoc />
        public override global::Anam.CartesiaSonic3VoiceGenerationOptionsEmotion Read(
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
                        return global::Anam.CartesiaSonic3VoiceGenerationOptionsEmotionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anam.CartesiaSonic3VoiceGenerationOptionsEmotion)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Anam.CartesiaSonic3VoiceGenerationOptionsEmotion);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anam.CartesiaSonic3VoiceGenerationOptionsEmotion value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Anam.CartesiaSonic3VoiceGenerationOptionsEmotionExtensions.ToValueString(value));
        }
    }
}
