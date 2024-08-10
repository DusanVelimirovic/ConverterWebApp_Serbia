using Converter_Web_Application.Service.Implementations.Unit;

namespace Converter_Web_Application.Service.Registrations.Unit
{
    /// <summary>
    /// Registers various time conversions with the ConversionManagerService.
    /// </summary>
    public class TimeConversions_registrations
    {
        /// <summary>
        /// Registers all time conversions in the provided ConversionManagerService.
        /// </summary>
        /// <param name="service">The ConversionManagerService where conversions will be registered.</param>
        public static void Register(ConversionManagerService service)
        {
            // Register conversions for seconds to other units
            service.RegisterConversion(new SecondsToMinutes());
            service.RegisterConversion(new SecondsToHours());
            service.RegisterConversion(new SecondsToDays());
            service.RegisterConversion(new SecondsToWeeks());
            service.RegisterConversion(new SecondsToMonths());
            service.RegisterConversion(new SecondsToYears());

            // Register conversions for minutes to other units
            service.RegisterConversion(new MinutesToSeconds());
            service.RegisterConversion(new MinutesToHours());
            service.RegisterConversion(new MinutesToDays());
            service.RegisterConversion(new MinutesToWeeks());
            service.RegisterConversion(new MinutesToMonths());
            service.RegisterConversion(new MinutesToYears());

            // Register conversions for hours to other units
            service.RegisterConversion(new HoursToSeconds());
            service.RegisterConversion(new HoursToMinutes());
            service.RegisterConversion(new HoursToDays());
            service.RegisterConversion(new HoursToWeeks());
            service.RegisterConversion(new HoursToMonths());
            service.RegisterConversion(new HoursToYears());

            // Register conversions for days to other units
            service.RegisterConversion(new DaysToSeconds());
            service.RegisterConversion(new DaysToMinutes());
            service.RegisterConversion(new DaysToHours());
            service.RegisterConversion(new DaysToWeeks());
            service.RegisterConversion(new DaysToMonths());
            service.RegisterConversion(new DaysToYears());

            // Register conversions for weeks to other units
            service.RegisterConversion(new WeeksToSeconds());
            service.RegisterConversion(new WeeksToMinutes());
            service.RegisterConversion(new WeeksToHours());
            service.RegisterConversion(new WeeksToDays());
            service.RegisterConversion(new WeeksToMonths());
            service.RegisterConversion(new WeeksToYears());

            // Register conversions for months to other units
            service.RegisterConversion(new MonthsToSeconds());
            service.RegisterConversion(new MonthsToMinutes());
            service.RegisterConversion(new MonthsToHours());
            service.RegisterConversion(new MonthsToDays());
            service.RegisterConversion(new MonthsToWeeks());
            service.RegisterConversion(new MonthsToYears());

            // Register conversions for years to other units
            service.RegisterConversion(new YearsToSeconds());
            service.RegisterConversion(new YearsToMinutes());
            service.RegisterConversion(new YearsToHours());
            service.RegisterConversion(new YearsToDays());
            service.RegisterConversion(new YearsToWeeks());
            service.RegisterConversion(new YearsToMonths());
        }
    }
}
