using Converter_Web_Application.Service.Base;

namespace Converter_Web_Application.Service.Implementations.Unit
{
    /// <summary>
    /// Conversions strategies
    /// </summary>

    // Seconds
    public class SecondsToMinutes : IConversion
    {
        public int Id => 1;

        public string FromUnit => "seconds";

        public string ToUnit => "minutes";

        public double Convert(double value)
        {
            return value / 60;
        }
    }
    public class SecondsToHours : IConversion
    {
        public int Id => 2;

        public string FromUnit => "seconds";

        public string ToUnit => "hours";

        public double Convert(double value)
        {
            return value / 3600;
        }
    }
    public class SecondsToDays : IConversion
    {
        public int Id => 3;

        public string FromUnit => "seconds";

        public string ToUnit => "days";

        public double Convert(double value)
        {
            return value / 86400;
        }
    }
    public class SecondsToWeeks : IConversion
    {
        public int Id => 4;

        public string FromUnit => "seconds";

        public string ToUnit => "weeks";

        public double Convert(double value)
        {
            return value / 604800;
        }
    }
    public class SecondsToMonths : IConversion
    {
        public int Id => 5;

        public string FromUnit => "seconds";

        public string ToUnit => "months";

        public double Convert(double value)
        {
            return value / 2.628e+6;
        }
    }
    public class SecondsToYears : IConversion
    {
        public int Id => 6;

        public string FromUnit => "seconds";

        public string ToUnit => "years";

        public double Convert(double value)
        {
            return value / 3.154e+7;
        }
    }

    // Minutes
    public class MinutesToSeconds : IConversion
    {
        public int Id => 7;

        public string FromUnit => "minutes";

        public string ToUnit => "seconds";

        public double Convert(double value)
        {
            return value * 60;
        }
    }
    public class MinutesToHours : IConversion
    {
        public int Id => 8;

        public string FromUnit => "minutes";

        public string ToUnit => "hours";

        public double Convert(double value)
        {
            return value / 60;
        }
    }
    public class MinutesToDays : IConversion
    {
        public int Id => 9;

        public string FromUnit => "minutes";

        public string ToUnit => "days";

        public double Convert(double value)
        {
            return value / 1440;
        }
    }
    public class MinutesToWeeks : IConversion
    {
        public int Id => 10;

        public string FromUnit => "minutes";

        public string ToUnit => "weeks";

        public double Convert(double value)
        {
            return value / 10080;
        }
    }
    public class MinutesToMonths : IConversion
    {
        public int Id => 11;

        public string FromUnit => "minutes";

        public string ToUnit => "months";

        public double Convert(double value)
        {
            return value / 43800;   // Minutes to months: value / 43800 (assuming 30.44 days per month)
        }
    }
    public class MinutesToYears : IConversion
    {
        public int Id => 12;

        public string FromUnit => "minutes";

        public string ToUnit => "years";

        public double Convert(double value)
        {
            return value / 525600; // Minutes to years: value / 525600 (assuming 365.25 days per year)
        }
    }

    // Hours
    public class HoursToSeconds : IConversion
    {
        public int Id => 13;

        public string FromUnit => "hours";

        public string ToUnit => "seconds";

        public double Convert(double value)
        {
            return value * 3600;
        }
    }
    public class HoursToMinutes : IConversion
    {
        public int Id => 14;

        public string FromUnit => "hours";

        public string ToUnit => "minutes";

        public double Convert(double value)
        {
            return value * 60;
        }
    }
    public class HoursToDays : IConversion
    {
        public int Id => 15;

        public string FromUnit => "hours";

        public string ToUnit => "days";

        public double Convert(double value)
        {
            return value * 60;
        }
    }
    public class HoursToWeeks : IConversion
    {
        public int Id => 16;

        public string FromUnit => "hours";

        public string ToUnit => "weeks";

        public double Convert(double value)
        {
            return value / 168;
        }
    }
    public class HoursToMonths : IConversion
    {
        public int Id => 17;

        public string FromUnit => "hours";

        public string ToUnit => "months";

        public double Convert(double value)
        {
            return value / 730;   // Hours to months: value / 730 (assuming 30.44 days per month)
        }
    }
    public class HoursToYears : IConversion
    {
        public int Id => 18;

        public string FromUnit => "hours";

        public string ToUnit => "years";

        public double Convert(double value)
        {
            return value / 8760;   // Hours to years: value / 8760 (assuming 365.25 days per year)
        }
    }

    // Days
    public class DaysToSeconds : IConversion
    {
        public int Id => 19;

        public string FromUnit => "days";

        public string ToUnit => "seconds";

        public double Convert(double value)
        {
            return value * 86400;
        }
    }
    public class DaysToMinutes : IConversion
    {
        public int Id => 20;

        public string FromUnit => "days";

        public string ToUnit => "minutes";

        public double Convert(double value)
        {
            return value * 1440;
        }
    }
    public class DaysToHours : IConversion
    {
        public int Id => 21;

        public string FromUnit => "days";

        public string ToUnit => "hours";

        public double Convert(double value)
        {
            return value * 24;
        }
    }
    public class DaysToWeeks : IConversion
    {
        public int Id => 22;

        public string FromUnit => "days";

        public string ToUnit => "weeks";

