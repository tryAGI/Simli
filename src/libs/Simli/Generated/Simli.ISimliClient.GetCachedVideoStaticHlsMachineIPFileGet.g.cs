#nullable enable

namespace Simli
{
    public partial interface ISimliClient
    {
        /// <summary>
        /// Get HLS Segment<br/>
        /// Get HLS Stream of Generated Video
        /// </summary>
        /// <param name="destination"></param>
        /// <param name="file"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Simli.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetCachedVideoStaticHlsMachineIPFileGetAsync(
            string destination,
            string file,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}