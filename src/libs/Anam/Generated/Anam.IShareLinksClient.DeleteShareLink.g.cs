#nullable enable

namespace Anam
{
    public partial interface IShareLinksClient
    {
        /// <summary>
        /// Delete share link<br/>
        /// Delete a share link by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anam.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteShareLinkAsync(
            global::System.Guid id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}