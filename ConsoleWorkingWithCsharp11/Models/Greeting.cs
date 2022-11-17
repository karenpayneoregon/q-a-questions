using static System.DateTime;
namespace ConsoleWorkingWithCsharp11.Models;

public class Greeting
{
    public class For
    {
        public static string TimeOfDay() => Now.Hour switch
        {
            <= 12 => "Good Morning",
            <= 16 => "Good Afternoon",
            <= 20 => "Good Evening",
            _ => "Good Night"
        };
    }
}