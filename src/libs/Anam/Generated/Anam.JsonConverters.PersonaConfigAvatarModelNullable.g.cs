#nullable enable

namespace Anam.JsonConverters
{
    /// <inheritdoc />
    public sealed class PersonaConfigAvatarModelNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anam.PersonaConfigAvatarModel?>
    {
        /// <inheritdoc />
        public override global::Anam.PersonaConfigAvatarModel? Read(
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
                        return global::Anam.PersonaConfigAvatarModelExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anam.PersonaConfigAvatarModel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Anam.PersonaConfigAvatarModel?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anam.PersonaConfigAvatarModel? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Anam.PersonaConfigAvatarModelExtensions.ToValueString(value.Value));
            }
        }
    }
}
