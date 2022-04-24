using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RadioButtonSelection.Classes
{
    public static class ControlExtensions
    {
        public static IEnumerable<T> GetDescendants<T>(this Control control) where T : class
        {
            foreach (Control child in control.Controls)
            {
                if (child is T thisControl)
                {
                    yield return (T)thisControl;
                }

                if (child.HasChildren)
                {
                    foreach (T descendant in GetDescendants<T>(child))
                    {
                        yield return descendant;
                    }
                }
            }
        }
        public static RadioButton RadioButtonChecked(this Control control, bool @checked = true) 
            => control.GetDescendants<RadioButton>().ToList().FirstOrDefault((radioButton) 
                => radioButton.Checked == @checked);
    }
}