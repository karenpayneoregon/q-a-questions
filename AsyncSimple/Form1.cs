using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncSimple
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource _cts = new ();
        public Form1()
        {
            InitializeComponent();
        }

        private async void StartButton_Click(object sender, EventArgs e)
        {
            if (_cts.IsCancellationRequested)
            {
                _cts.Dispose();
                _cts = new CancellationTokenSource();
            }

            var progressIndicator = new Progress<int>(ReportProgress);

            try
            {
                await AsyncMethod(progressIndicator, _cts.Token);
            }
            catch (OperationCanceledException)
            {
                // do nothing
            }
        }

        private void CancelButton_Click(object sender, EventArgs egEventArgs)
        {
            _cts.Cancel();
            toolStripProgressBar1.Value = 0;
        }
        private static async Task AsyncMethod(IProgress<int> progress, CancellationToken ct)
        {

            for (int index = 1; index <= 100; index++)
            {
                //Simulate an async call that takes some time to complete
                await Task.Delay(50, ct);

                progress?.Report(index);

            }

        }

        private void ReportProgress(int value)
        {
            if (_cts.IsCancellationRequested)
            {
                return;
            }
            else
            {
                toolStripProgressBar1.Value = value;
            }
        }
    }
}
