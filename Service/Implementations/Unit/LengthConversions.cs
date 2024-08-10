using Converter_Web_Application.Service.Base;

namespace Converter_Web_Application.Service.Implementations.Unit
{
    /// <summary>
    /// Conversions strategies
    /// </summary>

    // Meters
    public class MetersToFeet : IConversion
    {
        public int Id => 12;

        public string FromUnit => "meters";

        public string ToUnit => "feet";

        public double Convert(double value)
        {
            return value * 3.28084;
        }
    }
    public class MetersToYards : IConversion
    {
        public int Id => 16;

        public string FromUnit => "meters";

        public string ToUnit => "yards";

        public double Convert(double value)
        {
            return value * 1.09361;
        }
    }
    public class MetersToMillimeters : IConversion
    {
        public int Id => 8;

        public string FromUnit => "meters";

        public string ToUnit => "millimeters";

        public double Convert(double value)
        {
            return value * 1000;
        }
    }
    public class MetersToKilometers : IConversion
    {
        public int Id => 1;
        public string FromUnit => "meters";
        public string ToUnit => "kilometers";

        public double Convert(double value)
        {
            return value / 1000;
        }
    }
    public class MetersToCentimeters : IConversion
    {
        public int Id => 2;
        public string FromUnit => "meters";
        public string ToUnit => "centimeters";

        public double Convert(double value)
        {
            return value * 100;
        }
    }
    public class MetersToNauticalMiles : IConversion
    {
        public int Id => 3;
        public string FromUnit => "meters";
        public string ToUnit => "nautical miles";

        public double Convert(double value)
        {
            return value / 1852;
        }
    }
    public class MetersToInches : IConversion
    {
        public int Id => 3;
        public string FromUnit => "meters";
        public string ToUnit => "inches";

        public double Convert(double value)
        {
            return value * 39.3701;
        }
    }
    public class MetersToLeagues : IConversion
    {
        public int Id => 3;
        public string FromUnit => "meters";
        public string ToUnit => "leagues";

        public double Convert(double value)
        {
            return value / 5556;
        }
    }
    public class MetersToMiles : IConversion
    {
        public int Id => 4;

        public string FromUnit => "meters";

        public string ToUnit => "miles";

        public double Convert(double value)
        {
            return value / 1609.34;
        }
    }

    // Kilometers
    public class KilometersToMeters : IConversion
    {
        public int Id => 3;

        public string FromUnit => "kilometers";

        public string ToUnit => "meters";

        public double Convert(double value)
        {
            return value * 1000;
        }
    }
    public class KilometersToMiles : IConversion
    {
        public int Id => 10;

        public string FromUnit => "kilometers";

        public string ToUnit => "miles";

        public double Convert(double value)
        {
            return value * 0.621371;
        }
    }
    public class KilometersToNauticalMiles : IConversion
    {
        public int Id => 18;

        public string FromUnit => "kilometers";

        public string ToUnit => "nautical miles";

        public double Convert(double value)
        {
            return value * 0.539957;
        }
    }
    public class KilometersToLeagues : IConversion
    {
        public int Id => 20;

        public string FromUnit => "kilometers";

        public string ToUnit => "leagues";

        public double Convert(double value)
        {
            return value * 0.206612;
        }
    }
    public class KilometersToCentimeters : IConversion
    {
        public int Id => 21;

        public string FromUnit => "kilometers";

        public string ToUnit => "centimeters";

        public double Convert(double value)
        {
            return value * 100000;
        }
    }
    public class KilometersToMillimeters : IConversion
    {
        public int Id => 22;

        public string FromUnit => "kilometers";

        public string ToUnit => "millimeters";

        public double Convert(double value)
        {
            return value * 1000000;
        }
    }
    public class KilometersToYards : IConversion
    {
        public int Id => 23;

        public string FromUnit => "kilometers";

        public string ToUnit => "yards";

        public double Convert(double value)
        {
            return value * 1093.61;
        }
    }
    public class KilometersToFeet : IConversion
    {
        public int Id => 24;

        public string FromUnit => "kilometers";

        public string ToUnit => "feet";

