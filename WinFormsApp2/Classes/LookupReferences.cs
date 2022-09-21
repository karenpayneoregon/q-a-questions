using System.Diagnostics;

namespace WinFormsApp2.Classes;

public class LookupReferences
{
    [DebuggerStepThrough]
    public static Dictionary<string, string> Columns() =>
        new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase)
        {
            { "$_LastSaleDate", "last sale date" },
            { "$_LastSaleParty", "last sale to party" },
            { "$_LastSalePrice", "last sold price" },
            { "$Name", "name of party" },
            { "$_ClosingBalance", "closing balance" }
        };
}