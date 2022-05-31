using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SqlServerAsyncReadCore.Classes
{
    public static class CheckedListBoxExtensions
    {
        public class CheckedData
        {
            /// <summary>
            /// Associated data row for the checked item
            /// </summary>
            public DataRow Row { get; set; }
            /// <summary>
            /// Item index in the CheckedListBox
            /// </summary>
            public int Index { get; set; }
            /// <summary>
            /// Primary key for Row property
            /// </summary>
            public int Identifier { get; set; }
        }
        public static List<CheckedData> IndexList(this CheckedListBox sender, string primaryKeyName)
        {
            return
            (
                from item in sender.Items.Cast<DataRowView>()
                    .Select(
                        (data, index) =>
                            new CheckedData
                            {
                                Row = data.Row,
                                Index = index,
                                Identifier = data.Row.Field<int>(primaryKeyName)
                            }
                    )
                    .Where((x) => sender.GetItemChecked(x.Index))
                select item
            ).ToList();
        }
    }
}