#nullable enable

namespace Anam
{
    public partial interface IPersonasClient
    {
        /// <summary>
        /// Delete persona<br/>
        /// Delete a persona by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anam.ApiException"></exception>
        global::System.Threading.Tasks.Task DeletePersonaAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}