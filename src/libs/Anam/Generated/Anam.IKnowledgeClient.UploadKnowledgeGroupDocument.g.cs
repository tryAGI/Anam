#nullable enable

namespace Anam
{
    public partial interface IKnowledgeClient
    {
        /// <summary>
        /// Upload knowledge group document<br/>
        /// Upload a document to a knowledge group (PDF, TXT, MD, DOCX, CSV up to 50MB).
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anam.ApiException"></exception>
        global::System.Threading.Tasks.Task UploadKnowledgeGroupDocumentAsync(
            string id,

            global::Anam.UploadKnowledgeGroupDocumentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload knowledge group document<br/>
        /// Upload a document to a knowledge group (PDF, TXT, MD, DOCX, CSV up to 50MB).
        /// </summary>
        /// <param name="id"></param>
        /// <param name="file">
        /// Document file (PDF, TXT, MD, DOCX, or CSV, max 50MB).
        /// </param>
        /// <param name="filename">
        /// Document file (PDF, TXT, MD, DOCX, or CSV, max 50MB).
        /// </param>
        /// <param name="chunkSize">
        /// Default Value: 1000
        /// </param>
        /// <param name="chunkOverlap">
        /// Default Value: 200
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UploadKnowledgeGroupDocumentAsync(
            string id,
            byte[] file,
            string filename,
            int? chunkSize = default,
            int? chunkOverlap = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}