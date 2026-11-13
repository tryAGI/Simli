#nullable enable

namespace Simli
{
    public partial interface ISimliClient
    {
        /// <summary>
        /// Make a face public or private<br/>
        /// A private face can be used only by the account that created it. A public face can also be used by any other account that has its face ID. Making a face public does not make it discoverable: it is not listed or searchable anywhere, and GET /faces returns only your own faces, so other accounts can use it only if you give them the ID. New faces are private.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Simli.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Simli.FacesResponse> EditFaceByIdAsync(
            string id,

            global::Simli.FacePatchRequest request,
            global::Simli.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Make a face public or private<br/>
        /// A private face can be used only by the account that created it. A public face can also be used by any other account that has its face ID. Making a face public does not make it discoverable: it is not listed or searchable anywhere, and GET /faces returns only your own faces, so other accounts can use it only if you give them the ID. New faces are private.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Simli.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Simli.AutoSDKHttpResponse<global::Simli.FacesResponse>> EditFaceByIdAsResponseAsync(
            string id,

            global::Simli.FacePatchRequest request,
            global::Simli.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Make a face public or private<br/>
        /// A private face can be used only by the account that created it. A public face can also be used by any other account that has its face ID. Making a face public does not make it discoverable: it is not listed or searchable anywhere, and GET /faces returns only your own faces, so other accounts can use it only if you give them the ID. New faces are private.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="isPublic">
        /// true makes the face public (usable by any account that has its face ID; not listed or discoverable), false makes it private (usable only by the account that created it)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Simli.FacesResponse> EditFaceByIdAsync(
            string id,
            bool isPublic,
            global::Simli.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}