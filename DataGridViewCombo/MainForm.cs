using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DataGridViewCombo1.Classes;

namespace DataGridViewCombo1
{
    public partial class MainForm : Form
    {

        readonly BindingSource _customerBindingSource = new BindingSource();
        readonly BindingSource _colorBindingSource = new BindingSource();
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Setup();
            CustomersDataGridView.AllowUserToAddRows = false;
            
        }
        private void Setup()
        {

            CustomersDataGridView.AutoGenerateColumns = false;

            var (customerTable, colorTable) = DataOperations.LoadData();

            _colorBindingSource.DataSource = colorTable;

            ColorComboBoxColumn.DisplayMember = "ColorText";
            ColorComboBoxColumn.ValueMember = "ColorId";
            ColorComboBoxColumn.DataPropertyName = "ColorId";

            ColorComboBoxColumn.DataSource = _colorBindingSource;

            ColorComboBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;


            ItemTextBoxColumn.DataPropertyName = "Item";
            _customerBindingSource.DataSource = customerTable;

            bindingNavigator1.BindingSource = _customerBindingSource;
            CustomersDataGridView.DataSource = _customerBindingSource;
            
        }
        /// <summary>
        /// access current row data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CurrentButton_Click(object sender, EventArgs e)
        {
            var customerRow = ((DataRowView)_customerBindingSource.Current).Row;

            var colorName = (_colorBindingSource.DataSource as DataTable).AsEnumerable()
                .FirstOrDefault(row => row.Field<int>("ColorId") == customerRow.Field<int>("ColorId"))
                .Field<string>("ColorText");

        }
    }
}
