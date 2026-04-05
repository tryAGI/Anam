
#nullable enable

namespace Anam
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PaginationMeta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastPage")]
        public int? LastPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentPage")]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("perPage")]
        public int? PerPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prev")]
        public int? Prev { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        public int? Next { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginationMeta" /> class.
        /// </summary>
        /// <param name="total"></param>
        /// <param name="lastPage"></param>
        /// <param name="currentPage"></param>
        /// <param name="perPage"></param>
        /// <param name="prev"></param>
        /// <param name="next"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaginationMeta(
            int? total,
            int? lastPage,
            int? currentPage,
            int? perPage,
            int? prev,
            int? next)
        {
            this.Total = total;
            this.LastPage = lastPage;
            this.CurrentPage = currentPage;
            this.PerPage = perPage;
            this.Prev = prev;
            this.Next = next;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginationMeta" /> class.
        /// </summary>
        public PaginationMeta()
        {
        }
    }
}