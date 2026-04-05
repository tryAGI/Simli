#nullable enable

namespace Simli
{
    public partial interface ISimliClient
    {
        /// <summary>
        /// Retrieve session history<br/>
        /// Returns a list of session history records for the authenticated user
        /// </summary>
        /// <param name="start">
        /// Example: 1745750387
        /// </param>
        /// <param name="end">
        /// Example: 1745750408
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Simli.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Simli.GetHistorySessionsResponse> GetHistorySessionsAsync(
            int? start = default,
            int? end = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}