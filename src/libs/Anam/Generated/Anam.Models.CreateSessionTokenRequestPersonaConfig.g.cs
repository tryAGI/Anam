
#nullable enable

namespace Anam
{
    /// <summary>
    /// Persona configuration. Either provide inline config or a personaId.
    /// </summary>
    public sealed partial class CreateSessionTokenRequestPersonaConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatarId")]
        public string? AvatarId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatarModel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anam.JsonConverters.CreateSessionTokenRequestPersonaConfigAvatarModelJsonConverter))]
        public global::Anam.CreateSessionTokenRequestPersonaConfigAvatarModel? AvatarModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceId")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llmId")]
        public string? LlmId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("systemPrompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxSessionLengthSeconds")]
        public double? MaxSessionLengthSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipGreeting")]
        public bool? SkipGreeting { get; set; }

        /// <summary>
        /// Use an existing persona by ID instead of inline config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("personaId")]
        public string? PersonaId { get; set; }

        /// <summary>
        /// Options for voice activity detection during user speech input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceDetectionOptions")]
        public global::Anam.VoiceDetectionOptions? VoiceDetectionOptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languageCode")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSessionTokenRequestPersonaConfig" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="avatarId"></param>
        /// <param name="avatarModel"></param>
        /// <param name="voiceId"></param>
        /// <param name="llmId"></param>
        /// <param name="systemPrompt"></param>
        /// <param name="maxSessionLengthSeconds"></param>
        /// <param name="skipGreeting"></param>
        /// <param name="personaId">
        /// Use an existing persona by ID instead of inline config.
        /// </param>
        /// <param name="voiceDetectionOptions">
        /// Options for voice activity detection during user speech input.
        /// </param>
        /// <param name="languageCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSessionTokenRequestPersonaConfig(
            string? name,
            string? avatarId,
            global::Anam.CreateSessionTokenRequestPersonaConfigAvatarModel? avatarModel,
            string? voiceId,
            string? llmId,
            string? systemPrompt,
            double? maxSessionLengthSeconds,
            bool? skipGreeting,
            string? personaId,
            global::Anam.VoiceDetectionOptions? voiceDetectionOptions,
            string? languageCode)
        {
            this.Name = name;
            this.AvatarId = avatarId;
            this.AvatarModel = avatarModel;
            this.VoiceId = voiceId;
            this.LlmId = llmId;
            this.SystemPrompt = systemPrompt;
            this.MaxSessionLengthSeconds = maxSessionLengthSeconds;
            this.SkipGreeting = skipGreeting;
            this.PersonaId = personaId;
            this.VoiceDetectionOptions = voiceDetectionOptions;
            this.LanguageCode = languageCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSessionTokenRequestPersonaConfig" /> class.
        /// </summary>
        public CreateSessionTokenRequestPersonaConfig()
        {
        }

    }
}