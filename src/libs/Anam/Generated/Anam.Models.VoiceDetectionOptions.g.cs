
#nullable enable

namespace Anam
{
    /// <summary>
    /// Options for voice activity detection during user speech input.
    /// </summary>
    public sealed partial class VoiceDetectionOptions
    {
        /// <summary>
        /// Sensitivity for detecting end of speech, between 0 (least sensitive) and 1 (most sensitive).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endOfSpeechSensitivity")]
        public double? EndOfSpeechSensitivity { get; set; }

        /// <summary>
        /// Duration of silence (in seconds) before the current user turn is skipped.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("silenceBeforeSkipTurnSeconds")]
        public double? SilenceBeforeSkipTurnSeconds { get; set; }

        /// <summary>
        /// Duration of silence (in seconds) before the session is automatically ended.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("silenceBeforeSessionEndSeconds")]
        public double? SilenceBeforeSessionEndSeconds { get; set; }

        /// <summary>
        /// Duration of silence (in seconds) before the user turn is automatically ended.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("silenceBeforeAutoEndTurnSeconds")]
        public double? SilenceBeforeAutoEndTurnSeconds { get; set; }

        /// <summary>
        /// Level of speech enhancement to apply, 0 (no speech enhancement) 1 (max speech enhancement).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speechEnhancementLevel")]
        public double? SpeechEnhancementLevel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceDetectionOptions" /> class.
        /// </summary>
        /// <param name="endOfSpeechSensitivity">
        /// Sensitivity for detecting end of speech, between 0 (least sensitive) and 1 (most sensitive).
        /// </param>
        /// <param name="silenceBeforeSkipTurnSeconds">
        /// Duration of silence (in seconds) before the current user turn is skipped.
        /// </param>
        /// <param name="silenceBeforeSessionEndSeconds">
        /// Duration of silence (in seconds) before the session is automatically ended.
        /// </param>
        /// <param name="silenceBeforeAutoEndTurnSeconds">
        /// Duration of silence (in seconds) before the user turn is automatically ended.
        /// </param>
        /// <param name="speechEnhancementLevel">
        /// Level of speech enhancement to apply, 0 (no speech enhancement) 1 (max speech enhancement).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceDetectionOptions(
            double? endOfSpeechSensitivity,
            double? silenceBeforeSkipTurnSeconds,
            double? silenceBeforeSessionEndSeconds,
            double? silenceBeforeAutoEndTurnSeconds,
            double? speechEnhancementLevel)
        {
            this.EndOfSpeechSensitivity = endOfSpeechSensitivity;
            this.SilenceBeforeSkipTurnSeconds = silenceBeforeSkipTurnSeconds;
            this.SilenceBeforeSessionEndSeconds = silenceBeforeSessionEndSeconds;
            this.SilenceBeforeAutoEndTurnSeconds = silenceBeforeAutoEndTurnSeconds;
            this.SpeechEnhancementLevel = speechEnhancementLevel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceDetectionOptions" /> class.
        /// </summary>
        public VoiceDetectionOptions()
        {
        }
    }
}