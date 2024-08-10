using Converter_Web_Application.Service.Implementations.Unit;

namespace Converter_Web_Application.Service.Registrations.Unit
{
    /// <summary>
    /// Registers various speed conversions with the ConversionManagerService.
    /// </summary>
    public class SpeedConversions_registrations
    {
        /// <summary>
        /// Registers all speed conversions in the provided ConversionManagerService.
        /// </summary>
        /// <param name="service">The ConversionManagerService where conversions will be registered.</param>
        public static void Register(ConversionManagerService service)
        {
            // Register conversions for Meters per Second
            service.RegisterConversion(new MetersPerSecondToKilometersPerHour());
            service.RegisterConversion(new MetersPerSecondToMilesPerHour());
            service.RegisterConversion(new MetersPerSecondToFeetPerSecond());
            service.RegisterConversion(new MetersPerSecondToKnots());

            // Register conversions for Kilometers per Hour
            service.RegisterConversion(new KilometersPerHourToMetersPerSecond());
            service.RegisterConversion(new KilometersPerHourToMilesPerHour());
            service.RegisterConversion(new KilometersPerHourToFeetPerSecond());
            service.RegisterConversion(new KilometersPerHourToKnots());

            // Register conversions for Miles per Hour
            service.RegisterConversion(new MilesPerHourToMetersPerSecond());
            service.RegisterConversion(new MilesPerHourToKilometersPerHour());
            service.RegisterConversion(new MilesPerHourToFeetPerSecond());
            service.RegisterConversion(new MilesPerHourToKnots());

            // Register conversions for Feet per Second
            service.RegisterConversion(new FeetPerSecondToMetersPerSecond());
            service.RegisterConversion(new FeetPerSecondToKilometersPerHour());
            service.RegisterConversion(new FeetPerSecondToMilesPerHour());
            service.RegisterConversion(new FeetPerSecondToKnots());

            // Register conversions for Knots
            service.RegisterConversion(new KnotsToMetersPerSecond());
            service.RegisterConversion(new KnotsToKilometersPerHour());
            service.RegisterConversion(new KnotsToMilesPerHour());
            service.RegisterConversion(new KnotsToFeetPerSecond());
        }
    }
}
