using System.Data;

namespace WinFormsApp2.Classes;

public class Mocked
{
    public static DataTable GetData()
    {
        DataTable table = new DataTable();

        table.Columns.Add("$_LastSaleDate", typeof(DateTime));
        table.Columns.Add("$_LastSalePrice", typeof(decimal));
        table.Columns.Add("$Name", typeof(string));


        table.Rows.Add(
            new DateTime(2022, 9, 12),
            124.89m,
            "Jim's");

        return table;
    }
}