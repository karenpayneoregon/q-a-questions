namespace StackDemo.Classes;

public static class DateTimeOffsetExtensions
{
    public static void Deconstruct(this DateTimeOffset date, out int day, out int month, out int year)
        => (day, month, year) = (date.Day, date.Month, date.Year);

    public static void Deconstruct(this DateTimeOffset date, out int day, out int month, out int year, out TimeSpan offset)
        => (day, month, year, offset) = (date.Day, date.Month, date.Year, date.Offset);
}