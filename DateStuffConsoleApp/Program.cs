using System;
using System.Collections.Generic;
using System.Linq;

namespace DateStuffConsoleApp
{
    partial class Program
    {
        static void Main(string[] args)
        {

            //foreach (var dateTime in DateTimeHelpers.NextWeeksDates())
            //{
            //    Console.WriteLine(dateTime.ToShortDateString());
            //}

            var dates = DateTimeHelpers.GetMonthDays(2);
            foreach (var date in dates)
            {
                Console.WriteLine(date.ToShortDateString());
            }



            Console.ReadLine();
        }


    }

    public static class DateTimeHelpers
    {
        public static DateTime Next(this DateTime from, DayOfWeek dayOfWeek)
        {
            int start = (int)from.DayOfWeek;
            int target = (int)dayOfWeek;
            if (target <= start)
            {
                target += 7;
            }

            return from.AddDays(target - start);
        }

        public static List<DateTime> NextWeeksDates() =>
            Enumerable.Range(0, 7).Select(index => 
                DateTime.Now.Next(DayOfWeek.Sunday).AddDays(index)).ToList();

        public static List<DateTime> GetMonthDays(int month)
        {
            var year = DateTime.Now.Year;

            return Enumerable.Range(1, DateTime.DaysInMonth(year, month))
                .Select(day => new DateTime(year, month, day))
                .ToList();
        }
    }
}
