using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CreateDynamicControls.Classes.Containers;

namespace CreateDynamicControls.Classes
{
    public class DataOperations
    {
        /// <summary>
        /// Data connection to database, change Data Source if not
        /// using SQLEXPRESS
        /// </summary>
        private static readonly string ConnectionString =
            "Data Source=.\\SQLEXPRESS;Initial Catalog=NorthWind2020;Integrated Security=True";

        /// <summary>
        /// Read all categories
        /// </summary>
        /// <returns>list of categories</returns>
        public static List<Category> ReadCategories()
        {
            var list = new List<Category>();
            
            using (var cn = new SqlConnection() { ConnectionString = ConnectionString })
            {

                // disregard list category, CategoryID = 9 no products
                var selectStatement = "SELECT CategoryID, CategoryName FROM dbo.Categories WHERE CategoryID <9;";
                
                using (var cmd = new SqlCommand() { Connection = cn, CommandText = selectStatement })
                {
                    cn.Open();
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        list.Add(new Category() {Id = reader.GetInt32(0), Name = reader.GetString(1)});
                    }
                }
            }

            return list;
            
        }
        /// <summary>
        /// Read products by category identifier
        /// </summary>
        /// <param name="identifier">category identifier</param>
        /// <returns>list of products for category</returns>
        public static List<Product> ReadProducts(int identifier)
        {
            var list = new List<Product>();

            using (var cn = new SqlConnection() { ConnectionString = ConnectionString })
            {

                var selectStatement = "SELECT ProductID, ProductName FROM dbo.Products WHERE CategoryID = @Id ORDER BY ProductName";

                using (var cmd = new SqlCommand() { Connection = cn, CommandText = selectStatement })
                {
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = identifier;
                    cn.Open();
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        list.Add(new Product() { Id = reader.GetInt32(0), Name = reader.GetString(1) });
                    }
                }
            }

            return list;
            
        }
    }
}
