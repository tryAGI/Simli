
#nullable enable

namespace Simli
{
    /// <summary>
    /// 
    /// </summary>
    public enum AudioToVideoRequestAudioFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Mp3,
        /// <summary>
        /// 
        /// </summary>
        Ogg,
        /// <summary>
        /// 
        /// </summary>
        Pcm16,
        /// <summary>
        /// 
        /// </summary>
        Pcm32,
        /// <summary>
        /// 
        /// </summary>
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioToVideoRequestAudioFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioToVideoRequestAudioFormat value)
        {
            return value switch
            {
                AudioToVideoRequestAudioFormat.Mp3 => "mp3",
                AudioToVideoRequestAudioFormat.Ogg => "ogg",
                AudioToVideoRequestAudioFormat.Pcm16 => "pcm16",
                AudioToVideoRequestAudioFormat.Pcm32 => "pcm32",
                AudioToVideoRequestAudioFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioToVideoRequestAudioFormat? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => AudioToVideoRequestAudioFormat.Mp3,
                "ogg" => AudioToVideoRequestAudioFormat.Ogg,
                "pcm16" => AudioToVideoRequestAudioFormat.Pcm16,
                "pcm32" => AudioToVideoRequestAudioFormat.Pcm32,
                "wav" => AudioToVideoRequestAudioFormat.Wav,
                _ => null,
            };
        }
    }
}