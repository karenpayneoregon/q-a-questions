namespace KP_ConsoleAppJokes.Models;


public class JokeContainer
{
    public bool error { get; set; }
    public string category { get; set; }
    public string type { get; set; }
    public string setup { get; set; }
    public string delivery { get; set; }
    public Flags flags { get; set; }
    public int id { get; set; }
    public bool safe { get; set; }
    public string lang { get; set; }
    public string joke { get; set; }
    public bool IsTwoPart => type == "twopart";
    public bool IsSinglePart => type == "single";
}