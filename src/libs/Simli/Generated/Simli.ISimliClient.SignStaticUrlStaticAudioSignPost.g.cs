#nullable enable

namespace Simli
{
    public partial interface ISimliClient
    {
        /// <summary>
        /// Sign a Static Video's URLs Again<br/>
        /// Fresh signed URLs for a video made with POST /static/audio, for when the ones you have expired. Only the account that made the video can have its URLs signed.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Simli.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Simli.SignStaticUrlStaticAudioSignPostResponse> SignStaticUrlStaticAudioSignPostAsync(

            global::Simli.SignStaticUrlStaticAudioSignPostRequest request,
            global::Simli.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sign a Static Video's URLs Again<br/>
        /// Fresh signed URLs for a video made with POST /static/audio, for when the ones you have expired. Only the account that made the video can have its URLs signed.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Simli.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Simli.AutoSDKHttpResponse<global::Simli.SignStaticUrlStaticAudioSignPostResponse>> SignStaticUrlStaticAudioSignPostAsResponseAsync(

            global::Simli.SignStaticUrlStaticAudioSignPostRequest request,
            global::Simli.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sign a Static Video's URLs Again<br/>
        /// Fresh signed URLs for a video made with POST /static/audio, for when the ones you have expired. Only the account that made the video can have its URLs signed.
        /// </summary>
        /// <param name="url">
        /// Either of the video's URLs (hls_url or mp4_url), as returned before. The token on it may have expired, or be left off.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Simli.SignStaticUrlStaticAudioSignPostResponse> SignStaticUrlStaticAudioSignPostAsync(
            string url,
            global::Simli.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}