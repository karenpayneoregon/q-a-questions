namespace KP_ConsoleAppJokes.Classes
{
    public class SpectreConsoleHelpers
    {
        public static void Prompt()
        {
            Console.WriteLine();
            Render(new Rule($"[yellow]Press[/] [cyan]ENTER[/] [yellow]to continue[/]").RuleStyle(Style.Parse("silver")).Centered());
            Console.ReadLine();
        }
        private static void Render(Rule rule)
        {
            AnsiConsole.Write(rule);
            AnsiConsole.WriteLine();
        }
    }
}
