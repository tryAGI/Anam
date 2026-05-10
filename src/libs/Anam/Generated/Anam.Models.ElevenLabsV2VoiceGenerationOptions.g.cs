
#nullable enable

namespace Anam
{
    /// <summary>
    /// Voice generation options for ElevenLabs V2 models.
    /// </summary>
    public sealed partial class ElevenLabsV2VoiceGenerationOptions
    {
        /// <summary>
        /// Controls how stable the generated voice is between each generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stability")]
        public double? Stability { get; set; }

        /// <summary>
        /// Controls how close the generated voice is to the original speaker.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("similarityBoost")]
        public double? SimilarityBoost { get; set; }

        /// <summary>
        /// Amplifies the style of the original speaker.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        public double? Style { get; set; }

        /// <summary>
        /// Whether to use speaker boost for the generated voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("useSpeakerBoost")]
        public bool? UseSpeakerBoost { get; set; }

        /// <summary>
        /// Controls the speed of the spoken voice as a multiplier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// The ElevenLabs model ID to use for voice generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ElevenLabsV2VoiceGenerationOptions" /> class.
        /// </summary>
        /// <param name="stability">
        /// Controls how stable the generated voice is between each generation.
        /// </param>
        /// <param name="similarityBoost">
        /// Controls how close the generated voice is to the original speaker.
        /// </param>
        /// <param name="style">
        /// Amplifies the style of the original speaker.
        /// </param>
        /// <param name="useSpeakerBoost">
        /// Whether to use speaker boost for the generated voice.
        /// </param>
        /// <param name="speed">
        /// Controls the speed of the spoken voice as a multiplier.
        /// </param>
        /// <param name="model">
        /// The ElevenLabs model ID to use for voice generation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ElevenLabsV2VoiceGenerationOptions(
            double? stability,
            double? similarityBoost,
            double? style,
            bool? useSpeakerBoost,
            double? speed,
            string? model)
        {
            this.Stability = stability;
            this.SimilarityBoost = similarityBoost;
            this.Style = style;
            this.UseSpeakerBoost = useSpeakerBoost;
            this.Speed = speed;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElevenLabsV2VoiceGenerationOptions" /> class.
        /// </summary>
        public ElevenLabsV2VoiceGenerationOptions()
        {
        }

    }
}