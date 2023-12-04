using System.Globalization;
using System.Numerics;
using System.Runtime.InteropServices.JavaScript;

#pragma warning disable CS8602 // Dereference of a possibly null reference.

// ReSharper disable UseIndexFromEndExpression
namespace NullableDeconstruct;

internal class Program
{
    static void Main(string[] args)
    {

        List<string> months = DateTimeFormatInfo
            .CurrentInfo
            .MonthNames[..^1]
            .ToList();


        for (int index = 0; index < months.Count; index++)
        {
            Console.WriteLine($" {index.Increment(1).Ellipsis(10)}{months[index]}");
        }

        DateTime? someDateTime = new DateTime(2023,11,11,13,45,3);

        Console.WriteLine($" {someDateTime.Ellipsis(30)}demo");


        Console.ReadLine();

    }


}


public static class StringExtensions
{
    /// <summary>
    /// Add ellipsis-es to the end of a string
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="width">Width to pad</param>
    /// <param name="paddingChar">Character to pad with, defaults to a period</param>
    /// <returns>Padded string</returns>
    public static string Ellipsis(this string? sender, int width, char paddingChar = '.')
    {
        return sender.PadRight(width, paddingChar);
    }
    /// <summary>
    /// Add ellipsis-es to the end of a int and convert to a string
    /// </summary>
    /// <typeparam name="T">Type</typeparam>
    /// <param name="sender">Type of <see cref="T"/></param>
    /// <param name="width">Width to pad</param>
    /// <param name="paddingChar">Character to pad with, defaults to a period</param>
    /// <returns>Padded string</returns>
    public static string Ellipsis<T>(this T sender, int width, char paddingChar = '.') where T : INumber<T>
    {
        return sender.ToString().Ellipsis(width, paddingChar);
    }
    public static string Ellipsis<T>(this T? sender, int width, char paddingChar = '.') where T : struct
    {
        if (sender is not null)
        {
            return sender.ToString().Ellipsis(width, paddingChar);
        }
        else
        {
            return "".Ellipsis(width, paddingChar);
        }
        
    }
    /// <summary>
    /// Increment value
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="sender">Type of <see cref="T"/></param>
    /// <param name="value">Amount to increment by</param>
    /// <returns>Incremented value</returns>
    public static T Increment<T>(this T sender, T value) where T : INumber<T>
        => sender + value;
}


public static class IntegerExtensions
{
    public static string Ordinalize1(this int value) =>
        $"{value}{(
                  (value % 10 == 1 && value % 100 != 11) ? "st"
                : (value % 10 == 2 && value % 100 != 12) ? "nd"
                : (value % 10 == 3 && value % 100 != 13) ? "rd"
                : "th"
            )}";

    public static string Ordinalize2(this int value)
    {
        var ones = value % 10;
        var tens = value % 100;

        var suffix = ones switch
        {
            1 when tens != 11 => "st",
            2 when tens != 12 => "nd",
            3 when tens != 13 => "rd",
            _ => "th"
        };

        return string.Concat(value.ToString("N0"), suffix);
    }
}