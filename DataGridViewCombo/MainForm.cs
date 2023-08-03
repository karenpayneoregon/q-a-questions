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
            customersDataGridView.AllowUserToAddRows = false;
            customersDataGridView.Enter += CustomersDataGridViewOnEnter;

        }
        private void Setup()
        {

            customersDataGridView.AutoGenerateColumns = false;

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
            customersDataGridView.DataSource = _customerBindingSource;

            customersDataGridView.EditingControlShowing += CustomersDataGridViewOnEditingControlShowing;
            var currentRow = ((DataRowView)_customerBindingSource.Current).Row;
            //ColorIdLabel.Text = currentRow.Field<int>("ColorId").ToString();
            ColorIdLabel.DataBindings.Add("Text", _customerBindingSource, "ColorId", true);

 
        }


        // TODO
        private void CustomersDataGridViewOnEditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (!customersDataGridView.CurrentCell.IsComboBoxCell()) return;
            if (customersDataGridView.Columns[customersDataGridView.CurrentCell.ColumnIndex].Name != nameof(ColorComboBoxColumn)) return;
            if (!(e.Control is ComboBox cb)) return;
            cb.SelectionChangeCommitted -= SelectionChangeCommitted;
            cb.SelectionChangeCommitted += SelectionChangeCommitted;
        }

        private void SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (_customerBindingSource.Current == null) return;
            if (!string.IsNullOrWhiteSpace(((DataGridViewComboBoxEditingControl)sender).Text))
            {
                //CustomersDataGridView.EndEdit();
                DataRow currentRow = ((DataRowView)_customerBindingSource.Current).Row;

                ColorIdLabel.Text = currentRow.Field<int>("ColorId").ToString();
            }
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

            MessageBox.Show(colorName);
        }

        private void SetCurrentColorButton_Click(object sender, EventArgs e)
        {
            DataRow currentRow = ((DataRowView)_customerBindingSource.Current).Row;
            currentRow.SetField("ColorId", 1); // set to red in this case
        }

        private void GetTableButton_Click(object sender, EventArgs e)
        {
            var (table, exception) = Operations.Read();
            if (exception == null)
            {
                // use table
            }
            else
            {
                // deal with exception
            }
        }
        private void CustomersDataGridViewOnEnter(object sender, EventArgs e)
        {
            customersDataGridView.Rows[0].Cells[0].Selected = true;
            customersDataGridView.BeginEdit(false);
            customersDataGridView.Enter -= CustomersDataGridViewOnEnter;
        }
    }
}
