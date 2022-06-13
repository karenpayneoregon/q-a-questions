using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAdapterFormApp
{
    public partial class Form1 : Form
    {
        private static string ConnectionString =
            "Data Source=.\\sqlexpress;Initial Catalog=ForumExample;Integrated Security=True";

        private SqlDataAdapter _sqlDataAdapter = new SqlDataAdapter();
        private readonly DataSet _dataSet = new DataSet();
        private readonly SqlConnection connection = new SqlConnection(ConnectionString);

        public Form1()
        {
            InitializeComponent();
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            _sqlDataAdapter = new SqlDataAdapter(
                "SELECT id, FirstName, LastName, HiredDate FROM dbo.employee;", 
                connection);

            _sqlDataAdapter.Fill(_dataSet);
            _ = new SqlCommandBuilder(_sqlDataAdapter);
            dataGridView1.DataSource = _dataSet.Tables[0];
            dataGridView1.Columns[0].ReadOnly = true;
        }

        private void UpDateAllButton_Click(object sender, EventArgs e)
        {
            _sqlDataAdapter.Update(_dataSet);
        }
    }
}