        public double Convert(double value)
        {
            return value * 3280.84;
        }
    }
    public class KilometersToInches : IConversion
    {
        public int Id => 25;

        public string FromUnit => "kilometers";

        public string ToUnit => "inches";

        public double Convert(double value)
        {
            return value * 39370.1;
        }
    }

    // Miles
    public class MilesToMeters : IConversion
    {
        public int Id => 5;

        public string FromUnit => "miles";

        public string ToUnit => "meters";

        public double Convert(double value)
        {
            return value * 1609.34;
        }
    }
    public class MilesToKilometers : IConversion
    {
        public int Id => 9;

        public string FromUnit => "miles";

        public string ToUnit => "kilometers";

        public double Convert(double value)
        {
            return value * 1.60934;
        }
    }
    public class MilesToCentimeters : IConversion
    {
        public int Id => 26;

        public string FromUnit => "miles";

        public string ToUnit => "centimeters";

        public double Convert(double value)
        {
            return value * 160934;
        }
    }
    public class MilesToMillimeters : IConversion
    {
        public int Id => 27;

        public string FromUnit => "miles";

        public string ToUnit => "millimeters";
        public double Convert(double value)
        {
            return value * 1609340;
        }
    }
    public class MilesToNauticalMiles : IConversion
    {
        public int Id => 28;

        public string FromUnit => "miles";

        public string ToUnit => "nautical miles";
        public double Convert(double value)
        {
            return value / 1.15078;
        }
    }
    public class MilesToYards : IConversion
    {
        public int Id => 29;

        public string FromUnit => "miles";

        public string ToUnit => "yards";
        public double Convert(double value)
        {
            return value * 1760;
        }
    }
    public class MilesToFeet : IConversion
    {
        public int Id => 30;

        public string FromUnit => "miles";

        public string ToUnit => "feet";
        public double Convert(double value)
        {
            return value * 5280;
        }
    }
    public class MilesToInches : IConversion
    {
        public int Id => 31;

        public string FromUnit => "miles";

        public string ToUnit => "inches";
        public double Convert(double value)
        {
            return value * 63360;
        }
    }
    public class MilesToLeagues : IConversion
    {
        public int Id => 31;

        public string FromUnit => "miles";

        public string ToUnit => "leagues";
        public double Convert(double value)
        {
            return value / 5556000;
        }
    }


    // Centimeters
    public class CentimetersToMeters : IConversion
    {
        public int Id => 1;

        public string FromUnit => "centimeters";

        public string ToUnit => "meters";

        public double Convert(double value)
        {
            return value / 100;
        }
    }
    public class CentimetersToInches : IConversion
    {
        public int Id => 2;

        public string FromUnit => "centimeters";

        public string ToUnit => "inches";

        public double Convert(double value)
        {
            return value * 0.393701;
        }
    }
    public class CentimetersToKilometers : IConversion
    {
        public int Id => 3;

        public string FromUnit => "centimeters";

        public string ToUnit => "kilometers";
        public double Convert(double value)
        {
            return value / 100000;
        }
    }
    public class CentimetersToMiles : IConversion
    {
        public int Id => 4;

        public string FromUnit => "centimeters";

        public string ToUnit => "miles";
        public double Convert(double value)
        {
            return value / 160934;
        }
    }
    public class CentimetersToMillimeters : IConversion
    {
        public int Id => 5;

        public string FromUnit => "centimeters";

        public string ToUnit => "millimeters";
        public double Convert(double value)
        {
            return value * 10;
        }
    }
    public class CentimetersToNauticalMiles : IConversion
    {
        public int Id => 6;

        public string FromUnit => "centimeters";

        public string ToUnit => "nautical miles";
        public double Convert(double value)
        {
            return value / 185200;
        }
    }
    public class CentimetersToYards : IConversion
    {
        public int Id => 7;

        public string FromUnit => "centimeters";

        public string ToUnit => "yards";
        public double Convert(double value)
        {
            return value / 91.44;
        }
    }
    public class CentimetersToFeet : IConversion
    {
        public int Id => 8;

        public string FromUnit => "centimeters";

        public string ToUnit => "feet";
        public double Convert(double value)
        {
            return value / 30.48;
        }
    }
    public class CentimetersToLeagues : IConversion
    {
        public int Id => 9;

