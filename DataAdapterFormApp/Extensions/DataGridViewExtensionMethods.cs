using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DataAdapterFormApp.Extensions
{
    public static class DataGridViewExtensionMethods
    {

        /// <summary>
        /// Convert column Header text to a delimited string
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static string DelimitedHeaders(this DataGridView sender) =>
            string.Join(",", sender.Columns.OfType<DataGridViewColumn>()
                .Select(column => column.HeaderText).ToArray());

        /// <summary>
        /// Create a string array of data in the DataGridView, does not include header
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="delimiter">Delimiter which defaults to a comma</param>
        /// <returns>array comprised of rows/cell data without header</returns>
        public static string[] ToDelimited(this DataGridView sender, string delimiter = ",") =>
            (sender.Rows.Cast<DataGridViewRow>()
                .Where(row => !row.IsNewRow)
                .Select(row => new {
                    row,
                    rowItem = string.Join(delimiter,
                    Array.ConvertAll(row.Cells.Cast<DataGridViewCell>().ToArray(), c =>
                        ((c.Value == null) ? "" : c.Value.ToString())))
                })
                .Select(@t => @t.rowItem)).ToArray();

        /// <summary>
        ///  Create a string array of data in the DataGridView, includes header
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="delimiter">Delimiter which defaults to a comma</param>
        /// <returns>array comprised of rows/cell data with header</returns>
        public static string[] ToDelimitedWithHeaders(this DataGridView sender, string delimiter = ",")
        {
            string headers = sender.DelimitedHeaders();
            List<string> data = sender.ToDelimited().ToList();
            data.Insert(0, headers);
            return data.ToArray();
        }

        public static bool ExportToTextFile(this DataGridView sender, string fileName)
        {
            try
            {
                File.WriteAllLines(fileName, sender.ToDelimitedWithHeaders());
                return true;
            }
            catch 
            {
                return false;
            }
        }
    }
}