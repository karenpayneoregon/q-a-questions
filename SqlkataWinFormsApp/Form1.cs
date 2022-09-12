using SqlKata;
using SqlKata.Compilers;
using SqlKata.Execution;
using System.Data.SqlClient;

namespace SqlkataWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// https://sqlkata.com/docs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BuildButton_Click(object sender, EventArgs e)
        {
            using var cn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=NorthWind2020;Integrated Security=True");
            SqlServerCompiler compiler = new ();

            var db = new QueryFactory(cn, compiler);

            var query = db.Query("Contacts");

            // add first condition
            query = query.Where("FirstName", ContactFirstNameComboBox.Text);

            // add another condition
            query = query.Where("LastName", ContactLastNameComboBox.Text);
            SqlResult result = compiler.Compile(query);

            // this is the SQL statement parameterized
            string sql = result.Sql;
            

        }
    }
}