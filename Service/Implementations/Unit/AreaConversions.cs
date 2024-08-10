using Converter_Web_Application.Service.Base;

namespace Converter_Web_Application.Service.Implementations.Unit
{
    /// <summary>
    /// Conversions strategies
    /// </summary>

    // Square meters
    public class SquaremetersToSquareFeet : IConversion
    {
        public int Id => 1;

        public string FromUnit => "square meters";

        public string ToUnit => "square feet";

        public double Convert(double value)
        {
            return value * 10.7639;
        }
    }
    public class SquaremetersToSquareYards : IConversion
    {
        public int Id => 2;

        public string FromUnit => "square meters";

        public string ToUnit => "square yards";

        public double Convert(double value)
        {
            return value * 1.19599;
        }
    }
    public class SquaremetersToSquareMiles : IConversion
    {
        public int Id => 3;

        public string FromUnit => "square meters";

        public string ToUnit => "square miles";

        public double Convert(double value)
        {
            return value * 3.861e-7;
        }
    }
    public class SquaremetersToSquareKilometers : IConversion
    {
        public int Id => 4;

        public string FromUnit => "square meters";

        public string ToUnit => "square kilometers";

        public double Convert(double value)
        {
            return value * 1e-6;
        }
    }
    public class SquaremetersToAcres : IConversion
    {
        public int Id => 5;

        public string FromUnit => "square meters";

        public string ToUnit => "acres";

        public double Convert(double value)
        {
            return value * 0.000247105;
        }
    }
    public class SquaremetersToHectares : IConversion
    {
        public int Id => 6;

        public string FromUnit => "square meters";

        public string ToUnit => "hectares";

        public double Convert(double value)
        {
            return value * 0.0001;
        }
    }
    public class SquaremetersToSquereCentimeters : IConversion
    {
        public int Id => 7;

        public string FromUnit => "square meters";

        public string ToUnit => "square centimeters";

        public double Convert(double value)
        {
            return value * 10_000;
        }
    }
    public class SquaremetersToSquereInches : IConversion
    {
        public int Id => 8;

        public string FromUnit => "square meters";

        public string ToUnit => "square inches";

        public double Convert(double value)
        {
            return value * 1_550_0031;
        }
    }
    public class SquaremetersToSquereMillimeters : IConversion
    {
        public int Id => 9;

        public string FromUnit => "square meters";

        public string ToUnit => "square millimeters";

        public double Convert(double value)
        {
            return value * 1_000_000;
        }
    }


    // Square feet
    public class SquareFeetToSquereMeters : IConversion
    {
        public int Id => 10;

        public string FromUnit => "square feet";

        public string ToUnit => "square meters";

        public double Convert(double value)
        {
            return value * 0.092903;
        }
    }
    public class SquareFeetToSquereYards : IConversion
    {
        public int Id => 11;

        public string FromUnit => "square feet";

        public string ToUnit => "square yards";

        public double Convert(double value)
        {
            return value * 0.111111;
        }
    }
    public class SquareFeetToSquereMiles : IConversion
    {
        public int Id => 12;

        public string FromUnit => "square feet";

        public string ToUnit => "square miles";

        public double Convert(double value)
        {
            return value * 3.587e-8;
        }
    }
    public class SquareFeetToSquereKilometers : IConversion
    {
        public int Id => 13;

        public string FromUnit => "square feet";

        public string ToUnit => "square kilometers";

        public double Convert(double value)
        {
            return value * 9.2903e-8;
        }
    }
    public class SquareFeetToAcres : IConversion
    {
        public int Id => 14;

        public string FromUnit => "square feet";

        public string ToUnit => "acres";

        public double Convert(double value)
        {
            return value * 2.2957e-5;
        }
    }
    public class SquareFeetToHectares : IConversion
    {
        public int Id => 15;

        public string FromUnit => "square feet";

        public string ToUnit => "hectares";

        public double Convert(double value)
        {
            return value * 9.2903e-6;
        }
    }
    public class SquareFeetToSquareCentimeters : IConversion
    {
        public int Id => 16;

        public string FromUnit => "square feet";

        public string ToUnit => "square centimeters";

        public double Convert(double value)
        {
            return value * 929.0304;
        }
    }
    public class SquareFeetToSquareInches : IConversion
    {
        public int Id => 17;

        public string FromUnit => "square feet";

        public string ToUnit => "square inches";

