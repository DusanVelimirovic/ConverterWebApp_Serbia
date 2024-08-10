using Converter_Web_Application.Service.Implementations.Unit;

namespace Converter_Web_Application.Service.Registrations.Unit
{
    /// <summary>
    /// Registers various area conversions with the ConversionManagerService.
    /// </summary>
    public class AreaConversions_registrations
    {
        /// <summary>
        /// Registers all area conversions in the provided ConversionManagerService.
        /// </summary>
        /// <param name="service">The ConversionManagerService where conversions will be registered.</param>
        public static void Register(ConversionManagerService service)
        {
            // Register conversions for square meters
            service.RegisterConversion(new SquaremetersToSquareFeet());
            service.RegisterConversion(new SquaremetersToSquareYards());
            service.RegisterConversion(new SquaremetersToSquareMiles());
            service.RegisterConversion(new SquaremetersToSquareKilometers());
            service.RegisterConversion(new SquaremetersToAcres());
            service.RegisterConversion(new SquaremetersToHectares());
            service.RegisterConversion(new SquaremetersToSquereCentimeters());
            service.RegisterConversion(new SquaremetersToSquereInches());
            service.RegisterConversion(new SquaremetersToSquereMillimeters());

            // Register conversions for square feet
            service.RegisterConversion(new SquareFeetToSquereMeters());
            service.RegisterConversion(new SquareFeetToSquereYards());
            service.RegisterConversion(new SquareFeetToSquereMiles());
            service.RegisterConversion(new SquareFeetToSquereKilometers());
            service.RegisterConversion(new SquareFeetToAcres());
            service.RegisterConversion(new SquareFeetToHectares());
            service.RegisterConversion(new SquareFeetToSquareCentimeters());
            service.RegisterConversion(new SquareFeetToSquareInches());
            service.RegisterConversion(new SquareFeetToSquareMillimeters());

            // Register conversions for square yards
            service.RegisterConversion(new SquareYardsToSquareMeters());
            service.RegisterConversion(new SquareYardsToSquareFeet());
            service.RegisterConversion(new SquareYardsToSquareMiles());
            service.RegisterConversion(new SquareYardsToSquareKilometers());
            service.RegisterConversion(new SquareYardsToAcres());
            service.RegisterConversion(new SquareYardsToHectares());
            service.RegisterConversion(new SquareYardsToSquareCentimeters());
            service.RegisterConversion(new SquareYardsToSquareInches());
            service.RegisterConversion(new SquareYardsToSquareMillimeters());

            // Register conversions for square miles
            service.RegisterConversion(new SquareMilesToSquereMeters());
            service.RegisterConversion(new SquareMilesToSquereFeet());
            service.RegisterConversion(new SquareMilesToSquereYards());
            service.RegisterConversion(new SquareMilesToSquereKilometers());
            service.RegisterConversion(new SquareMilesToAcres());
            service.RegisterConversion(new SquareMilesToHectares());
            service.RegisterConversion(new SquareMilesToSquareCentimeters());
            service.RegisterConversion(new SquareMilesToSquareInches());
            service.RegisterConversion(new SquareMilesToSquareMillimeters());

            // Register conversions for square kilometers
            service.RegisterConversion(new SquareKilometersToSquereMeters());
            service.RegisterConversion(new SquareKilometersToSquereFeet());
            service.RegisterConversion(new SquareKilometersToSquereYards());
            service.RegisterConversion(new SquareKilometersToSquereMiles());
            service.RegisterConversion(new SquareKilometersToAcres());
            service.RegisterConversion(new SquareKilometersToHectares());
            service.RegisterConversion(new SquareKilometersToCentimeters());
            service.RegisterConversion(new SquareKilometersToInches());
            service.RegisterConversion(new SquareKilometersToMillimeters());

            // Register conversions for acres
            service.RegisterConversion(new AcresToMeters());
            service.RegisterConversion(new AcresToSquereFeet());
            service.RegisterConversion(new AcresToSquereYards());
            service.RegisterConversion(new AcresToSquereMiles());
            service.RegisterConversion(new AcresToSquereKilometers());
            service.RegisterConversion(new AcresToHectares());
            service.RegisterConversion(new AcresToSquareCentimeters());
            service.RegisterConversion(new AcresToSquareInches());
            service.RegisterConversion(new AcresToSquareMillimeters());

            // Register conversions for hectares
            service.RegisterConversion(new HectaresToSquereMeters());
            service.RegisterConversion(new HectaresToSquereFeet());
            service.RegisterConversion(new HectaresToSquereYards());
            service.RegisterConversion(new HectaresToSquereMiles());
            service.RegisterConversion(new HectaresToSquereKilometers());
            service.RegisterConversion(new HectaresToAcres());
            service.RegisterConversion(new HectaresToSquareCentimeters());
            service.RegisterConversion(new HectaresToSquareInches());
            service.RegisterConversion(new HectaresToSquareMillimeters());

            // Register conversions for square centimeters
            service.RegisterConversion(new SquereCentimetersToSquereInches());
            service.RegisterConversion(new SquereCentimetersToSquereMillimeters());
            service.RegisterConversion(new SquereCentimetersToSquareMeters());
            service.RegisterConversion(new SquereCentimetersToSquareFeet());
            service.RegisterConversion(new SquereCentimetersToSquareYards());
            service.RegisterConversion(new SquereCentimetersToSquareMiles());
            service.RegisterConversion(new SquereCentimetersToSquareKilometers());
            service.RegisterConversion(new SquereCentimetersToAcres());

            // Register conversions for square inches
            service.RegisterConversion(new SquereInchesToSquereCentimeters());
            service.RegisterConversion(new SquereInchesToSquereMillimeters());
            service.RegisterConversion(new SquereInchesToSquereMeters());
            service.RegisterConversion(new SquereInchesToSquereFeet());
            service.RegisterConversion(new SquereInchesToSquereYards());
            service.RegisterConversion(new SquereInchesToSquereMiles());
            service.RegisterConversion(new SquereInchesToSquereKilometers());
            service.RegisterConversion(new SquereInchesToAcres());
            service.RegisterConversion(new SquereInchesToHectares());

            // Register conversions for square millimeters
            service.RegisterConversion(new SquereMillimetersToSquereInches());
            service.RegisterConversion(new SquereMillimetersToSquereCentimeters());
            service.RegisterConversion(new SquereMillimetersToSquereMeters());
            service.RegisterConversion(new SquereMillimetersToSquereFeet());
            service.RegisterConversion(new SquereMillimetersToSquereYards());
            service.RegisterConversion(new SquereMillimetersToSquereMiles());
            service.RegisterConversion(new SquereMillimetersToSquereKilometers());
            service.RegisterConversion(new SquereMillimetersToAcres());
            service.RegisterConversion(new SquereMillimetersToHectares());
        }
    }
}
