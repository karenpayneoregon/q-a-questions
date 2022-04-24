using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Versioning
{
    public class Helpers
    {
        public static List<Container> GetZeros(string value)
        {
            List<Container> list = new();
            Regex regex = new(@"\d+(\.\d+)?");
            var matches = regex.Matches(value);
            int index = 0;

            foreach (Match match in matches)
            {
                var length = match.Value.Replace("0.", "").Length;
                list.Add(new Container() {Index = index, Value = match.Value, Length = length});
                index++;
            }

            return list;
        }
    }
}