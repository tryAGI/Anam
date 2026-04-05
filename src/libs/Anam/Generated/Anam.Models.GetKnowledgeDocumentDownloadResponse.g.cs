
#nullable enable

namespace Anam
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetKnowledgeDocumentDownloadResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downloadUrl")]
        public string? DownloadUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetKnowledgeDocumentDownloadResponse" /> class.
        /// </summary>
        /// <param name="downloadUrl"></param>
        /// <param name="filename"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetKnowledgeDocumentDownloadResponse(
            string? downloadUrl,
            string? filename)
        {
            this.DownloadUrl = downloadUrl;
            this.Filename = filename;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetKnowledgeDocumentDownloadResponse" /> class.
        /// </summary>
        public GetKnowledgeDocumentDownloadResponse()
        {
        }
    }
}