using Converter_Web_Application.Service.Commands.Fuel;
using Converter_Web_Application.Service.Implementations;

namespace Converter_Web_Application.Service.Registrations.Fuel
{
    /// <summary>
    /// Handles the registration of fuel conversions and commands in the ConversionManagerService.
    /// </summary>
    public static class FuelConversionsRegistration
    {
        /// <summary>
        /// Registers various fuel conversions and commands with the provided ConversionManagerService.
        /// </summary>
        /// <param name="service">The ConversionManagerService where conversions and commands will be registered.</param>
        public static void Register(ConversionManagerService service)
        {
            // Register fuel consumption conversions
            service.RegisterConversion(new MilesPerGallonToLitersPer100Km());
            service.RegisterConversion(new LitersPer100KmToMilesPerGallon());
            service.RegisterConversion(new MpgToLiters());
            service.RegisterConversion(new LitersToMpg());

            // Register additional fuel-related conversions
            service.RegisterConversion(new AverageFuelConsumption());
            service.RegisterConversion(new RequiredFuelForMileage());
            service.RegisterConversion(new PossibleMileageWithFuel());
            service.RegisterConversion(new TravelDistanceWithBudget());
            service.RegisterConversion(new MphToKmh());
            service.RegisterConversion(new KmhToMph());

            // Register fuel commands
            service.RegisterFuelCommand("AverageFuelConsumption", new CalculateAverageFuelConsumptionCommand());
            service.RegisterFuelCommand("RequiredFuelForMileage", new CalculateRequiredFuelForMileageCommand());
            service.RegisterFuelCommand("PossibleMileageWithFuel", new CalculatePossibleMileageWithFuelCommand());
            service.RegisterFuelCommand("TravelDistanceWithBudget", new CalculateTravelDistanceWithBudgetCommand());
        }
    }
}
