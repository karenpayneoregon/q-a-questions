using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsLibrary.LanguageExtensions
{
    public static class FormExtensions
    {
        public static IEnumerable<T> Descendant<T>(this Control control) where T : class
        {
            foreach (Control child in control.Controls)
            {
                if (child is T thisControl)
                {
                    yield return (T)thisControl;
                }

                if (child.HasChildren)
                {
                    foreach (T descendant in Descendant<T>(child))
                    {
                        yield return descendant;
                    }
                }
            }
        }
        public static List<TextBox> TextBoxList(this Control control)
            => control.Descendants<TextBox>().ToList();
    }
}
