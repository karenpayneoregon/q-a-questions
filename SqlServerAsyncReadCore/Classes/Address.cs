using System.Data.SqlClient;
using System.Data;
using SqlServerAsyncReadCore.Classes;
using System;

namespace SqlServerAsyncReadCore.Classes;

public class Address
{
    public int Id { get; set; }
    public int StreetNumber { get; set; }
    public string StreetName { get; set; }
    public StreetType StreetType { get; set; }
    public string StreetFull => $"{StreetNumber} {StreetName} {StreetType}";
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public int Toilets { get; set; }
    public int Replaced128 { get; set; }
    public int YearBuilt { get; set; }

}

public enum StreetType
{
    Residential,
    Commercial
}

public class SqlOperations
{
    private const string ConnectionString = "TODO";

    public static (bool success, Exception exception) Insert(Address address)
    {
        var statement = """
            INSERT INTO myTable(Address,Toilets) 
            VALUES(@address,@toilets);
            SELECT CAST(scope_identity() AS int);
        """;

        using var cn = new SqlConnection(ConnectionString);
        using var cmd = new SqlCommand
        {
            Connection = cn,
            CommandText = statement
        };

        cmd.Parameters.Add("@address", SqlDbType.NChar).Value = address.StreetFull;
        cmd.Parameters.Add("@toilets", SqlDbType.Int).Value = address.Toilets;

        // not in statement
        cmd.Parameters.Add("@Parameter", SqlDbType.Decimal, 11).Value = 1;
        cmd.Parameters["@Parameter"].Value = 18;
        cmd.Parameters["@Parameter"].Precision = 9;

        try
        {
            cn.Open();

            address.Id = Convert.ToInt32(cmd.ExecuteScalar());
            return (true, null)!;
        }
        catch (Exception ex)
        {
            return (false, ex);
        }
    }
}