
#nullable enable

namespace Anam
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListAvatarsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Anam.Avatar>? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::Anam.PaginationMeta? Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAvatarsResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="meta"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAvatarsResponse(
            global::System.Collections.Generic.IList<global::Anam.Avatar>? data,
            global::Anam.PaginationMeta? meta)
        {
            this.Data = data;
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAvatarsResponse" /> class.
        /// </summary>
        public ListAvatarsResponse()
        {
        }
    }
}