        public string FromUnit => "centimeters";

        public string ToUnit => "leagues";
        public double Convert(double value)
        {
            return value / 555600;
        }
    }

    // Millimeters
    public class MillimetersToMeters : IConversion
    {
        public int Id => 10;

        public string FromUnit => "millimeters";

        public string ToUnit => "meters";

        public double Convert(double value)
        {
            return value / 1000;
        }
    }
    public class MillimetersToKilometers : IConversion
    {
        public int Id => 11;

        public string FromUnit => "millimeters";

        public string ToUnit => "kilometers";
        public double Convert(double value)
        {
            return value / 1000000;
        }
    }
    public class MillimetersToMiles : IConversion
    {
        public int Id => 12;

        public string FromUnit => "millimeters";

        public string ToUnit => "miles";
        public double Convert(double value)
        {
            return value / 1609340;
        }
    }
    public class MillimetersToCentimeters : IConversion
    {
        public int Id => 13;

        public string FromUnit => "millimeters";

        public string ToUnit => "centimeters";
        public double Convert(double value)
        {
            return value / 10;
        }
    }
    public class MillimetersToNauticalMiles : IConversion
    {
        public int Id => 14;

        public string FromUnit => "millimeters";

        public string ToUnit => "nautical miles";
        public double Convert(double value)
        {
            return value / 1852000;
        }
    }
    public class MillimetersToYards : IConversion
    {
        public int Id => 15;

        public string FromUnit => "millimeters";

        public string ToUnit => "yards";
        public double Convert(double value)
        {
            return value / 914.4;
        }
    }
    public class MillimetersToFeet : IConversion
    {
        public int Id => 16;

        public string FromUnit => "millimeters";

        public string ToUnit => "feet";
        public double Convert(double value)
        {
            return value / 304.8;
        }
    }
    public class MillimetersToInches : IConversion
    {
        public int Id => 17;

        public string FromUnit => "millimeters";

        public string ToUnit => "inches";
        public double Convert(double value)
        {
            return value / 25.4;
        }
    }
    public class MillimetersToLeagues : IConversion
    {
        public int Id => 18;

        public string FromUnit => "millimeters";

        public string ToUnit => "leagues";
        public double Convert(double value)
        {
            return value / 5556000;
        }
    }

    // Feet
    public class FeetToMeters : IConversion
    {
        public int Id => 19;

        public string FromUnit => "feet";

        public string ToUnit => "meters";

        public double Convert(double value)
        {
            return value * 0.3048;
        }
    }
    public class FeetToKilometers : IConversion
    {
        public int Id => 20;

        public string FromUnit => "feet";

        public string ToUnit => "kilometers";
        public double Convert(double value)
        {
            return value / 3280.84;
        }
    }
    public class FeetToMiles : IConversion
    {
        public int Id => 21;

        public string FromUnit => "feet";

        public string ToUnit => "miles";
        public double Convert(double value)
        {
            return value / 5280;
        }
    }
    public class FeetToCentimeters : IConversion
    {
        public int Id => 22;

        public string FromUnit => "feet";

        public string ToUnit => "centimeters";
        public double Convert(double value)
        {
            return value * 30.48;
        }
    }
    public class FeetToMillimeters : IConversion
    {
        public int Id => 23;

        public string FromUnit => "feet";

        public string ToUnit => "millimeters";
        public double Convert(double value)
        {
            return value * 304.8;
        }
    }
    public class FeetToNauticalMiles : IConversion
    {
        public int Id => 24;

        public string FromUnit => "feet";

        public string ToUnit => "nautical miles";
        public double Convert(double value)
        {
            return value / 6076.12;
        }
    }
    public class FeetToYards : IConversion
    {
        public int Id => 25;

        public string FromUnit => "feet";

        public string ToUnit => "yards";
        public double Convert(double value)
        {
            return value / 3;
        }
    }
    public class FeetToInches : IConversion
    {
        public int Id => 26;

        public string FromUnit => "feet";

        public string ToUnit => "inches";
        public double Convert(double value)
        {
            return value * 12;
        }
    }
    public class FeetToLeagues : IConversion
    {
        public int Id => 27;

