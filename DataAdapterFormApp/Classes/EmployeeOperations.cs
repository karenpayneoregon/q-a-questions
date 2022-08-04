using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAdapterFormApp.Extensions;

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
            "Data Source=.\\sqlexpress;Initial Catalog=Examples;Integrated Security=True";

        private static SqlDataAdapter _sqlDataAdapter = new SqlDataAdapter();
        private static DataSet _dataSet;
        private static readonly SqlConnection connection = new SqlConnection(ConnectionString);
        public static readonly BindingSource BindingSource = new BindingSource();

        /// <summary>
        /// Read Employee data
        /// </summary>
        /// <remarks>
        /// _dataSet would normally be created once while in this case
        /// we create it each time for refreshing
        /// </remarks>
        public static (bool success, Exception exception) Load()
        {
            try
            {
                
                _dataSet = new DataSet();

                var selectStatement = "SELECT id, FirstName, LastName, HiredDate FROM dbo.employee;";
                _sqlDataAdapter = new SqlDataAdapter(selectStatement, connection);

                _sqlDataAdapter.Fill(_dataSet);
                _ = new SqlCommandBuilder(_sqlDataAdapter);
                _sqlDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                BindingSource.DataSource = _dataSet.Tables[0];

                return (true, null);
            }
            catch (Exception ex)
            {
                return (false, ex);
            }
        }

        /// <summary>
        /// Access current DataRow in the BindingSource
        /// </summary>
        public static DataRow Current() => ((DataRowView)BindingSource.Current).Row;

        /// <summary>
        /// Access underlying DataTable of the BindingSource
        /// </summary>
        public static DataTable DataTable() => (DataTable)BindingSource.DataSource;

        public static (bool hasChanges, DataTable table) ModifiedRecords()
        {
            var table = DataTable().GetChanges(DataRowState.Modified);
            return table == null ? (false, null) : (true, modified: table);
        }

        public static bool HasModified() => DataTable().GetChanges(DataRowState.Modified) != null;

        public static (bool hasChanges, DataTable table) Added()
        {
            var table = DataTable().GetChanges(DataRowState.Added);
            return table == null ? (false, null) : (true, modified: table);
        }
        
        public static bool HasNewRecords() => DataTable().GetChanges(DataRowState.Added) != null;

        public static bool HasDeletedRecords() => DataTable().GetChanges(DataRowState.Deleted) != null;

        public static (int affected, Exception exception) SaveChanges()
        {
            var count = -1;
            try
            {
                count = _sqlDataAdapter.Update(_dataSet);

                var table = DataTable();

                /*
                 * Set primary key from private var
                 */
                for (int rowIndex = 0; rowIndex < table.Rows.Count; rowIndex++)
                {
                    if (table.Rows[rowIndex][0] == DBNull.Value)
                    {
                        table.Rows[rowIndex].SetField("id", table.Rows[rowIndex].ObjectIdentifier());
                    }
                }
            }
            catch (Exception ex)
            {
                return (count, ex);
            }

            return (count, null);
        }
    }
}
