using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using BasicReadWriteJson.Classes;
using BasicReadWriteJson.Models;


namespace BasicReadWriteJson
{
    public partial class Form1 : Form
    {
        private BindingList<Products> _productsList;
        private readonly BindingSource _productsBindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();

            Shown += OnShown;
            Closing += OnClosing;
        }

        private void OnClosing(object sender, CancelEventArgs e)
        {
            DataOperations.WriteProducts(_productsList.ToList());
        }

        private void OnShown(object sender, EventArgs e)
        {
            _productsList = new SortableBindingList<Products>(DataOperations.ReadProductsList());
            _productsBindingSource.DataSource = _productsList;
            dataGridView1.DataSource = _productsBindingSource;
            _productsBindingSource.Sort = "ProductName";

            for (int index = 0; index < dataGridView1.Columns.Count; index++)
            {
                if (dataGridView1.Columns[index].Name.EndsWith("ID"))
                {
                    dataGridView1.Columns[index].Visible = false;
                }
            }
            
        }

        private void CurrentButton_Click(object sender, EventArgs e)
        {
            if (_productsBindingSource.Current == null) return;
            // provides access to the current DataGridView row as a Product
            Products current = _productsList[_productsBindingSource.Position];
        }
        /// <summary>
        /// Never need this when setting up a data source for the DataGridView
        /// </summary>
        private void PeekButton_Click(object sender, EventArgs e)
        {
            var row = dataGridView1.Rows[_productsBindingSource.Position];

            for (var index = 0; index < row.Cells.Count; index++)
            {
                DataGridViewCell cell = row.Cells[index];
                Console.WriteLine($@"{row.Cells[cell.ColumnIndex].OwningColumn.Name,-20}{row.Cells[cell.ColumnIndex].ValueType.Name}");
            }
        }
    }
}
