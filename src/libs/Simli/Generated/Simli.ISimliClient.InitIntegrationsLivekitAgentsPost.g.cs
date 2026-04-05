#nullable enable

namespace Simli
{
    public partial interface ISimliClient
    {
        /// <summary>
        /// Start Livekit Agents Session
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Simli.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Simli.InitIntegrationsLivekitAgentsPostResponse> InitIntegrationsLivekitAgentsPostAsync(

            global::Simli.LiveKitInitializationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start Livekit Agents Session
        /// </summary>
        /// <param name="sessionToken"></param>
        /// <param name="livekitToken"></param>
        /// <param name="livekitUrl"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Simli.InitIntegrationsLivekitAgentsPostResponse> InitIntegrationsLivekitAgentsPostAsync(
            string sessionToken,
            string livekitToken,
            string livekitUrl,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}