using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAdapterFormApp.Classes
{
    /// <summary>
    /// Code sample for
    /// 1. Loading a table from SQL-Server
    /// 2. Saving all changes
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    public class EmployeeOperations
    {
        public static string ConnectionString => 
            "Data Source=.\\sqlexpress;Initial Catalog=ForumExample;Integrated Security=True";

        private static SqlDataAdapter _sqlDataAdapter = new SqlDataAdapter();
        private static readonly DataSet _dataSet = new DataSet();
        private static readonly SqlConnection connection = new SqlConnection(ConnectionString);
        public static readonly BindingSource _bindingSource = new BindingSource();

        public static void Load()
        {
            var  selectStatement = "SELECT id, FirstName, LastName, HiredDate FROM dbo.employee;";
            _sqlDataAdapter = new SqlDataAdapter(selectStatement, connection);

            _sqlDataAdapter.Fill(_dataSet);
            _ = new SqlCommandBuilder(_sqlDataAdapter);
            _sqlDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            _bindingSource.DataSource = _dataSet.Tables[0];
        }

        public static int SaveChanges() => _sqlDataAdapter.Update(_dataSet);
    }
}
