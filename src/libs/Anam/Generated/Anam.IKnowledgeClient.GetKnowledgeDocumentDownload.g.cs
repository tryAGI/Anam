#nullable enable

namespace Anam
{
    public partial interface IKnowledgeClient
    {
        /// <summary>
        /// Get knowledge document download<br/>
        /// Get a presigned download URL for a knowledge document.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anam.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anam.GetKnowledgeDocumentDownloadResponse> GetKnowledgeDocumentDownloadAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}