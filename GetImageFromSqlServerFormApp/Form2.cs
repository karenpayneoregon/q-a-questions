using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GetImageFromSqlServerFormApp.Classes;

namespace GetImageFromSqlServerFormApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Load("Dummy.png");
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            using (var ms = new MemoryStream())
            {
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                var imageData = ms.ToArray();
                DataOperations.UpdateImage(3, imageData);
            }
        }
    }
}
