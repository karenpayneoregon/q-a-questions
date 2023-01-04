namespace GetDateTimeFromWebApp.Classes;
public static class Extensions
{

    /// <summary>
    /// Get person's age in years
    /// </summary>
    public static int Age(this DateTime? sender)
    {
        if (sender.HasValue)
        {
            DateTime today = DateTime.Today;
            
            var age = today.Year - sender.Value.Year;
            if (sender.Value.Date > today.AddYears(-age)) age--;
            return age;
        }
        else
        {
            return 0;
        }
    }

    public static void Deconstruct(this DateOnly date, out int day, out int month, out int year) =>
        (day, month, year) = (date.Day, date.Month, date.Year);

    public static void Deconstruct(this DateTime date, out int day, out int month, out int year ) =>
        (day, month, year) = (date.Day, date.Month, date.Year);
}
