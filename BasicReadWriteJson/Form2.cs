using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicReadWriteJson.Classes;
using BasicReadWriteJson.Extensions;

namespace BasicReadWriteJson
{
    public partial class Form2 : Form
    {
        private readonly BindingSource bindingSource = new BindingSource();
        public Form2()
        {
            InitializeComponent();

            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {

            bindingSource.DataSource = DataOperations.ReadProductsDataTable(); ;
            dataGridView1.DataSource = bindingSource;
            dataGridView1.HideIdentifiers();
            dataGridView1.ExpandColumns();
        }

        private void CurrentButton_Click(object sender, EventArgs e)
        {
            // here you can access column data
            var row = ((DataRowView)bindingSource.Current).Row;
        }

        private void IncreaseButton_Click(object sender, EventArgs e)
        {
            var row = ((DataRowView)bindingSource.Current).Row;
            row.SetField("UnitsInStock", row.Field<Int64>("UnitsInStock") + 1);
        }

        private void DecreaseButton_Click(object sender, EventArgs e)
        {
            var row = ((DataRowView)bindingSource.Current).Row;
            row.SetField("UnitsInStock", row.Field<Int64>("UnitsInStock") - 1);
        }
    }
}
