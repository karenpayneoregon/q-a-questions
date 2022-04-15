using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackGroundWorker1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int _currentIndex = 0;
        private readonly List<BackgroundWorkerCustom> _backgroundWorker = new List<BackgroundWorkerCustom>();
        private void RunButton_Click(object sender, EventArgs e)
        {
            var bw = new BackgroundWorkerCustom
            {
                WorkerReportsProgress = true, 
                Index = _currentIndex, 
                WorkerSupportsCancellation = true
            };

            _currentIndex += 1;

            _backgroundWorker.Add(bw);
            bw.DoWork += BwOnDoWork;
            bw.ProgressChanged += BwOnProgressChanged;
            bw.RunWorkerCompleted += BwOnRunWorkerCompleted;
            bw.RunWorkerAsync();
        }

        private void BwOnProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var current = (BackgroundWorkerCustom)sender;
            Console.WriteLine($"Change {current.Index}  {e.ProgressPercentage}");
        }

        private void BwOnRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var current = (BackgroundWorkerCustom)sender;

            Console.WriteLine(current.Cancelled ? $"\t{current.Index} cancelled" : $"\t{current.Index} done");
        }

        private void BwOnDoWork(object sender, DoWorkEventArgs e)
        {
            var current = (BackgroundWorkerCustom)sender;
            if (Operations.Work(e, current)) return;

            current.ReportProgress(100);
        }

        private static bool Work(DoWorkEventArgs e, BackgroundWorkerCustom current)
        {
            for (int index = 0; index < 50; index++)
            {
                Thread.Sleep(1000);
                current.ReportProgress(index);

                if (current.CancellationPending)
                {
                    e.Cancel = true;
                    current.ReportProgress(0);
                    return true;
                }
            }

            return false;
        }

        private void CancelJobsButton_Click(object sender, EventArgs e)
        {
            if (_backgroundWorker.Any())
            {

                foreach (var custom in _backgroundWorker)
                {
                    if (custom.IsBusy)
                    {
                        custom.CancelAsync();
                        custom.Cancelled = true;
                        Console.WriteLine($"\t\tCancelled {custom.Index}");
                    }
                    
                }

                _backgroundWorker.Clear();
                _currentIndex = 0;
            }
        }

        private readonly List<Task> tasks = new List<Task>();
        private async void StartButton_Click(object sender, EventArgs e)
        {
            Task task1 = StartTask(1000);
            Task task2 = StartTask(3000);
            Task task3 = StartTask(10000);
            Task task4 = StartTask(8000);
            Task task5 = StartTask(5000);

            tasks.AddRange(new []{ task1, task2, task3, task4, task5 });

            // causes non-responsive user interface
            //Task.WaitAll(task1, task2, task3, task4, task5);

            await Task.WhenAll(tasks);

            // You will not get here until all tasks are finished (in 10 seconds)
            Console.WriteLine("Done!");
        }
        private static Task StartTask(int timeToWait)
        {
            return Task.Run(async () =>
            {
                Console.WriteLine($"Waiting {timeToWait}");
                await Task.Delay(timeToWait);
                Console.WriteLine($"Done waiting {timeToWait}");
            });
        }
    }
}
