
#nullable enable

namespace Anam
{
    /// <summary>
    /// A knowledge group (RAG folder) containing documents for vector search.
    /// </summary>
    public sealed partial class KnowledgeGroup
    {
        /// <summary>
        /// Unique identifier for the knowledge group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Name of the knowledge group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description of the knowledge group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Number of documents in the group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentCount")]
        public int? DocumentCount { get; set; }

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
        /// Initializes a new instance of the <see cref="KnowledgeGroup" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the knowledge group.
        /// </param>
        /// <param name="name">
        /// Name of the knowledge group.
        /// </param>
        /// <param name="description">
        /// Description of the knowledge group.
        /// </param>
        /// <param name="documentCount">
        /// Number of documents in the group.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeGroup(
            string? id,
            string? name,
            string? description,
            int? documentCount,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.DocumentCount = documentCount;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeGroup" /> class.
        /// </summary>
        public KnowledgeGroup()
        {
        }
    }
}