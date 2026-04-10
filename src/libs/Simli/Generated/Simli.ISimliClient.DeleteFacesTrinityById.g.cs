#nullable enable

namespace Simli
{
    public partial interface ISimliClient
    {
        /// <summary>
        /// Delete a face<br/>
        /// Removes a face. This can not be undone. All agents connected to this face_id will be broken
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Simli.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteFacesTrinityByIdAsync(
            global::System.Guid id,
            global::Simli.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}