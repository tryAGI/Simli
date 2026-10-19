#nullable enable

namespace Simli
{
    public partial interface ISimliClient
    {
        /// <summary>
        /// Check Trinity Generation Status<br/>
        /// Status of the caller's Trinity generations. `generations` lists every one still tracked, oldest first; the top-level status, queue_position and face_id describe the most recent of them. Accounts that generate in parallel should read `generations` - the top-level fields only ever describe one of several in flight.
        /// </summary>
        /// <param name="faceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Simli.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Simli.TrinityGenerationStatus> GetRequestStatusFacesGsStatusGetAsync(
            string? faceId = default,
            global::Simli.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check Trinity Generation Status<br/>
        /// Status of the caller's Trinity generations. `generations` lists every one still tracked, oldest first; the top-level status, queue_position and face_id describe the most recent of them. Accounts that generate in parallel should read `generations` - the top-level fields only ever describe one of several in flight.
        /// </summary>
        /// <param name="faceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Simli.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Simli.AutoSDKHttpResponse<global::Simli.TrinityGenerationStatus>> GetRequestStatusFacesGsStatusGetAsResponseAsync(
            string? faceId = default,
            global::Simli.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}