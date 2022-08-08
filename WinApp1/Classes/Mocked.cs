using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace WinApp1.Classes
{
    public class Mocked
    {
        public static List<string> EnglishMonthList => Enumerable.Range(1, 12)
            .Select((index) =>
                DateTimeFormatInfo.CurrentInfo.GetMonthName(index)).ToList();

        public static List<string> PossibleTimeZones(DateTimeOffset offsetTime)
        {
            var list = new List<string>();
            TimeSpan offset = offsetTime.Offset;

            var timeZones = TimeZoneInfo.GetSystemTimeZones();

            list.AddRange(from TimeZoneInfo timeZone in timeZones
                where timeZone.GetUtcOffset(offsetTime.DateTime).Equals(offset)
                select timeZone.DaylightName);

            return list;
        }
    }
}