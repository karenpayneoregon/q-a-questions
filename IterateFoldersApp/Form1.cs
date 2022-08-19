using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using IterateFoldersApp.Classes;

namespace IterateFoldersApp
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource cancellationTokenSource = new();
        public Form1()
        {
            InitializeComponent();
            FormClosing += OnFormClosing;
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            cancellationTokenSource.Cancel();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (cancellationTokenSource.IsCancellationRequested)
            {
                cancellationTokenSource.Dispose();
                cancellationTokenSource = new CancellationTokenSource();
            }

            progressBar1.Maximum = DirectoryHelpers.FileCount("C:\\OED\\Dotnetland\\VS2019");
            progressBar1.Value = 0;
            FileOperations operations = new();

            operations.Traverse += OperationsOnTraverse;
            operations.Done += OnDone;

            try
            {
                await operations.EnumerateFiles("C:\\OED\\Dotnetland\\VS2019", "*.*", SearchOption.AllDirectories, cancellationTokenSource.Token);
            }
            catch (Exception exception)
            {
                if (exception is OperationCanceledException)
                {
                    label1.Text = @"Cancelled";
                }
            }
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
                progressBar1.Value += 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            button2.Text = $@"{DirectoryHelpers.FileCount("C:\\OED\\Dotnetland\\VS2019"):N0}";
            //button2.Text = DirectoryHelpers.FileCount("C:\\OED\\Dotnetland\\VS2019").ToString("N0");

            //DirectoryHelpers.FileCount("", SearchOption.AllDirectories);
            //DirectoryHelpers.FileCount("", SearchOption.AllDirectories,"");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var (directoryCount, fileCount) = DirectoryHelpers.DirectoryFileCount("C:\\OED\\Dotnetland\\VS2019");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            cancellationTokenSource.Cancel();
        }
    }
}
