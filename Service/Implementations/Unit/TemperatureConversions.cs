using Converter_Web_Application.Service.Base;

namespace Converter_Web_Application.Service.Implementations.Unit
{
    /// <summary>
    /// Conversions strategies
    /// </summary>

    // Celsius
    public class CelsiusToFahrenheit : IConversion
    {
        public int Id => 1;

        public string FromUnit => "celsius";

        public string ToUnit => "fahrenheit";

        public double Convert(double value)
        {
            return value * 9 / 5 + 32;
        }
    }
    public class CelsiusToKelvin : IConversion
    {
        public int Id => 2;

        public string FromUnit => "celsius";

        public string ToUnit => "kelvin";

        public double Convert(double value)
        {
            return value + 273.15;
        }
    }

    // Fahrenheit
    public class FahrenheitToCelsius : IConversion
    {
        public int Id => 3;

        public string FromUnit => "fahrenheit";

        public string ToUnit => "celsius";

        public double Convert(double value)
        {
            return (value - 32) * 5 / 9;
        }
    }
    public class FahrenheitToKelvin : IConversion
    {
        public int Id => 4;

        public string FromUnit => "fahrenheit";

        public string ToUnit => "kelvin";

        public double Convert(double value)
        {
            return (value - 32) * 5 / 9 + 273.15;
        }
    }

    // Kelvin
    public class KelvinToCelsius : IConversion
    {
        public int Id => 5;

        public string FromUnit => "kelvin";

        public string ToUnit => "celsius";

        public double Convert(double value)
        {
            return value - 273.15;
        }
    }
    public class KelvinToFahrenheit : IConversion
    {
        public int Id => 6;

        public string FromUnit => "kelvin";

        public string ToUnit => "fahrenheit";

        public double Convert(double value)
        {
            return (value - 273.15) * 9 / 5 + 32;
        }
    }

}

