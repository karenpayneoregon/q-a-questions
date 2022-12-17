using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HidePathInExceptions.Classes
{
    internal static class HelperExtensions
    {
        public static IEnumerable<DateTime> GetWeeks(this DateTime date, DayOfWeek startDay)
        {
            List<DateTime> list = new();
            DateTime first = new(date.Year, date.Month, 1);

            for (var i = first; i < first.AddMonths(1); i = i.AddDays(1))
            {
                if (i.DayOfWeek == startDay)
                {
                    list.Add(i);
                }
            }

            return list;
        }
    }
}
