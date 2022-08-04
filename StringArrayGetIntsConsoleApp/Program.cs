using System;
using System.Linq;
using Spectre.Console;

namespace StringArrayGetIntsConsoleApp
{
    partial class Program
    {
        static void Main(string[] args)
        {
            AnsiConsole.MarkupLine("[cyan]Get ints from string array[/]");
            string[] lineArray = { "Monday", "99", "Wednesday", "3", "Friday", "12", "Saturday", "109" };
            AnsiConsole.MarkupLine("[yellow]Extension[/]");
            int[] intArray = lineArray.ToIntegerArray();

            Array.Sort(intArray);

            foreach (var value in intArray)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine($"Min: {intArray.Min()}");
            Console.WriteLine($"Max: {intArray.Max()}");

            Console.WriteLine();
            AnsiConsole.MarkupLine("[b][fuchsia]Simple LINQ[/][/]");
            intArray =
            (
                from element in lineArray
                let item = int.TryParse(element, out int n) ? (int?)n : null
                where item.HasValue
                select item.Value
            ).ToArray();

            foreach (var value in intArray)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
    }

    public static class Extensions
    {
        public static int[] ToIntegerArray(this string[] sender)
        {

            var values = Array
                .ConvertAll(sender,
                    (input) => new {
                        IsInteger = int.TryParse(input, out var integerValue),
                        Value = integerValue
                    })
                .Where(result => result.IsInteger)
                .Select(result => result.Value)
                .ToArray();

            return values;

        }
    }
}
