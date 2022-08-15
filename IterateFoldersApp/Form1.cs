using System;
using System.IO;
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
            await operations.CollectFiles("C:\\OED\\Dotnetland\\VS2019", "*.*", SearchOption.AllDirectories);
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
    }
}
