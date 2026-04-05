#nullable enable

namespace Anam
{
    public partial interface IAvatarsClient
    {
        /// <summary>
        /// Create avatar<br/>
        /// Create a new custom avatar from an image.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anam.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anam.Avatar> CreateAvatarAsync(

            global::Anam.CreateAvatarRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create avatar<br/>
        /// Create a new custom avatar from an image.
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anam.Avatar> CreateAvatarAsync(
            string displayName,
            byte[]? imageFile = default,
            string? imageFilename = default,
            string? imageUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}