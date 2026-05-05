#nullable enable

namespace Simli
{
    public partial interface ISimliClient
    {
        /// <summary>
        /// Get HLS Segment<br/>
        /// Get HLS Stream of Generated Video
        /// </summary>
        /// <param name="destination"></param>
        /// <param name="file"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Simli.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetCachedVideoStaticHlsMachineIPFileGetAsync(
            string destination,
            string file,
            global::Simli.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get HLS Segment<br/>
        /// Get HLS Stream of Generated Video
        /// </summary>
        /// <param name="destination"></param>
        /// <param name="file"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Simli.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Simli.AutoSDKHttpResponse<string>> GetCachedVideoStaticHlsMachineIPFileGetAsResponseAsync(
            string destination,
            string file,
            global::Simli.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}