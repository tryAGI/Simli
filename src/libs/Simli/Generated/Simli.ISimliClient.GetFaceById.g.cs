#nullable enable

namespace Simli
{
    public partial interface ISimliClient
    {
        /// <summary>
        /// Check that a face can be used<br/>
        /// A face can be used by the account that created it, and, when it is public, by any account that has its face ID. Public faces are not discoverable: no endpoint lists or searches other accounts' faces, so another account can use a public face only if it has been given the ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Simli.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Simli.FaceAccess> GetFaceByIdAsync(
            string id,
            global::Simli.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check that a face can be used<br/>
        /// A face can be used by the account that created it, and, when it is public, by any account that has its face ID. Public faces are not discoverable: no endpoint lists or searches other accounts' faces, so another account can use a public face only if it has been given the ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Simli.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Simli.AutoSDKHttpResponse<global::Simli.FaceAccess>> GetFaceByIdAsResponseAsync(
            string id,
            global::Simli.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}