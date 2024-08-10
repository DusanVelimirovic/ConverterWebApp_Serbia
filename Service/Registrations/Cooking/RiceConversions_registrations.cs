using Converter_Web_Application.Service.Implementations;

namespace Converter_Web_Application.Service.Registrations.Cooking
{
    /// <summary>
    /// Handles the registration of rice conversions in the ConversionManagerService.
    /// </summary>
    public class RiceConversions_registrations
    {
        /// <summary>
        /// Registers various rice conversions with the provided ConversionManagerService.
        /// </summary>
        /// <param name="service">The ConversionManagerService where conversions will be registered.</param>
        public static void Register(ConversionManagerService service)
        {
            // Register conversions for cups of rice to various units
            service.RegisterConversion(new CupOfRiceToGrams());
            service.RegisterConversion(new CupOfRiceToKilograms());
            service.RegisterConversion(new CupOfRiceToOunces());
            service.RegisterConversion(new CupOfRiceToPounds());

            // Register conversions for tablespoons of rice to various units
            service.RegisterConversion(new TablespoonOfRiceToGrams());
            service.RegisterConversion(new TablespoonOfRiceToKilograms());
            service.RegisterConversion(new TablespoonOfRiceToOunces());
            service.RegisterConversion(new TablespoonOfRiceToPounds());

            // Register conversions for teaspoons of rice to various units
            service.RegisterConversion(new TeaspoonOfRiceToGrams());
            service.RegisterConversion(new TeaspoonOfRiceToKilograms());
            service.RegisterConversion(new TeaspoonOfRiceToOunces());
            service.RegisterConversion(new TeaspoonOfRiceToPounds());

            // Register conversions from various units to cups of rice
            service.RegisterConversion(new GramsToCupsOfRice());
            service.RegisterConversion(new KilogramsToCupsOfRice());
            service.RegisterConversion(new OuncesToCupsOfRice());
            service.RegisterConversion(new PoundsToCupsOfRice());

            // Register conversions from various units to tablespoons of rice
            service.RegisterConversion(new GramsToTablespoonsOfRice());
            service.RegisterConversion(new KilogramsToTablespoonsOfRice());
            service.RegisterConversion(new OuncesToTablespoonsOfRice());
            service.RegisterConversion(new PoundsToTablespoonsOfRice());

            // Register conversions from various units to teaspoons of rice
            service.RegisterConversion(new GramsToTeaspoonsOfRice());
            service.RegisterConversion(new KilogramsToTeaspoonsOfRice());
            service.RegisterConversion(new OuncesToTeaspoonsOfRice());
            service.RegisterConversion(new PoundsToTeaspoonsOfRice());
        }
    }
}
