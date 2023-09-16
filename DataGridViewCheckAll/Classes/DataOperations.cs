using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBoxColumnCount.Classes
{
    internal class DataOperations
    {
        private static readonly string ConnectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NorthWind2022;" + 
            "Integrated Security=True;Encrypt=False;";

        public static DataTable Read()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn()
            {
                ColumnName = "Process",
                DataType = typeof(bool),
                DefaultValue = false // if not set the default is null
            });

            var selectStatement = "SELECT CustomerIdentifier AS Identifier, CompanyName FROM  dbo.Customers";
            using (var cn = new SqlConnection { ConnectionString = ConnectionString })
            {
                using (var cmd = new SqlCommand { Connection = cn, CommandText = selectStatement})
                {
                    cn.Open();
                    dt.Load(cmd.ExecuteReader());
                    return dt;
                }
            }
        }
    }
}
