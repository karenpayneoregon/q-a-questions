using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataGridViewCombo1.Classes
{
    public class DataOperations
    {
        private static readonly string ConnectionString = 
            "Data Source=.\\sqlexpress;Initial Catalog=DataGridViewCodeSample;Integrated Security=True";

        public static (DataTable customerTable, DataTable colorTable) LoadData()
        {
            var dtCustomer = new DataTable();
            var dtColor = new DataTable();

            using (var cn = new SqlConnection { ConnectionString = ConnectionString })
            {
                using (var cmd = new SqlCommand { Connection = cn })
                {
                    cn.Open();

                    cmd.CommandText = "SELECT id,Item,ColorId,CustomerId FROM Product";

                    dtCustomer.Load(cmd.ExecuteReader());

                    cmd.CommandText = "SELECT ColorId,ColorText FROM Colors ORDER BY ColorText";
                    dtColor.Load(cmd.ExecuteReader());
                    var dr = dtColor.NewRow();
                    dr[0] = -1;
                    dr[1] = "Select";
                    dtColor.Rows.InsertAt(dr, 0);

                }
            }

            return (dtCustomer, dtColor);

        }
        public static string CreateMessage()
        {
            StringBuilder builder = new StringBuilder();
            var dtColor = new DataTable();

            using (var cn = new SqlConnection { ConnectionString = ConnectionString })
            {
                using (var cmd = new SqlCommand { Connection = cn })
                {
                    cn.Open();

                    cmd.CommandText = "SELECT ColorId,ColorText FROM Colors ORDER BY ColorText";
                    dtColor.Load(cmd.ExecuteReader());

                    builder.AppendLine("<P>");

                    builder.AppendLine("    <table>");

                    foreach (DataRow row in dtColor.Rows)
                    {
                        builder.AppendLine("        <tr>");
                        builder.AppendLine($"           <td>{row.Field<int>("ColorId")}</td><td>{row.Field<string>("ColorText")}</td>");

                        builder.AppendLine("        </tr>");
                    }

                    builder.AppendLine("    </table>");
                    builder.AppendLine("<P>");
                }
            }

            return builder.ToString();

        }

        public static void UpdateRow(DataRow dataRow)
        {
            // TODO
        }
    }
}
