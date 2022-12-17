// ReSharper disable once CheckNamespace

using Range = HidePathInExceptions.Classes.Range;

namespace ConsoleApp2;

public static class DateTimeHelpers
{
    public static DateOnly Next(this DateOnly from, DayOfWeek dayOfWeek)
    {
        int start = (int)from.DayOfWeek;
        int target = (int)dayOfWeek;

        if (target <= start)
        {
            target += 7;
        }

        return from.AddDays(target - start);
    }

    public static List<DateOnly> NextWeeksDates() 
        => Enumerable.Range(0, 7).Select(index =>
            DateOnly.FromDateTime(DateTime.Now).Next(DayOfWeek.Sunday).AddDays(index))
            .ToList();

    public static List<DateOnly> GetNextWeeksDates(DateOnly dateTime)
        => Enumerable.Range(0, 7).Select(index =>
                dateTime.Next(DayOfWeek.Sunday).AddDays(index))
            .ToList();

    public static List<DateOnly> GetNextWeeksDates(DateTime dateTime)
        => Enumerable.Range(0, 7).Select(index =>
                DateOnly.FromDateTime(dateTime).Next(DayOfWeek.Sunday).AddDays(index))
            .ToList();
    public static List<DateOnly> GetMonthDays(int month)
    {
        var year = DateTime.Now.Year;

        return Enumerable.Range(1, DateTime.DaysInMonth(year, month))
            .Select(day => new DateOnly(year, month, day))
            .ToList();
    }

    public static string MonthName 
        => CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month);

    public static IEnumerable<Range> GetRange(int year, int month)
    {
        var start = new DateTime(year, month, 1).AddDays(-6);
        var end = new DateTime(year, month, 1).AddMonths(1).AddDays(-1);
        for (var date = start; date <= end; date = date.AddDays(1))
        {
            if (date.DayOfWeek == DayOfWeek.Sunday)
            {
                yield return new Range(date);
            }
        }
    }
}