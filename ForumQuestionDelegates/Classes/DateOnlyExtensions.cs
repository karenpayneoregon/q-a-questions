namespace ForumQuestionDelegates.Classes;

internal static class DateOnlyExtensions
{
    public static bool IsWeekend(this DateTime self)
        => self.DayOfWeek is DayOfWeek.Sunday or DayOfWeek.Saturday;

    public static bool IsWeekDay(this DateTime self)
        => !self.IsWeekend();

}