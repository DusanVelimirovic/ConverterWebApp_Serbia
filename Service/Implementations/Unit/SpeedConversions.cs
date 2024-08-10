using Converter_Web_Application.Service.Base;

namespace Converter_Web_Application.Service.Implementations.Unit
{
    /// <summary>
    /// Conversions strategies
    /// </summary>

    // Meters per Second
    public class MetersPerSecondToKilometersPerHour : IConversion
    {
        public int Id => 1;
        public string FromUnit => "meters per second";
        public string ToUnit => "kilometers per hour";
        public double Convert(double value) => value * 3.6;
    }
    public class MetersPerSecondToMilesPerHour : IConversion
    {
        public int Id => 2;
        public string FromUnit => "meters per second";
        public string ToUnit => "miles per hour";
        public double Convert(double value) => value * 2.23694;
    }
    public class MetersPerSecondToFeetPerSecond : IConversion
    {
        public int Id => 3;
        public string FromUnit => "meters per second";
        public string ToUnit => "feet per second";
        public double Convert(double value) => value * 3.28084;
    }
    public class MetersPerSecondToKnots : IConversion
    {
        public int Id => 4;
        public string FromUnit => "meters per second";
        public string ToUnit => "knots";
        public double Convert(double value) => value * 1.94384;
    }

    // Kilometers Per Hour
    public class KilometersPerHourToMetersPerSecond : IConversion
    {
        public int Id => 5;
        public string FromUnit => "kilometers per hour";
        public string ToUnit => "meters per second";
        public double Convert(double value) => value / 3.6;
    }
    public class KilometersPerHourToMilesPerHour : IConversion
    {
        public int Id => 6;
        public string FromUnit => "kilometers per hour";
        public string ToUnit => "miles per hour";
        public double Convert(double value) => value / 1.60934;
    }
    public class KilometersPerHourToFeetPerSecond : IConversion
    {
        public int Id => 7;
        public string FromUnit => "kilometers per hour";
        public string ToUnit => "feet per second";
        public double Convert(double value) => value / 1.09728;
    }
    public class KilometersPerHourToKnots : IConversion
    {
        public int Id => 8;
        public string FromUnit => "kilometers per hour";
        public string ToUnit => "knots";
        public double Convert(double value) => value / 1.852;
    }

    // Miles per Hour
    public class MilesPerHourToMetersPerSecond : IConversion
    {
        public int Id => 9;
        public string FromUnit => "miles per hour";
        public string ToUnit => "meters per second";
        public double Convert(double value) => value / 2.23694;
    }
    public class MilesPerHourToKilometersPerHour : IConversion
    {
        public int Id => 10;
        public string FromUnit => "miles per hour";
        public string ToUnit => "kilometers per hour";
        public double Convert(double value) => value * 1.60934;
    }
    public class MilesPerHourToFeetPerSecond : IConversion
    {
        public int Id => 11;
        public string FromUnit => "miles per hour";
        public string ToUnit => "feet per second";
        public double Convert(double value) => value * 1.46667;
    }
    public class MilesPerHourToKnots : IConversion
    {
        public int Id => 12;
        public string FromUnit => "miles per hour";
        public string ToUnit => "knots";
        public double Convert(double value) => value / 1.15078;
    }

    // Feet Per Second
    public class FeetPerSecondToMetersPerSecond : IConversion
    {
        public int Id => 13;
        public string FromUnit => "feet per second";
        public string ToUnit => "meters per second";
        public double Convert(double value) => value / 3.28084;
    }
    public class FeetPerSecondToKilometersPerHour : IConversion
    {
        public int Id => 14;
        public string FromUnit => "feet per second";
        public string ToUnit => "kilometers per hour";
        public double Convert(double value) => value * 1.09728;
    }
    public class FeetPerSecondToMilesPerHour : IConversion
    {
        public int Id => 15;
        public string FromUnit => "feet per second";
        public string ToUnit => "miles per hour";
        public double Convert(double value) => value / 1.46667;
    }
    public class FeetPerSecondToKnots : IConversion
    {
        public int Id => 16;
        public string FromUnit => "feet per second";
        public string ToUnit => "knots";
        public double Convert(double value) => value / 1.68781;
    }

    // Knots
    public class KnotsToMetersPerSecond : IConversion
    {
        public int Id => 17;
        public string FromUnit => "knots";
        public string ToUnit => "meters per second";
        public double Convert(double value) => value / 1.94384;
    }
    public class KnotsToKilometersPerHour : IConversion
    {
        public int Id => 18;
        public string FromUnit => "knots";
        public string ToUnit => "kilometers per hour";
        public double Convert(double value) => value * 1.852;
    }
    public class KnotsToMilesPerHour : IConversion
    {
        public int Id => 19;
        public string FromUnit => "knots";
        public string ToUnit => "miles per hour";
        public double Convert(double value) => value * 1.15078;
    }
    public class KnotsToFeetPerSecond : IConversion
    {
        public int Id => 20;
        public string FromUnit => "knots";
        public string ToUnit => "feet per second";
        public double Convert(double value) => value * 1.68781;
    }
}
