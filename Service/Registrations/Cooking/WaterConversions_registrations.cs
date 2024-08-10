using Converter_Web_Application.Service.Implementations;

namespace Converter_Web_Application.Service.Registrations.Cooking
{
    /// <summary>
    /// Handles the registration of water conversions in the ConversionManagerService.
    /// </summary>
    public class WaterConversions_registrations
    {
        /// <summary>
        /// Registers various water conversions with the provided ConversionManagerService.
        /// </summary>
        /// <param name="service">The ConversionManagerService where conversions will be registered.</param>
        public static void Register(ConversionManagerService service)
        {
            // Register conversions for cups of water to various units
            service.RegisterConversion(new CupOfWaterToGrams());
            service.RegisterConversion(new CupOfWaterToKilograms());
            service.RegisterConversion(new CupOfWaterToOunces());
            service.RegisterConversion(new CupOfWaterToPounds());

            // Register conversions for tablespoons of water to various units
            service.RegisterConversion(new TablespoonOfWaterToGrams());
            service.RegisterConversion(new TablespoonOfWaterToKilograms());
            service.RegisterConversion(new TablespoonOfWaterToOunces());
            service.RegisterConversion(new TablespoonOfWaterToPounds());

            // Register conversions for teaspoons of water to various units
            service.RegisterConversion(new TeaspoonOfWaterToGrams());
            service.RegisterConversion(new TeaspoonOfWaterToKilograms());
            service.RegisterConversion(new TeaspoonOfWaterToOunces());
            service.RegisterConversion(new TeaspoonOfWaterToPounds());

            // Register conversions from various units to cups of water
            service.RegisterConversion(new GramsToCupsOfWater());
            service.RegisterConversion(new KilogramsToCupsOfWater());
            service.RegisterConversion(new OuncesToCupsOfWater());
            service.RegisterConversion(new PoundsToCupsOfWater());

            // Register conversions from various units to tablespoons of water
            service.RegisterConversion(new GramsToTablespoonsOfWater());
            service.RegisterConversion(new KilogramsToTablespoonsOfWater());
            service.RegisterConversion(new OuncesToTablespoonsOfWater());
            service.RegisterConversion(new PoundsToTablespoonsOfWater());

            // Register conversions from various units to teaspoons of water
            service.RegisterConversion(new GramsToTeaspoonsOfWater());
            service.RegisterConversion(new KilogramsToTeaspoonsOfWater());
            service.RegisterConversion(new OuncesToTeaspoonsOfWater());
            service.RegisterConversion(new PoundsToTeaspoonsOfWater());
        }
    }
}
