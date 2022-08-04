# About

Get int values from a string array. Try it in [dotnetfiddle](https://dotnetfiddle.net/kscBrp)


```csharp
using System;
using System.Linq;

namespace StringArrayGetIntsConsoleApp
{
    partial class Program
    {
        static void Main(string[] args)
        {
            string[] lineArray = { "Monday", "99", "Wednesday", "3", "Friday", "12", "Saturday", "109" };
            int[] intArray = lineArray.ToIntegerArray();

            Array.Sort(intArray);

            foreach (var value in intArray)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine($"Min: {intArray.Min()}");
            Console.WriteLine($"Max: {intArray.Max()}");

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
```

> **Note**:
> Done in .NET Core but works with .NET Framework also