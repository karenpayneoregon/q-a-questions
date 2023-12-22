using System.Drawing;
using EnumComparisionApp.Classes;
using Spectre.Console;
using Color = System.Drawing.Color;

namespace EnumComparisionApp;

internal class Program
{
    static void Main(string[] args)
    {
        Sample1();
        //Sample2();
        //MicroSoftExample();


        Console.ReadLine();
    }

    private static void Sample1()
    {
        Helpers.Print();

        List<string> list = ["DairyProducts", "dairyproducts", "Grains Cereals", "Beverages", "BEVERAGES"];

        foreach (var item in list)
        {
            Console.WriteLine(Enum.TryParse(item, true, out Category category)
                ? $"Found: {category}"
                : $"Could not find the specified {item}");
        }
        
        Console.WriteLine();

        list.Where(item => Enum.TryParse(item, true, out Category _))
            .ToList()
            .ForEach(Console.WriteLine);
        
        Console.WriteLine();

        list.Select(item => Enum.TryParse(item, true, out Category category) ? 
                category.ToString() : 
                "Whoops")
            .ToList()
            .ForEach(Console.WriteLine);

        Console.WriteLine();

        foreach (var item in list)
        {
            Console.WriteLine(Enum.TryParse(item, out Category categoryNotFound)
                ? $"Found: {categoryNotFound}"
                : $"Could not find the specified {nameof(Category)}.{item}");
        }

        Console.WriteLine();
    }
      
    private static void Sample2()
    {
        Helpers.Print();

        string[] lines = File.ReadAllLines("Items.txt")
            .Where(x => !string.IsNullOrWhiteSpace(x))
            .ToArray();

        foreach (var line in lines)
        {
            var parts = line.Split(',');

            if (parts is [ _ , _ , "Beverages" or "DairyProducts" or "GrainsCereals" or "Produce"])
            {
                AnsiConsole.MarkupLine($"      [cyan]Match[/] [[{string.Join(",", parts)}]]");
                AnsiConsole.MarkupLine($"             [yellow]{Enum.Parse(typeof(Category), parts[2])}[/]");
            }
            else
            {
                AnsiConsole.MarkupLine($"[red]Not a match[/] [[{string.Join(",", parts)}]]");
            }
        }

        Console.WriteLine();
    }
    [Flags] enum Colors { None = 0, Red = 1, Green = 2, Blue = 4 };
    // tweaks by Karen Payne
    public static void MicroSoftExample()
    {
        Helpers.Print();

        string[] colorStrings = { "0", "2", "8", "blue", "Blue", "Yellow", "Red, Green" };

        foreach (var colorString in colorStrings)
        {
            if (Enum.TryParse(colorString, true, out Colors colorValue))
            {
                if (Enum.IsDefined(typeof(Colors), colorValue) | colorValue.ToString().Contains(","))
                {
                    Console.WriteLine($"Converted '{colorString}' to {colorValue}.");
                }
                else
                {
                    AnsiConsole.MarkupLine($"[white on red]{colorString}[/] is [red]not an underlying value of the Colors enumeration[/].");
                }
            }
            else
            {
                AnsiConsole.MarkupLine($"[white on red]{colorString}[/] is [red]not a member of the Colors enumeration[/].");
            }
        }

        Console.WriteLine();
    }
}


