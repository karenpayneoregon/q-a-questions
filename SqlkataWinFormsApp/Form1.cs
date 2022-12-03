using System.Data;
using SqlKata;
using SqlKata.Compilers;
using SqlKata.Execution;
using System.Data.SqlClient;
using System.Diagnostics;

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

            var query = db.Query("Contacts").Limit(2);
            
            //// add first condition
            //query = query.Where("FirstName", ContactFirstNameComboBox.Text);
            //// add another condition
            //query = query.Where("LastName", ContactLastNameComboBox.Text);
            SqlResult result = compiler.Compile(query);

            // this is the SQL statement parameterized
            string sql = result.Sql;
            Debug.WriteLine(sql);
            using var cmd = new SqlCommand() { Connection = cn, CommandText = sql};
            cn.Open();

            DataTable table = new DataTable();
            //table.Load(cmd.ExecuteReader());

            Console.WriteLine();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using var cn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=NorthWind2020;Integrated Security=True");
            var compiler = new SqlServerCompiler();
            var db = new QueryFactory(cn, compiler);
            var query = db.Query("Contacts").Limit(3).Get<Contact>();

            foreach (var contact in query)
            {
                Debug.WriteLine(contact);
            }


        }
    }

    public class Contact
    {
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ContactTypeIdentifier { get; set; }
        public override string ToString() => $"{FirstName} {LastName}";

    }
}