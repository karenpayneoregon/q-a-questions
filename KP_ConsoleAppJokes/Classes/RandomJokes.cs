using KP_ConsoleAppJokes.Models;
using Newtonsoft.Json;

namespace KP_ConsoleAppJokes.Classes;

internal class RandomJokes
{
    public static void Execute()
    {
        var json = WebUtilities.ReadResponseFromUrl("https://v2.jokeapi.dev/joke/Programming");

        JokeContainer container = JsonConvert.DeserializeObject<JokeContainer>(json)!;
        if (container.IsTwoPart)
        {
            AnsiConsole.MarkupLine($"[yellow]{container.setup}[/] [cyan]press enter[/]");
            Console.ReadLine();
            AnsiConsole.MarkupLine($"[lime]{container.delivery}[/]");

        }
        else if (container.IsSinglePart)
        {
            AnsiConsole.MarkupLine($"[steelblue1_1]{container.joke}[/]");
        }
    }
}