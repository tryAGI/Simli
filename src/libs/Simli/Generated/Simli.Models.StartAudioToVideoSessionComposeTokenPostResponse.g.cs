
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
        /// Starting camera fields outside their supported range, region overrides, and background_id / foreground_id dropped as not your account's (the avatar's own is used). The token is minted regardless.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warnings")]
        public global::System.Collections.Generic.IList<string>? Warnings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartAudioToVideoSessionComposeTokenPostResponse" /> class.
        /// </summary>
        /// <param name="sessionToken"></param>
        /// <param name="warnings">
        /// Starting camera fields outside their supported range, region overrides, and background_id / foreground_id dropped as not your account's (the avatar's own is used). The token is minted regardless.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StartAudioToVideoSessionComposeTokenPostResponse(
            string? sessionToken,
            global::System.Collections.Generic.IList<string>? warnings)
        {
            this.SessionToken = sessionToken;
            this.Warnings = warnings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartAudioToVideoSessionComposeTokenPostResponse" /> class.
        /// </summary>
        public StartAudioToVideoSessionComposeTokenPostResponse()
        {
        }

    }
}