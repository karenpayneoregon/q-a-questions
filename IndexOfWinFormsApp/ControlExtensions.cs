namespace IndexOfWinFormsApp
{
    public static class ControlExtensions
    {
        public static IEnumerable<T> Descendants<T>(this Control control) where T : class
        {
            foreach (Control child in control.Controls)
            {
                if (child is T thisControl)
                    yield return thisControl;

                if (!child.HasChildren) continue;
                foreach (T descendant in Descendants<T>(child))
                    yield return descendant;
            }
        }
        public static RadioButton RadioButtonChecked(this Control control, bool @checked = true)
            => control.Descendants<RadioButton>().ToList()
                .FirstOrDefault((radioButton) => radioButton.Checked == @checked);

        public static string GetColor(this RadioButton radioButton) 
            => radioButton.Tag.ToString();
    }
}
