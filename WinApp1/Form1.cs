using System;
using static System.DateTime;
using System.Windows.Forms;
using WinApp1.Classes;

namespace WinApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Shown += Form1_Shown;

            foreach (var box in this.ComboBoxList())
            {
                box.DropDownStyle = ComboBoxStyle.DropDown;
                box.GotFocus += BoxOnGotFocus;
            }

            EnglishComboBox1.DataSource = Mocked.EnglishMonthList;
            EnglishComboBox1.SelectedIndex = Now.Month - 1;

            DateTimeOffset thisTime = new DateTimeOffset(
                new DateTime(Now.Year, Now.Month, Now.Day, 0, 0, 0), 
                new TimeSpan(-7, 0, 0));

            TimeZonesCombox.DataSource = Mocked.PossibleTimeZones(thisTime);
            TimeZonesCombox.SelectedIndex = 1;
        }

        private void BoxOnGotFocus(object sender, EventArgs e)
        {
            ((ComboBox)sender).Select(((ComboBox)sender).Text.Length, 0);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            foreach (var box in this.ComboBoxList())
            {
                box.InvokeIfRequired(cb => cb.Select(cb.Text.Length, 0));
            }
        }
    }
}
