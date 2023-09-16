using System;
using System.Linq;
using System.Windows.Forms;

namespace CheckBoxColumnCount.Extensions
{
	internal static class Module1
	{
	   public static int CheckBoxCount(this DataGridView dataGridView, int columnIndex, bool Checked) =>
       (
           from rows in dataGridView.Rows.Cast<DataGridViewRow>()
           where Convert.ToBoolean(rows.Cells[columnIndex].Value) == Checked
           select rows).Count();
    }

}
