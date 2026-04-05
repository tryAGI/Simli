
#nullable enable

namespace Simli
{
    /// <summary>
    /// 
    /// </summary>
    public enum SimliModels
    {
        /// <summary>
        /// 
        /// </summary>
        Artalk,
        /// <summary>
        /// 
        /// </summary>
        Fasttalk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SimliModelsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SimliModels value)
        {
            return value switch
            {
                SimliModels.Artalk => "artalk",
                SimliModels.Fasttalk => "fasttalk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimliModels? ToEnum(string value)
        {
            return value switch
            {
                "artalk" => SimliModels.Artalk,
                "fasttalk" => SimliModels.Fasttalk,
                _ => null,
            };
        }
    }
}