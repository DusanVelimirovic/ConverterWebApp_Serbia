using Microsoft.JSInterop;
using Newtonsoft.Json;
using Converter_Web_Application.Service.Base;
using Converter_Web_Application.Service.Models;
using Converter_Web_Application.ApiLayer;
using Converter_Web_Application.Service.Configuration;

namespace Converter_Web_Application.Service.DataServices
{
    public class DataPrefetchService
    {
        private readonly ICurrencyApiService _currencyApiService;
        private readonly IJSRuntime _jsRuntime;
        private IReadOnlyList<CurrencyInfo> _currencyCache;

        public DataPrefetchService(ICurrencyApiService currencyApiService, IJSRuntime jsRuntime)
        {
            _currencyApiService = currencyApiService;
            _jsRuntime = jsRuntime;
            _currencyCache = new List<CurrencyInfo>();
        }

        public async Task LoadCurrencyDataAsync()
        {
            // Check in-memory cache
            if (_currencyCache != null && _currencyCache.Count > 0)
            {
                return;
            }

            // Check local storage
            var cachedData = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", "currencyData");
            if (!string.IsNullOrEmpty(cachedData))
            {
                _currencyCache = JsonConvert.DeserializeObject<List<CurrencyInfo>>(cachedData) ?? new List<CurrencyInfo>();
                return;
            }

            // Fetch from API if not available in cache
            var currencyConversionService = new CurrencyConversionService(_currencyApiService, _jsRuntime);
            _currencyCache = await currencyConversionService.FetchEnrichedCurrencyDataAsync();

            // Update local storage
            await _jsRuntime.InvokeVoidAsync("localStorage.setItem", "currencyData", JsonConvert.SerializeObject(_currencyCache));
        }

        public IReadOnlyList<CurrencyInfo> GetCachedData()
        {
            return _currencyCache;
        }
    }
}
