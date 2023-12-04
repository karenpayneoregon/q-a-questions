using System.ComponentModel.DataAnnotations;
using System.Data;
using Microsoft.Data.SqlClient;

namespace SqlServerLibrary;

public class DataOperations
{
    private static readonly string ConnectionString =
        "TODO";

    public static (bool success, Exception exception) AddCustomer(Customer customer)
    {

        using var cn = new SqlConnection(ConnectionString);

        using var cmd = new SqlCommand
        {
            Connection = cn,
            CommandText = SqlStatements.InsertCustomer
        };


        cmd.Parameters.Add("@CompanyName", SqlDbType.NChar).Value =
            customer.CompanyName;

        cmd.Parameters.Add("@ContactName", SqlDbType.NChar).Value =
            customer.ContactName;

        cmd.Parameters.Add("@ContactTypeIdentifier", SqlDbType.Int).Value =
            customer.ContactTypeIdentifier;

        cmd.Parameters.Add("@GenderIdentifier", SqlDbType.Int).Value =
            customer.GenderIdentifier;

        try
        {
            cn.Open();

            customer.Identifier = Convert.ToInt32(cmd.ExecuteScalar());
            return (true, null);
        }
        catch (Exception localException)
        {

            return (false, localException);
        }
    }
}

public class Customer
{
    public int Identifier { get; set; }
    [Required]
    public string CompanyName { get; set; }
    [Required]
    public string ContactName { get; set; }
    [Required]
    public int? ContactTypeIdentifier { get; set; }
    [Required]
    public int? GenderIdentifier { get; set; }
    public override string ToString() => CompanyName;
}