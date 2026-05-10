
#nullable enable

namespace Anam
{
    /// <summary>
    /// Voice generation options for ElevenLabs V1 models.
    /// </summary>
    public sealed partial class ElevenLabsV1VoiceGenerationOptions
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
        /// Controls the speed of the spoken voice as a multiplier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ElevenLabsV1VoiceGenerationOptions" /> class.
        /// </summary>
        /// <param name="stability">
        /// Controls how stable the generated voice is between each generation.
        /// </param>
        /// <param name="similarityBoost">
        /// Controls how close the generated voice is to the original speaker.
        /// </param>
        /// <param name="speed">
        /// Controls the speed of the spoken voice as a multiplier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ElevenLabsV1VoiceGenerationOptions(
            double? stability,
            double? similarityBoost,
            double? speed)
        {
            this.Stability = stability;
            this.SimilarityBoost = similarityBoost;
            this.Speed = speed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElevenLabsV1VoiceGenerationOptions" /> class.
        /// </summary>
        public ElevenLabsV1VoiceGenerationOptions()
        {
        }

    }
}