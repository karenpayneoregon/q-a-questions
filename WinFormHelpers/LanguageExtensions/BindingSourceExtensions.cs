using System.Data;
using System.Windows.Forms;

namespace WinFormHelpers.LanguageExtensions
{
    public static class BindingSourceExtensions
    {
        public static DataTable DataTable(this BindingSource sender) 
            => (DataTable)sender.DataSource;

        public static DataView DataView(this BindingSource sender) 
            => ((DataTable)sender.DataSource).DefaultView;

        /// <summary>
        /// Apply a filter for Like 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="field">Field to apply filter on</param>
        /// <param name="value">Value for filter</param>
        /// <param name="caseSensitive">Filter should be case or case in-sensitive</param>
        public static void RowFilterContains(this BindingSource sender, string field, string value, bool caseSensitive = false)
        {
            sender.DataTable().CaseSensitive = caseSensitive;
            sender.DataView().RowFilter = $"{field} LIKE '%{value.EscapeApostrophe()}%'";
        }
        /// <summary>
        /// Apply a filter for Like starts with
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="field">Field to apply filter on</param>
        /// <param name="value">Value for filter</param>
        /// <param name="caseSensitive">Filter should be case or case in-sensitive</param>
        public static void RowFilterStartsWith(this BindingSource sender, string field, string value, bool caseSensitive = false)
        {
            sender.DataTable().CaseSensitive = caseSensitive;
            sender.DataView().RowFilter = $"{field} LIKE '{value.EscapeApostrophe()}%'";
        }
        public static void RowFilterEndsWith(this BindingSource sender, string field, string value, bool caseSensitive = false)
        {
            sender.DataTable().CaseSensitive = caseSensitive;
            sender.DataView().RowFilter = $"{field} LIKE '%{value.EscapeApostrophe()}'";
        }

        public static void RowFilterTwoConditions(this BindingSource sender, string field1, string value1, string pField2, string value2, bool caseSensitive = false)
        {
            sender.DataTable().CaseSensitive = caseSensitive;
            sender.DataView().RowFilter = $"{field1} = '{value1.EscapeApostrophe()}' AND {pField2} = '{value2.EscapeApostrophe()}'";
        }
        public static void RowFilterClear(this BindingSource sender)
        {
            sender.DataView().RowFilter = "";
        }
    }
}