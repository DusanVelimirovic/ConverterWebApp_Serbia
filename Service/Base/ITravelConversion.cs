namespace Converter_Web_Application.Service.Base
{
    /// <summary>
    /// Defines a contract for travel-related conversions.
    /// Inherits from <see cref="IBaseConversion"/>.
    /// </summary>
    public interface ITravelConversion : IBaseConversion
    {
        /// <summary>
        /// Converts a value based on two input parameters.
        /// </summary>
        /// <param name="value1">The first input value for the conversion.</param>
        /// <param name="value2">The second input value for the conversion.</param>
        /// <returns>The result of the conversion as a double.</returns>
        double Convert(double value1, double value2);
    }
}
