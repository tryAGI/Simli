
#nullable enable

namespace Simli
{
    /// <summary>
    /// 
    /// </summary>
    public enum GoogleModels
    {
        /// <summary>
        /// 
        /// </summary>
        Gemini25Flash,
        /// <summary>
        /// 
        /// </summary>
        Gemini25FlashLitePreview0617,
        /// <summary>
        /// 
        /// </summary>
        Gemini25Pro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GoogleModelsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoogleModels value)
        {
            return value switch
            {
                GoogleModels.Gemini25Flash => "gemini-2.5-flash",
                GoogleModels.Gemini25FlashLitePreview0617 => "gemini-2.5-flash-lite-preview-06-17",
                GoogleModels.Gemini25Pro => "gemini-2.5-pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoogleModels? ToEnum(string value)
        {
            return value switch
            {
                "gemini-2.5-flash" => GoogleModels.Gemini25Flash,
                "gemini-2.5-flash-lite-preview-06-17" => GoogleModels.Gemini25FlashLitePreview0617,
                "gemini-2.5-pro" => GoogleModels.Gemini25Pro,
                _ => null,
            };
        }
    }
}