
#nullable enable

namespace Anam
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateToolRequest
    {
        /// <summary>
        /// Unique name for the tool (pattern [a-zA-Z0-9_.-]+).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description of what the tool does.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Type of tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anam.JsonConverters.CreateToolRequestTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anam.CreateToolRequestType Type { get; set; }

        /// <summary>
        /// Type-specific configuration for the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public object? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateToolRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Unique name for the tool (pattern [a-zA-Z0-9_.-]+).
        /// </param>
        /// <param name="description">
        /// Description of what the tool does.
        /// </param>
        /// <param name="type">
        /// Type of tool.
        /// </param>
        /// <param name="config">
        /// Type-specific configuration for the tool.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateToolRequest(
            string name,
            string description,
            global::Anam.CreateToolRequestType type,
            object? config)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Type = type;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateToolRequest" /> class.
        /// </summary>
        public CreateToolRequest()
        {
        }

    }
}