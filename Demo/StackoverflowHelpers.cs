using System;

namespace Demo
{
    /// <summary>
    /// All this code is from Stackoverflow post
    /// </summary>
    public class StackoverflowHelpers
    {
        public static string RandomDigits(int length)
        {
            var random = new Random();
            string s = string.Empty;
            for (int i = 0; i < length; i++)
                s = string.Concat(s, random.Next(10).ToString());
            return s;
            
        }
        public static string PhoneNumber(string value)
        {
            if (string.IsNullOrEmpty(value)) return string.Empty;
            value = new System.Text.RegularExpressions.Regex(@"\D")
                .Replace(value, string.Empty);
            value = value.TrimStart('1');
            if (value.Length == 7)
                return Convert.ToInt64(value).ToString("###-####");
            if (value.Length == 10)
                return Convert.ToInt64(value).ToString("###-###-####");
            if (value.Length > 10)
                return Convert.ToInt64(value)
                    .ToString("###-###-#### " + new string('#', (value.Length - 10)));
            return value;
        }

        public static string FormattedPhoneNumber()
        {
            return PhoneNumber(RandomDigits(10));
        }
    }

}
