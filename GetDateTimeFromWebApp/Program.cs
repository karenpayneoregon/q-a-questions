namespace GetDateTimeFromWebApp;

internal partial class Program
{
    static void Main(string[] args)
    {

        string[] someArray = { "fname", "lname", "home", "home", "company", "fName" };
        var duplicates = someArray
            .Select((text, index) => new { Index = index, Text = text })
            .GroupBy(g => g.Text, StringComparer.OrdinalIgnoreCase)
            .Where(g => g.Count() > 1);

        foreach (var duplicate in duplicates)
        {
            someArray[duplicate.FirstOrDefault()!.Index] = "xxxx";
        }

        foreach (var value in someArray)
        {
            Console.WriteLine(value);
        }

        Console.ReadLine();
    }
}