using KP_ConsoleAppJokes.Models;
using Newtonsoft.Json;

namespace KP_ConsoleAppJokes.Classes;

internal class ChuckJokes
{
    public static void Execute()
    {
        var json = WebUtilities.ReadResponseFromUrl("https://api.chucknorris.io/jokes/random");

        ChuckNorris container = JsonConvert.DeserializeObject<ChuckNorris>(json)!;
        AnsiConsole.MarkupLine($"[aqua]{container.value}[/]");
    }
}