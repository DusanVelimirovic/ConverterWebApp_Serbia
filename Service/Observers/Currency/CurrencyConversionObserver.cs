namespace Converter_Web_Application.Service
{
    /// <summary>
    /// Observer implementation for monitoring currency conversion rates.
    /// Implements the IObserver interface.
    /// </summary>
    public class CurrencyConversionObserver : IObserver
    {
        // Private field to store exchange rates.
        private Dictionary<string, decimal>? _exchangeRates;

        /// <summary>
        /// Updates the exchange rates.
        /// This method is called by the subject when the exchange rates change.
        /// </summary>
        /// <param name="exchangeRates">The updated exchange rates.</param>
        public void Update(Dictionary<string, decimal> exchangeRates)
        {
            _exchangeRates = exchangeRates;
            // Handle the update as needed
            // For example, you could log the update, refresh UI components, etc.
        }

        /// <summary>
        /// Gets the current exchange rates.
        /// </summary>
        /// <returns>The current exchange rates, or null if not set.</returns>
        public Dictionary<string, decimal>? GetExchangeRates()
        {
            return _exchangeRates;
        }

        /// <summary>
        /// Determines if the exchange rates have been set.
        /// </summary>
        /// <returns>True if exchange rates have been set, otherwise false.</returns>
        public bool HasExchangeRates()
        {
            return _exchangeRates != null;
        }
    }
}
