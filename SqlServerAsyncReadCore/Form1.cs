using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlServerAsyncReadCore.Classes;
using static System.Globalization.DateTimeFormatInfo;
namespace SqlServerAsyncReadCore
{
    public partial class Form1 : Form
    {
        private readonly CancellationTokenSource _cancellationTokenSource = new();

        public Form1()
        {
            InitializeComponent();

            Shown += OnShown;
        }

        private async void OnShown(object sender, EventArgs e)
        {
            var table = await DataOperations.ReadProductsTask(_cancellationTokenSource.Token);

            dataGridView1.DataSource = table;
            dataGridView1.Columns["CompanyName"].Frozen = true;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var table = await DataOperations.ReadProductsTask(_cancellationTokenSource.Token);

            dataGridView1.DataSource = table;
            dataGridView1.Columns["CompanyName"].Frozen = true;
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParse(TextBox1.Text.Trim(), out var dateTime))
            {
                var (success, exception, id) = DataOperations.AddNewRecord(dateTime);
                if (success)
                {
                    // we can use id var
                }
                else
                {
                    // failure - log error using exception var about
                }
            }
            else
            {
                // not a valid date time, tell the user
            }
        }

        private void AgeButton_Click(object sender, EventArgs e)
        {
            DataOperations.GetAge();
        }
    }


}
