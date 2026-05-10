
#nullable enable

namespace Simli
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartAudioToVideoSessionComposeTokenPostResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_token")]
        public string? SessionToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartAudioToVideoSessionComposeTokenPostResponse" /> class.
        /// </summary>
        /// <param name="sessionToken"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StartAudioToVideoSessionComposeTokenPostResponse(
            string? sessionToken)
        {
            this.SessionToken = sessionToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartAudioToVideoSessionComposeTokenPostResponse" /> class.
        /// </summary>
        public StartAudioToVideoSessionComposeTokenPostResponse()
        {
        }

    }
}