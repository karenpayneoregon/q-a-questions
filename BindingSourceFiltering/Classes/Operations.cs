using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace BindingSourceFiltering.Classes
{
    public class Operations
    {
        private static string _connectionString =
            "Data Source=.\\SQLEXPRESS;Initial Catalog=NorthWind2020;Integrated Security=True";


        public static DataTable ReadProducts()
        {

            var productTable = new DataTable();

            using var cn = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand { Connection = cn, CommandText = SelectStatement() };
            cn.Open();
            
            productTable.Load(cmd.ExecuteReader());

            foreach (DataColumn column in productTable.Columns)
            {
                if (column.ColumnName.EndsWith("ID", StringComparison.OrdinalIgnoreCase))
                {
                    column.ColumnMapping = MappingType.Hidden;
                }
            }

            return productTable;
        }
        private static string SelectStatement()
        {
            return "SELECT P.ProductID, P.ProductName, P.SupplierID, S.CompanyName, P.CategoryID, " +
                   "C.CategoryName " +
                   "FROM  Products AS P INNER JOIN Categories AS C ON P.CategoryID = C.CategoryID " +
                   "INNER JOIN Suppliers AS S ON P.SupplierID = S.SupplierID ORDER BY P.ProductName";
        }
    }

}
