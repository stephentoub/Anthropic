
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestPageLocationCitation
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
        [global::System.Text.Json.Serialization.JsonPropertyName("document_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DocumentIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? DocumentTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_page_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndPageNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_page_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartPageNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.RequestPageLocationCitationTypeJsonConverter))]
        public global::Anthropic.RequestPageLocationCitationType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestPageLocationCitation" /> class.
        /// </summary>
        /// <param name="citedText"></param>
        /// <param name="documentIndex"></param>
        /// <param name="documentTitle"></param>
        /// <param name="endPageNumber"></param>
        /// <param name="startPageNumber"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestPageLocationCitation(
            string citedText,
            int documentIndex,
            string? documentTitle,
            int endPageNumber,
            int startPageNumber,
            global::Anthropic.RequestPageLocationCitationType type)
        {
            this.CitedText = citedText ?? throw new global::System.ArgumentNullException(nameof(citedText));
            this.DocumentIndex = documentIndex;
            this.DocumentTitle = documentTitle ?? throw new global::System.ArgumentNullException(nameof(documentTitle));
            this.EndPageNumber = endPageNumber;
            this.StartPageNumber = startPageNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestPageLocationCitation" /> class.
        /// </summary>
        public RequestPageLocationCitation()
        {
        }
    }
}