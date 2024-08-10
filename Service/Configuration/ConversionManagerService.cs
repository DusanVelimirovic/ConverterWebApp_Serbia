/// <summary>
/// Service for managing different unit conversions.
/// </summary>
using Converter_Web_Application.Service.Commands.Fuel;
using Converter_Web_Application.Service.Base;

/// <summary>
/// Registers and manages different unit conversions.
/// </summary>
public class ConversionManagerService
{
    // Initialized empty conversions list
    private readonly List<IBaseConversion> _conversions = new List<IBaseConversion>();

    // Initialized empty dictionary for fuel conversions (command pattern)
    private readonly Dictionary<string, IFuelCommand> _fuelCommands = new Dictionary<string, IFuelCommand>();

    /// <summary>
    /// Registers a new conversion.
    /// </summary>
    /// <param name="conversion">The conversion to register.</param>
    public void RegisterConversion(IBaseConversion conversion)
    {
        _conversions.Add(conversion);
    }

    /// <summary>
    /// Registers a new fuel command.
    /// </summary>
    /// <param name="name">The name of the fuel command.</param>
    /// <param name="command">The fuel command to register.</param>
    public void RegisterFuelCommand(string name, IFuelCommand command)
    {
        _fuelCommands[name] = command;
    }

    /// <summary>
    /// Gets all registered conversions.
    /// </summary>
    /// <returns>An IEnumerable of all registered conversions.</returns>
    public IEnumerable<IBaseConversion> GetAllConversions()
    {
        return _conversions;
    }

    /// <summary>
    /// Converts a value from one unit to another.
    /// </summary>
    /// <param name="fromUnit">The unit to convert from.</param>
    /// <param name="toUnit">The unit to convert to.</param>
    /// <param name="value">The value to convert.</param>
    /// <returns>The converted value.</returns>
    /// <exception cref="InvalidOperationException">Thrown when the specified conversion is not found.</exception>
    public double Convert(string fromUnit, string toUnit, double value)
    {
        var conversion = _conversions.OfType<IConversion>()
            .FirstOrDefault(c => c.FromUnit.Equals(fromUnit, StringComparison.OrdinalIgnoreCase) &&
                                 c.ToUnit.Equals(toUnit, StringComparison.OrdinalIgnoreCase));

        if (conversion != null)
        {
            return conversion.Convert(value);
        }

        throw new InvalidOperationException($"Conversion from {fromUnit} to {toUnit} not found.");
    }

    /// <summary>
    /// Executes a fuel command with the provided values.
    /// </summary>
    /// <param name="commandName">The name of the fuel command.</param>
    /// <param name="value1">The first value required for the command.</param>
    /// <param name="value2">The second value required for the command (optional).</param>
    /// <param name="value3">The third value required for the command (optional).</param>
    /// <returns>The result of the fuel command.</returns>
    /// <exception cref="InvalidOperationException">Thrown when the specified fuel command is not found.</exception>
    public double ExecuteFuelCommand(string commandName, double value1, double value2 = 0, double value3 = 0)
    {
        if (_fuelCommands.TryGetValue(commandName, out var command))
        {
            return command.Execute(value1, value2, value3);
        }

        throw new InvalidOperationException($"Fuel command {commandName} not found.");
    }
}