        public string FromUnit => "feet";

        public string ToUnit => "leagues";
        public double Convert(double value)
        {
            return value / 15840;
        }
    }

    // Inches
    public class InchesToCentimeters : IConversion
    {
        public int Id => 28;

        public string FromUnit => "inches";

        public string ToUnit => "centimeters";

        public double Convert(double value)
        {
            return value * 2.54;
        }
    }
    public class InchesToMeters : IConversion
    {
        public int Id => 29;

        public string FromUnit => "inches";

        public string ToUnit => "meters";
        public double Convert(double value)
        {
            return value / 39.3701;
        }
    }
    public class InchesToKilometers : IConversion
    {
        public int Id => 30;

        public string FromUnit => "inches";

        public string ToUnit => "kilometers";
        public double Convert(double value)
        {
            return value / 39370.1;
        }
    }
    public class InchesToMiles : IConversion
    {
        public int Id => 31;

        public string FromUnit => "inches";

        public string ToUnit => "miles";
        public double Convert(double value)
        {
            return value / 63360;
        }
    }
    public class InchesToMillimeters : IConversion
    {
        public int Id => 32;

        public string FromUnit => "inches";

        public string ToUnit => "Millimeters";
        public double Convert(double value)
        {
            return value * 25.4;
        }
    }
    public class InchesToNauticalMiles : IConversion
    {
        public int Id => 33;

        public string FromUnit => "inches";

        public string ToUnit => "nautical miles";
        public double Convert(double value)
        {
            return value / 72913.4;
        }
    }
    public class InchesToYards : IConversion
    {
        public int Id => 34;

        public string FromUnit => "inches";

        public string ToUnit => "Yards";
        public double Convert(double value)
        {
            return value / 36;
        }
    }
    public class InchesToFeet : IConversion
    {
        public int Id => 35;

        public string FromUnit => "inches";

        public string ToUnit => "feet";
        public double Convert(double value)
        {
            return value / 12;
        }
    }
    public class InchesToLeagues : IConversion
    {
        public int Id => 36;

        public string FromUnit => "inches";

        public string ToUnit => "leagues";
        public double Convert(double value)
        {
            return value / 190080;
        }
    }

    // Yards
    public class YardsToMeters : IConversion
    {
        public int Id => 37;

        public string FromUnit => "yards";

        public string ToUnit => "meters";

        public double Convert(double value)
        {
            return value * 0.9144;
        }
    }
    public class YardsToKilometers : IConversion
    {
        public int Id => 38;

        public string FromUnit => "yards";

        public string ToUnit => "kilometers";
        public double Convert(double value)
        {
            return value / 1093.61;
        }
    }
    public class YardsToMiles : IConversion
    {
        public int Id => 39;

        public string FromUnit => "yards";

        public string ToUnit => "miles";
        public double Convert(double value)
        {
            return value / 1760;
        }
    }
    public class YardsToCentimeters : IConversion
    {
        public int Id => 40;

        public string FromUnit => "yards";

        public string ToUnit => "centimeters";
        public double Convert(double value)
        {
            return value * 91.44;
        }
    }
    public class YardsToMillimeters : IConversion
    {
        public int Id => 41;

        public string FromUnit => "yards";

        public string ToUnit => "millimeters";
        public double Convert(double value)
        {
            return value * 914.4;
        }
    }
    public class YardsToNauticalMiles : IConversion
    {
        public int Id => 42;

        public string FromUnit => "yards";

        public string ToUnit => "nautical miles";
        public double Convert(double value)
        {
            return value / 2025.37;
        }
    }
    public class YardsToInches : IConversion
    {
        public int Id => 43;

        public string FromUnit => "yards";

        public string ToUnit => "inches";
        public double Convert(double value)
        {
            return value * 36;
        }
    }
    public class YardsToFeet : IConversion
    {
        public int Id => 44;

        public string FromUnit => "yards";

        public string ToUnit => "feet";
        public double Convert(double value)
        {
            return value * 3;
        }
    }
    public class YardsToLeagues : IConversion
    {
        public int Id => 45;

        public string FromUnit => "yards";

