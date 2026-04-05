
#nullable enable

namespace Simli
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LiveKitInitializationRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("livekit_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LivekitToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("livekit_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LivekitUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveKitInitializationRequest" /> class.
        /// </summary>
        /// <param name="sessionToken"></param>
        /// <param name="livekitToken"></param>
        /// <param name="livekitUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveKitInitializationRequest(
            string sessionToken,
            string livekitToken,
            string livekitUrl)
        {
            this.SessionToken = sessionToken ?? throw new global::System.ArgumentNullException(nameof(sessionToken));
            this.LivekitToken = livekitToken ?? throw new global::System.ArgumentNullException(nameof(livekitToken));
            this.LivekitUrl = livekitUrl ?? throw new global::System.ArgumentNullException(nameof(livekitUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveKitInitializationRequest" /> class.
        /// </summary>
        public LiveKitInitializationRequest()
        {
        }
    }
}