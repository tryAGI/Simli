#nullable enable

namespace Simli.JsonConverters
{
    /// <inheritdoc />
    public sealed class OpenAIModelsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Simli.OpenAIModels>
    {
        /// <inheritdoc />
        public override global::Simli.OpenAIModels Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Simli.OpenAIModelsExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Simli.OpenAIModels)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Simli.OpenAIModels);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Simli.OpenAIModels value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Simli.OpenAIModelsExtensions.ToValueString(value));
        }
    }
}
