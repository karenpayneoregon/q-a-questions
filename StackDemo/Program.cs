using Microsoft.Extensions.Configuration;
using System.Text.Json;
using StackDemo.Classes;
// ReSharper disable PossibleNullReferenceException

namespace StackDemo;

internal partial class Program
{
    static void Main(string[] args)
    {


        CreateAppSettings();

        IConfigurationRoot config = InitConfiguration();
        List<MailAddress> addresses = 
            config.GetSection($"{nameof(Settings)}:{nameof(MailAddress)}")
                .Get<MailAddress[]>().ToList();

        foreach (var address in addresses)
        {
            Console.WriteLine($"{address.Display,-20}{address.Address}");
        }

        Console.ReadLine();

    }

 
    private static void CreateAppSettings()
    {
        List<MailAddress> addresses = new()
        {
            new () { Address = "first@domain.com", Display = "First" },
            new () { Address = "second@domain.com", Display = "Second" },
            new () { Address = "third@domain.com", Display = "Third" }
        };

        Root setting = new() 
        { 
            Settings = new Settings()
            {
                MailAddress = addresses.ToArray()
            }
        };

        string jsonString = JsonSerializer.Serialize(setting, 
            new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText("appsettings.json", jsonString);
    }

    private static IConfigurationRoot InitConfiguration()
    {

        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");

        return builder.Build();

    }
}

    public class DemoOperations
    {
        public static void DoSomething(DateTimeOffset dateTimeOffset)
        {
            var (day, month, year, offset) = dateTimeOffset;
        }
    }



#region Place each class in their own file
public class Root
{
    public Settings Settings { get; set; }
}

public class Settings
{
    public MailAddress[] MailAddress { get; set; }
}

public class MailAddress
{
    public string Address { get; set; }
    public string Display { get; set; }
} 
#endregion