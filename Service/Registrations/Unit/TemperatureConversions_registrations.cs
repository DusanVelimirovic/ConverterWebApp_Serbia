using Converter_Web_Application.Service.Implementations.Unit;

namespace Converter_Web_Application.Service.Registrations.Unit
{
    /// <summary>
    /// Registers various temperature conversions with the ConversionManagerService.
    /// </summary>
    public class TemperatureConversions_registrations
    {
        /// <summary>
        /// Registers all temperature conversions in the provided ConversionManagerService.
        /// </summary>
        /// <param name="service">The ConversionManagerService where conversions will be registered.</param>
        public static void Register(ConversionManagerService service)
        {
            // Register conversions for Celsius to other units
            service.RegisterConversion(new CelsiusToFahrenheit());
            service.RegisterConversion(new CelsiusToKelvin());

            // Register conversions for Fahrenheit to other units
            service.RegisterConversion(new FahrenheitToCelsius());
            service.RegisterConversion(new FahrenheitToKelvin());

            // Register conversions for Kelvin to other units
            service.RegisterConversion(new KelvinToCelsius());
            service.RegisterConversion(new KelvinToFahrenheit());
        }
    }
}
