using Converter_Web_Application.Service.Implementations.Unit;

namespace Converter_Web_Application.Service.Registrations.Unit
{
    /// <summary>
    /// Registers various length conversions with the ConversionManagerService.
    /// </summary>
    public class LengthConversions_registrations
    {
        /// <summary>
        /// Registers all length conversions in the provided ConversionManagerService.
        /// </summary>
        /// <param name="service">The ConversionManagerService where conversions will be registered.</param>
        public static void Register(ConversionManagerService service)
        {
            // Register conversions for meters
            service.RegisterConversion(new MetersToKilometers());
            service.RegisterConversion(new MetersToMiles());
            service.RegisterConversion(new MetersToCentimeters());
            service.RegisterConversion(new MetersToMillimeters());
            service.RegisterConversion(new MetersToFeet());
            service.RegisterConversion(new MetersToYards());
            service.RegisterConversion(new MetersToNauticalMiles());
            service.RegisterConversion(new MetersToInches());
            service.RegisterConversion(new MetersToLeagues());

            // Register conversions for kilometers
            service.RegisterConversion(new KilometersToMiles());
            service.RegisterConversion(new KilometersToMeters());
            service.RegisterConversion(new KilometersToNauticalMiles());
            service.RegisterConversion(new KilometersToCentimeters());
            service.RegisterConversion(new KilometersToMillimeters());
            service.RegisterConversion(new KilometersToYards());
            service.RegisterConversion(new KilometersToFeet());
            service.RegisterConversion(new KilometersToInches());
            service.RegisterConversion(new KilometersToLeagues());

            // Register conversions for miles
            service.RegisterConversion(new MilesToKilometers());
            service.RegisterConversion(new MilesToMeters());
            service.RegisterConversion(new MilesToCentimeters());
            service.RegisterConversion(new MilesToMillimeters());
            service.RegisterConversion(new MilesToNauticalMiles());
            service.RegisterConversion(new MilesToYards());
            service.RegisterConversion(new MilesToFeet());
            service.RegisterConversion(new MilesToInches());
            service.RegisterConversion(new MilesToLeagues());

            // Register conversions for centimeters
            service.RegisterConversion(new CentimetersToInches());
            service.RegisterConversion(new CentimetersToKilometers());
            service.RegisterConversion(new CentimetersToMiles());
            service.RegisterConversion(new CentimetersToMillimeters());
            service.RegisterConversion(new CentimetersToNauticalMiles());
            service.RegisterConversion(new CentimetersToYards());
            service.RegisterConversion(new CentimetersToFeet());
            service.RegisterConversion(new CentimetersToMeters());
            service.RegisterConversion(new CentimetersToLeagues());

            // Register conversions for millimeters
            service.RegisterConversion(new MillimetersToMeters());
            service.RegisterConversion(new MillimetersToKilometers());
            service.RegisterConversion(new MillimetersToMiles());
            service.RegisterConversion(new MillimetersToCentimeters());
            service.RegisterConversion(new MillimetersToYards());
            service.RegisterConversion(new MillimetersToFeet());
            service.RegisterConversion(new MillimetersToNauticalMiles());
            service.RegisterConversion(new MillimetersToInches());
            service.RegisterConversion(new MillimetersToLeagues());

            // Register conversions for nautical miles
            service.RegisterConversion(new NauticalMilesToKilometers());
            service.RegisterConversion(new NauticalMilesToMeters());
            service.RegisterConversion(new NauticalMilesToCentimeters());
            service.RegisterConversion(new NauticalMilesToMillimeters());
            service.RegisterConversion(new NauticalMilesToYards());
            service.RegisterConversion(new NauticalMilesToFeet());
            service.RegisterConversion(new NauticalMilesToInches());
            service.RegisterConversion(new NauticalMilesToLeagues());

            // Register conversions for yards
            service.RegisterConversion(new YardsToMeters());
            service.RegisterConversion(new YardsToKilometers());
            service.RegisterConversion(new YardsToMiles());
            service.RegisterConversion(new YardsToCentimeters());
            service.RegisterConversion(new YardsToMillimeters());
            service.RegisterConversion(new YardsToNauticalMiles());
            service.RegisterConversion(new YardsToInches());
            service.RegisterConversion(new YardsToFeet());
            service.RegisterConversion(new YardsToLeagues());

            // Register conversions for feet
            service.RegisterConversion(new FeetToMeters());
            service.RegisterConversion(new FeetToKilometers());
            service.RegisterConversion(new FeetToMiles());
            service.RegisterConversion(new FeetToCentimeters());
            service.RegisterConversion(new FeetToMillimeters());
            service.RegisterConversion(new FeetToNauticalMiles());
            service.RegisterConversion(new FeetToYards());
            service.RegisterConversion(new FeetToInches());
            service.RegisterConversion(new FeetToLeagues());

            // Register conversions for inches
            service.RegisterConversion(new InchesToCentimeters());
            service.RegisterConversion(new InchesToMeters());
            service.RegisterConversion(new InchesToKilometers());
            service.RegisterConversion(new InchesToMiles());
            service.RegisterConversion(new InchesToMillimeters());
            service.RegisterConversion(new InchesToNauticalMiles());
            service.RegisterConversion(new InchesToYards());
            service.RegisterConversion(new InchesToFeet());
            service.RegisterConversion(new InchesToLeagues());

            // Register conversions for leagues
            service.RegisterConversion(new LeaguesToKilometers());
            service.RegisterConversion(new LeaguesToMeters());
            service.RegisterConversion(new LeaguesToCentimeters());
            service.RegisterConversion(new LeaguesToMillimeters());
            service.RegisterConversion(new LeaguesToNauticalMiles());
            service.RegisterConversion(new LeaguesToYards());
            service.RegisterConversion(new LeaguesToFeet());
            service.RegisterConversion(new LeaguesToInches());
            service.RegisterConversion(new LeaguesToMiles());
        }
    }
}
