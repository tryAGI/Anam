#nullable enable

namespace Anam
{
    public partial interface IKnowledgeClient
    {
        /// <summary>
        /// List knowledge group documents<br/>
        /// Get all documents in a knowledge group.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anam.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anam.ListKnowledgeGroupDocumentsResponse> ListKnowledgeGroupDocumentsAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}