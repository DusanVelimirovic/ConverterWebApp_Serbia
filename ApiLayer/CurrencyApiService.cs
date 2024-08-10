using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace Converter_Web_Application.ApiLayer
{
    public class CurrencyApiService : ICurrencyApiService
    {
        private readonly IApiClient _apiClient;
        private readonly string _apimBaseUrl;
        private readonly string _subscriptionKey;

        public CurrencyApiService(IApiClient apiClient, string apimBaseUrl, string subscriptionKey)
        {
            _apiClient = apiClient;
            _apimBaseUrl = apimBaseUrl;
            _subscriptionKey = subscriptionKey;
        }

        public async Task<JObject> GetExchangeRatesAsync()
        {
            var requestUri = $"{_apimBaseUrl}/currency/latest/USD";
            return await _apiClient.GetAsync<JObject>(requestUri, _subscriptionKey);
        }

        public async Task<JObject> GetSupportedCodesAsync()
        {
            var requestUri = $"{_apimBaseUrl}/currency/codes";
            return await _apiClient.GetAsync<JObject>(requestUri, _subscriptionKey);
        }

        public async Task<JObject> GetCurrencyFlagUrlAsync(string currencyCode)
        {
            var requestUri = $"{_apimBaseUrl}/currency/enriched/RSD/{currencyCode}";
            return await _apiClient.GetAsync<JObject>(requestUri, _subscriptionKey);
        }
    }
}
