#nullable enable

namespace Simli
{
    public partial interface ISimliClient
    {
        /// <summary>
        /// Generate Static Video<br/>
        /// Generate and stream a static video file from a given audio sample
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Simli.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Simli.AudioToVideoInterfaceStaticAudioPostResponse> AudioToVideoInterfaceStaticAudioPostAsync(

            global::Simli.AudioToVideoRequest request,
            global::Simli.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Static Video<br/>
        /// Generate and stream a static video file from a given audio sample
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Simli.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Simli.AutoSDKHttpResponse<global::Simli.AudioToVideoInterfaceStaticAudioPostResponse>> AudioToVideoInterfaceStaticAudioPostAsResponseAsync(

            global::Simli.AudioToVideoRequest request,
            global::Simli.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Static Video<br/>
        /// Generate and stream a static video file from a given audio sample
        /// </summary>
        /// <param name="faceId"></param>
        /// <param name="audioBase64"></param>
        /// <param name="audioFormat"></param>
        /// <param name="audioSampleRate">
        /// Default Value: 16000
        /// </param>
        /// <param name="audioChannelCount">
        /// Default Value: 1
        /// </param>
        /// <param name="videoStartingFrame">
        /// Default Value: 0
        /// </param>
        /// <param name="streamingWidth">
        /// Width of the video in pixels, Trinity-2 faces only (the others keep their own frame size). At least 512, and with streaming_height one of 1:1, 16:9 or 9:16, otherwise a 422. A canvas larger than the avatar's frame is padded with its background; a smaller one crops a window out of it.<br/>
        /// Default Value: 768
        /// </param>
        /// <param name="streamingHeight">
        /// Height of the video in pixels. See streaming_width.<br/>
        /// Default Value: 768
        /// </param>
        /// <param name="avatarPositionX">
        /// Where the avatar sits across the canvas, from 0 (left) to 1 (right). Trinity-2 only.<br/>
        /// Default Value: 0.5
        /// </param>
        /// <param name="avatarPositionY">
        /// Where the avatar sits down the canvas, from 0 (top) to 1 (bottom). Trinity-2 only.<br/>
        /// Default Value: 1.0
        /// </param>
        /// <param name="camera">
        /// The camera the video starts with, on top of the avatar's own framing. Trinity-2 only. Leave it out to keep the avatar's framing.
        /// </param>
        /// <param name="backgroundId">
        /// One of your uploaded backgrounds, by the id POST /assets/backgrounds returned, to show behind the avatar, cropped to fill the canvas. Trinity-2 only. Leave it out for the avatar's own. An id that is not one of your account's is dropped with a warning, and the video uses the avatar's own. An image is not accepted: upload it first.
        /// </param>
        /// <param name="foregroundId">
        /// One of your uploaded foregrounds, by the id POST /assets/foregrounds returned, laid over the avatar through its transparency and cropped to fill the canvas. Trinity-2 only; otherwise as background_id.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Simli.AudioToVideoInterfaceStaticAudioPostResponse> AudioToVideoInterfaceStaticAudioPostAsync(
            string faceId,
            string audioBase64,
            global::Simli.AudioToVideoRequestAudioFormat audioFormat,
            int? audioSampleRate = default,
            int? audioChannelCount = default,
            int? videoStartingFrame = default,
            int? streamingWidth = default,
            int? streamingHeight = default,
            double? avatarPositionX = default,
            double? avatarPositionY = default,
            global::Simli.CameraSetting? camera = default,
            global::System.Guid? backgroundId = default,
            global::System.Guid? foregroundId = default,
            global::Simli.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}