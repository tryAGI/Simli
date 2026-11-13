
#nullable enable

namespace Simli
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StartAudioToVideoSessionComposeTokenPostResponse3
    {
        /// <summary>
        /// Example: FACE_NOT_ALLOWED
        /// </summary>
        /// <example>FACE_NOT_ALLOWED</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public string? Detail { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartAudioToVideoSessionComposeTokenPostResponse3" /> class.
        /// </summary>
        /// <param name="detail">
        /// Example: FACE_NOT_ALLOWED
        /// </param>
        /// <param name="reason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StartAudioToVideoSessionComposeTokenPostResponse3(
            string? detail,
            string? reason)
        {
            this.Detail = detail;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartAudioToVideoSessionComposeTokenPostResponse3" /> class.
        /// </summary>
        public StartAudioToVideoSessionComposeTokenPostResponse3()
        {
        }

    }
}