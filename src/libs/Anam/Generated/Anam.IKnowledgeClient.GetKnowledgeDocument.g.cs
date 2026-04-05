#nullable enable

namespace Anam
{
    public partial interface IKnowledgeClient
    {
        /// <summary>
        /// Get knowledge document<br/>
        /// Get a single document by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anam.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anam.KnowledgeDocument> GetKnowledgeDocumentAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}