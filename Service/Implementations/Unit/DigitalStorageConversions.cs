using Converter_Web_Application.Service.Base;

namespace Converter_Web_Application.Service.Implementations.Unit
{
    /// <summary>
    /// Conversions strategies
    /// </summary>

    // Bits
    public class BitsToBytes : IConversion
    {
        public int Id => 1;
        public string FromUnit => "bits";
        public string ToUnit => "bytes";
        public double Convert(double value) => value / 8;
    }
    public class BitsToKilobits : IConversion
    {
        public int Id => 2;
        public string FromUnit => "bits";
        public string ToUnit => "kilobits";
        public double Convert(double value) => value / 1000;
    }
    public class BitsToKilobytes : IConversion
    {
        public int Id => 3;
        public string FromUnit => "bits";
        public string ToUnit => "kilobytes";
        public double Convert(double value) => value / 8000;
    }
    public class BitsToMegabits : IConversion
    {
        public int Id => 4;
        public string FromUnit => "bits";
        public string ToUnit => "megabits";
        public double Convert(double value) => value / 1e6;
    }
    public class BitsToMegabytes : IConversion
    {
        public int Id => 5;
        public string FromUnit => "bits";
        public string ToUnit => "megabytes";
        public double Convert(double value) => value / 8e6;
    }
    public class BitsToGigabits : IConversion
    {
        public int Id => 6;
        public string FromUnit => "bits";
        public string ToUnit => "gigabits";
        public double Convert(double value) => value / 1e9;
    }
    public class BitsToGigabytes : IConversion
    {
        public int Id => 7;
        public string FromUnit => "bits";
        public string ToUnit => "gigabytes";
        public double Convert(double value) => value / 8e9;
    }
    public class BitsToTerabits : IConversion
    {
        public int Id => 8;
        public string FromUnit => "bits";
        public string ToUnit => "terabits";
        public double Convert(double value) => value / 1e12;
    }
    public class BitsToTerabytes : IConversion
    {
        public int Id => 9;
        public string FromUnit => "bits";
        public string ToUnit => "terabytes";
        public double Convert(double value) => value / 8e12;
    }

    // Bytes
    public class BytesToBits : IConversion
    {
        public int Id => 10;
        public string FromUnit => "bytes";
        public string ToUnit => "bits";
        public double Convert(double value) => value * 8;
    }
    public class BytesToKilobits : IConversion
    {
        public int Id => 11;
        public string FromUnit => "bytes";
        public string ToUnit => "kilobits";
        public double Convert(double value) => value / 125;
    }
    public class BytesToKilobytes : IConversion
    {
        public int Id => 12;
        public string FromUnit => "bytes";
        public string ToUnit => "kilobytes";
        public double Convert(double value) => value / 1000;
    }
    public class BytesToMegabits : IConversion
    {
        public int Id => 13;
        public string FromUnit => "bytes";
        public string ToUnit => "megabits";
        public double Convert(double value) => value / 125000;
    }
    public class BytesToMegabytes : IConversion
    {
        public int Id => 14;
        public string FromUnit => "bytes";
        public string ToUnit => "megabytes";
        public double Convert(double value) => value / 1e6;
    }
    public class BytesToGigabits : IConversion
    {
        public int Id => 15;
        public string FromUnit => "bytes";
        public string ToUnit => "gigabits";
        public double Convert(double value) => value / 1.25e8;
    }
    public class BytesToGigabytes : IConversion
    {
        public int Id => 16;
        public string FromUnit => "bytes";
        public string ToUnit => "gigabytes";
        public double Convert(double value) => value / 1e9;
    }
    public class BytesToTerabits : IConversion
    {
        public int Id => 17;
        public string FromUnit => "bytes";
        public string ToUnit => "terabits";
        public double Convert(double value) => value / 1.25e11;
    }
    public class BytesToTerabytes : IConversion
    {
        public int Id => 18;
        public string FromUnit => "bytes";
        public string ToUnit => "terabytes";
        public double Convert(double value) => value / 1e12;
    }

