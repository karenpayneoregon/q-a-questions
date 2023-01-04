using GetDateTimeFromWebApp.Classes;
using System;

namespace GetDateTimeFromWebApp;

internal partial class Program
{
    static void Main(string[] args)
    {
        DateTime? birthdate = new DateTime(1956, 9, 24);
        Console.WriteLine(birthdate.Age());

        DateTime dateTime = new DateTime(2022, 2, 12, 13, 0, 0);
        var (day, month, year) = dateTime;
        Console.ReadLine();
    }

    private static void Duplicate()
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
    }
}