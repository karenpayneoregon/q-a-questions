using System.Diagnostics;
using System.Text.RegularExpressions;

namespace WinFormsApp2.Classes;

public static class Extensions
{
    [DebuggerStepThrough]
    public static string SplitCamelCase(this string sender) =>
        string.Join(" ", Regex.Matches(sender, @"([A-Z][a-z]+)")
            .Select(m => m.Value));

    [DebuggerStepThrough]
    public static void ExpandColumns(this DataGridView source, int rightPad = 0)
    {
        for (int index = 0; index <= source.Columns.Count - 1; index++)
        {
            int columnWidth = source.Columns[index].Width;
            source.Columns[index].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            source.Columns[index].Width = columnWidth + rightPad;
        }
    }
}