using Converter_Web_Application.Service.Implementations;

namespace Converter_Web_Application.Service.Registrations.Cooking
{
    /// <summary>
    /// Handles the registration of sugar conversions in the ConversionManagerService.
    /// </summary>
    public class SugarConversions_registrations
    {
        /// <summary>
        /// Registers various sugar conversions with the provided ConversionManagerService.
        /// </summary>
        /// <param name="service">The ConversionManagerService where conversions will be registered.</param>
        public static void Register(ConversionManagerService service)
        {
            // Register conversions for cups of sugar to various units
            service.RegisterConversion(new CupOfSugarToGrams());
            service.RegisterConversion(new CupOfSugarToKilograms());
            service.RegisterConversion(new CupOfSugarToOunces());
            service.RegisterConversion(new CupOfSugarToPounds());

            // Register conversions for tablespoons of sugar to various units
            service.RegisterConversion(new TablespoonOfSugarToGrams());
            service.RegisterConversion(new TablespoonOfSugarToKilograms());
            service.RegisterConversion(new TablespoonOfSugarToOunces());
            service.RegisterConversion(new TablespoonOfSugarToPounds());

            // Register conversions for teaspoons of sugar to various units
            service.RegisterConversion(new TeaspoonOfSugarToGrams());
            service.RegisterConversion(new TeaspoonOfSugarToKilograms());
            service.RegisterConversion(new TeaspoonOfSugarToOunces());
            service.RegisterConversion(new TeaspoonOfSugarToPounds());

            // Register conversions from various units to cups of sugar
            service.RegisterConversion(new GramsToCupsOfSugar());
            service.RegisterConversion(new KilogramsToCupsOfSugar());
            service.RegisterConversion(new OuncesToCupsOfSugar());
            service.RegisterConversion(new PoundsToCupsOfSugar());

            // Register conversions from various units to tablespoons of sugar
            service.RegisterConversion(new GramsToTablespoonsOfSugar());
            service.RegisterConversion(new KilogramsToTablespoonsOfSugar());
            service.RegisterConversion(new OuncesToTablespoonsOfSugar());
            service.RegisterConversion(new PoundsToTablespoonsOfSugar());

            // Register conversions from various units to teaspoons of sugar
            service.RegisterConversion(new GramsToTeaspoonsOfSugar());
            service.RegisterConversion(new KilogramsToTeaspoonsOfSugar());
            service.RegisterConversion(new OuncesToTeaspoonsOfSugar());
            service.RegisterConversion(new PoundsToTeaspoonsOfSugar());
        }
    }
}