    // Kilobits
    public class KilobitsToBits : IConversion
    {
        public int Id => 19;
        public string FromUnit => "kilobits";
        public string ToUnit => "bits";
        public double Convert(double value) => value * 1000;
    }
    public class KilobitsToBytes : IConversion
    {
        public int Id => 20;
        public string FromUnit => "kilobits";
        public string ToUnit => "bytes";
        public double Convert(double value) => value * 125;
    }
    public class KilobitsToKilobytes : IConversion
    {
        public int Id => 21;
        public string FromUnit => "kilobits";
        public string ToUnit => "kilobytes";
        public double Convert(double value) => value / 8;
    }
    public class KilobitsToMegabits : IConversion
    {
        public int Id => 22;
        public string FromUnit => "kilobits";
        public string ToUnit => "megabits";
        public double Convert(double value) => value / 1000;
    }
    public class KilobitsToMegabytes : IConversion
    {
        public int Id => 23;
        public string FromUnit => "kilobits";
        public string ToUnit => "megabytes";
        public double Convert(double value) => value / 8000;
    }
    public class KilobitsToGigabits : IConversion
    {
        public int Id => 24;
        public string FromUnit => "kilobits";
        public string ToUnit => "gigabits";
        public double Convert(double value) => value / 1e6;
    }
    public class KilobitsToGigabytes : IConversion
    {
        public int Id => 25;
        public string FromUnit => "kilobits";
        public string ToUnit => "gigabytes";
        public double Convert(double value) => value / 8e6;
    }
    public class KilobitsToTerabits : IConversion
    {
        public int Id => 26;
        public string FromUnit => "kilobits";
        public string ToUnit => "terabits";
        public double Convert(double value) => value / 1e9;
    }
    public class KilobitsToTerabytes : IConversion
    {
        public int Id => 27;
        public string FromUnit => "kilobits";
        public string ToUnit => "terabytes";
        public double Convert(double value) => value / 8e9;
    }

    // Kilobytes
    public class KilobytesToBits : IConversion
    {
        public int Id => 28;
        public string FromUnit => "kilobytes";
        public string ToUnit => "bits";
        public double Convert(double value) => value * 8000;
    }
    public class KilobytesToBytes : IConversion
    {
        public int Id => 29;
        public string FromUnit => "kilobytes";
        public string ToUnit => "bytes";
        public double Convert(double value) => value * 1000;
    }
    public class KilobytesToKilobits : IConversion
    {
        public int Id => 30;
        public string FromUnit => "kilobytes";
        public string ToUnit => "kilobits";
        public double Convert(double value) => value * 8;
    }
    public class KilobytesToMegabits : IConversion
    {
        public int Id => 31;
        public string FromUnit => "kilobytes";
        public string ToUnit => "megabits";
        public double Convert(double value) => value / 125;
    }
    public class KilobytesToMegabytes : IConversion
    {
        public int Id => 32;
        public string FromUnit => "kilobytes";
        public string ToUnit => "megabytes";
        public double Convert(double value) => value / 1000;
    }
    public class KilobytesToGigabits : IConversion
    {
        public int Id => 33;
        public string FromUnit => "kilobytes";
        public string ToUnit => "gigabits";
        public double Convert(double value) => value / 125000;
    }
    public class KilobytesToGigabytes : IConversion
    {
        public int Id => 34;
        public string FromUnit => "kilobytes";
        public string ToUnit => "gigabytes";
        public double Convert(double value) => value / 1e6;
    }
    public class KilobytesToTerabits : IConversion
    {
        public int Id => 35;
        public string FromUnit => "kilobytes";
        public string ToUnit => "terabits";
        public double Convert(double value) => value / 125000000;
    }
    public class KilobytesToTerabytes : IConversion
    {
        public int Id => 36;
        public string FromUnit => "kilobytes";
        public string ToUnit => "terabytes";
        public double Convert(double value) => value / 1e9;
    }

