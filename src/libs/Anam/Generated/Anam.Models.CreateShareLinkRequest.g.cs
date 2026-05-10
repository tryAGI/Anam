
#nullable enable

namespace Anam
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateShareLinkRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("personaId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid PersonaId { get; set; }

        /// <summary>
        /// Default Value: 168
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresInHours")]
        public double? ExpiresInHours { get; set; }

        /// <summary>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usageLimit")]
        public double? UsageLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateShareLinkRequest" /> class.
        /// </summary>
        /// <param name="personaId"></param>
        /// <param name="expiresInHours">
        /// Default Value: 168
        /// </param>
        /// <param name="usageLimit">
        /// Default Value: 10
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateShareLinkRequest(
            global::System.Guid personaId,
            double? expiresInHours,
            double? usageLimit)
        {
            this.PersonaId = personaId;
            this.ExpiresInHours = expiresInHours;
            this.UsageLimit = usageLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateShareLinkRequest" /> class.
        /// </summary>
        public CreateShareLinkRequest()
        {
        }

    }
}