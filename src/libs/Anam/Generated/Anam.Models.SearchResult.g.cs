
#nullable enable

namespace Anam
{
    /// <summary>
    /// A search result from vector similarity search.
    /// </summary>
    public sealed partial class SearchResult
    {
        /// <summary>
        /// The matched content chunk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Similarity score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// ID of the source document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentId")]
        public string? DocumentId { get; set; }

        /// <summary>
        /// Additional metadata about the match.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResult" /> class.
        /// </summary>
        /// <param name="content">
        /// The matched content chunk.
        /// </param>
        /// <param name="score">
        /// Similarity score.
        /// </param>
        /// <param name="documentId">
        /// ID of the source document.
        /// </param>
        /// <param name="metadata">
        /// Additional metadata about the match.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResult(
            string? content,
            double? score,
            string? documentId,
            object? metadata)
        {
            this.Content = content;
            this.Score = score;
            this.DocumentId = documentId;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResult" /> class.
        /// </summary>
        public SearchResult()
        {
        }

    }
}