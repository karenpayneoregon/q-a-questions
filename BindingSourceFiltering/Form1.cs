using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BindingSourceFiltering.Classes;
using BindingSourceFiltering.Extensions;
using WinFormHelpers.LanguageExtensions;

namespace BindingSourceFiltering
{
    public partial class Form1 : Form
    {
        private BindingSource _bindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();

            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            // ReadProducts returns a DataTable, ignore data is from a database
            // as at this point there is zero relation to the database table
            _bindingSource.DataSource = Operations.ReadProducts();
            dataGridView1.DataSource = _bindingSource;
            dataGridView1.ExpandColumns();

            StartsWithTextBox.KeyUp += StartsWithTextBoxOnKeyUp;
            EndsWithTextBox.KeyUp += EndsWithTextBoxOnKeyUp;

            ActiveControl = StartsWithTextBox;
        }

        private void StartsWithTextBoxOnKeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(StartsWithTextBox.Text))
            {
                _bindingSource.RowFilterClear();
            }
            else
            {
                _bindingSource.RowFilterStartsWith("ProductName", StartsWithTextBox.Text);
            }
        }

        private void EndsWithTextBoxOnKeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EndsWithTextBox.Text))
            {
                _bindingSource.RowFilterClear();
            }
            else
            {
                _bindingSource.RowFilterEndsWith("ProductName", EndsWithTextBox.Text);
            }
        }

        private void TwoConditionsButton_Click(object sender, EventArgs e)
        {
            _bindingSource.RowFilterTwoConditions("ProductName", "Chai", "CategoryName", "Beverages");
        }
    }
}
