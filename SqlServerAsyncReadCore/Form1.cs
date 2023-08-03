using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Reflection;
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
            //dataGridView1.Columns["CompanyName"].Frozen = true;
            dataGridView1.Columns["ProductID"].Visible = false;
            dataGridView1.Columns["SupplierID"].Visible = false;
            dataGridView1.Columns["CategoryID"].Visible = false;
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

        private void button3_Click(object sender, EventArgs e)
        {
            
            foreach (Form form in Application.OpenForms)
            {
                var componentList = GetComponents(form).ToList();
            }
        }
        private IEnumerable<Component> EnumerateComponents()
        {
            return from field in GetType().GetFields(
                    BindingFlags.Instance | 
                    BindingFlags.Public | 
                    BindingFlags.NonPublic)
                where typeof(Component).IsAssignableFrom(field.FieldType)
                let component = (Component)field.GetValue(this)
                where component != null
                select component;
        }
        public IEnumerable<Component> GetComponents(Control c)
        {
            FieldInfo fi = c.GetType().GetField("components", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)!;
            if (fi?.GetValue(c) is IContainer container)
            {
                return container.Components.OfType<Component>();
            }
            else
            {
                return Enumerable.Empty<Component>();
            }
        }
    }
}
