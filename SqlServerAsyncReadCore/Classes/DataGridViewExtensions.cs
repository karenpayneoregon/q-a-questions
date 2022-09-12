using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlServerAsyncReadCore.Classes
{
    public static class DataGridViewExtensions
    {
        public static DataTable GetDataTable(this DataGridView sender, bool pColumnNames = true)
        {
            var table = new DataTable();

            foreach (DataGridViewColumn column in sender.Columns)
            {
                if (!column.Visible) continue;

                if (pColumnNames)
                {
                    table.Columns.Add(new DataColumn() { ColumnName = column.Name });
                }
                else
                {
                    table.Columns.Add();
                }
            }

            var cellValues = new object[sender.Columns.Count];

            foreach (DataGridViewRow row in sender.Rows)
            {
                if (row.IsNewRow) continue;

                for (int index = 0; index < row.Cells.Count; index++)
                {
                    cellValues[index] = row.Cells[index].Value;
                }

                table.Rows.Add(cellValues);
            }

            return table;

        }
    }
}
