using BulkDeleteRecords.Models;
using Microsoft.Data.SqlClient;

namespace BulkDeleteRecords.Classes;

public class DataOperations
{
    private const string ConnectionString = 
        "Data Source=.\\SQLEXPRESS;Initial Catalog=ForumExample;Integrated Security=True;Encrypt=False";

    public static List<Container> Read()
    {
        List<Container> list = new List<Container>();
        using var cn = new SqlConnection(ConnectionString);
        using var cmd = new SqlCommand()
        {
            Connection = cn,
            CommandText = "SELECT Serial,SomeDate FROM dbo.Demo1"
        };

        cn.Open();

        var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            list.Add(new Container()
            {
                Serial = reader.GetString(0),
                SomeDate = reader.GetDateTime(1)
            });
        }

        return list;
    }

    public static bool DeleteRecords(List<string> statements)
    {
        using var cn = new SqlConnection(ConnectionString);
        using var cmd = new SqlCommand() { Connection = cn };

        cn.Open();

        try
        {
            foreach (var statement in statements)
            {
                cmd.CommandText = statement;
                cmd.ExecuteNonQuery();
            }

            return true;
        }
        catch (Exception)
        {

            return false;
        }

    }
}