
#nullable enable

namespace Simli
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InitIntegrationsLivekitAgentsPostResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public global::System.Guid? SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination")]
        public string? Destination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InitIntegrationsLivekitAgentsPostResponse" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="sessionId"></param>
        /// <param name="destination"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InitIntegrationsLivekitAgentsPostResponse(
            string? status,
            global::System.Guid? sessionId,
            string? destination)
        {
            this.Status = status;
            this.SessionId = sessionId;
            this.Destination = destination;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InitIntegrationsLivekitAgentsPostResponse" /> class.
        /// </summary>
        public InitIntegrationsLivekitAgentsPostResponse()
        {
        }
    }
}