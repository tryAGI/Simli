
#nullable enable

namespace Simli
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SessionMetricsSpeech
    {
        /// <summary>
        /// Seconds the user spoke
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userSeconds")]
        public double? UserSeconds { get; set; }

        /// <summary>
        /// Seconds the avatar spoke
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatarSeconds")]
        public double? AvatarSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionMetricsSpeech" /> class.
        /// </summary>
        /// <param name="userSeconds">
        /// Seconds the user spoke
        /// </param>
        /// <param name="avatarSeconds">
        /// Seconds the avatar spoke
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionMetricsSpeech(
            double? userSeconds,
            double? avatarSeconds)
        {
            this.UserSeconds = userSeconds;
            this.AvatarSeconds = avatarSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionMetricsSpeech" /> class.
        /// </summary>
        public SessionMetricsSpeech()
        {
        }

    }
}