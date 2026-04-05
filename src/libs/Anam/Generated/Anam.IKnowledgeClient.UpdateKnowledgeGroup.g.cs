#nullable enable

namespace Anam
{
    public partial interface IKnowledgeClient
    {
        /// <summary>
        /// Update knowledge group<br/>
        /// Update a knowledge group.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anam.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateKnowledgeGroupAsync(
            string id,

            global::Anam.UpdateKnowledgeGroupRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update knowledge group<br/>
        /// Update a knowledge group.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdateKnowledgeGroupAsync(
            string id,
            string? name = default,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}