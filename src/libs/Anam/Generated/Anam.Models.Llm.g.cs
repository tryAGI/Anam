
#nullable enable

namespace Anam
{
    /// <summary>
    /// An LLM configuration.
    /// </summary>
    public sealed partial class Llm
    {
        /// <summary>
        /// Unique identifier for the LLM.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Display name for the LLM.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Description of the LLM.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The format of the LLM API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llmFormat")]
        public string? LlmFormat { get; set; }

        /// <summary>
        /// The model name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelName")]
        public string? ModelName { get; set; }

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
        /// Initializes a new instance of the <see cref="Llm" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the LLM.
        /// </param>
        /// <param name="displayName">
        /// Display name for the LLM.
        /// </param>
        /// <param name="description">
        /// Description of the LLM.
        /// </param>
        /// <param name="llmFormat">
        /// The format of the LLM API.
        /// </param>
        /// <param name="modelName">
        /// The model name.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Llm(
            string? id,
            string? displayName,
            string? description,
            string? llmFormat,
            string? modelName,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id;
            this.DisplayName = displayName;
            this.Description = description;
            this.LlmFormat = llmFormat;
            this.ModelName = modelName;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Llm" /> class.
        /// </summary>
        public Llm()
        {
        }

    }
}