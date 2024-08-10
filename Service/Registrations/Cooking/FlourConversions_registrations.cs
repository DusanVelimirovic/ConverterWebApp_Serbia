using Converter_Web_Application.Service.Implementations;

namespace Converter_Web_Application.Service.Registrations.Cooking
{
    /// <summary>
    /// Handles the registration of flour conversions in the ConversionManagerService.
    /// </summary>
    public class FlourConversions_registrations
    {
        /// <summary>
        /// Registers various flour conversions with the provided ConversionManagerService.
        /// </summary>
        /// <param name="service">The ConversionManagerService where conversions will be registered.</param>
        public static void Register(ConversionManagerService service)
        {
            // Register conversions for cups of flour to various units
            service.RegisterConversion(new CupOfFlourToGrams());
            service.RegisterConversion(new CupOfFlourToKilograms());
            service.RegisterConversion(new CupOfFlourToOunces());
            service.RegisterConversion(new CupOfFlourToPounds());

            // Register conversions for tablespoons of flour to various units
            service.RegisterConversion(new TablespoonOfFlourToGrams());
            service.RegisterConversion(new TablespoonOfFlourToKilograms());
            service.RegisterConversion(new TablespoonOfFlourToOunces());
            service.RegisterConversion(new TablespoonOfFlourToPounds());

            // Register conversions for teaspoons of flour to various units
            service.RegisterConversion(new TeaspoonOfFlourToGrams());
            service.RegisterConversion(new TeaspoonOfFlourToKilograms());
            service.RegisterConversion(new TeaspoonOfFlourToOunces());
            service.RegisterConversion(new TeaspoonOfFlourToPounds());

            // Register conversions from various units to cups of flour
            service.RegisterConversion(new GramsToCupsOfFlour());
            service.RegisterConversion(new KilogramsToCupsOfFlour());
            service.RegisterConversion(new OuncesToCupsOfFlour());
            service.RegisterConversion(new PoundsToCupsOfFlour());

            // Register conversions from various units to tablespoons of flour
            service.RegisterConversion(new GramsToTablespoonsOfFlour());
            service.RegisterConversion(new KilogramsToTablespoonsOfFlour());
            service.RegisterConversion(new OuncesToTablespoonsOfFlour());
            service.RegisterConversion(new PoundsToTablespoonsOfFlour());

            // Register conversions from various units to teaspoons of flour
            service.RegisterConversion(new GramsToTeaspoonsOfFlour());
            service.RegisterConversion(new KilogramsToTeaspoonsOfFlour());
            service.RegisterConversion(new OuncesToTeaspoonsOfFlour());
            service.RegisterConversion(new PoundsToTeaspoonsOfFlour());
        }
    }
}
