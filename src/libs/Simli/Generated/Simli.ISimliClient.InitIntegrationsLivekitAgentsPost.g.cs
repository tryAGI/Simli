#nullable enable

namespace Simli
{
    public partial interface ISimliClient
    {
        /// <summary>
        /// Start Livekit Agents Session
        /// </summary>
        /// <param name="sessionToken"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Simli.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Simli.InitIntegrationsLivekitAgentsPostResponse> InitIntegrationsLivekitAgentsPostAsync(

            global::Simli.LiveKitInitializationRequest request,
            string? sessionToken = default,
            global::Simli.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start Livekit Agents Session
        /// </summary>
        /// <param name="sessionToken"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Simli.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Simli.AutoSDKHttpResponse<global::Simli.InitIntegrationsLivekitAgentsPostResponse>> InitIntegrationsLivekitAgentsPostAsResponseAsync(

            global::Simli.LiveKitInitializationRequest request,
            string? sessionToken = default,
            global::Simli.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start Livekit Agents Session
        /// </summary>
        /// <param name="sessionToken"></param>
        /// <param name="requestSessionToken"></param>
        /// <param name="livekitToken"></param>
        /// <param name="livekitUrl"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Simli.InitIntegrationsLivekitAgentsPostResponse> InitIntegrationsLivekitAgentsPostAsync(
            string requestSessionToken,
            string livekitToken,
            string livekitUrl,
            string? sessionToken = default,
            global::Simli.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}