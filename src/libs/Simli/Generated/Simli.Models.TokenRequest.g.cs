
#nullable enable

namespace Simli
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TokenRequest
    {
        /// <summary>
        /// Default Value: -1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiryStamp")]
        public int? ExpiryStamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("simliAPIKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SimliAPIKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llmAPIKey")]
        public string? LlmAPIKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttsAPIKey")]
        public string? TtsAPIKey { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTranscript")]
        public bool? CreateTranscript { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("originAllowList")]
        public global::System.Collections.Generic.IList<string>? OriginAllowList { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenRequest" /> class.
        /// </summary>
        /// <param name="simliAPIKey"></param>
        /// <param name="expiryStamp">
        /// Default Value: -1
        /// </param>
        /// <param name="llmAPIKey"></param>
        /// <param name="ttsAPIKey"></param>
        /// <param name="createTranscript">
        /// Default Value: false
        /// </param>
        /// <param name="originAllowList">
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TokenRequest(
            string simliAPIKey,
            int? expiryStamp,
            string? llmAPIKey,
            string? ttsAPIKey,
            bool? createTranscript,
            global::System.Collections.Generic.IList<string>? originAllowList)
        {
            this.ExpiryStamp = expiryStamp;
            this.SimliAPIKey = simliAPIKey ?? throw new global::System.ArgumentNullException(nameof(simliAPIKey));
            this.LlmAPIKey = llmAPIKey;
            this.TtsAPIKey = ttsAPIKey;
            this.CreateTranscript = createTranscript;
            this.OriginAllowList = originAllowList;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenRequest" /> class.
        /// </summary>
        public TokenRequest()
        {
        }
    }
}