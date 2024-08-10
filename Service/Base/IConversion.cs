namespace Converter_Web_Application.Service.Base
{
    /// <summary>
    /// Defines methods for performing unit conversions.
    /// </summary>
    public interface IConversion : IBaseConversion
    {
        /// <summary>
        /// Converts a value from one unit to another.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value.</returns>
        double Convert(double value);
    }
}
