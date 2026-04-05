#nullable enable

namespace Simli
{
    public partial interface ISimliClient
    {
        /// <summary>
        /// Check Trinity Generation Status
        /// </summary>
        /// <param name="faceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Simli.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetRequestStatusFacesGsStatusGetAsync(
            string? faceId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}