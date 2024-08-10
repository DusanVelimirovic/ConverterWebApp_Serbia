namespace Converter_Web_Application.Service.Base
{
    /// <summary>
    /// Defines the base properties for a unit conversion.
    /// </summary>
    public interface IBaseConversion
    {
        /// <summary>
        /// Gets the unique identifier for the conversion.
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Gets the unit from which the conversion starts.
        /// </summary>
        string FromUnit { get; }

        /// <summary>
        /// Gets the unit to which the conversion is made.
        /// </summary>
        string ToUnit { get; }
    }
}
