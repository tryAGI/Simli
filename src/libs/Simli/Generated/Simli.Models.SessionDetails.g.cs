
#nullable enable

namespace Simli
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionDetails
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roomUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoomUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionDetails" /> class.
        /// </summary>
        /// <param name="roomUrl"></param>
        /// <param name="sessionId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionDetails(
            string roomUrl,
            string sessionId)
        {
            this.RoomUrl = roomUrl ?? throw new global::System.ArgumentNullException(nameof(roomUrl));
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionDetails" /> class.
        /// </summary>
        public SessionDetails()
        {
        }

    }
}