using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.IO;
using System;

namespace GetImageFromSqlServerFormApp.Classes
{
    internal class PhotoOperations
    {
        public static string ConnectionString =
            "Data Source=.\\sqlexpress;Initial Catalog=WorkingImages;Integrated Security=True";

        public static void InsertImage(byte[] imageBytes)
        {
            var sql = "INSERT INTO [dbo].[Pictures1] ([Photo])  VALUES (@ByteArray)";

            using (var cn = new SqlConnection(ConnectionString))
            {
                using (var cmd = new SqlCommand(sql, cn))
                {

                    cmd.Parameters.Add("@ByteArray", SqlDbType.VarBinary).Value = imageBytes;
                    cn.Open();
                    cmd.ExecuteNonQuery();

                }

            }
        }

        public static PhotoContainer ReadImage(int identifier)
        {
            var photoContainer = new PhotoContainer() { Id = identifier };
            var sql = "SELECT id, Photo FROM dbo.Pictures1 WHERE dbo.Pictures1.id = @id;";

            using (var cn = new SqlConnection(ConnectionString))
            {
                using (var cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = identifier;
                    cn.Open();
                    var reader = cmd.ExecuteReader();
                    reader.Read();
                    var imageData = (byte[])reader[1];
                    using (var ms = new MemoryStream(imageData, 0, imageData.Length))
                    {
                        ms.Write(imageData, 0, imageData.Length);
                        photoContainer.Picture = Image.FromStream(ms, true);
                    }
                }
            }

            return photoContainer;
        }

        public static void TruncateTable()
        {
            var sql = "TRUNCATE TABLE dbo.Pictures1;";
            using (var cn = new SqlConnection(ConnectionString))
            {
                using (var cmd = new SqlCommand(sql, cn))
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

        }

    }
}
