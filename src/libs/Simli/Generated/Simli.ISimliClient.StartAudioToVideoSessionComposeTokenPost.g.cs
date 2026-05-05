#nullable enable

namespace Simli
{
    public partial interface ISimliClient
    {
        /// <summary>
        /// Compose Session Token<br/>
        /// Create a temporary Simli Compose Session Token
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Simli.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Simli.StartAudioToVideoSessionComposeTokenPostResponse> StartAudioToVideoSessionComposeTokenPostAsync(

            global::Simli.StartStreamingSessionRequest request,
            global::Simli.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Compose Session Token<br/>
        /// Create a temporary Simli Compose Session Token
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Simli.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Simli.AutoSDKHttpResponse<global::Simli.StartAudioToVideoSessionComposeTokenPostResponse>> StartAudioToVideoSessionComposeTokenPostAsResponseAsync(

            global::Simli.StartStreamingSessionRequest request,
            global::Simli.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Compose Session Token<br/>
        /// Create a temporary Simli Compose Session Token
        /// </summary>
        /// <param name="faceId"></param>
        /// <param name="apiVersion"></param>
        /// <param name="sessionAggregator"></param>
        /// <param name="handleSilence">
        /// Default Value: true
        /// </param>
        /// <param name="maxSessionLength">
        /// Default Value: 3600
        /// </param>
        /// <param name="maxIdleTime">
        /// Default Value: 300
        /// </param>
        /// <param name="startFrame">
        /// Default Value: 0
        /// </param>
        /// <param name="audioInputFormat">
        /// Default Value: pcm16
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Simli.StartAudioToVideoSessionComposeTokenPostResponse> StartAudioToVideoSessionComposeTokenPostAsync(
            string faceId,
            string? apiVersion = default,
            string? sessionAggregator = default,
            bool? handleSilence = default,
            int? maxSessionLength = default,
            int? maxIdleTime = default,
            int? startFrame = default,
            string? audioInputFormat = default,
            global::Simli.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}