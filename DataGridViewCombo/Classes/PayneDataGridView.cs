using System;
using System.Windows.Forms;

namespace DataGridViewCombo1.Classes
{
    public class PayneDataGridView : DataGridView
    {
        private bool _firstTime = true;

        protected override void OnEnter(EventArgs e)
        {
            if (DataSource != null)
            {
                if (_firstTime)
                {
                    CurrentCell = Rows[0].Cells[1];
                    Timer timer = new Timer();
                    timer.Interval = 20;
                    timer.Tick += (ts, te) => {
                        timer.Stop();
                        BeginEdit(false);
                    };
                    timer.Start();

                    _firstTime = false;
                }
            }
        }
    }

    public class KarenDataGridView : DataGridView
    {
        private bool _firstTime = true;
        protected override void Select(bool directed, bool forward)
        {
            if (DataSource != null)
            {
                if (_firstTime)
                {
                    CurrentCell = Rows[0].Cells[1];
                    Timer timer = new Timer();
                    timer.Interval = 20;
                    timer.Tick += (ts, te) => {
                        timer.Stop();
                        BeginEdit(false);
                    };
                    timer.Start();

                    _firstTime = false;
                }
            }
            else
            {
                base.Select(directed, forward);
            }
        }

    }

}
