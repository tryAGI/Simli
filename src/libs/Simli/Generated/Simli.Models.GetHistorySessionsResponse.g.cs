
#nullable enable

namespace Simli
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetHistorySessionsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessions")]
        public global::System.Collections.Generic.IList<global::Simli.HistoryRecord>? Sessions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetHistorySessionsResponse" /> class.
        /// </summary>
        /// <param name="sessions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetHistorySessionsResponse(
            global::System.Collections.Generic.IList<global::Simli.HistoryRecord>? sessions)
        {
            this.Sessions = sessions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetHistorySessionsResponse" /> class.
        /// </summary>
        public GetHistorySessionsResponse()
        {
        }

    }
}