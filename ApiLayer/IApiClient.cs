namespace Converter_Web_Application.ApiLayer
{
    /// <summary>
    /// Defines the interface for an API client.
    /// </summary>
    public interface IApiClient
    {
        /// <summary>
        /// Sends a GET request to the specified URI and deserializes the response to the specified type.
        /// </summary>
        /// <typeparam name="T">The type to which the response content should be deserialized.</typeparam>
        /// <param name="requestUri">The URI to send the GET request to.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the deserialized response content.</returns>
        Task<T> GetAsync<T>(string requestUri, string subscriptionKey);
    }
}
