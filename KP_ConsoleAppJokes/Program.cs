using KP_ConsoleAppJokes.Classes;
using static KP_ConsoleAppJokes.Classes.SpectreConsoleHelpers;

namespace KP_ConsoleAppJokes;

internal partial class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();

            var menuItem = AnsiConsole.Prompt(MenuOperations.SelectionPrompt());
            if (menuItem.Id != -1)
            {
                menuItem.Action();
                Prompt();
            }
            else
            {
                return;
            }
        }

    }

}