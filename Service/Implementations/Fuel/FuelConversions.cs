using Converter_Web_Application.Service.Base;

namespace Converter_Web_Application.Service.Implementations
{
    /// <summary>
    /// Conversions strategies
    /// </summary>

    public class MilesPerGallonToLitersPer100Km : IFuelConversion
    {
        public int Id => 1;
        public string FromUnit => "MPG";
        public string ToUnit => "L/100km";

        public double Convert(double value1, double value2 = 0, double value3 = 0)
        {
            return 235.214 / value1;
        }
    }

    public class LitersPer100KmToMilesPerGallon : IFuelConversion
    {
        public int Id => 2;
        public string FromUnit => "L/100km";
        public string ToUnit => "MPG";

        public double Convert(double value1, double value2 = 0, double value3 = 0)
        {
            return 235.214 / value1;
        }
    }

    public class MpgToLiters : IFuelConversion
    {
        public int Id => 3;
        public string FromUnit => "MPG";
        public string ToUnit => "liters";

        public double Convert(double value1, double value2 = 0, double value3 = 0)
        {
            return 3.78541 / (value1 / 100);
        }
    }

    public class LitersToMpg : IFuelConversion
    {
        public int Id => 4;
        public string FromUnit => "liters";
        public string ToUnit => "MPG";

        public double Convert(double value1, double value2 = 0, double value3 = 0)
        {
            return 100 / (value1 / 3.78541);
        }
    }

    public class AverageFuelConsumption : IFuelConversion
    {
        public int Id => 5;
        public string FromUnit => "distance";
        public string ToUnit => "fuel";

        public double Convert(double distance, double fuel, double value3 = 0)
        {
            return (fuel / distance) * 100;
        }
    }

    public class RequiredFuelForMileage : IFuelConversion
    {
        public int Id => 6;
        public string FromUnit => "distance";
        public string ToUnit => "fuel";

        public double Convert(double distance, double averageConsumption, double value3 = 0)
        {
            return (averageConsumption / 100) * distance;
        }
    }

    public class PossibleMileageWithFuel : IFuelConversion
    {
        public int Id => 7;
        public string FromUnit => "fuel";
        public string ToUnit => "distance";

        public double Convert(double fuel, double averageConsumption, double value3 = 0)
        {
            return (fuel * 100) / averageConsumption;
        }
    }

    public class TravelDistanceWithBudget : IFuelConversion
    {
        public int Id => 8;
        public string FromUnit => "budget";
        public string ToUnit => "distance";

        public double Convert(double budget, double fuelEfficiency, double fuelPrice)
        {
            return (budget / fuelPrice) * fuelEfficiency;
        }
    }
}
