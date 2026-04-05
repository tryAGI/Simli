#nullable enable

namespace Simli
{
    public partial interface ISimliClient
    {
        /// <summary>
        /// Active Session Count
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Simli.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Simli.GetRatelimiterSessionsResponse> GetRatelimiterSessionsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}