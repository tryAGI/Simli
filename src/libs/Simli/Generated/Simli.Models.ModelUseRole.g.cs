
#nullable enable

namespace Simli
{
    /// <summary>
    ///
    /// </summary>
    public enum ModelUseRole
    {
        /// <summary>
        ///
        /// </summary>
        Avatar,
        /// <summary>
        ///
        /// </summary>
        Llm,
        /// <summary>
        ///
        /// </summary>
        SpeechToSpeech,
        /// <summary>
        ///
        /// </summary>
        Stt,
        /// <summary>
        ///
        /// </summary>
        Tts,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelUseRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelUseRole value)
        {
            return value switch
            {
                ModelUseRole.Avatar => "avatar",
                ModelUseRole.Llm => "llm",
                ModelUseRole.SpeechToSpeech => "speech_to_speech",
                ModelUseRole.Stt => "stt",
                ModelUseRole.Tts => "tts",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelUseRole? ToEnum(string value)
        {
            return value switch
            {
                "avatar" => ModelUseRole.Avatar,
                "llm" => ModelUseRole.Llm,
                "speech_to_speech" => ModelUseRole.SpeechToSpeech,
                "stt" => ModelUseRole.Stt,
                "tts" => ModelUseRole.Tts,
                _ => null,
            };
        }
    }
}