using Newtonsoft.Json;
using KP_ConsoleAppJokes.Classes;
using static KP_ConsoleAppJokes.Classes.SpectreConsoleHelpers;

namespace KP_ConsoleAppJokes;

internal partial class Program
{
    static void Main(string[] args)
    {
        var json = ReadResponseFromUrl("https://v2.jokeapi.dev/joke/Programming");
  
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

        ExitPrompt();
    }

    private static string ReadResponseFromUrl(string url)
    {
        var httpClientHandler = new HttpClientHandler();
        var httpClient = new HttpClient(httpClientHandler)
        {
            BaseAddress = new Uri(url)
        };

        using var response = httpClient.GetAsync(url);
        string responseBody = response.Result.Content.ReadAsStringAsync().Result;
        return responseBody;
    }

}