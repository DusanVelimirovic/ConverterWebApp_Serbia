namespace Converter_Web_Application.Service.Commands.Fuel
{
    /// <summary>
    /// Represents a command for fuel-related calculations.
    /// </summary>
    public interface IFuelCommand
    {
        /// <summary>
        /// Executes the fuel command with the provided values.
        /// </summary>
        /// <param name="value1">The first value required for the calculation.</param>
        /// <param name="value2">The second value required for the calculation (optional).</param>
        /// <param name="value3">The third value required for the calculation (optional).</param>
        /// <returns>The result of the fuel calculation.</returns>
        double Execute(double value1, double value2 = 0, double value3 = 0);
    }
}
