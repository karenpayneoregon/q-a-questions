using ConsoleWorkingWithCsharp11.Models;
using static ConsoleWorkingWithCsharp11.Classes.Helpers;

// ReSharper disable once CheckNamespace
namespace ConsoleWorkingWithCsharp11;

internal partial class Program
{
    private static void NewLineInterpolations()
    {
        Console.WriteLine($"Greeting is {Greeting.For.TimeOfDay()}");
    }

    private static void GenericMath()
    {
        var integers = new[] { 1, 2, 3, 4, 5 };
        var doubles = new[] { 0.1, 0.7, 1.1, 8.3 };

        AnsiConsole.MarkupLine($"Add two int with Helpers.Add [white on blue]{Add(1, 2)}[/]");
        AnsiConsole.MarkupLine($"Add two double with Helpers.Add [yellow on blue]{Add(1.5m, 2.45m)}[/]");

        AnsiConsole.MarkupLine($"Helpers.Sum(integers) [white on blue]{Sum(integers)}[/]");
        AnsiConsole.MarkupLine($"Helpers.Sum(doubles) [white on blue]{Sum(doubles):F}[/]");
    }
    private static void RequiredModifier()
    {
        /*
         * uses required modifier
         * to enforce constructors and callers to initialize those values
         */
        Person person = new() { FirstName = "", LastName = "" };
    }

    private static void ListAndSlicePattern()
    {
        int[] list1 = { 1, 2, 3, 4, 5 };

        if (list1 is [1, 2, 3, 4, 5] && list1 is [_, _, _, _,  5])
        {
            AnsiConsole.MarkupLine("[white on blue]List Pattern Matched[/]");
        }
        else
        {
            AnsiConsole.MarkupLine("[white on red]No match[/]");
        }

        Console.WriteLine();

        var list2 = new[] { 1, 2, 3, 4, 5, 6 };

        if (list2 is [1, 2, .. var values, 6])
        {
            AnsiConsole.MarkupLine($"[white on gray]{string.Join(",", values)}[/]");
        }

        Console.WriteLine();

        int[] numbers = { 24, 320, 32, 700 };

        string arrayDesc = numbers switch
        {
            [24, 320, 32, 700] => "[yellow]It's the array we expected![/]",
            _ => "[yellow on red]no match[/]"
        };

        AnsiConsole.MarkupLine(arrayDesc);

    }

    public static Table CreateTable() =>
        new Table()
            .RoundedBorder()
            .AddColumn("[cyan]Id[/]")
            .AddColumn("[cyan]Company[/]")
            .AddColumn("[cyan]First[/]")
            .AddColumn("[cyan]Last[/]")
            .AddColumn("[cyan]Gender[/]")
            .AddColumn("[cyan]Contact type[/]")
            .Alignment(Justify.Center)
            .BorderColor(Color.LightSlateGrey)
            .Title("[LightGreen]Customers[/]");

    private static void Render(Rule rule)
    {
        AnsiConsole.Write(rule);
        AnsiConsole.WriteLine();
    }

    private static void ExitPrompt()
    {
        Console.WriteLine();
        Render(new Rule($"[yellow]Press a key to exit the demo[/]").RuleStyle(Style.Parse("silver")).Centered());
        Console.ReadLine();
    }
}