
#nullable enable

namespace Simli
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetRatelimiterSessionsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentUsage")]
        public int? CurrentUsage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRatelimiterSessionsResponse" /> class.
        /// </summary>
        /// <param name="currentUsage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRatelimiterSessionsResponse(
            int? currentUsage)
        {
            this.CurrentUsage = currentUsage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRatelimiterSessionsResponse" /> class.
        /// </summary>
        public GetRatelimiterSessionsResponse()
        {
        }

    }
}