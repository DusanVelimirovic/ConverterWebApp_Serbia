using Converter_Web_Application.Service.Base;

namespace Converter_Web_Application.Service.Implementations.Unit
{
    /// <summary>
    /// Conversions strategies
    /// </summary>

    // Cubic Centimeters
    public class CubicCentimetersToCubicInches : IConversion
    {
        public int Id => 1;

        public string FromUnit => "cubic centimeters";

        public string ToUnit => "cubic inches";

        public double Convert(double value)
        {
            return value / 16.3871;
        }
    }
    public class CubicCentimetersToCubicMeters : IConversion
    {
        public int Id => 2;

        public string FromUnit => "cubic centimeters";

        public string ToUnit => "cubic meters";

        public double Convert(double value)
        {
            return value * 0.000001;
        }
    }
    public class CubicCentimetersToLiters : IConversion
    {
        public int Id => 3;

        public string FromUnit => "cubic centimeters";

        public string ToUnit => "liters";

        public double Convert(double value)
        {
            return value / 1000;
        }
    }
    public class CubicCentimetersToMilliliters : IConversion
    {
        public int Id => 4;

        public string FromUnit => "cubic centimeters";

        public string ToUnit => "milliliters";

        public double Convert(double value)
        {
            return value;
        }
    }

    // Cubic Inches
    public class CubicInchesToCubicCentimeters : IConversion
    {
        public int Id => 5;

        public string FromUnit => "cubic inches";

        public string ToUnit => "cubic centimeters";

        public double Convert(double value)
        {
            return value * 16.3871;
        }
    }
    public class CubicInchesToCubicMeters : IConversion
    {
        public int Id => 6;

        public string FromUnit => "cubic inches";

        public string ToUnit => "cubic meters";

        public double Convert(double value)
        {
            return value / 1.6387E-5;
        }
    }
    public class CubicInchesToLiters : IConversion
    {
        public int Id => 7;

        public string FromUnit => "cubic inches";

        public string ToUnit => "liters";

        public double Convert(double value)
        {
            return value / 61.0237;
        }
    }
    public class CubicInchesToMilliliters : IConversion
    {
        public int Id => 8;

        public string FromUnit => "cubic inches";

        public string ToUnit => "milliliters";

        public double Convert(double value)
        {
            return value * 16.3871;
        }
    }

    // Cubic Meters
    public class CubicMetersToCubicCentimeters : IConversion
    {
        public int Id => 9;

        public string FromUnit => "cubic meters";

        public string ToUnit => "cubic centimeters";

        public double Convert(double value)
        {
            return value * 1_000_000;
        }
    }
    public class CubicMetersToCubicInches : IConversion
    {
        public int Id => 10;

        public string FromUnit => "cubic meters";

        public string ToUnit => "cubic inches";

        public double Convert(double value)
        {
            return value * 61023.7;
        }
    }
    public class CubicMetersToLiters : IConversion
    {
        public int Id => 11;

        public string FromUnit => "cubic meters";

        public string ToUnit => "liters";

        public double Convert(double value)
        {
            return value * 1000;
        }
    }
    public class CubicMetersToMilliliters : IConversion
    {
        public int Id => 12;

        public string FromUnit => "cubic meters";

        public string ToUnit => "milliliters";

        public double Convert(double value)
        {
            return value * 1_000_000;
        }
    }

    // Liters
    public class LitersToCubicCentimeters : IConversion
    {
        public int Id => 13;

        public string FromUnit => "liters";

        public string ToUnit => "cubic centimeters";

        public double Convert(double value)
        {
            return value * 1000;
        }
    }
    public class LitersToCubicInches : IConversion
    {
        public int Id => 14;

        public string FromUnit => "liters";

        public string ToUnit => "cubic inches";

        public double Convert(double value)
        {
            return value * 61.0237;
        }
    }
    public class LitersToCubicMeters : IConversion
    {
        public int Id => 15;

        public string FromUnit => "liters";

        public string ToUnit => "cubic meters";

        public double Convert(double value)
        {
            return value / 1000;
        }
    }
    public class LitersToMilliliters : IConversion
    {
        public int Id => 16;

        public string FromUnit => "liters";

        public string ToUnit => "milliliters";

        public double Convert(double value)
        {
            return value * 1000;
        }
    }

    // Milliliters
    public class MillilitersToCubicInches : IConversion
    {
        public int Id => 17;

        public string FromUnit => "milliliters";

        public string ToUnit => "cubic inches";

        public double Convert(double value)
        {
            return value / 16.3871;
        }
    }
    public class MillilitersToCubicMeters : IConversion
    {
        public int Id => 18;

        public string FromUnit => "milliliters";

        public string ToUnit => "cubic meters";

        public double Convert(double value)
        {
            return value / 1_000_000;
        }
    }
    public class MillilitersToLiters : IConversion
    {
        public int Id => 19;

        public string FromUnit => "milliliters";

        public string ToUnit => "liters";

        public double Convert(double value)
        {
            return value / 1000;
        }
    }
    public class MillilitersToCubicCentimeters : IConversion
    {
        public int Id => 20;

        public string FromUnit => "milliliters";

        public string ToUnit => "cubic centimeters";

        public double Convert(double value)
        {
            return value;
        }
    }







}

