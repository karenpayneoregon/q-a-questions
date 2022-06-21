using System;
using System.Windows.Forms;

namespace StackoverflowQuestion
{
    public partial class ChildForm : Form
    {
        public delegate void OnAdd(string firstName, string lastName);
        public event OnAdd AddPerson;
        public ChildForm()
        {
            InitializeComponent();
        }

        private void PostButton_Click(object sender, EventArgs e)
        {
            if (
                !string.IsNullOrWhiteSpace(FirstNameTextBox.Text) && 
                !string.IsNullOrWhiteSpace(LastNameTextBox.Text))
            {
                AddPerson?.Invoke(FirstNameTextBox.Text, LastNameTextBox.Text);
            }
        }
    }
}
