using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetImageFromSqlServerFormApp.Classes
{
    public class DataOperations
    {
        public static string ConnectionString = "Data Source=.\\sqlexpress;Initial Catalog=WorkingImages;Integrated Security=True";

        /// <summary>
        /// Get record count
        /// </summary>
        /// <returns>row count</returns>
        public static int RowCount()
        {
            using (var cn = new SqlConnection(ConnectionString))
            {
                using (var cmd = new SqlCommand("SELECT COUNT(id)  FROM dbo.Fruits ", cn))
                {
                    cn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
                
            }
        }
        /// <summary>
        /// Get image by primary key
        /// </summary>
        /// <param name="identifier">Existing key</param>
        /// <returns>Fruit instance</returns>
        public static Fruit GetImage(int identifier)
        {
            var fruit = new Fruit();
            using (var cn = new SqlConnection(ConnectionString))
            {
                using (var cmd = new SqlCommand("SELECT id, Description, Picture FROM dbo.Fruits WHERE dbo.Fruits.id = @id;", cn))
                {
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = identifier;
                    cn.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        var imageData = (byte[])reader[2];
                        using (var ms = new MemoryStream(imageData, 0, imageData.Length))
                        {
                            ms.Write(imageData, 0, imageData.Length);
                            fruit.Picture = Image.FromStream(ms, true);
                        }

                    }
                }
            }

            return fruit;
        }
    }
}
