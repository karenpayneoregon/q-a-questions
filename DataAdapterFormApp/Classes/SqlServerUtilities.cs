using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataAdapterFormApp.Classes
{
    public class SqlServerUtilities
    {
        /// <summary>
        /// Change this to your database server and catalog
        /// </summary>
        public static string ConnectionString =>
            "Data Source=.\\sqlexpress;Initial Catalog=Northwind2020;Integrated Security=True";

        /// <summary>
        /// Pass in an existing table name to get column names
        /// </summary>
        /// <param name="tableName">table name to get columns for</param>
        /// <returns>list of column names</returns>
        public static List<string> ColumnNameForTable(string tableName)
        {
            var columnNames = new List<string>();
            using (var cn = new SqlConnection() {ConnectionString = ConnectionString})
            {
                using (var cmd = new SqlCommand() {Connection = cn})
                {
                    cmd.CommandText = GetColumnNamesStatement;
                    
                    cmd.Parameters.Add("@TableName", SqlDbType.NChar)
                        .Value = tableName;

                    cn.Open();

                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        columnNames.Add(reader.GetString(0));
                    }
                }
            }

            return columnNames;

        }

        public static string GetColumnNamesStatement => @"
        SELECT COLUMN_NAME 
        FROM INFORMATION_SCHEMA.COLUMNS
        WHERE TABLE_NAME = @TableName
        ORDER BY COLUMN_NAME";
    }
}
