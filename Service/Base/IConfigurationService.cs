namespace Converter_Web_Application.Service.Base
{
    /// <summary>
    /// Provides access to configuration settings.
    /// </summary>
    public interface IConfigurationService
    {
        /// <summary>
        /// Gets the API key for accessing the exchange rate service.
        /// </summary>
        string ExchangeRateApiKey { get; }
    }
}
