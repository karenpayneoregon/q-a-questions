using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HidePathInExceptions.Classes
{
    internal class WeeklyDateRanges
    {
        public void Example()
        {
            string startDay = ""; //ConfigurationManager.AppSettings["StartDayOfWeek"];
            DateTime dayInWeek = DateTime.Now;
            Tuple<DateTime, DateTime> academicWeek = CampusVueDateRange(dayInWeek, startDay);

            Console.WriteLine("Default First Day of Week: {0}", GetFirstDayOfWeek(DateTime.Now));
            Console.WriteLine("Specified First Day of Week: {0}", GetFirstDayOfWeek(dayInWeek, startDay));
            Console.WriteLine("Default Last Day of Week: {0}", GetLastDayOfWeek(dayInWeek));
            Console.WriteLine("Specified Last Day of Week: {0}", GetLastDayOfWeek(dayInWeek, startDay));
            Console.WriteLine("This academic week is from {0} to {1}", academicWeek.Item1, academicWeek.Item2);
        }
        /// <summary>
        /// Returns the first day of the week that the specified date is in
        /// using the current culture.
        /// </summary>
        /// <param name="dayInWeek"></param>
        /// <returns></returns>
        private static DateTime GetFirstDayOfWeek(DateTime dayInWeek)
        {
            CultureInfo defaultCultureInfo = CultureInfo.CurrentCulture;
            return GetFirstDayOfWeek(dayInWeek, defaultCultureInfo);
        }

        private static DateTime GetFirstDayOfWeek(DateTime dayInWeek, DayOfWeek firstDay)
        {
            DateTime firstDayInWeek = dayInWeek.Date;

            while (firstDayInWeek.DayOfWeek != firstDay)
            {
                firstDayInWeek = firstDayInWeek.AddDays(-1);
            }

            return firstDayInWeek;
        }

        private static DateTime GetFirstDayOfWeek(DateTime dayInWeek, string startDay)
        {
            DayOfWeek firstDay = ParseEnum<DayOfWeek>(startDay);
            return GetFirstDayOfWeek(dayInWeek, firstDay);
        }
        private static DateTime GetFirstDayOfWeek(DateTime dayInWeek, CultureInfo cultureInfo)
        {
            DayOfWeek firstDay = cultureInfo.DateTimeFormat.FirstDayOfWeek;
            return GetFirstDayOfWeek(dayInWeek, firstDay);
        }

        private static DateTime GetLastDayOfWeek(DateTime dayInWeek)
        {
            CultureInfo defaultCultureInfo = CultureInfo.CurrentCulture;
            return GetLastDayOfWeek(dayInWeek, defaultCultureInfo);
        }

        private static DateTime GetLastDayOfWeek(DateTime dayInWeek, DayOfWeek firstDay)
        {
            DateTime firstDayInWeek = GetFirstDayOfWeek(dayInWeek, firstDay);
            return firstDayInWeek.AddDays(7);
        }

        private static DateTime GetLastDayOfWeek(DateTime dayInWeek, string startDay)
        {
            DateTime firstDayInWeek = GetFirstDayOfWeek(dayInWeek, startDay);
            return firstDayInWeek.AddDays(7);
        }
        private static DateTime GetLastDayOfWeek(DateTime dayInWeek, CultureInfo cultureInfo)
        {
            DateTime firstDayInWeek = GetFirstDayOfWeek(dayInWeek, cultureInfo);
            return firstDayInWeek.AddDays(7);
        }

        private static Tuple<DateTime, DateTime> CampusVueDateRange(DateTime dayInWeek, string startDay)
        {
            DateTime firstDayOfWeek = GetFirstDayOfWeek(dayInWeek, startDay).AddSeconds(1);
            DateTime lastDayOfWeek = GetLastDayOfWeek(dayInWeek, startDay);

            return new Tuple<DateTime, DateTime>(firstDayOfWeek, lastDayOfWeek);
        }

        private static T ParseEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }
    }
}
