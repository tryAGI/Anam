#nullable enable

namespace Anam
{
    public partial interface IPersonasClient
    {
        /// <summary>
        /// Get persona<br/>
        /// Returns a persona by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anam.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anam.PersonaConfig> GetPersonaAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}