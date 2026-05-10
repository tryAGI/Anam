
#nullable enable

namespace Anam
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateKnowledgeDocumentRequest
    {
        /// <summary>
        /// New filename for the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateKnowledgeDocumentRequest" /> class.
        /// </summary>
        /// <param name="filename">
        /// New filename for the document.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateKnowledgeDocumentRequest(
            string? filename)
        {
            this.Filename = filename;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateKnowledgeDocumentRequest" /> class.
        /// </summary>
        public UpdateKnowledgeDocumentRequest()
        {
        }

    }
}