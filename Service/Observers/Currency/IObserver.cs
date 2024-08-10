namespace Converter_Web_Application.Service
{
    /// <summary>
    /// Defines a contract for an observer in the Observer pattern.
    /// Observers implementing this interface are notified of changes to exchange rates.
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// Method to update the observer with the latest exchange rates.
        /// </summary>
        /// <param name="exchangeRates">A dictionary containing the latest exchange rates with currency codes as keys and their respective rates as values.</param>
        void Update(Dictionary<string, decimal> exchangeRates);
    }
}
