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

namespace CopyToOutputFolderDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private readonly string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Json");
        private void ValidateFolderExistsButton_Click(object sender, EventArgs e)
        {

            MessageBox.Show(Directory.Exists(path) ? 
                "Json folder exists" : 
                "Json folder does not exists");
        }

        private void ValidateFilesExistsButton_Click(object sender, EventArgs e)
        {
            string[] fileArray = { "customers.csv", "Vendor.csv" };

            var files = Directory.GetFiles(path).Select(Path.GetFileName).ToArray();

            MessageBox.Show($"Found both files {fileArray.SequenceEqual(files).ToYesNoString()}");
        }
    }
}
