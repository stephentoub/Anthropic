
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaResponseSearchResultLocationCitation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cited_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CitedText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_block_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndBlockIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_result_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SearchResultIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_block_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartBlockIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Title { get; set; }

        /// <summary>
        /// Default Value: search_result_location
        /// </summary>
        /// <default>global::Anthropic.BetaResponseSearchResultLocationCitationType.SearchResultLocation</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaResponseSearchResultLocationCitationTypeJsonConverter))]
        public global::Anthropic.BetaResponseSearchResultLocationCitationType Type { get; set; } = global::Anthropic.BetaResponseSearchResultLocationCitationType.SearchResultLocation;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseSearchResultLocationCitation" /> class.
        /// </summary>
        /// <param name="citedText"></param>
        /// <param name="endBlockIndex"></param>
        /// <param name="searchResultIndex"></param>
        /// <param name="source"></param>
        /// <param name="startBlockIndex"></param>
        /// <param name="title"></param>
        /// <param name="type">
        /// Default Value: search_result_location
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseSearchResultLocationCitation(
            string citedText,
            int endBlockIndex,
            int searchResultIndex,
            string source,
            int startBlockIndex,
            string? title,
            global::Anthropic.BetaResponseSearchResultLocationCitationType type = global::Anthropic.BetaResponseSearchResultLocationCitationType.SearchResultLocation)
        {
            this.CitedText = citedText ?? throw new global::System.ArgumentNullException(nameof(citedText));
            this.EndBlockIndex = endBlockIndex;
            this.SearchResultIndex = searchResultIndex;
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.StartBlockIndex = startBlockIndex;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseSearchResultLocationCitation" /> class.
        /// </summary>
        public BetaResponseSearchResultLocationCitation()
        {
        }
    }
}