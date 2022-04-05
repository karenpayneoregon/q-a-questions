using System;
using System.Windows.Forms;

namespace BasicReadWriteJson.Extensions
{
    public static class DataGridViewExtensions
    {
        public static void ExpandColumns(this DataGridView source, bool sizable = false)
        {
            foreach (DataGridViewColumn col in source.Columns)
            {
                if (col.ValueType.Name != "ICollection`1")
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }

            if (!sizable) return;

            for (int index = 0; index <= source.Columns.Count - 1; index++)
            {
                int columnWidth = source.Columns[index].Width;

                source.Columns[index].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                // Set Width to calculated AutoSize value:
                source.Columns[index].Width = columnWidth;
            }


        }

        public static void HideIdentifiers(this DataGridView sender)
        {
            for (int index = 0; index < sender.Columns.Count; index++)
            {
                if (sender.Columns[index].Name.EndsWith("ID", StringComparison.OrdinalIgnoreCase))
                {
                    sender.Columns[index].Visible = false;
                }
            }

        }
    }
}