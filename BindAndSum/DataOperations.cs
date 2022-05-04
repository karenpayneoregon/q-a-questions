using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindAndSum
{
    public class DataOperations
    {
        // caller validates parameters have values
        public static Login DoSomething(string userName, string sifre)
        {
            Login login = new Login();

            var selectStatement = "SELECT * FROM login WHERE username= @userName AND sifre = @sifre";

            using (var cn = new SqlConnection("TODO"))
            {
                using (var cmd = new SqlCommand(selectStatement, cn))
                {
                    cmd.Parameters.Add("@userName", SqlDbType.NVarChar).Value = userName;
                    cmd.Parameters.Add("@sifre", SqlDbType.NVarChar).Value = sifre;

                    cn.Open();

                    var reader = cmd.ExecuteReader();

                    if (!reader.HasRows) return login;
                    reader.Read();
                    login.Id = reader.GetInt32(0);
                }
            }

            return login;
        }
    }

    public class Login
    {
        public int Id { get; set; }
    }
}
