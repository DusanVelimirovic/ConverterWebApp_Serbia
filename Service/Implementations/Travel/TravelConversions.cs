using Converter_Web_Application.Service.Base;
/// <summary>
/// Conversions strategies
/// </summary>
public class CalculateTravelTime : ITravelConversion
{
    public int Id => 1;
    public string FromUnit => "distance";
    public string ToUnit => "time";
    public double Convert(double distance, double speed)
    {
        return distance / speed;
    }
}

public class CalculateTravelSpeed : ITravelConversion
{
    public int Id => 2;
    public string FromUnit => "distance";
    public string ToUnit => "speed";
    public double Convert(double distance, double time)
    {
        return distance / time;
    }
}

public class MphToKmh : IConversion
{
    public int Id => 1;
    public string FromUnit => "mph";
    public string ToUnit => "km/h";
    public double Convert(double value)
    {
        return value * 1.60934; // 1 mile = 1.60934 km
    }
}

public class KmhToMph : IConversion
{
    public int Id => 2;
    public string FromUnit => "km/h";
    public string ToUnit => "mph";
    public double Convert(double value)
    {
        return value / 1.60934; // 1 km = 0.621371 miles
    }
}

