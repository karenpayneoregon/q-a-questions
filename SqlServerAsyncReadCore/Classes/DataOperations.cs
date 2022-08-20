using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace SqlServerAsyncReadCore.Classes
{
    public class DataOperations
    {
        private static string _connectionString =
            "Data Source=.\\sqlexpress;Initial Catalog=NorthWind2020;Integrated Security=True";
        private static string _connectionString1 =
            "Data Source=.\\sqlexpress;Initial Catalog=Examples;Integrated Security=True";

        public static (bool success, Exception exception, int id) AddNewRecord(DateTime dateTime)
        {
            using var cn = new SqlConnection { ConnectionString = _connectionString1 };
            using var cmd = new SqlCommand { Connection = cn };
            cmd.CommandText = "INSERT INTO dbo.Table1 (SomeDateTime) " +
                              "VALUES (@SomeDateTime);" +
                              "SELECT CAST(scope_identity() AS int);";

            cmd.Parameters.Add("@SomeDateTime", SqlDbType.DateTime).Value = dateTime;

            try
            {
                cn.Open();
                return (true, null, Convert.ToInt32(cmd.ExecuteScalar()));

            }
            catch (Exception ex)
            {
                return (false, ex, -1);
            }
        }
        public static async Task<DataTable> ReadProductsTask(CancellationToken ct)
        {

            return await Task.Run(async () =>
            {
                var productTable = new DataTable();

                using var cn = new SqlConnection(_connectionString);
                using var cmd = new SqlCommand {Connection = cn, CommandText = SelectStatement()};
                try
                {
                    await cn.OpenAsync(ct);
                    Debug.WriteLine("Open");
                }
                catch (TaskCanceledException tce)
                {
                    return null;
                }
                catch (Exception ex)
                {
                    return null;
                }

                productTable.Load(await cmd.ExecuteReaderAsync(ct));

                return productTable;

            });

        }

        public static void GetAge(DateTime date)
        {
            using var cn = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand
            {
                Connection = cn, 
                CommandText = "select (0 + Convert(Char(8),@FromDate,112) - Convert(Char(8),@BirthDate,112)) / 10000"
                
            };

            cmd.Parameters.Add("@FromDate", SqlDbType.Date).Value = date;
            cmd.Parameters.Add("@BirthDate", SqlDbType.Date).Value = new DateTime(1956, 9, 24);
            cn.Open();

            var age = (int)cmd.ExecuteScalar();
        }

        private static string SelectStatement()
        {
            return "SELECT P.ProductID, P.ProductName, P.SupplierID, S.CompanyName, P.CategoryID, " +
                   "C.CategoryName, P.QuantityPerUnit, P.UnitPrice, P.UnitsInStock, P.UnitsOnOrder, " +
                   "P.ReorderLevel, P.Discontinued, P.DiscontinuedDate " +
                   "FROM  Products AS P INNER JOIN Categories AS C ON P.CategoryID = C.CategoryID " +
                   "INNER JOIN Suppliers AS S ON P.SupplierID = S.SupplierID";
        }

    }

}
