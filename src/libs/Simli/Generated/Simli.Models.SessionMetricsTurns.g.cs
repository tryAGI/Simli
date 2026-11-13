
#nullable enable

namespace Simli
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SessionMetricsTurns
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public int? User { get; set; }

        /// <summary>
        /// The user's turns they typed (user-input on the session websocket) instead of saying; counted in user too
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("typed")]
        public int? Typed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public int? Avatar { get; set; }

        /// <summary>
        /// Times the user cut the avatar off
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interruptions")]
        public int? Interruptions { get; set; }

        /// <summary>
        /// Short listening sounds ("mhm") the avatar made while the user talked; neither its turns nor replies
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backchannels")]
        public int? Backchannels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionMetricsTurns" /> class.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="typed">
        /// The user's turns they typed (user-input on the session websocket) instead of saying; counted in user too
        /// </param>
        /// <param name="avatar"></param>
        /// <param name="interruptions">
        /// Times the user cut the avatar off
        /// </param>
        /// <param name="backchannels">
        /// Short listening sounds ("mhm") the avatar made while the user talked; neither its turns nor replies
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionMetricsTurns(
            int? user,
            int? typed,
            int? avatar,
            int? interruptions,
            int? backchannels)
        {
            this.User = user;
            this.Typed = typed;
            this.Avatar = avatar;
            this.Interruptions = interruptions;
            this.Backchannels = backchannels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionMetricsTurns" /> class.
        /// </summary>
        public SessionMetricsTurns()
        {
        }

    }
}