
#nullable enable

namespace Anam
{
    /// <summary>
    /// A session representing a conversation with an AI persona.
    /// </summary>
    public sealed partial class Session
    {
        /// <summary>
        /// Unique identifier for the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Client-provided label for the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientLabel")]
        public string? ClientLabel { get; set; }

        /// <summary>
        /// ID of the persona used in the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("personaId")]
        public global::System.Guid? PersonaId { get; set; }

        /// <summary>
        /// Name of the persona used in the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("personaName")]
        public string? PersonaName { get; set; }

        /// <summary>
        /// Current status of the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// When the session started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startTime")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// When the session ended.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endTime")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Duration of the session in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("durationMs")]
        public int? DurationMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Session" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the session.
        /// </param>
        /// <param name="clientLabel">
        /// Client-provided label for the session.
        /// </param>
        /// <param name="personaId">
        /// ID of the persona used in the session.
        /// </param>
        /// <param name="personaName">
        /// Name of the persona used in the session.
        /// </param>
        /// <param name="status">
        /// Current status of the session.
        /// </param>
        /// <param name="startTime">
        /// When the session started.
        /// </param>
        /// <param name="endTime">
        /// When the session ended.
        /// </param>
        /// <param name="durationMs">
        /// Duration of the session in milliseconds.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Session(
            global::System.Guid? id,
            string? clientLabel,
            global::System.Guid? personaId,
            string? personaName,
            string? status,
            global::System.DateTime? startTime,
            global::System.DateTime? endTime,
            int? durationMs,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id;
            this.ClientLabel = clientLabel;
            this.PersonaId = personaId;
            this.PersonaName = personaName;
            this.Status = status;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.DurationMs = durationMs;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Session" /> class.
        /// </summary>
        public Session()
        {
        }

    }
}