    // Megabits
    public class MegabitsToBits : IConversion
    {
        public int Id => 37;
        public string FromUnit => "megabits";
        public string ToUnit => "bits";
        public double Convert(double value) => value * 1e6;
    }
    public class MegabitsToBytes : IConversion
    {
        public int Id => 38;
        public string FromUnit => "megabits";
        public string ToUnit => "bytes";
        public double Convert(double value) => value * 125000;
    }
    public class MegabitsToKilobits : IConversion
    {
        public int Id => 39;
        public string FromUnit => "megabits";
        public string ToUnit => "kilobits";
        public double Convert(double value) => value * 1000;
    }
    public class MegabitsToKilobytes : IConversion
    {
        public int Id => 40;
        public string FromUnit => "megabits";
        public string ToUnit => "kilobytes";
        public double Convert(double value) => value * 125;
    }
    public class MegabitsToMegabytes : IConversion
    {
        public int Id => 41;
        public string FromUnit => "megabits";
        public string ToUnit => "megabytes";
        public double Convert(double value) => value / 8;
    }
    public class MegabitsToGigabits : IConversion
    {
        public int Id => 42;
        public string FromUnit => "megabits";
        public string ToUnit => "gigabits";
        public double Convert(double value) => value / 1000;
    }
    public class MegabitsToGigabytes : IConversion
    {
        public int Id => 43;
        public string FromUnit => "megabits";
        public string ToUnit => "gigabytes";
        public double Convert(double value) => value / 8000;
    }
    public class MegabitsToTerabits : IConversion
    {
        public int Id => 44;
        public string FromUnit => "megabits";
        public string ToUnit => "terabits";
        public double Convert(double value) => value / 1e6;
    }
    public class MegabitsToTerabytes : IConversion
    {
        public int Id => 45;
        public string FromUnit => "megabits";
        public string ToUnit => "terabytes";
        public double Convert(double value) => value / 8e6;
    }

    // Megabytes
    public class MegabytesToBits : IConversion
    {
        public int Id => 46;
        public string FromUnit => "megabytes";
        public string ToUnit => "bits";
        public double Convert(double value) => value * 8e6;
    }
    public class MegabytesToBytes : IConversion
    {
        public int Id => 47;
        public string FromUnit => "megabytes";
        public string ToUnit => "bytes";
        public double Convert(double value) => value * 1e6;
    }
    public class MegabytesToKilobits : IConversion
    {
        public int Id => 48;
        public string FromUnit => "megabytes";
        public string ToUnit => "kilobits";
        public double Convert(double value) => value * 8000;
    }
    public class MegabytesToKilobytes : IConversion
    {
        public int Id => 49;
        public string FromUnit => "megabytes";
        public string ToUnit => "kilobytes";
        public double Convert(double value) => value * 1000;
    }
    public class MegabytesToMegabits : IConversion
    {
        public int Id => 50;
        public string FromUnit => "megabytes";
        public string ToUnit => "megabits";
        public double Convert(double value) => value * 8;
    }
    public class MegabytesToGigabits : IConversion
    {
        public int Id => 51;
        public string FromUnit => "megabytes";
        public string ToUnit => "gigabits";
        public double Convert(double value) => value / 125;
    }
    public class MegabytesToGigabytes : IConversion
    {
        public int Id => 52;
        public string FromUnit => "megabytes";
        public string ToUnit => "gigabytes";
        public double Convert(double value) => value / 1000;
    }
    public class MegabytesToTerabits : IConversion
    {
        public int Id => 53;
        public string FromUnit => "megabytes";
        public string ToUnit => "terabits";
        public double Convert(double value) => value / 125000;
    }
    public class MegabytesToTerabytes : IConversion
    {
        public int Id => 54;
        public string FromUnit => "megabytes";
        public string ToUnit => "terabytes";
        public double Convert(double value) => value / 1e6;
    }

