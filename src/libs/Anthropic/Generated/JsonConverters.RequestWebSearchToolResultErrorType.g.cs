#nullable enable

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public sealed class RequestWebSearchToolResultErrorTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.RequestWebSearchToolResultErrorType>
    {
        /// <inheritdoc />
        public override global::Anthropic.RequestWebSearchToolResultErrorType Read(
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
                        return global::Anthropic.RequestWebSearchToolResultErrorTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anthropic.RequestWebSearchToolResultErrorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Anthropic.RequestWebSearchToolResultErrorType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.RequestWebSearchToolResultErrorType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Anthropic.RequestWebSearchToolResultErrorTypeExtensions.ToValueString(value));
        }
    }
}
