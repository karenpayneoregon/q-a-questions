﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

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

        private static bool Update(string cardNumber, string pin, decimal deposit)
        {
            using (var cn = new SqlConnection("Data Source=MAD-PC-023;Database=atmbd;Trusted_Connection=True;"))
            {
                using var cmd = new SqlCommand
                {
                    Connection = cn,
                    CommandText = "UPDATE atmbd.atm SET Balance = Balance + @Deposit WHERE CardNumber = @CardNumber AND Pin = @Pin"
                };
                
                cmd.Parameters.Add("@CardNumber", SqlDbType.NChar).Value = cardNumber;
                cmd.Parameters.Add("@Pin", SqlDbType.NChar).Value = pin;
                cmd.Parameters.Add("@Deposit", SqlDbType.Decimal).Value = deposit;

                cn.Open();
                return cmd.ExecuteNonQuery() == 1;
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

                using var cn = new SqlConnection(_connectionString);
                using var cmd = new SqlCommand { Connection = cn, CommandText = SelectStatement() };
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
