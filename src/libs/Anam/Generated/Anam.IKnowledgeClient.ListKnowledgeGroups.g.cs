#nullable enable

namespace Anam
{
    public partial interface IKnowledgeClient
    {
        /// <summary>
        /// List knowledge groups<br/>
        /// Returns a list of all knowledge groups for the organization.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anam.ApiException"></exception>
        global::System.Threading.Tasks.Task ListKnowledgeGroupsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}