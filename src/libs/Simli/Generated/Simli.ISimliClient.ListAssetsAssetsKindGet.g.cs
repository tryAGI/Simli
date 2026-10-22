#nullable enable

namespace Simli
{
    public partial interface ISimliClient
    {
        /// <summary>
        /// List Backgrounds or Foregrounds<br/>
        /// Your uploaded backgrounds or foregrounds, newest first, each with a signed URL that reads the image (a PNG) until url_expires_at, an hour on. Anyone holding the URL can read that one image until then, so keep it to your own app. List again for fresh URLs.
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Simli.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Simli.ListedAsset>> ListAssetsAssetsKindGetAsync(
            global::Simli.AssetKind kind,
            global::Simli.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Backgrounds or Foregrounds<br/>
        /// Your uploaded backgrounds or foregrounds, newest first, each with a signed URL that reads the image (a PNG) until url_expires_at, an hour on. Anyone holding the URL can read that one image until then, so keep it to your own app. List again for fresh URLs.
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Simli.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Simli.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Simli.ListedAsset>>> ListAssetsAssetsKindGetAsResponseAsync(
            global::Simli.AssetKind kind,
            global::Simli.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}