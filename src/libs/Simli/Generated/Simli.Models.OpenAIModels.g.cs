
#nullable enable

namespace Simli
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpenAIModels
    {
        /// <summary>
        /// 
        /// </summary>
        Gpt41,
        /// <summary>
        /// 
        /// </summary>
        Gpt41Mini,
        /// <summary>
        /// 
        /// </summary>
        Gpt41Nano,
        /// <summary>
        /// 
        /// </summary>
        Gpt4o,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMini,
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
                OpenAIModels.Gpt41 => "gpt-4.1",
                OpenAIModels.Gpt41Mini => "gpt-4.1-mini",
                OpenAIModels.Gpt41Nano => "gpt-4.1-nano",
                OpenAIModels.Gpt4o => "gpt-4o",
                OpenAIModels.Gpt4oMini => "gpt-4o-mini",
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
                "gpt-4.1" => OpenAIModels.Gpt41,
                "gpt-4.1-mini" => OpenAIModels.Gpt41Mini,
                "gpt-4.1-nano" => OpenAIModels.Gpt41Nano,
                "gpt-4o" => OpenAIModels.Gpt4o,
                "gpt-4o-mini" => OpenAIModels.Gpt4oMini,
                _ => null,
            };
        }
    }
}