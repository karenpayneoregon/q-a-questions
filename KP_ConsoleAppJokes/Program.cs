using Newtonsoft.Json;
using KP_ConsoleAppJokes.Classes;
using static KP_ConsoleAppJokes.Classes.SpectreConsoleHelpers;

namespace KP_ConsoleAppJokes;

internal partial class Program
{
    static void Main(string[] args)
    {
        RandomJokes.Execute();

        ExitPrompt();
    }

}