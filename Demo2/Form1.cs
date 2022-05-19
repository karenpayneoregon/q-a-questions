using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetTimeButton_Click(object sender, EventArgs e)
        {
            string format = "Valid format is HH:mm";
            if (!string.IsNullOrWhiteSpace(TimeTextBox.Text))
            {
                TimeLabel.Text = DateTime.TryParseExact(TimeTextBox.Text, "HH:mm", 
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out var time) ?
                    time.ToShortTimeString() : 
                    format;
            }
            else
            {
                TimeLabel.Text = format;
            }
        }
    }
}