        public double Convert(double value)
        {
            return value / 7;
        }
    }
    public class DaysToMonths : IConversion
    {
        public int Id => 23;

        public string FromUnit => "days";

        public string ToUnit => "months";

        public double Convert(double value)
        {
            return value / 30.44;
        }
    }
    public class DaysToYears : IConversion
    {
        public int Id => 24;

        public string FromUnit => "days";

        public string ToUnit => "years";

        public double Convert(double value)
        {
            return value / 365.25;
        }
    }

    // Weeks
    public class WeeksToSeconds : IConversion
    {
        public int Id => 25;

        public string FromUnit => "weeks";

        public string ToUnit => "seconds";

        public double Convert(double value)
        {
            return value * 604800;
        }
    }
    public class WeeksToMinutes : IConversion
    {
        public int Id => 26;

        public string FromUnit => "weeks";

        public string ToUnit => "minutes";

        public double Convert(double value)
        {
            return value * 10080;
        }
    }
    public class WeeksToHours : IConversion
    {
        public int Id => 27;

        public string FromUnit => "weeks";

        public string ToUnit => "hours";

        public double Convert(double value)
        {
            return value * 168;
        }
    }
    public class WeeksToDays : IConversion
    {
        public int Id => 28;

        public string FromUnit => "weeks";

        public string ToUnit => "days";

        public double Convert(double value)
        {
            return value * 7;
        }
    }
    public class WeeksToMonths : IConversion
    {
        public int Id => 29;

        public string FromUnit => "weeks";

        public string ToUnit => "months";

        public double Convert(double value)
        {
            return value / 4.34812;    // Weeks to months: value / 4.34812 (assuming 30.44 days per month)
        }
    }
    public class WeeksToYears : IConversion
    {
        public int Id => 30;

        public string FromUnit => "weeks";

        public string ToUnit => "years";

        public double Convert(double value)
        {
            return value / 52.1786;    // Weeks to years: value / 52.1786 (assuming 365.25 days per year)
        }
    }

    // Months
    public class MonthsToSeconds : IConversion
    {
        public int Id => 31;

        public string FromUnit => "months";

        public string ToUnit => "seconds";

        public double Convert(double value)
        {
            return value * 2.628e+6;    // Months to seconds: value* 2.628e+6 (assuming 30.44 days per month)
        }
    }
    public class MonthsToMinutes : IConversion
    {
        public int Id => 32;

        public string FromUnit => "months";

        public string ToUnit => "minutes";

        public double Convert(double value)
        {
            return value * 43800;    // Months to seconds: value* 2.628e+6 (assuming 30.44 days per month)
        }
    }
    public class MonthsToHours : IConversion
    {
        public int Id => 33;

        public string FromUnit => "months";

        public string ToUnit => "hours";

        public double Convert(double value)
        {
            return value * 730;    // Months to hours: value* 730 (assuming 30.44 days per month)
        }
    }
    public class MonthsToDays : IConversion
    {
        public int Id => 34;

        public string FromUnit => "months";

        public string ToUnit => "days";

        public double Convert(double value)
        {
            return value * 30.44;    // Months to days: value* 30.44 (assuming 30.44 days per month)
        }
    }
    public class MonthsToWeeks : IConversion
    {
        public int Id => 35;

        public string FromUnit => "months";

        public string ToUnit => "weeks";

        public double Convert(double value)
        {
            return value * 4.34812;    // Months to weeks: value* 4.34812 (assuming 30.44 days per month)
        }
    }
    public class MonthsToYears : IConversion
    {
        public int Id => 36;

        public string FromUnit => "months";

        public string ToUnit => "years";

        public double Convert(double value)
        {
            return value / 12;
        }
    }

    // Years
    public class YearsToSeconds : IConversion
    {
        public int Id => 37;

        public string FromUnit => "years";

        public string ToUnit => "seconds";

        public double Convert(double value)
        {
            return value * 3.154e+7;    // Years to seconds: value* 3.154e+7 (assuming 365.25 days per year)
        }
    }
    public class YearsToMinutes : IConversion
    {
        public int Id => 38;

        public string FromUnit => "years";

        public string ToUnit => "minutes";

        public double Convert(double value)
        {
            return value * 525600;    // Years to minutes: value* 525600 (assuming 365.25 days per year)
        }
    }
    public class YearsToHours : IConversion
    {
        public int Id => 39;

        public string FromUnit => "years";

        public string ToUnit => "hours";

        public double Convert(double value)
        {
            return value * 8760;    // Years to hours: value* 8760 (assuming 365.25 days per year)
        }
    }
    public class YearsToDays : IConversion
    {
        public int Id => 40;

        public string FromUnit => "years";

        public string ToUnit => "days";

        public double Convert(double value)
        {
            return value * 365.25;    // Years to days: value* 365.25 (assuming 365.25 days per year)
        }
    }
    public class YearsToWeeks : IConversion
    {
        public int Id => 41;

        public string FromUnit => "years";

        public string ToUnit => "weeks";

        public double Convert(double value)
        {
            return value * 52.1786;    // Years to weeks: value* 52.1786 (assuming 365.25 days per year)
        }
    }
    public class YearsToMonths : IConversion
    {
        public int Id => 42;

        public string FromUnit => "years";

        public string ToUnit => "months";

        public double Convert(double value)
        {
            return value * 12;
        }
    }
}

