using System;

namespace ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        DateTime startDate = new(2022, 10, 1);
        DateTime endDate = new(2022, 10, LastDayOfMonth);
        DumpDates(endDate, startDate);
        Console.ReadLine();
    }

    private static void DumpDates(DateTime endDate, DateTime startDate)
    {
        TimeSpan diff = endDate - startDate;
        int days = diff.Days;

        for (var index = 0; index <= days; index++)
        {
            var testDate = startDate.AddDays(index);
            switch (testDate)
            {
                case { DayOfWeek: DayOfWeek.Saturday }:
                case { DayOfWeek: DayOfWeek.Sunday }:
                    Console.WriteLine(testDate.ToShortDateString());
                    break;
            }
        }
    }

    private static int LastDayOfMonth =>
        DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
}