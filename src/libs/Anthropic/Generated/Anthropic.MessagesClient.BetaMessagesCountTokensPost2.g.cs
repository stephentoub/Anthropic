
#nullable enable

namespace Anthropic
{
    public partial class MessagesClient
    {
        partial void PrepareBetaMessagesCountTokensPost2Arguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? anthropicBeta,
            ref string? anthropicVersion,
            global::Anthropic.BetaCountMessageTokensParams request);
        partial void PrepareBetaMessagesCountTokensPost2Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? anthropicBeta,
            string? anthropicVersion,
            global::Anthropic.BetaCountMessageTokensParams request);
        partial void ProcessBetaMessagesCountTokensPost2Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessBetaMessagesCountTokensPost2ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Count tokens in a Message<br/>
        /// Count the number of tokens in a Message.<br/>
        /// The Token Count API can be used to count the number of tokens in a Message, including tools, images, and documents, without creating it.
        /// </summary>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Anthropic API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://docs.anthropic.com/en/api/versioning).
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Anthropic.BetaCountMessageTokensResponse> BetaMessagesCountTokensPost2Async(
            global::Anthropic.BetaCountMessageTokensParams request,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareBetaMessagesCountTokensPost2Arguments(
                httpClient: HttpClient,
                anthropicBeta: ref anthropicBeta,
                anthropicVersion: ref anthropicVersion,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/v1/messages/count_tokens",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            if (anthropicBeta != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("anthropic-beta", anthropicBeta.ToString());
            }
            if (anthropicVersion != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("anthropic-version", anthropicVersion.ToString());
            }

            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareBetaMessagesCountTokensPost2Request(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                anthropicBeta: anthropicBeta,
                anthropicVersion: anthropicVersion,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessBetaMessagesCountTokensPost2Response(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Error response.  See our [errors documentation](https://docs.anthropic.com/en/api/errors) for more details.
            if ((int)__response.StatusCode >= 400 && (int)__response.StatusCode <= 499)
            {
                string? __content_4XX = null;
                global::Anthropic.BetaErrorResponse? __value_4XX = null;
                if (ReadResponseAsString)
                {
                    __content_4XX = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_4XX = global::Anthropic.BetaErrorResponse.FromJson(__content_4XX, JsonSerializerContext);
                }
                else
                {
                    var __contentStream_4XX = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_4XX = await global::Anthropic.BetaErrorResponse.FromJsonStreamAsync(__contentStream_4XX, JsonSerializerContext).ConfigureAwait(false);
                }

                throw new global::Anthropic.ApiException<global::Anthropic.BetaErrorResponse>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_4XX,
                    ResponseObject = __value_4XX,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessBetaMessagesCountTokensPost2ResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::Anthropic.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                return
                    global::Anthropic.BetaCountMessageTokensResponse.FromJson(__content, JsonSerializerContext) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::Anthropic.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                using var __content = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);

                return
                    await global::Anthropic.BetaCountMessageTokensResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Count tokens in a Message<br/>
        /// Count the number of tokens in a Message.<br/>
        /// The Token Count API can be used to count the number of tokens in a Message, including tools, images, and documents, without creating it.
        /// </summary>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Anthropic API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://docs.anthropic.com/en/api/versioning).
        /// </param>
        /// <param name="toolChoice">
        /// How the model should use the provided tools. The model can use a specific tool, any available tool, or decide by itself.
        /// </param>
        /// <param name="tools">
        /// Definitions of tools that the model may use.<br/>
        /// If you include `tools` in your API request, the model may return `tool_use` content blocks that represent the model's use of those tools. You can then run those tools using the tool input generated by the model and then optionally return results back to the model using `tool_result` content blocks.<br/>
        /// Each tool definition includes:<br/>
        /// * `name`: Name of the tool.<br/>
        /// * `description`: Optional, but strongly-recommended description of the tool.<br/>
        /// * `input_schema`: [JSON schema](https://json-schema.org/) for the tool `input` shape that the model will produce in `tool_use` output content blocks.<br/>
        /// For example, if you defined `tools` as:<br/>
        /// ```json<br/>
        /// [<br/>
        ///   {<br/>
        ///     "name": "get_stock_price",<br/>
        ///     "description": "Get the current stock price for a given ticker symbol.",<br/>
        ///     "input_schema": {<br/>
        ///       "type": "object",<br/>
        ///       "properties": {<br/>
        ///         "ticker": {<br/>
        ///           "type": "string",<br/>
        ///           "description": "The stock ticker symbol, e.g. AAPL for Apple Inc."<br/>
        ///         }<br/>
        ///       },<br/>
        ///       "required": ["ticker"]<br/>
        ///     }<br/>
        ///   }<br/>
        /// ]<br/>
        /// ```<br/>
        /// And then asked the model "What's the S&amp;P 500 at today?", the model might produce `tool_use` content blocks in the response like this:<br/>
        /// ```json<br/>
        /// [<br/>
        ///   {<br/>
        ///     "type": "tool_use",<br/>
        ///     "id": "toolu_01D7FLrfh4GYq7yT1ULFeyMV",<br/>
        ///     "name": "get_stock_price",<br/>
        ///     "input": { "ticker": "^GSPC" }<br/>
        ///   }<br/>
        /// ]<br/>
        /// ```<br/>
        /// You might then run your `get_stock_price` tool with `{"ticker": "^GSPC"}` as an input, and return the following back to the model in a subsequent `user` message:<br/>
        /// ```json<br/>
        /// [<br/>
        ///   {<br/>
        ///     "type": "tool_result",<br/>
        ///     "tool_use_id": "toolu_01D7FLrfh4GYq7yT1ULFeyMV",<br/>
        ///     "content": "259.75 USD"<br/>
        ///   }<br/>
        /// ]<br/>
        /// ```<br/>
        /// Tools can be used for workflows that include running client-side tools and functions, or more generally whenever you want the model to produce a particular JSON structure of output.<br/>
        /// See our [guide](https://docs.anthropic.com/en/docs/tool-use) for more details.
        /// </param>
        /// <param name="messages">
        /// Input messages.<br/>
        /// Our models are trained to operate on alternating `user` and `assistant` conversational turns. When creating a new `Message`, you specify the prior conversational turns with the `messages` parameter, and the model then generates the next `Message` in the conversation. Consecutive `user` or `assistant` turns in your request will be combined into a single turn.<br/>
        /// Each input message must be an object with a `role` and `content`. You can specify a single `user`-role message, or you can include multiple `user` and `assistant` messages.<br/>
        /// If the final message uses the `assistant` role, the response content will continue immediately from the content in that message. This can be used to constrain part of the model's response.<br/>
        /// Example with a single `user` message:<br/>
        /// ```json<br/>
        /// [{"role": "user", "content": "Hello, Claude"}]<br/>
        /// ```<br/>
        /// Example with multiple conversational turns:<br/>
        /// ```json<br/>
        /// [<br/>
        ///   {"role": "user", "content": "Hello there."},<br/>
        ///   {"role": "assistant", "content": "Hi, I'm Claude. How can I help you?"},<br/>
        ///   {"role": "user", "content": "Can you explain LLMs in plain English?"},<br/>
        /// ]<br/>
        /// ```<br/>
        /// Example with a partially-filled response from Claude:<br/>
        /// ```json<br/>
        /// [<br/>
        ///   {"role": "user", "content": "What's the Greek name for Sun? (A) Sol (B) Helios (C) Sun"},<br/>
        ///   {"role": "assistant", "content": "The best answer is ("},<br/>
        /// ]<br/>
        /// ```<br/>
        /// Each input message `content` may be either a single `string` or an array of content blocks, where each block has a specific `type`. Using a `string` for `content` is shorthand for an array of one content block of type `"text"`. The following input messages are equivalent:<br/>
        /// ```json<br/>
        /// {"role": "user", "content": "Hello, Claude"}<br/>
        /// ```<br/>
        /// ```json<br/>
        /// {"role": "user", "content": [{"type": "text", "text": "Hello, Claude"}]}<br/>
        /// ```<br/>
        /// Starting with Claude 3 models, you can also send image content blocks:<br/>
        /// ```json<br/>
        /// {"role": "user", "content": [<br/>
        ///   {<br/>
        ///     "type": "image",<br/>
        ///     "source": {<br/>
        ///       "type": "base64",<br/>
        ///       "media_type": "image/jpeg",<br/>
        ///       "data": "/9j/4AAQSkZJRg...",<br/>
        ///     }<br/>
        ///   },<br/>
        ///   {"type": "text", "text": "What is in this image?"}<br/>
        /// ]}<br/>
        /// ```<br/>
        /// We currently support the `base64` source type for images, and the `image/jpeg`, `image/png`, `image/gif`, and `image/webp` media types.<br/>
        /// See [examples](https://docs.anthropic.com/en/api/messages-examples#vision) for more input examples.<br/>
        /// Note that if you want to include a [system prompt](https://docs.anthropic.com/en/docs/system-prompts), you can use the top-level `system` parameter — there is no `"system"` role for input messages in the Messages API.
        /// </param>
        /// <param name="system">
        /// System prompt.<br/>
        /// A system prompt is a way of providing context and instructions to Claude, such as specifying a particular goal or role. See our [guide to system prompts](https://docs.anthropic.com/en/docs/system-prompts).<br/>
        /// Example: []
        /// </param>
        /// <param name="model">
        /// The model that will complete your prompt.\n\nSee [models](https://docs.anthropic.com/en/docs/models-overview) for additional details and options.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Anthropic.BetaCountMessageTokensResponse> BetaMessagesCountTokensPost2Async(
            global::System.Collections.Generic.IList<global::Anthropic.BetaInputMessage> messages,
            global::Anthropic.Model model,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            global::Anthropic.BetaToolChoice? toolChoice = default,
            global::System.Collections.Generic.IList<global::Anthropic.ToolsItem>? tools = default,
            global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.BetaRequestTextBlock>>? system = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Anthropic.BetaCountMessageTokensParams
            {
                ToolChoice = toolChoice,
                Tools = tools,
                Messages = messages,
                System = system,
                Model = model,
            };

            return await BetaMessagesCountTokensPost2Async(
                anthropicBeta: anthropicBeta,
                anthropicVersion: anthropicVersion,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}