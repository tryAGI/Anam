#nullable enable

namespace Anam
{
    public partial interface IAvatarsClient
    {
        /// <summary>
        /// Update avatar<br/>
        /// Update an avatar by ID (only display name can be updated).
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anam.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anam.Avatar> UpdateAvatarAsync(
            global::System.Guid id,

            global::Anam.UpdateAvatarRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update avatar<br/>
        /// Update an avatar by ID (only display name can be updated).
        /// </summary>
        /// <param name="id"></param>
        /// <param name="displayName">
        /// New display name for the avatar.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anam.Avatar> UpdateAvatarAsync(
            global::System.Guid id,
            string displayName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}