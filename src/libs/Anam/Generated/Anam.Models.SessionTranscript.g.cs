
#nullable enable

namespace Anam
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionTranscript
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionId")]
        public string? SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("personaName")]
        public string? PersonaName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startTime")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endTime")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("durationMs")]
        public int? DurationMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalMessages")]
        public int? TotalMessages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcriptsEnabled")]
        public bool? TranscriptsEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::Anam.TranscriptMessage>? Messages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionTranscript" /> class.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="personaName"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="durationMs"></param>
        /// <param name="totalMessages"></param>
        /// <param name="transcriptsEnabled"></param>
        /// <param name="messages"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionTranscript(
            string? sessionId,
            string? personaName,
            global::System.DateTime? startTime,
            global::System.DateTime? endTime,
            int? durationMs,
            int? totalMessages,
            bool? transcriptsEnabled,
            global::System.Collections.Generic.IList<global::Anam.TranscriptMessage>? messages)
        {
            this.SessionId = sessionId;
            this.PersonaName = personaName;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.DurationMs = durationMs;
            this.TotalMessages = totalMessages;
            this.TranscriptsEnabled = transcriptsEnabled;
            this.Messages = messages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionTranscript" /> class.
        /// </summary>
        public SessionTranscript()
        {
        }

    }
}