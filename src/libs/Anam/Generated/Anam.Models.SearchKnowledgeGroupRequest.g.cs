
#nullable enable

namespace Anam
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchKnowledgeGroupRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchKnowledgeGroupRequest" /> class.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="limit">
        /// Default Value: 5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchKnowledgeGroupRequest(
            string query,
            int? limit)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchKnowledgeGroupRequest" /> class.
        /// </summary>
        public SearchKnowledgeGroupRequest()
        {
        }
    }
}