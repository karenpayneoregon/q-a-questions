using Microsoft.Data.SqlClient;

namespace HidePathInExceptions.Classes
{
    public class DataOperations
    {
        private static readonly string ConnectionString =
            //"Data Source=.\\SQLEXPRESS;Initial Catalog=NorthWind2022;integrated security=True;";
            "Data Source=.\\SQLEXPRESS;Initial Catalog=NorthWind2022;integrated security=True;Encrypt=False";
        public static async IAsyncEnumerable<string> GetData(bool delay)
        {

            var statement = "SELECT P.ProductName FROM OrderDetails AS OD INNER JOIN Products AS P ON OD.ProductID = P.ProductID";
            await using var cn = new SqlConnection(ConnectionString);
            await using var cmd = new SqlCommand { Connection = cn, CommandText = statement };

            await cn.OpenAsync(new CancellationTokenSource(TimeSpan.FromSeconds(GlobalStuff.TimeOutSeconds)).Token);
            await using var reader = await cmd.ExecuteReaderAsync();

            while (reader.Read())
            {

                if (delay)
                {
                    await Task.Delay(GlobalStuff.TimeSpan);
                }

                yield return reader.GetString(0);
            }

        }
    }
}
