using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using IterateFoldersApp.Classes;

namespace IterateFoldersApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            FileOperations operations = new();
            operations.Traverse += OperationsOnTraverse;
            operations.Done += OnDone;
            await operations.EnumerateFiles("C:\\OED\\Dotnetland\\VS2019", "*.*", SearchOption.AllDirectories);
        }

        private void OnDone()
        {
            MessageBox.Show("Done");
        }

        private void OperationsOnTraverse(string sender)
        {
            FileInfo info = new (sender);
            if (File.Exists(sender))
            {
                label1.Text = $"Working {info.Name}";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            button2.Text = $@"{DirectoryHelpers.FileCount("C:\\OED\\Dotnetland\\VS2019"):N0}";
            button2.Text = DirectoryHelpers.FileCount("C:\\OED\\Dotnetland\\VS2019").ToString("N0");

            DirectoryHelpers.FileCount("", SearchOption.AllDirectories);
            DirectoryHelpers.FileCount("", SearchOption.AllDirectories,"");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var (directoryCount, fileCount) = DirectoryHelpers.DirectoryFileCount("C:\\OED\\Dotnetland\\VS2019");
        }
    }
}
