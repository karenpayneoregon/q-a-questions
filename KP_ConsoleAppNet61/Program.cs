using System.Text.Json;

namespace JsonDemoApp;

internal partial class Program
{
    static void Main(string[] args)
    {
        Information information = new Information()
        {
            UserData = new UserData[]
            {
                new UserData()
                {
                    Location = @"C:\Users\stage\OneDrive\Documenten", 
                    Language = "NL"
                }
            }
        };

        string json = JsonSerializer.Serialize(information, 
            new JsonSerializerOptions() { WriteIndented = true });
            
        Console.WriteLine(json);
        File.WriteAllText("Data.json", json);
        Console.ReadLine();
         
    }
}

public class Information
{
    public UserData[] UserData { get; set; }
}

public class UserData
{
    public string Language { get; set; }
    public string Location { get; set; }
}