        public double Convert(double value)
        {
            return value * 144;
        }
    }
    public class SquareFeetToSquareMillimeters : IConversion
    {
        public int Id => 18;

        public string FromUnit => "square feet";

        public string ToUnit => "square millimeters";

        public double Convert(double value)
        {
            return value * 92903.04;
        }
    }

    // Square yards
    public class SquareYardsToSquareMeters : IConversion
    {
        public int Id => 19;

        public string FromUnit => "square yards";

        public string ToUnit => "square meters";

        public double Convert(double value)
        {
            return value * 0.836127;
        }
    }
    public class SquareYardsToSquareFeet : IConversion
    {
        public int Id => 20;

        public string FromUnit => "square yards";

        public string ToUnit => "square feet";

        public double Convert(double value)
        {
            return value * 9;
        }
    }
    public class SquareYardsToSquareMiles : IConversion
    {
        public int Id => 21;

        public string FromUnit => "square yards";

        public string ToUnit => "square miles";

        public double Convert(double value)
        {
            return value * 3.2283e-7;
        }
    }
    public class SquareYardsToSquareKilometers : IConversion
    {
        public int Id => 22;

        public string FromUnit => "square yards";

        public string ToUnit => "square kilometers";

        public double Convert(double value)
        {
            return value * 8.3613e-7;
        }
    }
    public class SquareYardsToAcres : IConversion
    {
        public int Id => 23;

        public string FromUnit => "square yards";

        public string ToUnit => "acres";

        public double Convert(double value)
        {
            return value * 0.000206612;
        }
    }
    public class SquareYardsToHectares : IConversion
    {
        public int Id => 24;

        public string FromUnit => "square yards";

        public string ToUnit => "hectares";

        public double Convert(double value)
        {
            return value * 8.3613e-5;
        }
    }
    public class SquareYardsToSquareCentimeters : IConversion
    {
        public int Id => 25;

        public string FromUnit => "square yards";

        public string ToUnit => "square centimeters";

        public double Convert(double value)
        {
            return value * 8361.27;
        }
    }
    public class SquareYardsToSquareInches : IConversion
    {
        public int Id => 26;

        public string FromUnit => "square yards";

        public string ToUnit => "square inches";

        public double Convert(double value)
        {
            return value * 1296;
        }
    }
    public class SquareYardsToSquareMillimeters : IConversion
    {
        public int Id => 27;

        public string FromUnit => "square yards";

        public string ToUnit => "square millimeters";

        public double Convert(double value)
        {
            return value * 836127;
        }
    }

    // Square miles
    public class SquareMilesToSquereMeters : IConversion
    {
        public int Id => 28;

        public string FromUnit => "square miles";

        public string ToUnit => "square meters";

        public double Convert(double value)
        {
            return value * 2.58999e6;
        }
    }
    public class SquareMilesToSquereFeet : IConversion
    {
        public int Id => 29;

        public string FromUnit => "square miles";

        public string ToUnit => "square feet";

        public double Convert(double value)
        {
            return value * 2.788e7;
        }
    }
    public class SquareMilesToSquereYards : IConversion
    {
        public int Id => 30;

        public string FromUnit => "square miles";

        public string ToUnit => "square yards";

        public double Convert(double value)
        {
            return value * 3.098e6;
        }
    }
    public class SquareMilesToSquereKilometers : IConversion
    {
        public int Id => 31;

        public string FromUnit => "square miles";

        public string ToUnit => "square kilometers";

        public double Convert(double value)
        {
            return value * 2.58999;
        }
    }
    public class SquareMilesToAcres : IConversion
    {
        public int Id => 32;

        public string FromUnit => "square miles";

        public string ToUnit => "acres";

        public double Convert(double value)
        {
            return value * 640;
        }
    }
    public class SquareMilesToHectares : IConversion
    {
        public int Id => 33;

        public string FromUnit => "square miles";

        public string ToUnit => "hectares";

        public double Convert(double value)
        {
            return value * 258.999;
        }
    }
    public class SquareMilesToSquareCentimeters : IConversion
    {
        public int Id => 34;

        public string FromUnit => "square miles";

        public string ToUnit => "square centimeters";

        public double Convert(double value)
        {
            return value * 2.58999e10;
        }
    }
    public class SquareMilesToSquareInches : IConversion
    {
        public int Id => 35;

        public string FromUnit => "square miles";

        public string ToUnit => "square inches";

        public double Convert(double value)
        {
            return value * 4.014e9;
        }
    }
    public class SquareMilesToSquareMillimeters : IConversion
    {
        public int Id => 36;

