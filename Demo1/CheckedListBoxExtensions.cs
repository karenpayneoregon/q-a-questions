using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Demo1
{
    public static class CheckedListBoxExtensions
    {
        public static List<T> CheckedList<T>(this CheckedListBox source)
            => source.Items.Cast<T>()
                .Where((item, index) => source.GetItemChecked(index))
                .Select(item => item)
                .ToList();
    }
}