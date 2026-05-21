
#nullable enable

namespace Anam
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateToolRequest
    {
        /// <summary>
        /// Updated name for the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Updated description of what the tool does.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anam.JsonConverters.UpdateToolRequestTypeJsonConverter))]
        public global::Anam.UpdateToolRequestType? Type { get; set; }

        /// <summary>
        /// Updated type-specific configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public object? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateToolRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Updated name for the tool.
        /// </param>
        /// <param name="description">
        /// Updated description of what the tool does.
        /// </param>
        /// <param name="type"></param>
        /// <param name="config">
        /// Updated type-specific configuration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateToolRequest(
            string? name,
            string? description,
            global::Anam.UpdateToolRequestType? type,
            object? config)
        {
            this.Name = name;
            this.Description = description;
            this.Type = type;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateToolRequest" /> class.
        /// </summary>
        public UpdateToolRequest()
        {
        }

    }
}