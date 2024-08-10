namespace Converter_Web_Application.Service.Commands.Travel
{
    /// <summary>
    /// Interface for travel-related commands that perform calculations based on two input values.
    /// </summary>
    public interface ITravelCommand
    {
        /// <summary>
        /// Executes the command with two input values and returns the result.
        /// </summary>
        /// <param name="value1">The first input value, typically representing a distance or a related metric.</param>
        /// <param name="value2">The second input value, typically representing a speed, time, or another related metric.</param>
        /// <returns>The result of the calculation as a double.</returns>
        double Execute(double value1, double value2);
    }
}
