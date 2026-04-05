#nullable enable

namespace Anam
{
    public partial interface IShareLinksClient
    {
        /// <summary>
        /// Update share link<br/>
        /// Update a share link by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anam.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateShareLinkAsync(
            global::System.Guid id,

            global::Anam.UpdateShareLinkRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update share link<br/>
        /// Update a share link by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="expiresInHours"></param>
        /// <param name="usageLimit"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdateShareLinkAsync(
            global::System.Guid id,
            double? expiresInHours = default,
            double? usageLimit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}