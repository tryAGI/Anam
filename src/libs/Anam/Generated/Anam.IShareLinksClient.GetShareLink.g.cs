#nullable enable

namespace Anam
{
    public partial interface IShareLinksClient
    {
        /// <summary>
        /// Get share link<br/>
        /// Returns a share link by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anam.ApiException"></exception>
        global::System.Threading.Tasks.Task GetShareLinkAsync(
            global::System.Guid id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}