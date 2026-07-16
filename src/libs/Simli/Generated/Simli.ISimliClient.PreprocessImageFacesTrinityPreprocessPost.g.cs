#nullable enable

namespace Simli
{
    public partial interface ISimliClient
    {
        /// <summary>
        /// Preprocess Trinity Face Image<br/>
        /// Reframes a portrait to the framing Trinity expects: the head centred with equal padding above and below, squared to the camera, on a simplified version of the image's own background. Returns the reframed PNG.
        /// </summary>
        /// <param name="retry">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Simli.ApiException"></exception>
        global::System.Threading.Tasks.Task PreprocessImageFacesTrinityPreprocessPostAsync(

            global::Simli.BodyPreprocessImageFacesTrinityPreprocessPost request,
            bool? retry = default,
            global::Simli.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Preprocess Trinity Face Image<br/>
        /// Reframes a portrait to the framing Trinity expects: the head centred with equal padding above and below, squared to the camera, on a simplified version of the image's own background. Returns the reframed PNG.
        /// </summary>
        /// <param name="retry">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Simli.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Simli.AutoSDKHttpResponse> PreprocessImageFacesTrinityPreprocessPostAsResponseAsync(

            global::Simli.BodyPreprocessImageFacesTrinityPreprocessPost request,
            bool? retry = default,
            global::Simli.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Preprocess Trinity Face Image<br/>
        /// Reframes a portrait to the framing Trinity expects: the head centred with equal padding above and below, squared to the camera, on a simplified version of the image's own background. Returns the reframed PNG.
        /// </summary>
        /// <param name="retry">
        /// Default Value: false
        /// </param>
        /// <param name="image">
        /// JPEG, PNG or WEBP, under 5MB, at least 512x512. It must contain a person facing the camera whose head is at least 15% of the image height - a head smaller than that carries too few pixels to keep the likeness, and is rejected. Where several people are present, the largest camera-facing head is treated as the subject.
        /// </param>
        /// <param name="imagename">
        /// JPEG, PNG or WEBP, under 5MB, at least 512x512. It must contain a person facing the camera whose head is at least 15% of the image height - a head smaller than that carries too few pixels to keep the likeness, and is rejected. Where several people are present, the largest camera-facing head is treated as the subject.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PreprocessImageFacesTrinityPreprocessPostAsync(
            byte[] image,
            string imagename,
            bool? retry = default,
            global::Simli.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Preprocess Trinity Face Image<br/>
        /// Reframes a portrait to the framing Trinity expects: the head centred with equal padding above and below, squared to the camera, on a simplified version of the image's own background. Returns the reframed PNG.
        /// </summary>
        /// <param name="retry">
        /// Default Value: false
        /// </param>
        /// <param name="image">
        /// JPEG, PNG or WEBP, under 5MB, at least 512x512. It must contain a person facing the camera whose head is at least 15% of the image height - a head smaller than that carries too few pixels to keep the likeness, and is rejected. Where several people are present, the largest camera-facing head is treated as the subject.
        /// </param>
        /// <param name="imagename">
        /// JPEG, PNG or WEBP, under 5MB, at least 512x512. It must contain a person facing the camera whose head is at least 15% of the image height - a head smaller than that carries too few pixels to keep the likeness, and is rejected. Where several people are present, the largest camera-facing head is treated as the subject.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Simli.ApiException"></exception>
        global::System.Threading.Tasks.Task PreprocessImageFacesTrinityPreprocessPostAsync(
            global::System.IO.Stream image,
            string imagename,
            bool? retry = default,
            global::Simli.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Preprocess Trinity Face Image<br/>
        /// Reframes a portrait to the framing Trinity expects: the head centred with equal padding above and below, squared to the camera, on a simplified version of the image's own background. Returns the reframed PNG.
        /// </summary>
        /// <param name="retry">
        /// Default Value: false
        /// </param>
        /// <param name="image">
        /// JPEG, PNG or WEBP, under 5MB, at least 512x512. It must contain a person facing the camera whose head is at least 15% of the image height - a head smaller than that carries too few pixels to keep the likeness, and is rejected. Where several people are present, the largest camera-facing head is treated as the subject.
        /// </param>
        /// <param name="imagename">
        /// JPEG, PNG or WEBP, under 5MB, at least 512x512. It must contain a person facing the camera whose head is at least 15% of the image height - a head smaller than that carries too few pixels to keep the likeness, and is rejected. Where several people are present, the largest camera-facing head is treated as the subject.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Simli.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Simli.AutoSDKHttpResponse> PreprocessImageFacesTrinityPreprocessPostAsResponseAsync(
            global::System.IO.Stream image,
            string imagename,
            bool? retry = default,
            global::Simli.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}