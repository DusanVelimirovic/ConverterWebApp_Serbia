namespace Converter_Web_Application.Service.Base
{
    /// <summary>
    /// Defines methods for performing fuel conversions.
    /// Inherits from <see cref="IBaseConversion"/>.
    /// </summary>
    public interface IFuelConversion : IBaseConversion
    {
        /// <summary>
        /// Converts fuel-related values based on the provided input parameters.
        /// </summary>
        /// <param name="value1">The primary value to be converted.</param>
        /// <param name="value2">An optional second value for conversion calculations. Defaults to 0.</param>
        /// <param name="value3">An optional third value for conversion calculations. Defaults to 0.</param>
        /// <returns>The result of the conversion as a double.</returns>
        double Convert(double value1, double value2 = 0, double value3 = 0);
    }
}
