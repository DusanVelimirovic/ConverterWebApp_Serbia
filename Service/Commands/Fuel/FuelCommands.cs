namespace Converter_Web_Application.Service.Commands.Fuel
{
    /// <summary>
    /// Command to calculate average fuel consumption per 100 kilometers.
    /// </summary>
    public class CalculateAverageFuelConsumptionCommand : IFuelCommand
    {
        /// <summary>
        /// Executes the calculation of average fuel consumption.
        /// </summary>
        /// <param name="distance">The distance traveled in kilometers.</param>
        /// <param name="fuel">The amount of fuel consumed in liters.</param>
        /// <param name="value3">Optional parameter, not used in this calculation.</param>
        /// <returns>The average fuel consumption per 100 kilometers.</returns>
        public double Execute(double distance, double fuel, double value3 = 0)
        {
            return (fuel / distance) * 100;
        }
    }

    /// <summary>
    /// Command to calculate the required fuel for a given mileage.
    /// </summary>
    public class CalculateRequiredFuelForMileageCommand : IFuelCommand
    {
        /// <summary>
        /// Executes the calculation of required fuel for a given distance.
        /// </summary>
        /// <param name="distance">The distance to be traveled in kilometers.</param>
        /// <param name="averageConsumption">The average fuel consumption per 100 kilometers.</param>
        /// <param name="value3">Optional parameter, not used in this calculation.</param>
        /// <returns>The required fuel in liters for the given distance.</returns>
        public double Execute(double distance, double averageConsumption, double value3 = 0)
        {
            return (averageConsumption / 100) * distance;
        }
    }

    /// <summary>
    /// Command to calculate the possible mileage with the available fuel.
    /// </summary>
    public class CalculatePossibleMileageWithFuelCommand : IFuelCommand
    {
        /// <summary>
        /// Executes the calculation of possible mileage with the available fuel.
        /// </summary>
        /// <param name="fuel">The amount of available fuel in liters.</param>
        /// <param name="averageConsumption">The average fuel consumption per 100 kilometers.</param>
        /// <param name="value3">Optional parameter, not used in this calculation.</param>
        /// <returns>The possible mileage in kilometers that can be covered with the available fuel.</returns>
        public double Execute(double fuel, double averageConsumption, double value3 = 0)
        {
            return (fuel * 100) / averageConsumption;
        }
    }

    /// <summary>
    /// Command to calculate the travel distance possible within a given budget.
    /// </summary>
    public class CalculateTravelDistanceWithBudgetCommand : IFuelCommand
    {
        /// <summary>
        /// Executes the calculation of travel distance possible within a given budget.
        /// </summary>
        /// <param name="budget">The available budget in monetary units.</param>
        /// <param name="fuelEfficiency">The fuel efficiency of the vehicle in kilometers per liter.</param>
        /// <param name="fuelPrice">The price of fuel per liter.</param>
        /// <returns>The possible travel distance in kilometers within the given budget.</returns>
        public double Execute(double budget, double fuelEfficiency, double fuelPrice)
        {
            return (budget / fuelPrice) * fuelEfficiency;
        }
    }
}
