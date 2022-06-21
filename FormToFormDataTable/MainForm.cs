using System;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;
using StackoverflowQuestion.Classes;

namespace StackoverflowQuestion
{
    public partial class MainForm : Form
    {
        private readonly BindingSource _bindingSource = 
            new BindingSource();

        public MainForm()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;

            DataTable table = new DataTable();
            table.Columns.Add("FirstName", typeof(string));
            table.Columns.Add("LastName", typeof(string));

            _bindingSource.DataSource = table;
            dataGridView1.DataSource = _bindingSource;

        }

        private void ShowChildFormButton_Click(object sender, EventArgs e)
        {
            var childForm = new ChildForm();
            childForm.AddPerson += OnAddPerson;
            childForm.ShowDialog();
            childForm.Dispose();
        }

        private void OnAddPerson(string firstname, string lastname)
        {

            var table = ((DataTable) _bindingSource.DataSource);

            DataRow rowData = table.AsEnumerable()
                .FirstOrDefault(row =>
                    row.Field<string>("FirstName").IgnoreCaseEquals(firstname) &&
                    row.Field<string>("LastName").IgnoreCaseEquals(lastname));

            if (rowData == null)
            {
                table.Rows.Add(firstname, lastname);
            }

        }
    }
}
