using System.Windows.Forms;
using EnumDescriptions.Classes;

namespace EnumDescriptions.Extensions
{
    public static class Extensions
    {


        public static (string text, T item) Current<T>(this ListControl source)
            => (source.Text, (T)source.SelectedValue);

    }
}