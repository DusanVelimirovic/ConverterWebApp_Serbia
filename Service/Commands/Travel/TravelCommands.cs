namespace Converter_Web_Application.Service.Commands.Travel
{
    /// <summary>
    /// Command to calculate travel time based on distance and speed.
    /// </summary>
    public class CalculateTravelTimeCommand : ITravelCommand
    {
        /// <summary>
        /// Executes the calculation of travel time.
        /// </summary>
        /// <param name="distance">The distance to be traveled in kilometers or miles.</param>
        /// <param name="speed">The speed of travel in kilometers per hour or miles per hour.</param>
        /// <returns>The travel time in hours.</returns>
        public double Execute(double distance, double speed)
        {
            return distance / speed;
        }
    }

    /// <summary>
    /// Command to calculate travel speed based on distance and time.
    /// </summary>
    public class CalculateTravelSpeedCommand : ITravelCommand
    {
        /// <summary>
        /// Executes the calculation of travel speed.
        /// </summary>
        /// <param name="distance">The distance traveled in kilometers or miles.</param>
        /// <param name="time">The time taken to travel the distance in hours.</param>
        /// <returns>The travel speed in kilometers per hour or miles per hour.</returns>
        public double Execute(double distance, double time)
        {
            return distance / time;
        }
    }
}
