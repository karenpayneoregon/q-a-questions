﻿using System.Text.RegularExpressions;

namespace WinFormsApp1.Classes;

public static class StringExtensions
{
    public static string SplitCamelCase(this string sender) =>
        string.Join(" ", Regex.Matches(sender, @"([A-Z][a-z]+)")
            .Select(m => m.Value));
}