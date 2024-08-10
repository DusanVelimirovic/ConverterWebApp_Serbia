namespace Converter_Web_Application.Service
{
    /// <summary>
    /// Defines a command interface for currency conversion operations.
    /// </summary>
    public interface ICurrencyCommand
    {
        /// <summary>
        /// Executes the currency conversion command.
        /// </summary>
        /// <param name="amount">The amount of currency to be converted.</param>
        /// <param name="exchangeRates">A dictionary containing exchange rates for various currencies.</param>
        /// <param name="fromCurrency">The currency code of the currency to convert from.</param>
        /// <param name="toCurrency">The currency code of the currency to convert to.</param>
        /// <returns>The converted amount as a decimal.</returns>
        decimal Execute(decimal amount, Dictionary<string, decimal> exchangeRates, string fromCurrency, string toCurrency);
    }
}
