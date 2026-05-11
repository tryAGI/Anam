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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anam.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anam.Avatar> CreateAvatarAsync(

            global::Anam.CreateAvatarRequest request,
            global::Anam.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create avatar<br/>
        /// Create a new custom avatar from an image.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anam.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anam.AutoSDKHttpResponse<global::Anam.Avatar>> CreateAvatarAsResponseAsync(

            global::Anam.CreateAvatarRequest request,
            global::Anam.AutoSDKRequestOptions? requestOptions = default,
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anam.Avatar> CreateAvatarAsync(
            string displayName,
            byte[]? imageFile = default,
            string? imageFilename = default,
            string? imageUrl = default,
            global::Anam.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}