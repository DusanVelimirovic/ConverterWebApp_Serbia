using Converter_Web_Application.Service.Implementations;

namespace Converter_Web_Application.Service.Registrations.Cooking
{
    /// <summary>
    /// Handles the registration of milk conversions in the ConversionManagerService.
    /// </summary>
    public class MilkConversions_registrations
    {
        /// <summary>
        /// Registers various milk conversions with the provided ConversionManagerService.
        /// </summary>
        /// <param name="service">The ConversionManagerService where conversions will be registered.</param>
        public static void Register(ConversionManagerService service)
        {
            // Register conversions for cups of milk to various units
            service.RegisterConversion(new CupOfMilkToGrams());
            service.RegisterConversion(new CupOfMilkToKilograms());
            service.RegisterConversion(new CupOfMilkToOunces());
            service.RegisterConversion(new CupOfMilkToPounds());

            // Register conversions for tablespoons of milk to various units
            service.RegisterConversion(new TablespoonOfMilkToGrams());
            service.RegisterConversion(new TablespoonOfMilkToKilograms());
            service.RegisterConversion(new TablespoonOfMilkToOunces());
            service.RegisterConversion(new TablespoonOfMilkToPounds());

            // Register conversions for teaspoons of milk to various units
            service.RegisterConversion(new TeaspoonOfMilkToGrams());
            service.RegisterConversion(new TeaspoonOfMilkToKilograms());
            service.RegisterConversion(new TeaspoonOfMilkToOunces());
            service.RegisterConversion(new TeaspoonOfMilkToPounds());

            // Register conversions from various units to cups of milk
            service.RegisterConversion(new GramsToCupsOfMilk());
            service.RegisterConversion(new KilogramsToCupsOfMilk());
            service.RegisterConversion(new OuncesToCupsOfMilk());
            service.RegisterConversion(new PoundsToCupsOfMilk());

            // Register conversions from various units to tablespoons of milk
            service.RegisterConversion(new GramsToTablespoonsOfMilk());
            service.RegisterConversion(new KilogramsToTablespoonsOfMilk());
            service.RegisterConversion(new OuncesToTablespoonsOfMilk());
            service.RegisterConversion(new PoundsToTablespoonsOfMilk());

            // Register conversions from various units to teaspoons of milk
            service.RegisterConversion(new GramsToTeaspoonsOfMilk());
            service.RegisterConversion(new KilogramsToTeaspoonsOfMilk());
            service.RegisterConversion(new OuncesToTeaspoonsOfMilk());
            service.RegisterConversion(new PoundsToTeaspoonsOfMilk());
        }
    }
}
