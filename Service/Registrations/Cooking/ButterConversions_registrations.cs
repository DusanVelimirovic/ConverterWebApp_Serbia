using Converter_Web_Application.Service.Implementations;

namespace Converter_Web_Application.Service.Registrations.Cooking
{
    /// <summary>
    /// Handles the registration of butter conversions in the ConversionManagerService.
    /// </summary>
    public class ButterConversions_registrations
    {
        /// <summary>
        /// Registers various butter conversions with the provided ConversionManagerService.
        /// </summary>
        /// <param name="service">The ConversionManagerService where conversions will be registered.</param>
        public static void Register(ConversionManagerService service)
        {
            // Register conversions for cups of butter to various units
            service.RegisterConversion(new CupOfButterToGrams());
            service.RegisterConversion(new CupOfButterToKilograms());
            service.RegisterConversion(new CupOfButterToOunces());
            service.RegisterConversion(new CupOfButterToPounds());

            // Register conversions for tablespoons of butter to various units
            service.RegisterConversion(new TablespoonOfButterToGrams());
            service.RegisterConversion(new TablespoonOfButterToKilograms());
            service.RegisterConversion(new TablespoonOfButterToOunces());
            service.RegisterConversion(new TablespoonOfButterToPounds());

            // Register conversions for teaspoons of butter to various units
            service.RegisterConversion(new TeaspoonOfButterToGrams());
            service.RegisterConversion(new TeaspoonOfButterToKilograms());
            service.RegisterConversion(new TeaspoonOfButterToOunces());
            service.RegisterConversion(new TeaspoonOfButterToPounds());

            // Register conversions from various units to cups of butter
            service.RegisterConversion(new GramsToCupsOfButter());
            service.RegisterConversion(new KilogramsToCupsOfButter());
            service.RegisterConversion(new OuncesToCupsOfButter());
            service.RegisterConversion(new PoundsToCupsOfButter());

            // Register conversions from various units to tablespoons of butter
            service.RegisterConversion(new GramsToTablespoonsOfButter());
            service.RegisterConversion(new KilogramsToTablespoonsOfButter());
            service.RegisterConversion(new OuncesToTablespoonsOfButter());
            service.RegisterConversion(new PoundsToTablespoonsOfButter());

            // Register conversions from various units to teaspoons of butter
            service.RegisterConversion(new GramsToTeaspoonsOfButter());
            service.RegisterConversion(new KilogramsToTeaspoonsOfButter());
            service.RegisterConversion(new OuncesToTeaspoonsOfButter());
            service.RegisterConversion(new PoundsToTeaspoonsOfButter());
        }
    }
}