    // Gigabits
    public class GigabitsToBits : IConversion
    {
        public int Id => 55;
        public string FromUnit => "gigabits";
        public string ToUnit => "bits";
        public double Convert(double value) => value * 1e9;
    }
    public class GigabitsToBytes : IConversion
    {
        public int Id => 56;
        public string FromUnit => "gigabits";
        public string ToUnit => "bytes";
        public double Convert(double value) => value * 1.25e8;
    }
    public class GigabitsToKilobits : IConversion
    {
        public int Id => 57;
        public string FromUnit => "gigabits";
        public string ToUnit => "kilobits";
        public double Convert(double value) => value * 1e6;
    }
    public class GigabitsToKilobytes : IConversion
    {
        public int Id => 58;
        public string FromUnit => "gigabits";
        public string ToUnit => "kilobytes";
        public double Convert(double value) => value * 125000;
    }
    public class GigabitsToMegabits : IConversion
    {
        public int Id => 59;
        public string FromUnit => "gigabits";
        public string ToUnit => "megabits";
        public double Convert(double value) => value * 1000;
    }
    public class GigabitsToMegabytes : IConversion
    {
        public int Id => 60;
        public string FromUnit => "gigabits";
        public string ToUnit => "megabytes";
        public double Convert(double value) => value * 125;
    }
    public class GigabitsToGigabytes : IConversion
    {
        public int Id => 61;
        public string FromUnit => "gigabits";
        public string ToUnit => "gigabytes";
        public double Convert(double value) => value / 8;
    }
    public class GigabitsToTerabits : IConversion
    {
        public int Id => 62;
        public string FromUnit => "gigabits";
        public string ToUnit => "terabits";
        public double Convert(double value) => value / 1000;
    }
    public class GigabitsToTerabytes : IConversion
    {
        public int Id => 63;
        public string FromUnit => "gigabits";
        public string ToUnit => "terabytes";
        public double Convert(double value) => value / 8000;
    }

    // Gigabytes
    public class GigabytesToBits : IConversion
    {
        public int Id => 64;
        public string FromUnit => "gigabytes";
        public string ToUnit => "bits";
        public double Convert(double value) => value * 8e9;
    }
    public class GigabytesToBytes : IConversion
    {
        public int Id => 65;
        public string FromUnit => "gigabytes";
        public string ToUnit => "bytes";
        public double Convert(double value) => value * 1e9;
    }
    public class GigabytesToKilobits : IConversion
    {
        public int Id => 66;
        public string FromUnit => "gigabytes";
        public string ToUnit => "kilobits";
        public double Convert(double value) => value * 8e6;
    }
    public class GigabytesToKilobytes : IConversion
    {
        public int Id => 67;
        public string FromUnit => "gigabytes";
        public string ToUnit => "kilobytes";
        public double Convert(double value) => value * 1e6;
    }
    public class GigabytesToMegabits : IConversion
    {
        public int Id => 68;
        public string FromUnit => "gigabytes";
        public string ToUnit => "megabits";
        public double Convert(double value) => value * 8000;
    }
    public class GigabytesToMegabytes : IConversion
    {
        public int Id => 69;
        public string FromUnit => "gigabytes";
        public string ToUnit => "megabytes";
        public double Convert(double value) => value * 1000;
    }
    public class GigabytesToGigabits : IConversion
    {
        public int Id => 70;
        public string FromUnit => "gigabytes";
        public string ToUnit => "gigabits";
        public double Convert(double value) => value * 8;
    }
    public class GigabytesToTerabits : IConversion
    {
        public int Id => 71;
        public string FromUnit => "gigabytes";
        public string ToUnit => "terabits";
        public double Convert(double value) => value / 125;
    }
    public class GigabytesToTerabytes : IConversion
    {
        public int Id => 72;
        public string FromUnit => "gigabytes";
        public string ToUnit => "terabytes";
        public double Convert(double value) => value / 1000;
    }

