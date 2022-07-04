using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CloneImagePictureBox.Extensions;

namespace CloneImagePictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbImage1.LoadClone(Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory, "Images", "DeleteCode.png"));
            pbImage2.LoadClone(Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory, "Images", "oops.png"));
        }
    }
}
