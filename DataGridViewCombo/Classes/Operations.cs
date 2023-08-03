using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataGridViewCombo1.Classes
{
    public class Operations
    {
        private static string _connectionString =
            ConfigurationManager.ConnectionStrings["DefaultConnection"]
                .ConnectionString;

        public static (DataTable table, Exception exception) Read()
        {

            var dt = new DataTable();

            using (var cn = new SqlConnection { ConnectionString = _connectionString })
            {
                using (var cmd = new SqlCommand { Connection = cn })
                {
                    cmd.CommandText = "SELECT CategoryID, CategoryName FROM dbo.Categories;";
                    try
                    {
                        cn.Open();
                        dt.Load(cmd.ExecuteReader());
                        return (dt, null);
                    }
                    catch (Exception localException)
                    {
                        return (null,localException);
                    }
                }
            }
        }
    }
}