    // Terabits
    public class TerabitsToBits : IConversion
    {
        public int Id => 73;
        public string FromUnit => "terabits";
        public string ToUnit => "bits";
        public double Convert(double value) => value * 1e12;
    }
    public class TerabitsToBytes : IConversion
    {
        public int Id => 74;
        public string FromUnit => "terabits";
        public string ToUnit => "bytes";
        public double Convert(double value) => value * 1.25e11;
    }
    public class TerabitsToKilobits : IConversion
    {
        public int Id => 75;
        public string FromUnit => "terabits";
        public string ToUnit => "kilobits";
        public double Convert(double value) => value * 1e9;
    }
    public class TerabitsToKilobytes : IConversion
    {
        public int Id => 76;
        public string FromUnit => "terabits";
        public string ToUnit => "kilobytes";
        public double Convert(double value) => value * 125000000;
    }
    public class TerabitsToMegabits : IConversion
    {
        public int Id => 77;
        public string FromUnit => "terabits";
        public string ToUnit => "megabits";
        public double Convert(double value) => value * 1e6;
    }
    public class TerabitsToMegabytes : IConversion
    {
        public int Id => 78;
        public string FromUnit => "terabits";
        public string ToUnit => "megabytes";
        public double Convert(double value) => value * 125000;
    }
    public class TerabitsToGigabits : IConversion
    {
        public int Id => 79;
        public string FromUnit => "terabits";
        public string ToUnit => "gigabits";
        public double Convert(double value) => value * 1000;
    }
    public class TerabitsToGigabytes : IConversion
    {
        public int Id => 80;
        public string FromUnit => "terabits";
        public string ToUnit => "gigabytes";
        public double Convert(double value) => value * 125;
    }
    public class TerabitsToTerabytes : IConversion
    {
        public int Id => 81;
        public string FromUnit => "terabits";
        public string ToUnit => "terabytes";
        public double Convert(double value) => value / 8;
    }

    // Terabytes
    public class TerabytesToBits : IConversion
    {
        public int Id => 82;
        public string FromUnit => "terabytes";
        public string ToUnit => "bits";
        public double Convert(double value) => value * 8e12;
    }
    public class TerabytesToBytes : IConversion
    {
        public int Id => 83;
        public string FromUnit => "terabytes";
        public string ToUnit => "bytes";
        public double Convert(double value) => value * 1e12;
    }
    public class TerabytesToKilobits : IConversion
    {
        public int Id => 84;
        public string FromUnit => "terabytes";
        public string ToUnit => "kilobits";
        public double Convert(double value) => value * 8e9;
    }
    public class TerabytesToKilobytes : IConversion
    {
        public int Id => 85;
        public string FromUnit => "terabytes";
        public string ToUnit => "kilobytes";
        public double Convert(double value) => value * 1e9;
    }
    public class TerabytesToMegabits : IConversion
    {
        public int Id => 86;
        public string FromUnit => "terabytes";
        public string ToUnit => "megabits";
        public double Convert(double value) => value * 8e6;
    }
    public class TerabytesToMegabytes : IConversion
    {
        public int Id => 87;
        public string FromUnit => "terabytes";
        public string ToUnit => "megabytes";
        public double Convert(double value) => value * 1e6;
    }
    public class TerabytesToGigabits : IConversion
    {
        public int Id => 88;
        public string FromUnit => "terabytes";
        public string ToUnit => "gigabits";
        public double Convert(double value) => value * 8000;
    }
    public class TerabytesToGigabytes : IConversion
    {
        public int Id => 89;
        public string FromUnit => "terabytes";
        public string ToUnit => "gigabytes";
        public double Convert(double value) => value * 1000;
    }
    public class TerabytesToTerabits : IConversion
    {
        public int Id => 90;
        public string FromUnit => "terabytes";
        public string ToUnit => "terabits";
        public double Convert(double value) => value * 8;
    }
}

