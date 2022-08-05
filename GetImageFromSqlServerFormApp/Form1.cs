using System;
using System.Drawing;
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

            /*
             * There is no key pasted 3, so 4 is invalid
             */
            var fruit = DataOperations.GetImage(4);

            if (fruit.Picture == null)
            {
                pictureBox1.Image = DataOperations.ConvertTextToImage(Environment.NewLine + "    Error", "Arial", 20, Color.Red, Color.White, 300, 200);
            }
            
        }

        private void GetImageButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = DataOperations.GetImage((int)numericUpDown1.Value).Picture;
        }
    }
}
