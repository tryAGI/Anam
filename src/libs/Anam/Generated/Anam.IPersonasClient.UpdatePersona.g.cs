#nullable enable

namespace Anam
{
    public partial interface IPersonasClient
    {
        /// <summary>
        /// Update persona<br/>
        /// Update a persona by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anam.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anam.PersonaConfig> UpdatePersonaAsync(
            string id,

            global::Anam.PersonaConfig request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update persona<br/>
        /// Update a persona by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestId">
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anam.PersonaConfig> UpdatePersonaAsync(
            string id,
            global::System.Guid? requestId = default,
            string? name = default,
            string? description = default,
            string? avatarId = default,
            global::Anam.PersonaConfigAvatarModel? avatarModel = default,
            string? voiceId = default,
            string? llmId = default,
            string? systemPrompt = default,
            bool? skipGreeting = default,
            bool? zeroDataRetention = default,
            global::Anam.VoiceDetectionOptions? voiceDetectionOptions = default,
            string? languageCode = default,
            global::System.Collections.Generic.IList<string>? toolIds = default,
            global::System.DateTime? createdAt = default,
            global::System.DateTime? updatedAt = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}