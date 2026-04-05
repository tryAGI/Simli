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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Simli.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Simli.AudioToVideoInterfaceStaticAudioPostResponse> AudioToVideoInterfaceStaticAudioPostAsync(

            global::Simli.AudioToVideoRequest request,
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Simli.AudioToVideoInterfaceStaticAudioPostResponse> AudioToVideoInterfaceStaticAudioPostAsync(
            string faceId,
            string audioBase64,
            global::Simli.AudioToVideoRequestAudioFormat audioFormat,
            int? audioSampleRate = default,
            int? audioChannelCount = default,
            int? videoStartingFrame = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}