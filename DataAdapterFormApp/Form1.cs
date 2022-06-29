using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DataAdapterFormApp.Extensions;

namespace DataAdapterFormApp
{
    /// <summary>
    /// https://social.msdn.microsoft.com/Forums/vstudio/en-US/98bfec38-f7f7-45a8-a980-d0931b54ce87/how-to-get-rowid-value-or-objectid-from-datarow?forum=vbgeneral
    /// </summary>
    public partial class Form1 : Form
    {
        private static string ConnectionString =
            "Data Source=.\\sqlexpress;Initial Catalog=ForumExample;Integrated Security=True";

        private SqlDataAdapter _sqlDataAdapter = new SqlDataAdapter();
        private readonly DataSet _dataSet = new DataSet();
        private readonly SqlConnection connection = new SqlConnection(ConnectionString);
        private readonly BindingSource _bindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            Shown += OnShown;
        }

        /// <summary>
        /// Populate the DataTable with zero records
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnShown(object sender, EventArgs e)
        {
            _sqlDataAdapter = new SqlDataAdapter("SELECT id, FirstName, LastName, HiredDate FROM dbo.employee;", connection);

            _sqlDataAdapter.Fill(_dataSet);
            _ = new SqlCommandBuilder(_sqlDataAdapter);
            _sqlDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            _bindingSource.DataSource = _dataSet.Tables[0];
            dataGridView1.DataSource = _bindingSource;
            dataGridView1.Columns[0].ReadOnly = true;
        }

        private void UpDateAllButton_Click(object sender, EventArgs e)
        {
            _sqlDataAdapter.Update(_dataSet);
        }

        private void InspectButton_Click(object sender, EventArgs e)
        {
            var current = ((DataRowView)_bindingSource.Current).Row;
            var rowId = current.ObjectIdentifier();

        }

        private void FixIdButton_Click(object sender, EventArgs e)
        {
            var table = (DataTable)_bindingSource.DataSource;

            for (int rowIndex = 0; rowIndex < table.Rows.Count; rowIndex++)
            {
                if (table.Rows[rowIndex][0] == DBNull.Value)
                {
                    Console.WriteLine();
                }

            }
        }
    }
}
