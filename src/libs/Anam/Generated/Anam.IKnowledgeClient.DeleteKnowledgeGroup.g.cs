#nullable enable

namespace Anam
{
    public partial interface IKnowledgeClient
    {
        /// <summary>
        /// Delete knowledge group<br/>
        /// Delete a knowledge group.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anam.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteKnowledgeGroupAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}