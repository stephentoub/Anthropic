#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class CitationsItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.CitationsItem>
    {
        /// <inheritdoc />
        public override global::Anthropic.CitationsItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRequestTextBlockCitationDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRequestTextBlockCitationDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaRequestTextBlockCitationDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaRequestCharLocationCitation? charLocation = default;
            if (discriminator?.Type == global::Anthropic.BetaRequestTextBlockCitationDiscriminatorType.CharLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRequestCharLocationCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRequestCharLocationCitation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaRequestCharLocationCitation)}");
                charLocation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaRequestPageLocationCitation? pageLocation = default;
            if (discriminator?.Type == global::Anthropic.BetaRequestTextBlockCitationDiscriminatorType.PageLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRequestPageLocationCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRequestPageLocationCitation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaRequestPageLocationCitation)}");
                pageLocation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaRequestContentBlockLocationCitation? contentBlockLocation = default;
            if (discriminator?.Type == global::Anthropic.BetaRequestTextBlockCitationDiscriminatorType.ContentBlockLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRequestContentBlockLocationCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRequestContentBlockLocationCitation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaRequestContentBlockLocationCitation)}");
                contentBlockLocation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaRequestWebSearchResultLocationCitation? webSearchResultLocation = default;
            if (discriminator?.Type == global::Anthropic.BetaRequestTextBlockCitationDiscriminatorType.WebSearchResultLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRequestWebSearchResultLocationCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRequestWebSearchResultLocationCitation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaRequestWebSearchResultLocationCitation)}");
                webSearchResultLocation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaRequestSearchResultLocationCitation? searchResultLocation = default;
            if (discriminator?.Type == global::Anthropic.BetaRequestTextBlockCitationDiscriminatorType.SearchResultLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRequestSearchResultLocationCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRequestSearchResultLocationCitation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaRequestSearchResultLocationCitation)}");
                searchResultLocation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Anthropic.CitationsItem(
                discriminator?.Type,
                charLocation,
                pageLocation,
                contentBlockLocation,
                webSearchResultLocation,
                searchResultLocation
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.CitationsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCharLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRequestCharLocationCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRequestCharLocationCitation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaRequestCharLocationCitation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CharLocation, typeInfo);
            }
            else if (value.IsPageLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRequestPageLocationCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRequestPageLocationCitation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaRequestPageLocationCitation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PageLocation, typeInfo);
            }
            else if (value.IsContentBlockLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRequestContentBlockLocationCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRequestContentBlockLocationCitation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaRequestContentBlockLocationCitation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentBlockLocation, typeInfo);
            }
            else if (value.IsWebSearchResultLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRequestWebSearchResultLocationCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRequestWebSearchResultLocationCitation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaRequestWebSearchResultLocationCitation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchResultLocation, typeInfo);
            }
            else if (value.IsSearchResultLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRequestSearchResultLocationCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRequestSearchResultLocationCitation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaRequestSearchResultLocationCitation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SearchResultLocation, typeInfo);
            }
        }
    }
}