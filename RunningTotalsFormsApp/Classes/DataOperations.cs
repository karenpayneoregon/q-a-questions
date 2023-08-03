using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace RunningTotalsFormsApp.Classes;
internal class DataOperations
{
    private static IConfiguration? _configuration;

    public static DataTable GetData()
    {

        DataTable table = new DataTable();
        var connectionString = _configuration!.GetValue<string>("ConnectionStrings:ExamplesConnection");
        using SqlConnection cn = new(connectionString);
        using SqlCommand cmd = new(TransactionsQuery(), cn);
        cn.Open();
        SqlDataReader? reader = cmd.ExecuteReader();
        table.Load(reader);
        return table;
    }

    public static void Configure()
    {
        _configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .AddEnvironmentVariables()
            .Build();
    }

    private static string TransactionsQuery() =>
        """
        WITH CTE
        AS (SELECT t2.id,
                   t2.TransDate,
                   t2.Credit,
                   t2.Debit,
                   SUM(COALESCE(t1.credit, 0) - COALESCE(t1.debit, 0)) AS Balance
            FROM Transactions t1
                INNER JOIN Transactions t2
                    ON t1.TransDate <= t2.TransDate
            GROUP BY t2.TransDate,
                     t2.Credit,
                     t2.Debit, t2.id)
        SELECT *
        FROM CTE;
        """;
}
