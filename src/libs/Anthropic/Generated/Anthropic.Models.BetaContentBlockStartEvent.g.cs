
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaContentBlockStartEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_block")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.ContentBlockJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.ContentBlock ContentBlock { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// Default Value: content_block_start
        /// </summary>
        /// <default>global::Anthropic.BetaContentBlockStartEventType.ContentBlockStart</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaContentBlockStartEventTypeJsonConverter))]
        public global::Anthropic.BetaContentBlockStartEventType Type { get; set; } = global::Anthropic.BetaContentBlockStartEventType.ContentBlockStart;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaContentBlockStartEvent" /> class.
        /// </summary>
        /// <param name="contentBlock"></param>
        /// <param name="index"></param>
        /// <param name="type">
        /// Default Value: content_block_start
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaContentBlockStartEvent(
            global::Anthropic.ContentBlock contentBlock,
            int index,
            global::Anthropic.BetaContentBlockStartEventType type = global::Anthropic.BetaContentBlockStartEventType.ContentBlockStart)
        {
            this.ContentBlock = contentBlock;
            this.Index = index;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaContentBlockStartEvent" /> class.
        /// </summary>
        public BetaContentBlockStartEvent()
        {
        }
    }
}