using System;
using System.Drawing;
using System.Windows.Forms;

namespace CreateButtons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ButtonOperations.BaseName = "CategoryButton";

            ButtonOperations.Initialize(this, 20, 30, 10, 100, Clicker);
            CountTextBox.Text = "5";
        }

        private void Clicker(object sender, EventArgs e)
        {
            Button current = (Button)sender;
            var tag = (int)current.Tag;
            MessageBox.Show($@"Text: {current.Text} Tag: {tag}");
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(CountTextBox.Text, out var count))
            {
                for (int index = 0; index < count; index++)
                {
                    ButtonOperations.CreateButton($"Button {ButtonOperations.Index}");
                }
            }
        }

        private void RemoveAllButton_Click(object sender, EventArgs e)
        {
            foreach (var button in ButtonOperations.ButtonsList)
            {
                ButtonOperations.ParentControl.Controls.Remove(button);
            }

            ButtonOperations.Index = 1;
            ButtonOperations.Top = 20;
        }
    }
}
