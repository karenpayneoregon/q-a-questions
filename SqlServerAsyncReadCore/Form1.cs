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
using SqlServerAsyncReadCore.Classes;

namespace SqlServerAsyncReadCore
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();
        public Form1()
        {
            InitializeComponent();
            
            //Shown += OnShown;
            DataOperations.GetDateTime();
        }

        private async void OnShown(object? sender, EventArgs e)
        {
            var table = await DataOperations.ReadProductsTask(_cancellationTokenSource.Token);

            dataGridView1.DataSource = table;
            dataGridView1.Columns["CompanyName"].Frozen = true;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var table = await DataOperations.ReadProductsTask(_cancellationTokenSource.Token);

            table.Columns["ProductID"].ColumnMapping = MappingType.Hidden;
            table.Columns["SupplierID"].ColumnMapping = MappingType.Hidden;
            table.Columns["CategoryID"].ColumnMapping = MappingType.Hidden;
            dataGridView1.DataSource = table;

            dataGridView1.Columns["CompanyName"].Frozen = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable table = dataGridView1.GetDataTable();
        }
    }
}
