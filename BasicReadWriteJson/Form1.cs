using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using BasicReadWriteJson.Classes;
using BasicReadWriteJson.Extensions;
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

            dataGridView1.HideIdentifiers();
            dataGridView1.ExpandColumns();

        }

        private void CurrentButton_Click(object sender, EventArgs e)
        {
            if (_productsBindingSource.Current == null) return;
            Products current = _productsList[_productsBindingSource.Position];
        }

        private void IncreaseButton_Click(object sender, EventArgs e)
        {
            if (_productsBindingSource.Current == null) return;

            Products current = _productsList[_productsBindingSource.Position];
            current.UnitsInStockUpDown();
        }

        private void DecreaseButton_Click(object sender, EventArgs e)
        {
            if (_productsBindingSource.Current == null) return;

            Products current = _productsList[_productsBindingSource.Position];
            current.UnitsInStockUpDown(false);
        }
    }
}
