using Converter_Web_Application.Service.Base;

namespace Converter_Web_Application.Service.Configuration
{
    /// <summary>
    /// Service for managing configuration settings for API key for exchange rate service.
    /// </summary>
    public class ConfigurationService : IConfigurationService
    {
        private readonly IConfiguration _configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationService"/> class.
        /// </summary>
        /// <param name="configuration">The configuration instance.</param>
        public ConfigurationService(IConfiguration configuration)
        {
            _configuration = configuration;
            ExchangeRateApiKey = _configuration["ExchangeRateApiKey"]
                                 ?? throw new ArgumentNullException(nameof(ExchangeRateApiKey), "ExchangeRateApiKey configuration is missing.");
        }

        /// <summary>
        /// Gets the exchange rate API key from the configuration.
        /// </summary>
        public string ExchangeRateApiKey { get; }

        // Future configuration settings can be added here.
    }
}
