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
        global::System.Threading.Tasks.Task<byte[]> GetCachedVideoStaticHlsMachineIPFileGetAsync(
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
        global::System.Threading.Tasks.Task<global::System.IO.Stream> GetCachedVideoStaticHlsMachineIPFileGetAsStreamAsync(
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
        /// <returns>The response metadata and an unbuffered body stream. The caller must dispose Body to release the HTTP response.</returns>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Simli.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Simli.AutoSDKHttpResponse<global::System.IO.Stream>> GetCachedVideoStaticHlsMachineIPFileGetAsStreamAsResponseAsync(
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
        global::System.Threading.Tasks.Task<global::Simli.AutoSDKHttpResponse<byte[]>> GetCachedVideoStaticHlsMachineIPFileGetAsResponseAsync(
            string destination,
            string file,
            global::Simli.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}