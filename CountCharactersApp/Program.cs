using CountCharactersApp.Classes;

namespace CountCharactersApp;

internal partial class Program
{
    static void Main(string[] args)
    {
        AnsiConsole.MarkupLine("[yellow]Hello[/]");
        
        var (letterCount, numberCount, specialCount) = StringHelpers.GetDetails(":AC11~F2+z");


        
        Console.ReadLine();
    }
}