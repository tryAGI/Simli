
#nullable enable

namespace Simli
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartAudioToVideoSessionComposeTokenPostResponse2
    {
        /// <summary>
        /// FAIL TOKEN
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_token")]
        public string? SessionToken { get; set; }

        /// <summary>
        /// Fail Reason
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public string? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartAudioToVideoSessionComposeTokenPostResponse2" /> class.
        /// </summary>
        /// <param name="sessionToken">
        /// FAIL TOKEN
        /// </param>
        /// <param name="detail">
        /// Fail Reason
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StartAudioToVideoSessionComposeTokenPostResponse2(
            string? sessionToken,
            string? detail)
        {
            this.SessionToken = sessionToken;
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartAudioToVideoSessionComposeTokenPostResponse2" /> class.
        /// </summary>
        public StartAudioToVideoSessionComposeTokenPostResponse2()
        {
        }

    }
}