using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EnumComparisionApp.Classes;
internal class Helpers
{
    public static void Print([CallerMemberName] string? methodName = null)
    {
        //AnsiConsole.MarkupLine($"[white on blue]{methodName!}[/]");
        var rule = new Rule($"[white on blue]{methodName!}[/]");
        rule.RuleStyle("deepskyblue4");
        AnsiConsole.Write(rule);
        Console.WriteLine();
    }
}

public static class StringExtensions
{
    public static string SplitCamelCase(this string sender) =>
        string.Join(" ", Regex.Matches(sender, @"([A-Z][a-z]+)")
            .Select(m => m.Value));
    public static string ToYesNoString(this bool value) => (value ? "[cyan]Yes[/]" : "[red]No[/]");

}

