
#nullable enable

namespace Anam
{
    /// <summary>
    /// A document uploaded to a knowledge group.
    /// </summary>
    public sealed partial class KnowledgeDocument
    {
        /// <summary>
        /// Unique identifier for the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Name of the document file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Processing status of the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// File size in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileSize")]
        public long? FileSize { get; set; }

        /// <summary>
        /// MIME type of the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mimeType")]
        public string? MimeType { get; set; }

        /// <summary>
        /// Number of chunks the document was split into.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunkCount")]
        public int? ChunkCount { get; set; }

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
        /// Initializes a new instance of the <see cref="KnowledgeDocument" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the document.
        /// </param>
        /// <param name="filename">
        /// Name of the document file.
        /// </param>
        /// <param name="status">
        /// Processing status of the document.
        /// </param>
        /// <param name="fileSize">
        /// File size in bytes.
        /// </param>
        /// <param name="mimeType">
        /// MIME type of the document.
        /// </param>
        /// <param name="chunkCount">
        /// Number of chunks the document was split into.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeDocument(
            string? id,
            string? filename,
            string? status,
            long? fileSize,
            string? mimeType,
            int? chunkCount,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id;
            this.Filename = filename;
            this.Status = status;
            this.FileSize = fileSize;
            this.MimeType = mimeType;
            this.ChunkCount = chunkCount;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeDocument" /> class.
        /// </summary>
        public KnowledgeDocument()
        {
        }

    }
}