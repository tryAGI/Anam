
#nullable enable

namespace Anam
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAvatarRequest
    {
        /// <summary>
        /// Display name for the avatar (3-50 characters).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// Image file (JPEG, PNG, WebP; max 4.5MB).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageFile")]
        public byte[]? ImageFile { get; set; }

        /// <summary>
        /// Image file (JPEG, PNG, WebP; max 4.5MB).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageFilename")]
        public string? ImageFilename { get; set; }

        /// <summary>
        /// Image URL (JPEG, PNG, WebP; max 4.5MB).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageUrl")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAvatarRequest" /> class.
        /// </summary>
        /// <param name="displayName">
        /// Display name for the avatar (3-50 characters).
        /// </param>
        /// <param name="imageFile">
        /// Image file (JPEG, PNG, WebP; max 4.5MB).
        /// </param>
        /// <param name="imageFilename">
        /// Image file (JPEG, PNG, WebP; max 4.5MB).
        /// </param>
        /// <param name="imageUrl">
        /// Image URL (JPEG, PNG, WebP; max 4.5MB).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAvatarRequest(
            string displayName,
            byte[]? imageFile,
            string? imageFilename,
            string? imageUrl)
        {
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.ImageFile = imageFile;
            this.ImageFilename = imageFilename;
            this.ImageUrl = imageUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAvatarRequest" /> class.
        /// </summary>
        public CreateAvatarRequest()
        {
        }
    }
}