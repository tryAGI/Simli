#nullable enable

namespace Simli
{
    public partial interface ISimliClient
    {
        /// <summary>
        /// Delete a Background or Foreground<br/>
        /// Deletes one of your uploaded backgrounds or foregrounds. This can not be undone. A token or agent that names it starts with the avatar's own instead.
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Simli.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAssetAssetsKindAssetIdDeleteAsync(
            global::Simli.AssetKind kind,
            global::System.Guid id,
            global::Simli.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a Background or Foreground<br/>
        /// Deletes one of your uploaded backgrounds or foregrounds. This can not be undone. A token or agent that names it starts with the avatar's own instead.
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Simli.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Simli.AutoSDKHttpResponse> DeleteAssetAssetsKindAssetIdDeleteAsResponseAsync(
            global::Simli.AssetKind kind,
            global::System.Guid id,
            global::Simli.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}