using System.Data;

namespace WinFormsApp1;

public class DataOperations
{
    public static DataTable Table()
    {
        var dt = new DataTable();


        dt.Columns.Add(new DataColumn()
        {
            ColumnName = "Id",
            DataType = typeof(int),
            AutoIncrement = true,
            AutoIncrementSeed = 1,
            ColumnMapping = MappingType.Hidden
        });

        dt.Columns.Add(new DataColumn() { ColumnName = "FirstName", DataType = typeof(string) });
        dt.Columns.Add(new DataColumn() { ColumnName = "LastName", DataType = typeof(string) });
        dt.Columns.Add(new DataColumn() { ColumnName = "StartTime", DataType = typeof(DateTime) });

        dt.Rows.Add( null, "Jeanine", "Abbott", new DateTime(2018, 1, 1, 8, 0, 0));
        dt.Rows.Add(null, "Lester", "Lam", new DateTime(2018, 1, 1, 9, 0, 0));
        dt.Rows.Add( null, "Claire", "Cowan", new DateTime(2018, 1, 1, 10, 0, 0));
        dt.Rows.Add( null, "Karen", "Payne", new DateTime(2022, 1, 1, 10, 0, 0));

        dt.Columns.Add(new DataColumn() { ColumnName = "Process", DataType = typeof(bool), DefaultValue = false });
        dt.Columns["Process"]!.SetOrdinal(0);

        dt.Rows[1].SetField("Process", true);



        return dt;
    }
}