        public string ToUnit => "leagues";
        public double Convert(double value)
        {
            return value / 5280;
        }
    }

    // Nautical Miles
    public class NauticalMilesToKilometers : IConversion
    {
        public int Id => 46;

        public string FromUnit => "nautical miles";

        public string ToUnit => "kilometers";

        public double Convert(double value)
        {
            return value * 1.852;
        }
    }
    public class NauticalMilesToMeters : IConversion
    {
        public int Id => 47;

        public string FromUnit => "nautical miles";

        public string ToUnit => "meters";
        public double Convert(double value)
        {
            return value * 1852;
        }
    }
    public class NauticalMilesToCentimeters : IConversion
    {
        public int Id => 48;

        public string FromUnit => "nautical miles";

        public string ToUnit => "centimeters";
        public double Convert(double value)
        {
            return value * 185200;
        }
    }
    public class NauticalMilesToMillimeters : IConversion
    {
        public int Id => 49;

        public string FromUnit => "nautical miles";

        public string ToUnit => "millimeters";
        public double Convert(double value)
        {
            return value * 1852000;
        }
    }
    public class NauticalMilesToYards : IConversion
    {
        public int Id => 50;

        public string FromUnit => "nautical miles";

        public string ToUnit => "yards";
        public double Convert(double value)
        {
            return value * 2025.37;
        }
    }
    public class NauticalMilesToFeet : IConversion
    {
        public int Id => 51;

        public string FromUnit => "nautical miles";

        public string ToUnit => "feet";
        public double Convert(double value)
        {
            return value * 6076.12;
        }
    }
    public class NauticalMilesToInches : IConversion
    {
        public int Id => 52;

        public string FromUnit => "nautical miles";

        public string ToUnit => "inches";
        public double Convert(double value)
        {
            return value * 72913.4;
        }
    }
    public class NauticalMilesToLeagues : IConversion
    {
        public int Id => 53;

        public string FromUnit => "nautical miles";

        public string ToUnit => "leagues";
        public double Convert(double value)
        {
            return value / 3;
        }
    }

    // Leagues
    public class LeaguesToKilometers : IConversion
    {
        public int Id => 54;

        public string FromUnit => "leagues";

        public string ToUnit => "kilometers";

        public double Convert(double value)
        {
            return value * 4.82803;
        }
    }
    public class LeaguesToMeters : IConversion
    {
        public int Id => 55;

        public string FromUnit => "leagues";

        public string ToUnit => "meters";
        public double Convert(double value)
        {
            return value * 5556;
        }
    }
    public class LeaguesToCentimeters : IConversion
    {
        public int Id => 56;

        public string FromUnit => "leagues";

        public string ToUnit => "centimeters";
        public double Convert(double value)
        {
            return value * 555600;
        }
    }
    public class LeaguesToMillimeters : IConversion
    {
        public int Id => 57;

        public string FromUnit => "leagues";

        public string ToUnit => "millimeters";
        public double Convert(double value)
        {
            return value * 5556000;
        }
    }
    public class LeaguesToNauticalMiles : IConversion
    {
        public int Id => 58;

        public string FromUnit => "leagues";

        public string ToUnit => "nautical miles";
        public double Convert(double value)
        {
            return value * 3;
        }
    }
    public class LeaguesToYards : IConversion
    {
        public int Id => 59;

        public string FromUnit => "leagues";

        public string ToUnit => "yards";
        public double Convert(double value)
        {
            return value * 5280;
        }
    }
    public class LeaguesToFeet : IConversion
    {
        public int Id => 60;

        public string FromUnit => "leagues";

        public string ToUnit => "feet";
        public double Convert(double value)
        {
            return value * 15840;
        }
    }
    public class LeaguesToInches : IConversion
    {
        public int Id => 61;

        public string FromUnit => "leagues";

        public string ToUnit => "inches";
        public double Convert(double value)
        {
            return value * 190080;
        }
    }
    public class LeaguesToMiles : IConversion
    {
        public int Id => 62;

        public string FromUnit => "leagues";

        public string ToUnit => "miles";
        public double Convert(double value)
        {
            return value * 3;
        }
    }

}
