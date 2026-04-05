
#nullable enable

namespace Simli
{
    /// <summary>
    /// The provider of the LLM used by the agent
    /// </summary>
    public enum AgentResponseLlmProvider
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
    public static class AgentResponseLlmProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentResponseLlmProvider value)
        {
            return value switch
            {
                AgentResponseLlmProvider.Google => "google",
                AgentResponseLlmProvider.Openai => "openai",
                AgentResponseLlmProvider.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentResponseLlmProvider? ToEnum(string value)
        {
            return value switch
            {
                "google" => AgentResponseLlmProvider.Google,
                "openai" => AgentResponseLlmProvider.Openai,
                "user" => AgentResponseLlmProvider.User,
                _ => null,
            };
        }
    }
}