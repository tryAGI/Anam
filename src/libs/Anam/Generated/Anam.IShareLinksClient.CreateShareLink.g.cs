#nullable enable

namespace Anam
{
    public partial interface IShareLinksClient
    {
        /// <summary>
        /// Create share link<br/>
        /// Create a new share link.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anam.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anam.ShareLink> CreateShareLinkAsync(

            global::Anam.CreateShareLinkRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create share link<br/>
        /// Create a new share link.
        /// </summary>
        /// <param name="personaId"></param>
        /// <param name="expiresInHours">
        /// Default Value: 168
        /// </param>
        /// <param name="usageLimit">
        /// Default Value: 10
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anam.ShareLink> CreateShareLinkAsync(
            global::System.Guid personaId,
            double? expiresInHours = default,
            double? usageLimit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}