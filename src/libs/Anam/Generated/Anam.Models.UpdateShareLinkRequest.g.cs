
#nullable enable

namespace Anam
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateShareLinkRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresInHours")]
        public double? ExpiresInHours { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usageLimit")]
        public double? UsageLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateShareLinkRequest" /> class.
        /// </summary>
        /// <param name="expiresInHours"></param>
        /// <param name="usageLimit"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateShareLinkRequest(
            double? expiresInHours,
            double? usageLimit)
        {
            this.ExpiresInHours = expiresInHours;
            this.UsageLimit = usageLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateShareLinkRequest" /> class.
        /// </summary>
        public UpdateShareLinkRequest()
        {
        }

    }
}