        public string FromUnit => "square miles";

        public string ToUnit => "square millimeters";

        public double Convert(double value)
        {
            return value * 2.58999e12;
        }
    }

    // Square kilometers
    public class SquareKilometersToSquereMeters : IConversion
    {
        public int Id => 37;

        public string FromUnit => "square kilometers";

        public string ToUnit => "square meters";

        public double Convert(double value)
        {
            return value * 1e6;
        }
    }
    public class SquareKilometersToSquereFeet : IConversion
    {
        public int Id => 38;

        public string FromUnit => "square kilometers";

        public string ToUnit => "square feet";

        public double Convert(double value)
        {
            return value * 1.076e7;
        }
    }
    public class SquareKilometersToSquereYards : IConversion
    {
        public int Id => 39;

        public string FromUnit => "square kilometers";

        public string ToUnit => "square yards";

        public double Convert(double value)
        {
            return value * 1.196e6;
        }
    }
    public class SquareKilometersToSquereMiles : IConversion
    {
        public int Id => 40;

        public string FromUnit => "square kilometers";

        public string ToUnit => "square miles";

        public double Convert(double value)
        {
            return value * 0.386102;
        }
    }
    public class SquareKilometersToAcres : IConversion
    {
        public int Id => 41;

        public string FromUnit => "square kilometers";

        public string ToUnit => "acres";

        public double Convert(double value)
        {
            return value * 247.105;
        }
    }
    public class SquareKilometersToHectares : IConversion
    {
        public int Id => 42;

        public string FromUnit => "square kilometers";

        public string ToUnit => "hectares";

        public double Convert(double value)
        {
            return value * 100;
        }
    }
    public class SquareKilometersToCentimeters : IConversion
    {
        public int Id => 43;

        public string FromUnit => "square kilometers";

        public string ToUnit => "square centimeters";

        public double Convert(double value)
        {
            return value * 1e10;
        }
    }
    public class SquareKilometersToInches : IConversion
    {
        public int Id => 44;

        public string FromUnit => "square kilometers";

        public string ToUnit => "square inches";

        public double Convert(double value)
        {
            return value * 1.55e9;
        }
    }
    public class SquareKilometersToMillimeters : IConversion
    {
        public int Id => 45;

        public string FromUnit => "square kilometers";

        public string ToUnit => "square millimeters";

        public double Convert(double value)
        {
            return value * 1e12;
        }
    }

    // Acres
    public class AcresToMeters : IConversion
    {
        public int Id => 46;

        public string FromUnit => "acres";

        public string ToUnit => "square meters";

        public double Convert(double value)
        {
            return value * 4046.86;
        }
    }
    public class AcresToSquereFeet : IConversion
    {
        public int Id => 47;

        public string FromUnit => "acres";

        public string ToUnit => "square feet";

        public double Convert(double value)
        {
            return value * 43560;
        }
    }
    public class AcresToSquereYards : IConversion
    {
        public int Id => 48;

        public string FromUnit => "acres";

        public string ToUnit => "square yards";

        public double Convert(double value)
        {
            return value * 4840;
        }
    }
    public class AcresToSquereMiles : IConversion
    {
        public int Id => 49;

        public string FromUnit => "acres";

        public string ToUnit => "square miles";

        public double Convert(double value)
        {
            return value * 0.0015625;
        }
    }
    public class AcresToSquereKilometers : IConversion
    {
        public int Id => 50;

        public string FromUnit => "acres";

        public string ToUnit => "square kilometers";

        public double Convert(double value)
        {
            return value * 0.00404686;
        }
    }
    public class AcresToHectares : IConversion
    {
        public int Id => 51;

        public string FromUnit => "acres";

        public string ToUnit => "hectares";

        public double Convert(double value)
        {
            return value * 404686;
        }
    }
    public class AcresToSquareCentimeters : IConversion
    {
        public int Id => 52;

        public string FromUnit => "acres";

        public string ToUnit => "square centimeters";

        public double Convert(double value)
        {
            return value * 4.04686e7;
        }
    }
    public class AcresToSquareInches : IConversion
    {
        public int Id => 53;

        public string FromUnit => "acres";

        public string ToUnit => "square inches";

        public double Convert(double value)
        {
            return value * 6.273e6;
        }
    }
    public class AcresToSquareMillimeters : IConversion
    {
        public int Id => 54;

        public string FromUnit => "acres";

