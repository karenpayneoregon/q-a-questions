using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace CheckedListBoxLastChecked
{
    public partial class Form1 : Form
    {
        private readonly LastChecked _lastChecked = new LastChecked() {Index = -1};
        public Form1()
        {
            InitializeComponent();
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            var months = DateTimeFormatInfo.CurrentInfo.MonthNames.Take(12).ToList();
            checkedListBox1.DataSource = months;
            checkedListBox1.ItemCheck += CheckedListBox1OnItemCheck;
        }

        private void CheckedListBox1OnItemCheck(object sender, ItemCheckEventArgs e)
        {
           
            _lastChecked.CheckState = e.NewValue;
            _lastChecked.Index = e.Index;
        }

        private void LastCheckedButton_Click(object sender, EventArgs e)
        {
            if (_lastChecked.Index > -1)
            {
                MessageBox.Show($"Index: {_lastChecked.Index,-5}{_lastChecked.CheckState}");
            }
            else
            {
                MessageBox.Show("Nothing checked yet");
            }
        }

  
    }

    public class LastChecked
    {
        public int Index { get; set; }
        public CheckState CheckState { get; set; }

    }

    
}
