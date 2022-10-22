using KP_ConsoleAppXml.Classes;


namespace KP_ConsoleAppXml;

internal partial class Program
{
    static void Main(string[] args)
    {

        Dictionary<string, string> dictionary = new()
        {
            { "Something", "111" },
            { "Another", DateTime.Now.Hour.ToString() }
        };

        //StudentOperations.XDocFindByAttribute(3, dictionary);

        DateTime dateTime = DateTime.Now;
        var dateNow = DateOnly.FromDateTime(dateTime);
        Console.WriteLine(dateNow);



        Console.ReadLine();
    }




}

public static class Extensions
{
    public static string ToDateOnly(this string sender) => 
        DateTime.TryParse(sender, out var dateTime) ? 
            DateOnly.FromDateTime(dateTime).ToString() : 
            sender;
}