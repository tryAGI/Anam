#nullable enable

namespace Anam
{
    public partial interface IKnowledgeClient
    {
        /// <summary>
        /// Create knowledge group<br/>
        /// Create a new knowledge group for RAG.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anam.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anam.KnowledgeGroup> CreateKnowledgeGroupAsync(

            global::Anam.CreateKnowledgeGroupRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create knowledge group<br/>
        /// Create a new knowledge group for RAG.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anam.KnowledgeGroup> CreateKnowledgeGroupAsync(
            string name,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}