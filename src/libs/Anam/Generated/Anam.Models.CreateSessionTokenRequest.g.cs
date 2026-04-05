
#nullable enable

namespace Anam
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSessionTokenRequest
    {
        /// <summary>
        /// Identifier for the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientLabel")]
        public string? ClientLabel { get; set; }

        /// <summary>
        /// Persona configuration. Either provide inline config or a personaId.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("personaConfig")]
        public global::Anam.CreateSessionTokenRequestPersonaConfig? PersonaConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionOptions")]
        public global::Anam.CreateSessionTokenRequestSessionOptions? SessionOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSessionTokenRequest" /> class.
        /// </summary>
        /// <param name="clientLabel">
        /// Identifier for the session.
        /// </param>
        /// <param name="personaConfig">
        /// Persona configuration. Either provide inline config or a personaId.
        /// </param>
        /// <param name="sessionOptions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSessionTokenRequest(
            string? clientLabel,
            global::Anam.CreateSessionTokenRequestPersonaConfig? personaConfig,
            global::Anam.CreateSessionTokenRequestSessionOptions? sessionOptions)
        {
            this.ClientLabel = clientLabel;
            this.PersonaConfig = personaConfig;
            this.SessionOptions = sessionOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSessionTokenRequest" /> class.
        /// </summary>
        public CreateSessionTokenRequest()
        {
        }
    }
}