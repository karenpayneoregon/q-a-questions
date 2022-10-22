namespace KP_ConsoleAppJokes.Classes;

internal class WebUtilities
{
    public static string ReadResponseFromUrl(string url)
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