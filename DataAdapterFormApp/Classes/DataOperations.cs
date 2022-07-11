using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DataAdapterFormApp.Classes
{
    /// <summary>
    /// For
    /// https://docs.microsoft.com/en-us/answers/questions/912193/my-method-takes-a-long-time-to-save-a-lot-of-infor.html
    /// </summary>
    public class DataOperations
    {
        public static string ConnectionString => "TODO";

        private static OleDbDataAdapter _sqlDataAdapter = new OleDbDataAdapter();
        private static readonly DataSet _dataSet = new DataSet();
        private static readonly OleDbConnection connection = new OleDbConnection(ConnectionString);
        public static readonly BindingSource BindingSource = new BindingSource();

        /// <summary>
        /// Get data specified in the SELECT statement
        /// </summary>
        /// <returns></returns>
        public static (bool success, Exception exception) Load()
        {
            try
            {
                var selectStatement = "SELECT id, FirstName, LastName, HiredDate FROM dbo.employee;";
                _sqlDataAdapter = new OleDbDataAdapter(selectStatement, connection);

                _sqlDataAdapter.Fill(_dataSet);

                // setup SQL commands e.g. insert, edit, delete
                _ = new OleDbCommandBuilder(_sqlDataAdapter);

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
        /// Get current row in grid
        /// </summary>
        public static DataRow Current() 
            => ((DataRowView)BindingSource.Current).Row;

        /// <summary>
        /// Get DataTable so we need not cast in user code
        /// </summary>
        public static DataTable DataTable() 
            => (DataTable)BindingSource.DataSource;

        /// <summary>
        /// Check if modified records and provide a DataTable to examine
        /// Caller should deconstruct for clearly working with return information
        /// </summary>
        public static (bool hasChanges, DataTable table) ModifiedRecords()
        {
            var table = DataTable().GetChanges(DataRowState.Modified);
            return table == null ? (false, null) : (true, modified: table);
        }
        /// <summary>
        /// Determine if there are modified records
        /// </summary>
        public static bool HasModified() 
            => DataTable().GetChanges(DataRowState.Modified) != null;

        /// <summary>
        /// Check if added records and provide a DataTable to examine
        /// Caller should deconstruct for clearly working with return information
        /// </summary>
        public static (bool hasChanges, DataTable table) Added()
        {
            var table = DataTable().GetChanges(DataRowState.Added);
            return table == null ? (false, null) : (true, modified: table);
        }

        /// <summary>
        /// Determine if there are no records
        /// </summary>
        public static bool HasNewRecords() => 
            DataTable().GetChanges(DataRowState.Added) != null;

        /// <summary>
        /// Determine if one or more records have been deleted
        /// </summary>
        public static bool HasDeletedRecords() => 
            DataTable().GetChanges(DataRowState.Deleted) != null;

        /// <summary>
        /// Save changed, return count of changes and if there was an
        /// exception provide access to it to the caller
        /// </summary>
        /// <returns></returns>
        public static (int affected, Exception exception) SaveChanges()
        {
            var count = -1;
            try
            {
                count = _sqlDataAdapter.Update(_dataSet);
            }
            catch (Exception ex)
            {
                return (count, ex);
            }

            return (count, null);
        }


    }
}
