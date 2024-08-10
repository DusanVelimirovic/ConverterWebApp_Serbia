namespace Converter_Web_Application.Service
{
    /// <summary>
    /// Command implementation for converting currency amounts using exchange rates.
    /// </summary>
    public class ConvertCurrencyCommand : ICurrencyCommand
    {
        /// <summary>
        /// Executes the currency conversion command.
        /// </summary>
        /// <param name="amount">The amount of currency to be converted.</param>
        /// <param name="exchangeRates">A dictionary containing exchange rates for various currencies.</param>
        /// <param name="fromCurrency">The currency code of the currency to convert from.</param>
        /// <param name="toCurrency">The currency code of the currency to convert to.</param>
        /// <returns>The converted amount as a decimal.</returns>
        public decimal Execute(decimal amount, Dictionary<string, decimal> exchangeRates, string fromCurrency, string toCurrency)
        {
            if (fromCurrency == "USD")
            {
                // Direct conversion from USD to the target currency.
                return amount * exchangeRates[toCurrency];
            }
            else if (toCurrency == "USD")
            {
                // Direct conversion from the source currency to USD.
                return amount / exchangeRates[fromCurrency];
            }
            else
            {
                // Conversion between two non-USD currencies via USD as an intermediary.
                var rateFromUSD = exchangeRates[fromCurrency];
                var rateToUSD = exchangeRates[toCurrency];
                return amount * (rateToUSD / rateFromUSD);
            }
        }
    }
}
