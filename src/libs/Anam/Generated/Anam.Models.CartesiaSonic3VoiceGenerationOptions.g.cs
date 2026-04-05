
#nullable enable

namespace Anam
{
    /// <summary>
    /// Voice generation options for Cartesia Sonic-3 models.
    /// </summary>
    public sealed partial class CartesiaSonic3VoiceGenerationOptions
    {
        /// <summary>
        /// Controls the volume level of the generated voice as a multiplier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume")]
        public double? Volume { get; set; }

        /// <summary>
        /// Controls the speed of the spoken voice as a multiplier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Sets the emotional tone of the generated voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emotion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anam.JsonConverters.CartesiaSonic3VoiceGenerationOptionsEmotionJsonConverter))]
        public global::Anam.CartesiaSonic3VoiceGenerationOptionsEmotion? Emotion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CartesiaSonic3VoiceGenerationOptions" /> class.
        /// </summary>
        /// <param name="volume">
        /// Controls the volume level of the generated voice as a multiplier.
        /// </param>
        /// <param name="speed">
        /// Controls the speed of the spoken voice as a multiplier.
        /// </param>
        /// <param name="emotion">
        /// Sets the emotional tone of the generated voice.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CartesiaSonic3VoiceGenerationOptions(
            double? volume,
            double? speed,
            global::Anam.CartesiaSonic3VoiceGenerationOptionsEmotion? emotion)
        {
            this.Volume = volume;
            this.Speed = speed;
            this.Emotion = emotion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CartesiaSonic3VoiceGenerationOptions" /> class.
        /// </summary>
        public CartesiaSonic3VoiceGenerationOptions()
        {
        }
    }
}