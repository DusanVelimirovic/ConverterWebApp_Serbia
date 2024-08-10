namespace Converter_Web_Application.Service.Models
{
    /// <summary>
    /// Represents information about a currency, including its code, name, and flag URL.
    /// </summary>
    public class CurrencyInfo
    {
        /// <summary>
        /// Gets or sets the currency code (e.g., "USD" for US Dollar).
        /// </summary>
        public string? CurrencyCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the currency (e.g., "US Dollar").
        /// </summary>
        public string? CurrencyName { get; set; }

        /// <summary>
        /// Gets or sets the URL to the flag image representing the currency.
        /// </summary>
        public string? FlagUrl { get; set; }
    }
}