        public string ToUnit => "square millimeters";

        public double Convert(double value)
        {
            return value * 4.04686e9;
        }
    }

    // Hectares
    public class HectaresToSquereMeters : IConversion
    {
        public int Id => 55;

        public string FromUnit => "hectares";

        public string ToUnit => "square meters";

        public double Convert(double value)
        {
            return value * 10000;
        }
    }
    public class HectaresToSquereFeet : IConversion
    {
        public int Id => 56;

        public string FromUnit => "hectares";

        public string ToUnit => "square feet";

        public double Convert(double value)
        {
            return value * 107639;
        }
    }
    public class HectaresToSquereYards : IConversion
    {
        public int Id => 57;

        public string FromUnit => "hectares";

        public string ToUnit => "square yards";

        public double Convert(double value)
        {
            return value * 11959.9;
        }
    }
    public class HectaresToSquereMiles : IConversion
    {
        public int Id => 58;

        public string FromUnit => "hectares";

        public string ToUnit => "square miles";

        public double Convert(double value)
        {
            return value * 0.00386102;
        }
    }
    public class HectaresToSquereKilometers : IConversion
    {
        public int Id => 59;

        public string FromUnit => "hectares";

        public string ToUnit => "square kilometers";

        public double Convert(double value)
        {
            return value * 0.01;
        }
    }
    public class HectaresToAcres : IConversion
    {
        public int Id => 60;

        public string FromUnit => "hectares";

        public string ToUnit => "acres";

        public double Convert(double value)
        {
            return value * 2.47105;
        }
    }
    public class HectaresToSquareCentimeters : IConversion
    {
        public int Id => 61;

        public string FromUnit => "hectares";

        public string ToUnit => "square centimeters";

        public double Convert(double value)
        {
            return value * 1e8;
        }
    }
    public class HectaresToSquareInches : IConversion
    {
        public int Id => 62;

        public string FromUnit => "hectares";

        public string ToUnit => "square inches";

        public double Convert(double value)
        {
            return value * 1.55e7;
        }
    }
    public class HectaresToSquareMillimeters : IConversion
    {
        public int Id => 63;

        public string FromUnit => "hectares";

        public string ToUnit => "square millimeters";

        public double Convert(double value)
        {
            return value * 1e10;
        }
    }

    // Square centimeters
    public class SquereCentimetersToSquereInches : IConversion
    {
        public int Id => 42;

        public string FromUnit => "square centimeters";

        public string ToUnit => "square inches";

        public double Convert(double value)
        {
            return value * 0.155;
        }
    }
    public class SquereCentimetersToSquereMillimeters : IConversion
    {
        public int Id => 43;

        public string FromUnit => "square centimeters";

        public string ToUnit => "square millimeters";

        public double Convert(double value)
        {
            return value * 100;
        }
    }
    public class SquereCentimetersToSquareMeters : IConversion
    {
        public int Id => 43;

        public string FromUnit => "square centimeters";

        public string ToUnit => "square meters";

        public double Convert(double value)
        {
            return value * 0.0001;
        }
    }
    public class SquereCentimetersToSquareFeet : IConversion
    {
        public int Id => 43;

        public string FromUnit => "square centimeters";

        public string ToUnit => "square feet";

        public double Convert(double value)
        {
            return value * 0.00107639;
        }
    }
    public class SquereCentimetersToSquareYards : IConversion
    {
        public int Id => 43;

        public string FromUnit => "square centimeters";

        public string ToUnit => "square yards";

        public double Convert(double value)
        {
            return value * 0.000119599;
        }
    }
    public class SquereCentimetersToSquareMiles : IConversion
    {
        public int Id => 43;

        public string FromUnit => "square centimeters";

        public string ToUnit => "square miles";

        public double Convert(double value)
        {
            return value * 3.861e-11;
        }
    }
    public class SquereCentimetersToSquareKilometers : IConversion
    {
        public int Id => 43;

        public string FromUnit => "square centimeters";

        public string ToUnit => "square kilometers";

        public double Convert(double value)
        {
            return value * 1e-10;
        }
    }
    public class SquereCentimetersToAcres : IConversion
    {
        public int Id => 43;

        public string FromUnit => "square centimeters";

        public string ToUnit => "acres";

        public double Convert(double value)
        {
            return value * 2.47105e-8;
        }
    }

    // Square inches
    public class SquereInchesToSquereCentimeters : IConversion
    {
        public int Id => 64;

