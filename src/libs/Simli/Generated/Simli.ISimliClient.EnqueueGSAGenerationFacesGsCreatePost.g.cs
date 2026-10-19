#nullable enable

namespace Simli
{
    public partial interface ISimliClient
    {
        /// <summary>
        /// Generate Trinity Face
        /// </summary>
        /// <param name="targetRatio"></param>
        /// <param name="gsVersion">
        /// Default Value: GSA_1.0
        /// </param>
        /// <param name="faceName">
        /// Default Value: untitled_avatar
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Simli.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Simli.EnqueueGSAGenerationFacesGsCreatePostResponse> EnqueueGSAGenerationFacesGsCreatePostAsync(

            global::Simli.BodyEnqueueGSAGenerationFacesGsCreatePost request,
            float? targetRatio = default,
            global::Simli.TrinityVersion? gsVersion = default,
            string? faceName = default,
            global::Simli.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Trinity Face
        /// </summary>
        /// <param name="targetRatio"></param>
        /// <param name="gsVersion">
        /// Default Value: GSA_1.0
        /// </param>
        /// <param name="faceName">
        /// Default Value: untitled_avatar
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Simli.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Simli.AutoSDKHttpResponse<global::Simli.EnqueueGSAGenerationFacesGsCreatePostResponse>> EnqueueGSAGenerationFacesGsCreatePostAsResponseAsync(

            global::Simli.BodyEnqueueGSAGenerationFacesGsCreatePost request,
            float? targetRatio = default,
            global::Simli.TrinityVersion? gsVersion = default,
            string? faceName = default,
            global::Simli.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Trinity Face
        /// </summary>
        /// <param name="targetRatio"></param>
        /// <param name="gsVersion">
        /// Default Value: GSA_1.0
        /// </param>
        /// <param name="faceName">
        /// Default Value: untitled_avatar
        /// </param>
        /// <param name="image"></param>
        /// <param name="imagename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Simli.EnqueueGSAGenerationFacesGsCreatePostResponse> EnqueueGSAGenerationFacesGsCreatePostAsync(
            byte[] image,
            string imagename,
            float? targetRatio = default,
            global::Simli.TrinityVersion? gsVersion = default,
            string? faceName = default,
            global::Simli.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Generate Trinity Face
        /// </summary>
        /// <param name="targetRatio"></param>
        /// <param name="gsVersion">
        /// Default Value: GSA_1.0
        /// </param>
        /// <param name="faceName">
        /// Default Value: untitled_avatar
        /// </param>
        /// <param name="image">
        /// The stream to send as the multipart 'image' file part.
        /// </param>
        /// <param name="imagename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Simli.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Simli.EnqueueGSAGenerationFacesGsCreatePostResponse> EnqueueGSAGenerationFacesGsCreatePostAsync(
            global::System.IO.Stream image,
            string imagename,
            float? targetRatio = default,
            global::Simli.TrinityVersion? gsVersion = default,
            string? faceName = default,
            global::Simli.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Trinity Face
        /// </summary>
        /// <param name="targetRatio"></param>
        /// <param name="gsVersion">
        /// Default Value: GSA_1.0
        /// </param>
        /// <param name="faceName">
        /// Default Value: untitled_avatar
        /// </param>
        /// <param name="image">
        /// The stream to send as the multipart 'image' file part.
        /// </param>
        /// <param name="imagename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Simli.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Simli.AutoSDKHttpResponse<global::Simli.EnqueueGSAGenerationFacesGsCreatePostResponse>> EnqueueGSAGenerationFacesGsCreatePostAsResponseAsync(
            global::System.IO.Stream image,
            string imagename,
            float? targetRatio = default,
            global::Simli.TrinityVersion? gsVersion = default,
            string? faceName = default,
            global::Simli.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}