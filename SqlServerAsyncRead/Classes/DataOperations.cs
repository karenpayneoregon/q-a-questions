using System;
using System.Data;
using System.Data.SqlClient;

using System.Threading;
using System.Threading.Tasks;

namespace SqlServerAsyncRead.Classes
{
    public class DataOperations
    {
        private const string ConnectionString 
            = "Data Source=.\\sqlexpress;Initial Catalog=NorthWind2020;Integrated Security=True";

        public delegate void OnProcessing(string text);
        public static event OnProcessing Processed;

        // call a method to indicate time to reorder the product
        public delegate void OnReorder(int productId);
        public static event OnReorder Reorder;

        public static void UpdateProductStockCount(int id, int amount)
        {
            using (var cn = new SqlConnection(ConnectionString))
            {
                using (var cmd = new SqlCommand() { Connection = cn })
                {
                    cmd.CommandText = "SELECT UnitsInStock FROM dbo.Products WHERE ProductID = @Id";
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;

                    cn.Open();

                    var currentCount = (short)cmd.ExecuteScalar();
                    if (currentCount - amount < 0)
                        Processed?.Invoke("Insufficient stock");
                    else
                    {
                        cmd.CommandText = "UPDATE dbo.Products SET UnitsInStock = @InStock WHERE ProductID = @Id";
                        cmd.Parameters.Add("@InStock", SqlDbType.Int).Value = currentCount - amount;
                        cmd.ExecuteNonQuery();
                        Reorder?.Invoke(id);
                        Processed?.Invoke("Processed");
                    }
                
                } 
            }
        }
        public static async Task<DataTableResults> ReadProductsTask(CancellationToken ct)
        {
            var result = new DataTableResults() {DataTable = new DataTable()};

            return await Task.Run(async () =>
            {
                using (var cn = new SqlConnection(ConnectionString))
                {

                    using (var cmd = new SqlCommand() { Connection = cn })
                    {

                        cmd.CommandText = SelectStatement();
                        
                        try
                        {
                            await cn.OpenAsync(ct);
                        }
                        catch (TaskCanceledException tce)
                        {
                            Exceptions.Write(tce, ExceptionLogType.ConnectionFailure, $"Connection string '{ConnectionString}'" );
                            result.ConnectionFailed = true;
                            result.ExceptionMessage = "Connection Failed";
                            return result;
                        }
                        catch (Exception ex)
                        {
                            Exceptions.Write(ex, ExceptionLogType.General);
                            result.GeneralException = ex;
                            return result;
                        }

                        result.DataTable.Load(await cmd.ExecuteReaderAsync(ct));

                        result.DataTable.Columns["ProductID"].ColumnMapping = MappingType.Hidden;
                    }

                }

                return result;
                
            }, ct);

        }

        // works just fine, opt out to use lesser columns in SelectStatement
        private static string SelectStatement1()
        {
            return "SELECT P.ProductID, P.ProductName, P.SupplierID, S.CompanyName, P.CategoryID, " + 
                   "C.CategoryName, P.QuantityPerUnit, P.UnitPrice, P.UnitsInStock, P.UnitsOnOrder, " + 
                   "P.ReorderLevel, P.Discontinued, P.DiscontinuedDate " + 
                   "FROM  Products AS P INNER JOIN Categories AS C ON P.CategoryID = C.CategoryID " + 
                   "INNER JOIN Suppliers AS S ON P.SupplierID = S.SupplierID";
        }
        private static string SelectStatement()
        {
            return "SELECT P.ProductID, P.ProductName, S.CompanyName, " +
                   "C.CategoryName, P.UnitPrice, P.UnitsInStock, P.UnitsOnOrder, " +
                   "P.DiscontinuedDate " +
                   "FROM  Products AS P INNER JOIN Categories AS C ON P.CategoryID = C.CategoryID " +
                   "INNER JOIN Suppliers AS S ON P.SupplierID = S.SupplierID";
        }

    }

}
