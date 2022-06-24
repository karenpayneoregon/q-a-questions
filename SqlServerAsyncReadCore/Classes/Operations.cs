using System.Data;
using System.Data.SqlClient;

namespace SqlServerAsyncReadCore.Classes
{
    /// <summary>
    /// For stack overflow question
    /// </summary>
    public class Operations
    {
        private static string _connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;" + 
            @"AttachDbFilename=E:\desk\new\abusalem\abusalem\Database1.mdf;" + 
            "Integrated Security=True";

        public static bool Remove(int id)
        {
            using var cn = new SqlConnection( _connectionString);
            using var cmd = new SqlCommand() {Connection = cn};
            cmd.CommandText = "delete from datauser where id=@Id";
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            return cmd.ExecuteNonQuery() == 1;
        }
    }
}
