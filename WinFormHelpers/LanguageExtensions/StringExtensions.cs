namespace WinFormHelpers.LanguageExtensions
{

    public static class StringExtensions
    {
        public static string EscapeApostrophe(this string sender) 
            => sender.Replace("'", "''");
    }
}
