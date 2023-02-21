using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using DbPeekQueryLibrary.LanguageExtensions;

namespace SqlServerAsyncReadCore.Classes
{
    public class DataOperations
    {
        private static string _connectionString =
            "Data Source=.\\sqlexpress;Initial Catalog=NorthWind2020;Integrated Security=True";

        private static string _connectionString1 =
            "Data Source=.\\sqlexpress;Initial Catalog=ForumExample;Integrated Security=True";

        public static void GetDateTime()
        {
            using var cn = new SqlConnection(_connectionString1);
            using var cmd = new SqlCommand
            {
                Connection = cn,
                CommandText = "SELECT Created FROM dbo.AuditLog"
            };

            cn.Open();
            var reader = cmd.ExecuteReader();
            reader.Read();
            var created = reader.GetDateTime(0);

            var formatted = created.ToString("MM/dd/yyyy hh:mm:ss.fffffff");
            var timeOfDay = created.TimeOfDay.ToString();
            
        }

        public static DataSet ForumQuestion(string condition)
        {
            using var cn = new SqlConnection(_connectionString1);
            using var cmd = new SqlCommand
            {
                Connection = cn,
                CommandText = "SELECT id,FirstName,LastName FROM dbo.Persons1 WHERE LastName LIKE @LastNameCondition"
            };

            cmd.Parameters.Add("@LastNameCondition", SqlDbType.NVarChar).Value = $"%{condition}%";

            cn.Open();

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);

            return ds;

        }

        private static bool Update(string cardNumber, string pin, decimal deposit)
        {
            using var cn = new SqlConnection("Data Source=MAD-PC-023;Database=atmbd;Trusted_Connection=True;");
            using var cmd = new SqlCommand
            {
                Connection = cn,
                CommandText = 
                    """
                        UPDATE atmbd.atm 
                            SET Balance = Balance + @Deposit 
                        WHERE CardNumber = @CardNumber AND Pin = @Pin
                    """
            };
                
            cmd.Parameters.Add("@CardNumber", SqlDbType.NChar).Value = cardNumber;
            cmd.Parameters.Add("@Pin", SqlDbType.NChar).Value = pin;
            cmd.Parameters.Add("@Deposit", SqlDbType.Decimal).Value = deposit;

            cn.Open();
            return cmd.ExecuteNonQuery() == 1;
        }
        private static bool UpdateBad(string cardNumber, string pin, decimal deposit)
        {
            using var cn = new SqlConnection("Data Source=MAD-PC-023;Database=atmbd;Trusted_Connection=True;");
            using var cmd = new SqlCommand
            {
                Connection = cn,
                CommandText = $"""
                UPDATE atmbd.atm 
                    SET Balance = Balance + {deposit} 
                WHERE CardNumber = {cardNumber} AND Pin = {pin}
                """
            };

            cn.Open();
            return cmd.ExecuteNonQuery() == 1;
        }
        /// <summary>
        /// Stackoverflow
        /// https://stackoverflow.com/questions/74763115/i-created-a-windows-form-and-connect-it-to-database-but-i-got-a-error-while-run/74765025#74765025
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surName"></param>
        /// <param name="address"></param>
        public static void Insert(string name, string surName, string address)
        {
            using (var cn = new SqlConnection(_connectionString))
            {
                using var cmd = new SqlCommand
                {
                    Connection = cn,
                    CommandText = "INSERT INTO [MyTable] (Name, Surename, Address) VALUES (@Name, @SurName, @Address);"
                };

                cmd.Parameters.Add("@Name", SqlDbType.NChar).Value = name;
                cmd.Parameters.Add("@SurName", SqlDbType.NChar).Value = surName;
                cmd.Parameters.Add("@Address", SqlDbType.NChar).Value = address;

                cn.Open();

                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable Categories()
        {
            var catTable = new DataTable();

            using var cn = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand
            {
                Connection = cn,
                CommandText = "SELECT CategoryID,CategoryName,Picture  FROM dbo.Categories  WHERE CategoryID < 9"
            };
            cn.Open();
            catTable.Load(cmd.ExecuteReader());
            return catTable;
        }

        public static async Task<DataTable> ReadProductsTask(CancellationToken ct)
        {

            return await Task.Run(async () =>
            {
                var productTable = new DataTable();

                using (var cn = new SqlConnection(_connectionString))
                {
                    using (var cmd = new SqlCommand { Connection = cn, CommandText = SelectStatement() })
                    {
                        try
                        {
                            await cn.OpenAsync(ct);
                        }
                        catch (TaskCanceledException tce)
                        {
                            return null;
                        }
                        catch (Exception ex)
                        {
                            return null;
                        }

                        productTable.Load(await cmd.ExecuteReaderAsync());

                    }
                }



                return productTable;

            });

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
