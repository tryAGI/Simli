
#nullable enable

namespace Simli
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelUse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Simli.JsonConverters.ModelUseRoleJsonConverter))]
        public global::Simli.ModelUseRole? Role { get; set; }

        /// <summary>
        /// Example: Azure OpenAI
        /// </summary>
        /// <example>Azure OpenAI</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// Example: gpt-realtime-2.1-mini
        /// </summary>
        /// <example>gpt-realtime-2.1-mini</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Whether it ran on Simli's key (Simli pays for it) rather than the caller's
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("simliKey")]
        public bool? SimliKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelUse" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="provider">
        /// Example: Azure OpenAI
        /// </param>
        /// <param name="model">
        /// Example: gpt-realtime-2.1-mini
        /// </param>
        /// <param name="simliKey">
        /// Whether it ran on Simli's key (Simli pays for it) rather than the caller's
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelUse(
            global::Simli.ModelUseRole? role,
            string? provider,
            string? model,
            bool? simliKey)
        {
            this.Role = role;
            this.Provider = provider;
            this.Model = model;
            this.SimliKey = simliKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelUse" /> class.
        /// </summary>
        public ModelUse()
        {
        }

    }
}