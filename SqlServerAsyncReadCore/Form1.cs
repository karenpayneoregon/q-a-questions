using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using SqlServerAsyncReadCore.Classes;

namespace SqlServerAsyncReadCore
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource _cancellationTokenSource = new();
        private BindingSource _bindingSource = new ();
        public Form1()
        {
            InitializeComponent();
            
            Shown += OnShown;
            DataOperations.GetDateTime();
        }

        private async void OnShown(object sender, EventArgs e)
        {
            //var table = await DataOperations.ReadProductsTask(_cancellationTokenSource.Token);
            _bindingSource.DataSource = await DataOperations.ReadProductsTask(_cancellationTokenSource.Token);
            dataGridView1.DataSource = _bindingSource;
            dataGridView1.Columns["CompanyName"].Frozen = true;
            _bindingSource.PositionChanged += _bindingSource_PositionChanged;
        }

        private void _bindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (_bindingSource.Current != null)
            {
                DataRow row = ((DataRowView)_bindingSource.Current).Row;
                Key = row.Field<int>("ProductID");
                Text = Key.ToString();
            }
        }

        private int Key;


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

        private void ChunkButton_Click(object sender, EventArgs e)
        {
            DataTable dataTable = (DataTable)dataGridView1.DataSource;

            DataHelper.DataTableToFiles(dataTable, true, 20, "tableData1");
        }


    }
}
