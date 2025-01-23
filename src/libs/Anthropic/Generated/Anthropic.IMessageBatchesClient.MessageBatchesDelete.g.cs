#nullable enable

namespace Anthropic
{
    public partial interface IMessageBatchesClient
    {
        /// <summary>
        /// Delete a Message Batch<br/>
        /// Delete a Message Batch.<br/>
        /// Message Batches can only be deleted once they've finished processing. If you'd like to delete an in-progress batch, you must first cancel it.
        /// </summary>
        /// <param name="messageBatchId">
        /// ID of the Message Batch.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Anthropic API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://docs.anthropic.com/en/api/versioning).
        /// </param>
        /// <param name="xApiKey">
        /// Your unique API key for authentication. <br/>
        /// This key is required in the header of all API requests, to authenticate your account and access Anthropic's services. Get your API key through the [Console](https://console.anthropic.com/settings/keys). Each key is scoped to a Workspace.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.DeleteMessageBatchResponse> MessageBatchesDeleteAsync(
            string messageBatchId,
            string? anthropicVersion = default,
            string? xApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}