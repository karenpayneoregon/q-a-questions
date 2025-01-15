using System.Data;
using System.Text.RegularExpressions;
using System;
using System.Windows.Forms;

namespace DataGridViewCombo1.Classes
{
    public static class DataGridViewExtensions
    {
        public static bool IsComboBoxCell(this DataGridViewCell sender)
        {
            var result = false;
            if (sender.EditType == null) return false;
            if (sender.EditType == typeof(DataGridViewComboBoxEditingControl))
            {
                result = true;
            }

            return result;
        }
        public static void MoveRowUp(this DataGridView sender, BindingSource bindingSource)
        {
            if (!string.IsNullOrWhiteSpace(bindingSource.Sort))
            {
                bindingSource.Sort = "";
            }

            var currentColumnIndex = sender.CurrentCell.ColumnIndex;
            var newIndex = Convert.ToInt32((bindingSource.Position == 0) ? 0 : bindingSource.Position - 1);

            var dt = (DataTable)bindingSource.DataSource;

            DataRow rowToMove = ((DataRowView)bindingSource.Current).Row;
            var newRow = dt.NewRow();

            newRow.ItemArray = rowToMove.ItemArray;
            dt.Rows.RemoveAt(bindingSource.Position);
            dt.Rows.InsertAt(newRow, newIndex);

            dt.AcceptChanges();

            bindingSource.Position = newIndex;

            sender.CurrentCell = sender[currentColumnIndex, newIndex];
        }
        public static void MoveRowDown(this DataGridView sender, BindingSource bindingSource)
        {
            if (!string.IsNullOrWhiteSpace(bindingSource.Sort))
            {
                bindingSource.Sort = "";
            }

            var currentColumnIndex = sender.CurrentCell.ColumnIndex;
            var upperLimit = bindingSource.Count - 1;
            var newIndex = Convert.ToInt32((bindingSource.Position + 1 >= upperLimit) ? upperLimit : bindingSource.Position + 1);

            var dt = (DataTable)bindingSource.DataSource;
            DataRow rowToMove = ((DataRowView)bindingSource.Current).Row;
            var newRow = dt.NewRow();

            newRow.ItemArray = rowToMove.ItemArray;
            dt.Rows.RemoveAt(bindingSource.Position);
            dt.Rows.InsertAt(newRow, newIndex);

            dt.AcceptChanges();

            bindingSource.Position = newIndex;
            sender.CurrentCell = sender[currentColumnIndex, newIndex];
        }
    }
}

