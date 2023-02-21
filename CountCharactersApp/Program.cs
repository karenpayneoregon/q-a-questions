using CountCharactersApp.Classes;
using CountCharactersApp.Models;

namespace CountCharactersApp;

internal partial class Program
{
    static void Main(string[] args)
    {
        AnsiConsole.MarkupLine("[yellow]Hello[/]");
        
        var (letterCount, numberCount, specialCount) = StringHelpers.GetDetails(":AC11~F2+z");


        IOrderedEnumerable<Item> results = "Karen Payne posted this".Occurrences();
        foreach (var item in results)
        {
            Console.WriteLine($"'{item.Character}' {item.Occurrences}");
        }

        Console.WriteLine(results.Select(x => x.Occurrences).Sum());
        
        Console.ReadLine();
    }
}