using ConsoleApp2;
using HidePathInExceptions.Classes;

namespace HidePathInExceptions
{
    internal partial class Program
    {
        static async Task Main(string[] args)
        {
            await Task.Delay(0);
            //Dump();


            DayOfWeek weekStart = DayOfWeek.Monday;
            DateTime startingDate = DateTime.Today;

            while (startingDate.DayOfWeek != weekStart)
                startingDate = startingDate.AddDays(-1);

            DateTime previousWeekStart = startingDate.AddDays(-7);
            DateTime previousWeekEnd = startingDate.AddDays(-1);

            Console.WriteLine(previousWeekStart);
            Console.WriteLine(previousWeekEnd);

            Console.WriteLine();

            List<DateOnly> sundays = GetDates(DateTime.Now);
            Console.WriteLine("Sundays");
            foreach (DateOnly sunday in sundays)
            {
                Console.WriteLine(sunday);
                var days = DateTimeHelpers.GetNextWeeksDates(sunday);

                Console.WriteLine($"  {string.Join(",", days.Select(x => x.Day).ToArray())}");

            }

            Console.WriteLine();

            foreach (var item in DateTimeHelpers.GetRange(2022, 10))
            {
                Console.WriteLine($"{item.Start:MM/dd/yyyy}  {item.End:MM/dd/yyyy}");
                
            }

            DumpMe();

            Console.ReadLine();
        }

        static void DumpMe()
        {
            // Get the weeks in a month

            DateTime date = DateTime.Today;
            // first generate all dates in the month of 'date'
            var dates = Enumerable.Range(1, DateTime.DaysInMonth(date.Year, date.Month)).Select(n => new DateTime(date.Year, date.Month, n));
            // then filter the only the start of weeks
            var firstDays = from d in dates
                where d.DayOfWeek == DayOfWeek.Monday
                select d;

            new DateTime(2022,10,1).GetWeeks(DayOfWeek.Sunday);
            Console.WriteLine();
        }
 
        private static void Dump()
        {


            var dates = DateTimeHelpers.GetMonthDays(DateTime.Now.Month);
            var chunked = dates.Chunk(7).ToList();


            Console.WriteLine($"Dates in {DateTimeHelpers.MonthName}\n");

            foreach (var item in chunked)
            {
                Console.WriteLine(string.Join(",", item));
            }

            Console.WriteLine();
            Console.WriteLine("Next week's dates");
            var nextWeeksDates = DateTimeHelpers.NextWeeksDates();

            Console.WriteLine(string.Join(",", nextWeeksDates));
        }

        private static List<DateOnly> GetDates(DateTime sender)
        {
            List<DateOnly> list = new();

            sender = sender.AddDays(Convert.ToDouble(-sender.Day + 1));
            DateTime dateTime = sender.AddMonths(1).AddDays(Convert.ToDouble(-1));

            while (sender < dateTime)
            {
                if (sender.DayOfWeek == DayOfWeek.Sunday)
                {
                    list.Add(DateOnly.FromDateTime(sender));
                }

                sender = sender.AddDays(1.0);
            }

            return list;
        }
    }
}