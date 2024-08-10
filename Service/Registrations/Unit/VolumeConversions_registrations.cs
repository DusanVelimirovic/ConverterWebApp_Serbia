using Converter_Web_Application.Service.Implementations.Unit;

namespace Converter_Web_Application.Service.Registrations.Unit
{
    /// <summary>
    /// Registers various volume conversions with the ConversionManagerService.
    /// </summary>
    public class VolumeConversions_registrations
    {
        /// <summary>
        /// Registers all volume conversions in the provided ConversionManagerService.
        /// </summary>
        /// <param name="service">The ConversionManagerService where conversions will be registered.</param>
        public static void Register(ConversionManagerService service)
        {
            // Register conversions from cubic centimeters to other units
            service.RegisterConversion(new CubicCentimetersToCubicInches());
            service.RegisterConversion(new CubicCentimetersToCubicMeters());
            service.RegisterConversion(new CubicCentimetersToLiters());
            service.RegisterConversion(new CubicCentimetersToMilliliters());

            // Register conversions from cubic inches to other units
            service.RegisterConversion(new CubicInchesToCubicCentimeters());
            service.RegisterConversion(new CubicInchesToCubicMeters());
            service.RegisterConversion(new CubicInchesToLiters());
            service.RegisterConversion(new CubicInchesToMilliliters());

            // Register conversions from cubic meters to other units
            service.RegisterConversion(new CubicMetersToCubicCentimeters());
            service.RegisterConversion(new CubicMetersToCubicInches());
            service.RegisterConversion(new CubicMetersToLiters());
            service.RegisterConversion(new CubicMetersToMilliliters());

            // Register conversions from liters to other units
            service.RegisterConversion(new LitersToCubicCentimeters());
            service.RegisterConversion(new LitersToCubicInches());
            service.RegisterConversion(new LitersToCubicMeters());
            service.RegisterConversion(new LitersToMilliliters());

            // Register conversions from milliliters to other units
            service.RegisterConversion(new MillilitersToCubicInches());
            service.RegisterConversion(new MillilitersToCubicMeters());
            service.RegisterConversion(new MillilitersToLiters());
            service.RegisterConversion(new MillilitersToCubicCentimeters());
        }
    }
}
