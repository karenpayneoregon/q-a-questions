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


public class QuoteRoot
{
    public Quote[] quotes { get; set; }
    public int total { get; set; }
    public int skip { get; set; }
    public int limit { get; set; }
}

public class Quote
{
    public int id { get; set; }
    public string quote { get; set; }
    public string author { get; set; }
}
