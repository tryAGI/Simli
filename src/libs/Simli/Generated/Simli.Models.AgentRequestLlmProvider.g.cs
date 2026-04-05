
#nullable enable

namespace Simli
{
    /// <summary>
    /// The provider of the LLM used by the agent
    /// </summary>
    public enum AgentRequestLlmProvider
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
    public static class AgentRequestLlmProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentRequestLlmProvider value)
        {
            return value switch
            {
                AgentRequestLlmProvider.Google => "google",
                AgentRequestLlmProvider.Openai => "openai",
                AgentRequestLlmProvider.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentRequestLlmProvider? ToEnum(string value)
        {
            return value switch
            {
                "google" => AgentRequestLlmProvider.Google,
                "openai" => AgentRequestLlmProvider.Openai,
                "user" => AgentRequestLlmProvider.User,
                _ => null,
            };
        }
    }
}