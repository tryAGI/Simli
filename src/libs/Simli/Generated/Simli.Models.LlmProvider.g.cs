
#nullable enable

namespace Simli
{
    /// <summary>
    /// 
    /// </summary>
    public enum LlmProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Google,
        /// <summary>
        /// 
        /// </summary>
        OpenAI,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LlmProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LlmProvider value)
        {
            return value switch
            {
                LlmProvider.Google => "Google",
                LlmProvider.OpenAI => "OpenAI",
                LlmProvider.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LlmProvider? ToEnum(string value)
        {
            return value switch
            {
                "Google" => LlmProvider.Google,
                "OpenAI" => LlmProvider.OpenAI,
                "User" => LlmProvider.User,
                _ => null,
            };
        }
    }
}