using Spectre.Console;

namespace ChristmasTree.Classes;

public class SpectreConsoleHelpers
{
    public static void ContinuePrompt()
    {
        Console.WriteLine();

        Render(new Rule($"[yellow]Press[/] [green]ENTER[/] [yellow]to continue[/]")
            .RuleStyle(Style.Parse("silver")).LeftJustified());

        Console.ReadLine();
    }

    private static void Render(Rule rule)
    {
        AnsiConsole.Write(rule);
        AnsiConsole.WriteLine();
    }
}