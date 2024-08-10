using Converter_Web_Application.Service.Base;

namespace Converter_Web_Application.Service.Implementations.Unit
{

    /// <summary>
    /// Conversions strategies
    /// </summary>

    // Grams
    public class GramsToKilograms : IConversion
    {
        public int Id => 1;

        public string FromUnit => "grams";

        public string ToUnit => "kilograms";

        public double Convert(double value)
        {
            return value / 1000;
        }
    }
    public class GramsToOunces : IConversion
    {
        public int Id => 2;

        public string FromUnit => "grams";

        public string ToUnit => "ounces";

        public double Convert(double value)
        {
            return value / 28.3495;
        }
    }
    public class GramsToPoundes : IConversion
    {
        public int Id => 3;

        public string FromUnit => "grams";

        public string ToUnit => "pounds";

        public double Convert(double value)
        {
            return value / 453.592;
        }
    }
    public class GramsToStones : IConversion
    {
        public int Id => 4;

        public string FromUnit => "grams";

        public string ToUnit => "stones";

        public double Convert(double value)
        {
            return value / 6350.29;
        }
    }

    // Kilograms
    public class KilogramsToGrams : IConversion
    {
        public int Id => 5;

        public string FromUnit => "kilograms";

        public string ToUnit => "grams";

        public double Convert(double value)
        {
            return value * 1000;
        }
    }
    public class KilogramsToOunces : IConversion
    {
        public int Id => 6;

        public string FromUnit => "kilograms";

        public string ToUnit => "ounces";

        public double Convert(double value)
        {
            return value * 35.274;
        }
    }
    public class KilogramsToPounds : IConversion
    {
        public int Id => 7;

        public string FromUnit => "kilograms";

        public string ToUnit => "pounds";

        public double Convert(double value)
        {
            return value * 2.20462;
        }
    }
    public class KilogramsToStones : IConversion
    {
        public int Id => 8;

        public string FromUnit => "kilograms";

        public string ToUnit => "stones";

        public double Convert(double value)
        {
            return value / 6.35029;
        }
    }

    // Ounces
    public class OuncesToGrams : IConversion
    {
        public int Id => 9;

        public string FromUnit => "ounces";

        public string ToUnit => "grams";

        public double Convert(double value)
        {
            return value * 28.3495;
        }
    }
    public class OuncesToKilograms : IConversion
    {
        public int Id => 10;

        public string FromUnit => "ounces";

        public string ToUnit => "kilograms";

        public double Convert(double value)
        {
            return value / 35.274;
        }
    }
    public class OuncesToPounds : IConversion
    {
        public int Id => 11;

        public string FromUnit => "ounces";

        public string ToUnit => "pounds";

        public double Convert(double value)
        {
            return value / 16;
        }
    }
    public class OuncesToStones : IConversion
    {
        public int Id => 12;

        public string FromUnit => "ounces";

        public string ToUnit => "stones";

        public double Convert(double value)
        {
            return value / 224;
        }
    }

    // Pounds
    public class PoundsToGrams : IConversion
    {
        public int Id => 13;

        public string FromUnit => "pounds";

        public string ToUnit => "grams";

        public double Convert(double value)
        {
            return value * 453.592;
        }
    }
    public class PoundsToKilograms : IConversion
    {
        public int Id => 14;

        public string FromUnit => "pounds";

        public string ToUnit => "kilograms";

        public double Convert(double value)
        {
            return value / 2.20462;
        }
    }
    public class PoundsToOunces : IConversion
    {
        public int Id => 15;

        public string FromUnit => "pounds";

        public string ToUnit => "ounces";

        public double Convert(double value)
        {
            return value * 16;
        }
    }
    public class PoundsToStones : IConversion
    {
        public int Id => 16;

        public string FromUnit => "pounds";

        public string ToUnit => "stones";

        public double Convert(double value)
        {
            return value / 14;
        }
    }

    // Stones
    public class StonesToGrams : IConversion
    {
        public int Id => 17;

        public string FromUnit => "stones";

        public string ToUnit => "grams";

        public double Convert(double value)
        {
            return value * 6350.29;
        }
    }
    public class StonesToKilograms : IConversion
    {
        public int Id => 18;

        public string FromUnit => "stones";

        public string ToUnit => "kilograms";

        public double Convert(double value)
        {
            return value * 6.35029;
        }
    }
    public class StonesToOunces : IConversion
    {
        public int Id => 19;

        public string FromUnit => "stones";

        public string ToUnit => "ounces";

        public double Convert(double value)
        {
            return value * 224;
        }
    }
    public class StonesToPoundes : IConversion
    {
        public int Id => 20;

        public string FromUnit => "stones";

        public string ToUnit => "pounds";

        public double Convert(double value)
        {
            return value * 14;
        }
    }



}