        public string FromUnit => "square inches";

        public string ToUnit => "square centimeters";

        public double Convert(double value)
        {
            return value * 6.4516;
        }
    }
    public class SquereInchesToSquereMillimeters : IConversion
    {
        public int Id => 65;

        public string FromUnit => "square inches";

        public string ToUnit => "square millimeters";

        public double Convert(double value)
        {
            return value * 645.16;
        }
    }
    public class SquereInchesToSquereMeters : IConversion
    {
        public int Id => 66;

        public string FromUnit => "square inches";

        public string ToUnit => "square meters";

        public double Convert(double value)
        {
            return value * 0.00064516;
        }
    }
    public class SquereInchesToSquereFeet : IConversion
    {
        public int Id => 67;

        public string FromUnit => "square inches";

        public string ToUnit => "square feet";

        public double Convert(double value)
        {
            return value * 0.00694444;
        }
    }
    public class SquereInchesToSquereYards : IConversion
    {
        public int Id => 68;

        public string FromUnit => "square inches";

        public string ToUnit => "square yards";

        public double Convert(double value)
        {
            return value * 0.000771605;
        }
    }
    public class SquereInchesToSquereMiles : IConversion
    {
        public int Id => 69;

        public string FromUnit => "square inches";

        public string ToUnit => "square miles";

        public double Convert(double value)
        {
            return value * 2.491e-10;
        }
    }
    public class SquereInchesToSquereKilometers : IConversion
    {
        public int Id => 70;

        public string FromUnit => "square inches";

        public string ToUnit => "square kilometers";

        public double Convert(double value)
        {
            return value * 6.4516e-10;
        }
    }
    public class SquereInchesToAcres : IConversion
    {
        public int Id => 71;

        public string FromUnit => "square inches";

        public string ToUnit => "acres";

        public double Convert(double value)
        {
            return value * 1.5942e-7;
        }
    }
    public class SquereInchesToHectares : IConversion
    {
        public int Id => 72;

        public string FromUnit => "square inches";

        public string ToUnit => "hectares";

        public double Convert(double value)
        {
            return value * 6.4516e-8;
        }
    }

    // Square millimeters
    public class SquereMillimetersToSquereInches : IConversion
    {
        public int Id => 73;

        public string FromUnit => "square millimeters";

        public string ToUnit => "square inches";

        public double Convert(double value)
        {
            return value * 0.0015500031;
        }
    }
    public class SquereMillimetersToSquereCentimeters : IConversion
    {
        public int Id => 74;

        public string FromUnit => "square millimeters";

        public string ToUnit => "square centimeters";

        public double Convert(double value)
        {
            return value * 0.01;
        }
    }
    public class SquereMillimetersToSquereMeters : IConversion
    {
        public int Id => 75;

        public string FromUnit => "square millimeters";

        public string ToUnit => "square meters";

        public double Convert(double value)
        {
            return value * 1e-6;
        }
    }
    public class SquereMillimetersToSquereFeet : IConversion
    {
        public int Id => 76;

        public string FromUnit => "square millimeters";

        public string ToUnit => "square feet";

        public double Convert(double value)
        {
            return value * 1.07639e-5;
        }
    }
    public class SquereMillimetersToSquereYards : IConversion
    {
        public int Id => 77;

        public string FromUnit => "square millimeters";

        public string ToUnit => "square yards";

        public double Convert(double value)
        {
            return value * 1.19599e-6;
        }
    }
    public class SquereMillimetersToSquereMiles : IConversion
    {
        public int Id => 78;

        public string FromUnit => "square millimeters";

        public string ToUnit => "square miles";

        public double Convert(double value)
        {
            return value * 3.861e-13;
        }
    }
    public class SquereMillimetersToSquereKilometers : IConversion
    {
        public int Id => 79;

        public string FromUnit => "square millimeters";

        public string ToUnit => "square kilometers";

        public double Convert(double value)
        {
            return value * 1e-12;
        }
    }
    public class SquereMillimetersToAcres : IConversion
    {
        public int Id => 80;

        public string FromUnit => "square millimeters";

        public string ToUnit => "acres";

        public double Convert(double value)
        {
            return value * 2.47105e-10;
        }
    }
    public class SquereMillimetersToHectares : IConversion
    {
        public int Id => 81;

        public string FromUnit => "square millimeters";

        public string ToUnit => "hectares";

        public double Convert(double value)
        {
            return value * 1e-10;
        }
    }
}

