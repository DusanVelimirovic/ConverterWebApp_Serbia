using Newtonsoft.Json.Linq;

namespace Converter_Web_Application.ApiLayer
{
    /// <summary>
    /// Interface for interacting with the currency API to fetch exchange rates, supported codes, and currency flag URLs.
    /// </summary>
    public interface ICurrencyApiService
    {
        /// <summary>
        /// Fetches the latest exchange rates from the API.
        /// </summary>
        /// <returns>A JSON object containing the latest exchange rates.</returns>
        Task<JObject> GetExchangeRatesAsync();

        /// <summary>
        /// Fetches the supported currency codes from the API.
        /// </summary>
        /// <returns>A JSON object containing the supported currency codes.</returns>
        Task<JObject> GetSupportedCodesAsync();

        /// <summary>
        /// Fetches the currency flag URL for a given currency code from the API.
        /// </summary>
        /// <param name="currencyCode">The currency code for which to fetch the flag URL.</param>
        /// <returns>A JSON object containing the flag URL for the specified currency code.</returns>
        Task<JObject> GetCurrencyFlagUrlAsync(string currencyCode);
    }
}
