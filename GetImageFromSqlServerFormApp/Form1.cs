using System;
using System.Windows.Forms;
using GetImageFromSqlServerFormApp.Classes;

namespace GetImageFromSqlServerFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = DataOperations.RowCount();
        }

        private void GetImageButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = DataOperations.GetImage((int)numericUpDown1.Value).Picture;
        }
    }
}
