
#nullable enable

namespace Anam
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranscriptMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anam.JsonConverters.TranscriptMessageRoleJsonConverter))]
        public global::Anam.TranscriptMessageRole? Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public global::System.DateTime? Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speakingDurationSeconds")]
        public double? SpeakingDurationSeconds { get; set; }

        /// <summary>
        /// Only present for persona messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wasInterrupted")]
        public bool? WasInterrupted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptMessage" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="message"></param>
        /// <param name="timestamp"></param>
        /// <param name="speakingDurationSeconds"></param>
        /// <param name="wasInterrupted">
        /// Only present for persona messages.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptMessage(
            global::Anam.TranscriptMessageRole? role,
            string? message,
            global::System.DateTime? timestamp,
            double? speakingDurationSeconds,
            bool? wasInterrupted)
        {
            this.Role = role;
            this.Message = message;
            this.Timestamp = timestamp;
            this.SpeakingDurationSeconds = speakingDurationSeconds;
            this.WasInterrupted = wasInterrupted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptMessage" /> class.
        /// </summary>
        public TranscriptMessage()
        {
        }

    }
}