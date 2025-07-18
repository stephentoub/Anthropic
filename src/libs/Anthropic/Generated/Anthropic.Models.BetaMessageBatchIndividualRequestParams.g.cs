
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaMessageBatchIndividualRequestParams
    {
        /// <summary>
        /// Developer-provided ID created for each request in a Message Batch. Useful for matching results to requests, as results may be given out of request order.<br/>
        /// Must be unique for each request within the Message Batch.<br/>
        /// Example: my-custom-id-1
        /// </summary>
        /// <example>my-custom-id-1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CustomId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaCreateMessageParams Params { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMessageBatchIndividualRequestParams" /> class.
        /// </summary>
        /// <param name="customId">
        /// Developer-provided ID created for each request in a Message Batch. Useful for matching results to requests, as results may be given out of request order.<br/>
        /// Must be unique for each request within the Message Batch.<br/>
        /// Example: my-custom-id-1
        /// </param>
        /// <param name="params"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaMessageBatchIndividualRequestParams(
            string customId,
            global::Anthropic.BetaCreateMessageParams @params)
        {
            this.CustomId = customId ?? throw new global::System.ArgumentNullException(nameof(customId));
            this.Params = @params ?? throw new global::System.ArgumentNullException(nameof(@params));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMessageBatchIndividualRequestParams" /> class.
        /// </summary>
        public BetaMessageBatchIndividualRequestParams()
        {
        }
    }
}