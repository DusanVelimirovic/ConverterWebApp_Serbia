using Converter_Web_Application.ApiLayer;
using Converter_Web_Application.Service.Base;
using Converter_Web_Application.Service.Models;
using Microsoft.JSInterop;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Converter_Web_Application.Service.Configuration
{
    public class CurrencyConversionService : ICurrencyConversionService, ISubject
    {
        private readonly ICurrencyApiService _currencyApiService;
        private readonly IJSRuntime _jsRuntime;
        private readonly Dictionary<string, ICurrencyCommand> _commands;
        private readonly List<IObserver> _observers;
        private List<CurrencyInfo> _currencyCache;
        private Dictionary<string, decimal> _exchangeRates;

        public CurrencyConversionService(ICurrencyApiService currencyApiService, IJSRuntime jsRuntime)
        {
            _currencyApiService = currencyApiService;
            _jsRuntime = jsRuntime;
            _currencyCache = new List<CurrencyInfo>();
            _exchangeRates = new Dictionary<string, decimal>();  // Initialize to avoid null warnings
            _observers = new List<IObserver>();

            _commands = new Dictionary<string, ICurrencyCommand>
            {
                { "convert", new ConvertCurrencyCommand() }
            };
        }

        public async Task<Dictionary<string, decimal>> FetchExchangeRatesAsync()
        {
            var jsonResponse = await _currencyApiService.GetExchangeRatesAsync();

            if (jsonResponse?["result"]?.ToString() == "success")
            {
                _exchangeRates = jsonResponse["conversion_rates"]?.ToObject<Dictionary<string, decimal>>()
                                 ?? throw new Exception("Conversion rates not found in the response.");
                Notify(); // Notify all observers about the update
                return _exchangeRates;
            }

            throw new Exception("Failed to fetch exchange rates");
        }

        public async Task<decimal> GetExchangeRateAsync(string fromCurrency, string toCurrency)
        {
            if (_exchangeRates == null || _exchangeRates.Count == 0)
            {
                await FetchExchangeRatesAsync();
            }

            if (fromCurrency == "USD")
            {
                if (_exchangeRates.TryGetValue(toCurrency, out var rateToUSD))
                {
                    return rateToUSD;
                }
                throw new KeyNotFoundException($"Exchange rate for {toCurrency} not found.");
            }

            if (toCurrency == "USD")
            {
                if (_exchangeRates.TryGetValue(fromCurrency, out var rateFromUSD))
                {
                    return 1 / rateFromUSD;
                }
                throw new KeyNotFoundException($"Exchange rate for {fromCurrency} not found.");
            }

            if (_exchangeRates.TryGetValue(fromCurrency, out var fromRate) &&
                _exchangeRates.TryGetValue(toCurrency, out var toRate))
            {
                return toRate / fromRate;
            }

            throw new KeyNotFoundException($"Exchange rates for {fromCurrency} or {toCurrency} not found.");
        }

        public async Task<decimal> ConvertCurrencyAsync(decimal amount, string fromCurrency, string toCurrency)
        {
            var exchangeRates = await FetchExchangeRatesAsync();
            return _commands["convert"].Execute(amount, exchangeRates, fromCurrency, toCurrency);
        }

        public async Task<IReadOnlyList<CurrencyInfo>> FetchEnrichedCurrencyDataAsync()
        {
            if (_currencyCache != null && _currencyCache.Count > 0)
            {
                return _currencyCache;
            }

            var cachedData = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", "currencyData");
            if (!string.IsNullOrEmpty(cachedData))
            {
                _currencyCache = Newtonsoft.Json.JsonConvert.DeserializeObject<List<CurrencyInfo>>(cachedData)
                                ?? new List<CurrencyInfo>();
                return _currencyCache;
            }

            var jsonResponse = await _currencyApiService.GetSupportedCodesAsync();

            if (jsonResponse?["result"]?.ToString() == "success")
            {
                var supportedCodes = jsonResponse["supported_codes"]?.ToObject<List<List<string>>>()
                                    ?? new List<List<string>>();

                var enrichedCurrencyData = new List<CurrencyInfo>();
                foreach (var code in supportedCodes)
                {
                    var flagUrl = await GetCurrencyFlagUrl(code[0]);
                    enrichedCurrencyData.Add(new CurrencyInfo
                    {
                        CurrencyCode = code[0],
                        CurrencyName = code[1],
                        FlagUrl = flagUrl
                    });
                }

                _currencyCache = enrichedCurrencyData;
                await _jsRuntime.InvokeVoidAsync("localStorage.setItem", "currencyData", Newtonsoft.Json.JsonConvert.SerializeObject(_currencyCache));

                return enrichedCurrencyData;
            }

            throw new Exception("Failed to fetch supported currency codes");
        }

        public async Task<IReadOnlyList<CurrencyInfo>> FetchCommonCurrenciesAsync()
        {
            // Return a limited set of common currencies
            var commonCurrencies = new List<CurrencyInfo>
            {
                new CurrencyInfo { CurrencyCode = "USD", CurrencyName = "United States Dollar", FlagUrl = "path/to/usd/flag" },
                new CurrencyInfo { CurrencyCode = "EUR", CurrencyName = "Euro", FlagUrl = "path/to/eur/flag" },
                new CurrencyInfo { CurrencyCode = "GBP", CurrencyName = "British Pound", FlagUrl = "path/to/gbp/flag" },
                new CurrencyInfo { CurrencyCode = "JPY", CurrencyName = "Japanese Yen", FlagUrl = "path/to/jpy/flag" }
            };

            return commonCurrencies;
        }

        private async Task<string> GetCurrencyFlagUrl(string currencyCode)
        {
            var jsonResponse = await _currencyApiService.GetCurrencyFlagUrlAsync(currencyCode);

            return jsonResponse?["target_data"]?["flag_url"]?.ToString() ?? string.Empty;
        }

        // Implement ISubject methods
        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_exchangeRates);
            }
        }
    }
}
