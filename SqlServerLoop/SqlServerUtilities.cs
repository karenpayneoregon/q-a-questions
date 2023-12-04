using System.Data;
using Microsoft.Data.SqlClient;


namespace SqlServerLoop
{
    public class SqlServerUtilities
    {
        public static async Task CallIt()
        {
            var test = await ColumnNames("");
        }
        /// <summary>
        /// Change this to your database server and catalog
        /// </summary>
        public static string ConnectionString =>
            "Data Source=.\\sqlexpress;Initial Catalog=Northwind2020;Integrated Security=True;Encrypt=False";


        public static async Task<List<string>> ColumnNames(string tableName)
        {
            List<string> columnNames = new();
            await using SqlConnection cn = new()
            {
                ConnectionString = ConnectionString
            };
            await using SqlCommand cmd = new () {Connection = cn};
            cmd.CommandText = GetColumnNamesStatement;
                    
            cmd.Parameters.Add("@TableName", SqlDbType.NChar).Value = tableName;

            await cn.OpenAsync();

            var reader = await cmd.ExecuteReaderAsync();

            while (reader.Read())
            {
                columnNames.Add(reader.GetString(0));
            }

            return columnNames;

        }

        public static string GetColumnNamesStatement => 
            """
            SELECT COLUMN_NAME
            FROM INFORMATION_SCHEMA.COLUMNS
            WHERE TABLE_NAME = @TableName
            ORDER BY COLUMN_NAME
            """;
    }
}
