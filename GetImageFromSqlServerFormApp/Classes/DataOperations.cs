using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;


namespace GetImageFromSqlServerFormApp.Classes
{
    public class DataOperations
    {
        public static string ConnectionString = 
            "Data Source=.\\sqlexpress;Initial Catalog=WorkingImages;Integrated Security=True";


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
                    else
                    {
                        fruit.Picture = null; 
                    }
                }
            }

            return fruit;
        }
        /// <summary>
        /// Responsive for creating a error image
        /// </summary>
        /// <param name="pMessageText">Message to display in image</param>
        /// <param name="pFontName">Font for pMessageText</param>
        /// <param name="pFontSize">Font size for pMessageText</param>
        /// <param name="pBackColor">pMessageText back color</param>
        /// <param name="pForeColor">pMessageText fore color</param>
        /// <param name="pWidth">Image width</param>
        /// <param name="pHeight">Image height</param>
        /// <returns></returns>
        public static Bitmap ConvertTextToImage(string pMessageText, string pFontName, int pFontSize, Color pBackColor, Color pForeColor, int pWidth, int pHeight)
        {

            var bmp = new Bitmap(pWidth, pHeight);

            using (var graphics = Graphics.FromImage(bmp))
            {
                var font = new Font(pFontName, pFontSize);
                graphics.FillRectangle(new SolidBrush(pBackColor), 0, 0, bmp.Width, bmp.Height);
                graphics.DrawString(pMessageText, font, new SolidBrush(pForeColor), 0, 0);
                graphics.Flush();
                font.Dispose();
                graphics.Dispose();
            }

            return bmp;

        }
    }
}
