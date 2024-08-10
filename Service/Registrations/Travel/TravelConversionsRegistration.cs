namespace Converter_Web_Application.Service.Registrations.Travel
{
    /// <summary>
    /// Handles the registration of travel-related conversions in the ConversionManagerService.
    /// </summary>
    public static class TravelConversionsRegistration
    {
        /// <summary>
        /// Registers various travel conversions with the provided ConversionManagerService.
        /// </summary>
        /// <param name="service">The ConversionManagerService where conversions will be registered.</param>
        public static void Register(ConversionManagerService service)
        {
            // Register travel time and speed calculations
            service.RegisterConversion(new CalculateTravelTime());
            service.RegisterConversion(new CalculateTravelSpeed());

            // Register unit conversions between miles per hour and kilometers per hour
            service.RegisterConversion(new MphToKmh());
            service.RegisterConversion(new KmhToMph());
        }
    }
}
