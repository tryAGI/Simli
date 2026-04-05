
#nullable enable

namespace Simli
{
    /// <summary>
    /// The provider of the LLM used by the agent
    /// </summary>
    public enum AgentUpdateLlmProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Google,
        /// <summary>
        /// 
        /// </summary>
        Openai,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentUpdateLlmProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentUpdateLlmProvider value)
        {
            return value switch
            {
                AgentUpdateLlmProvider.Google => "google",
                AgentUpdateLlmProvider.Openai => "openai",
                AgentUpdateLlmProvider.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentUpdateLlmProvider? ToEnum(string value)
        {
            return value switch
            {
                "google" => AgentUpdateLlmProvider.Google,
                "openai" => AgentUpdateLlmProvider.Openai,
                "user" => AgentUpdateLlmProvider.User,
                _ => null,
            };
        }
    }
}