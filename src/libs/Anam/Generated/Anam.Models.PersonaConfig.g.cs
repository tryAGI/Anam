
#nullable enable

namespace Anam
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PersonaConfig
    {
        /// <summary>
        /// Unique identifier for the persona.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Name of the persona.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description of the persona.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The avatar to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatarId")]
        public string? AvatarId { get; set; }

        /// <summary>
        /// Avatar model version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatarModel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anam.JsonConverters.PersonaConfigAvatarModelJsonConverter))]
        public global::Anam.PersonaConfigAvatarModel? AvatarModel { get; set; }

        /// <summary>
        /// The voice to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceId")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// The LLM to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llmId")]
        public string? LlmId { get; set; }

        /// <summary>
        /// System prompt for the LLM.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("systemPrompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// Whether to skip the greeting message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipGreeting")]
        public bool? SkipGreeting { get; set; }

        /// <summary>
        /// When true, session data is not stored after the conversation ends.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zeroDataRetention")]
        public bool? ZeroDataRetention { get; set; }

        /// <summary>
        /// Options for voice activity detection during user speech input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceDetectionOptions")]
        public global::Anam.VoiceDetectionOptions? VoiceDetectionOptions { get; set; }

        /// <summary>
        /// ISO 639-1 language code override for transcription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languageCode")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// Array of tool IDs to attach to the persona.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolIds")]
        public global::System.Collections.Generic.IList<string>? ToolIds { get; set; }

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
        /// Initializes a new instance of the <see cref="PersonaConfig" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the persona.
        /// </param>
        /// <param name="name">
        /// Name of the persona.
        /// </param>
        /// <param name="description">
        /// Description of the persona.
        /// </param>
        /// <param name="avatarId">
        /// The avatar to use.
        /// </param>
        /// <param name="avatarModel">
        /// Avatar model version.
        /// </param>
        /// <param name="voiceId">
        /// The voice to use.
        /// </param>
        /// <param name="llmId">
        /// The LLM to use.
        /// </param>
        /// <param name="systemPrompt">
        /// System prompt for the LLM.
        /// </param>
        /// <param name="skipGreeting">
        /// Whether to skip the greeting message.
        /// </param>
        /// <param name="zeroDataRetention">
        /// When true, session data is not stored after the conversation ends.
        /// </param>
        /// <param name="voiceDetectionOptions">
        /// Options for voice activity detection during user speech input.
        /// </param>
        /// <param name="languageCode">
        /// ISO 639-1 language code override for transcription.
        /// </param>
        /// <param name="toolIds">
        /// Array of tool IDs to attach to the persona.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PersonaConfig(
            global::System.Guid? id,
            string? name,
            string? description,
            string? avatarId,
            global::Anam.PersonaConfigAvatarModel? avatarModel,
            string? voiceId,
            string? llmId,
            string? systemPrompt,
            bool? skipGreeting,
            bool? zeroDataRetention,
            global::Anam.VoiceDetectionOptions? voiceDetectionOptions,
            string? languageCode,
            global::System.Collections.Generic.IList<string>? toolIds,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.AvatarId = avatarId;
            this.AvatarModel = avatarModel;
            this.VoiceId = voiceId;
            this.LlmId = llmId;
            this.SystemPrompt = systemPrompt;
            this.SkipGreeting = skipGreeting;
            this.ZeroDataRetention = zeroDataRetention;
            this.VoiceDetectionOptions = voiceDetectionOptions;
            this.LanguageCode = languageCode;
            this.ToolIds = toolIds;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonaConfig" /> class.
        /// </summary>
        public PersonaConfig()
        {
        }

    }
}