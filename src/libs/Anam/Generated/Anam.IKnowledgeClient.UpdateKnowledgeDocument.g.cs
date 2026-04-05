#nullable enable

namespace Anam
{
    public partial interface IKnowledgeClient
    {
        /// <summary>
        /// Update knowledge document<br/>
        /// Update a document (rename).
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anam.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anam.KnowledgeDocument> UpdateKnowledgeDocumentAsync(
            string id,

            global::Anam.UpdateKnowledgeDocumentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update knowledge document<br/>
        /// Update a document (rename).
        /// </summary>
        /// <param name="id"></param>
        /// <param name="filename">
        /// New filename for the document.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anam.KnowledgeDocument> UpdateKnowledgeDocumentAsync(
            string id,
            string? filename = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}