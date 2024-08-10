using Converter_Web_Application.Service.Implementations.Unit;

namespace Converter_Web_Application.Service.Registrations.Unit
{
    public class WeightConversions_registrations
    {
        public static void Register(ConversionManagerService service)
        {
            // Grams
            service.RegisterConversion(new GramsToKilograms());
            service.RegisterConversion(new GramsToOunces());
            service.RegisterConversion(new GramsToPoundes());
            service.RegisterConversion(new GramsToStones());

            // Kilograms
            service.RegisterConversion(new KilogramsToGrams());
            service.RegisterConversion(new KilogramsToOunces());
            service.RegisterConversion(new KilogramsToPounds());
            service.RegisterConversion(new KilogramsToStones());

            // Ounces
            service.RegisterConversion(new OuncesToGrams());
            service.RegisterConversion(new OuncesToKilograms());
            service.RegisterConversion(new OuncesToPounds());
            service.RegisterConversion(new OuncesToStones());

            // Pounds
            service.RegisterConversion(new PoundsToGrams());
            service.RegisterConversion(new PoundsToKilograms());
            service.RegisterConversion(new PoundsToOunces());
            service.RegisterConversion(new PoundsToStones());

            // Stones
            service.RegisterConversion(new StonesToGrams());
            service.RegisterConversion(new StonesToKilograms());
            service.RegisterConversion(new StonesToOunces());
            service.RegisterConversion(new StonesToPoundes());
        }
    }
}
