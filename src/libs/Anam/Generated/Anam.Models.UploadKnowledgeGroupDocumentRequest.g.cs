
#nullable enable

namespace Anam
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadKnowledgeGroupDocumentRequest
    {
        /// <summary>
        /// Document file (PDF, TXT, MD, DOCX, or CSV, max 50MB).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// Document file (PDF, TXT, MD, DOCX, or CSV, max 50MB).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Default Value: 1000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunkSize")]
        public int? ChunkSize { get; set; }

        /// <summary>
        /// Default Value: 200
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunkOverlap")]
        public int? ChunkOverlap { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadKnowledgeGroupDocumentRequest" /> class.
        /// </summary>
        /// <param name="file">
        /// Document file (PDF, TXT, MD, DOCX, or CSV, max 50MB).
        /// </param>
        /// <param name="filename">
        /// Document file (PDF, TXT, MD, DOCX, or CSV, max 50MB).
        /// </param>
        /// <param name="chunkSize">
        /// Default Value: 1000
        /// </param>
        /// <param name="chunkOverlap">
        /// Default Value: 200
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadKnowledgeGroupDocumentRequest(
            byte[] file,
            string filename,
            int? chunkSize,
            int? chunkOverlap)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.ChunkSize = chunkSize;
            this.ChunkOverlap = chunkOverlap;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadKnowledgeGroupDocumentRequest" /> class.
        /// </summary>
        public UploadKnowledgeGroupDocumentRequest()
        {
        }
    }
}