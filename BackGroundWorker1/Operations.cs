using System.ComponentModel;
using System.Threading;

namespace BackGroundWorker1
{
    public class Operations
    {
        public static bool Work(DoWorkEventArgs e, BackgroundWorkerCustom current)
        {

            for (int index = 0; index < 5; index++)
            {
                Thread.Sleep(1000);
                current.ReportProgress(index);

                if (!current.CancellationPending) continue;
                e.Cancel = true;
                current.ReportProgress(0);
                return true;
            }

            return false;

        }
    }
}
