using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace ChristmasTree;
internal partial class Program
{
    [ModuleInitializer]
    public static void Init()
    {
        AnsiConsole.MarkupLine("");
        Console.Title = $"Christmas {DateTime.Now.Year}";
        WindowUtility.SetConsoleWindowPosition(WindowUtility.AnchorWindow.Center);
    }
}
