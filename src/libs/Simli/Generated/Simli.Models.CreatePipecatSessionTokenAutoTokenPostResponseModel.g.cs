
#nullable enable

namespace Simli
{
    /// <summary>
    ///
    /// </summary>
    public enum CreatePipecatSessionTokenAutoTokenPostResponseModel
    {
        /// <summary>
        ///
        /// </summary>
        Trinity1,
        /// <summary>
        ///
        /// </summary>
        Trinity2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreatePipecatSessionTokenAutoTokenPostResponseModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePipecatSessionTokenAutoTokenPostResponseModel value)
        {
            return value switch
            {
                CreatePipecatSessionTokenAutoTokenPostResponseModel.Trinity1 => "trinity1",
                CreatePipecatSessionTokenAutoTokenPostResponseModel.Trinity2 => "trinity2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePipecatSessionTokenAutoTokenPostResponseModel? ToEnum(string value)
        {
            return value switch
            {
                "trinity1" => CreatePipecatSessionTokenAutoTokenPostResponseModel.Trinity1,
                "trinity2" => CreatePipecatSessionTokenAutoTokenPostResponseModel.Trinity2,
                _ => null,
            };
        }
    }
}