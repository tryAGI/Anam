
#nullable enable

namespace Anam
{
    /// <summary>
    /// A shareable link for accessing a persona.
    /// </summary>
    public sealed partial class ShareLink
    {
        /// <summary>
        /// Unique identifier for the share link.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// ID of the persona this link provides access to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("personaId")]
        public global::System.Guid? PersonaId { get; set; }

        /// <summary>
        /// The shareable URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// When the share link expires.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Maximum number of times the link can be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usageLimit")]
        public int? UsageLimit { get; set; }

        /// <summary>
        /// Number of times the link has been used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usageCount")]
        public int? UsageCount { get; set; }

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
        /// Initializes a new instance of the <see cref="ShareLink" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the share link.
        /// </param>
        /// <param name="personaId">
        /// ID of the persona this link provides access to.
        /// </param>
        /// <param name="url">
        /// The shareable URL.
        /// </param>
        /// <param name="expiresAt">
        /// When the share link expires.
        /// </param>
        /// <param name="usageLimit">
        /// Maximum number of times the link can be used.
        /// </param>
        /// <param name="usageCount">
        /// Number of times the link has been used.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ShareLink(
            global::System.Guid? id,
            global::System.Guid? personaId,
            string? url,
            global::System.DateTime? expiresAt,
            int? usageLimit,
            int? usageCount,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id;
            this.PersonaId = personaId;
            this.Url = url;
            this.ExpiresAt = expiresAt;
            this.UsageLimit = usageLimit;
            this.UsageCount = usageCount;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShareLink" /> class.
        /// </summary>
        public ShareLink()
        {
        }
    }
}