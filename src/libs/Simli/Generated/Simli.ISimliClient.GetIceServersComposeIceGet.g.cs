#nullable enable

namespace Simli
{
    public partial interface ISimliClient
    {
        /// <summary>
        /// Get Ice Servers<br/>
        /// Create a new set of temporary ICE Server Credentials for WebRTC P2P session
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Simli.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Simli.GetIceServersComposeIceGetResponseItem>> GetIceServersComposeIceGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}