using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridViewDistinctGroup.Classes
{
    public class Operations
    {
        public static DataTable LoadMockedData()
        {
            DataTable dt = new() { TableName = "MyTable" };
            dt.Columns.Add(new DataColumn
            {
                ColumnName = "Identifier",
                DataType = typeof(int),
                AutoIncrement = true,
                AutoIncrementSeed = 1
            });
            dt.Columns.Add(new DataColumn
            {
                ColumnName = "Priority",
                DataType = typeof(string)
            });
            dt.Columns.Add(new DataColumn
            {
                ColumnName = "Status",
                DataType = typeof(string)
            });

            dt.Rows.Add(null, "Low", "New");
            dt.Rows.Add(null, "High", "Old");
            dt.Rows.Add(null, "Low", "New");
            dt.Rows.Add(null, "Medium", "Old");
            dt.Rows.Add(null, "Low", "New");
            dt.Rows.Add(null, "Low", "New");
            dt.Rows.Add(null, "High", "Old");
            dt.Rows.Add(null, "Medium", "New");
            dt.Rows.Add(null, "Medium", "Old");
            dt.Rows.Add(null, "Low", "Old");

            return dt;
        }
    }
}
