namespace UtilityLibrary.LanguageExtensions;
public static class Extension
{
    public static double ToDouble(this TimeSpan o) => o.TotalDays;
}
