
#nullable enable

namespace Simli
{
    /// <summary>
    /// gpt-realtime-2.1-mini and gpt-live-1 are speech to speech: they listen and speak themselves, so the TTS settings don't apply. The older gpt-4o and gpt-4.1 models are still accepted for existing integrations.
    /// </summary>
    public enum OpenAIModels
    {
        /// <summary>
        ///
        /// </summary>
        Gpt6Luna,
        /// <summary>
        /// they listen and speak themselves, so the TTS settings don't apply. The older gpt-4o and gpt-4.1 models are still accepted for existing integrations.
        /// </summary>
        GptLive1,
        /// <summary>
        /// they listen and speak themselves, so the TTS settings don't apply. The older gpt-4o and gpt-4.1 models are still accepted for existing integrations.
        /// </summary>
        GptRealtime21Mini,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIModelsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIModels value)
        {
            return value switch
            {
                OpenAIModels.Gpt6Luna => "gpt-6-luna",
                OpenAIModels.GptLive1 => "gpt-live-1",
                OpenAIModels.GptRealtime21Mini => "gpt-realtime-2.1-mini",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIModels? ToEnum(string value)
        {
            return value switch
            {
                "gpt-6-luna" => OpenAIModels.Gpt6Luna,
                "gpt-live-1" => OpenAIModels.GptLive1,
                "gpt-realtime-2.1-mini" => OpenAIModels.GptRealtime21Mini,
                _ => null,
            };
        }
    }
}