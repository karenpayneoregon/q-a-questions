using System.Data;
using System.Runtime.InteropServices;
using System.Security;
using Microsoft.Data.SqlClient;

namespace SqlServerLoop;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Code sample";
        var test = DataOperations.ValidateUser1();

        var userName = "payneoregon";
        var password = "!FirstOnMonday".ToSecureString();

        Console.WriteLine();
        if (DataOperations.ValidateUser(userName, password!))
        {
            Console.WriteLine("Valid user");
        }
        else
        {
            Console.WriteLine("Invalid user");
        }

        Console.ReadLine();
    }
}

static class Utilities
{
    public static SecureString? ToSecureString(this string? sender)
    {
        if (sender == null) return null;

        return sender.Aggregate(new SecureString(), (item, c) => { item.AppendChar(c); return item; },
            (item) => { item.MakeReadOnly(); return item; });
    }
    public static string? ToUnSecureString(this SecureString? sender)
    {
        if (sender == null) return null;

        var unmanagedString = IntPtr.Zero;

        try
        {
            unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(sender);
            return Marshal.PtrToStringUni(unmanagedString);
        }
        finally
        {
            Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
        }
    }
}
class DataOperations
{
    public static bool ValidateUser(string username, SecureString password)
    {
        using var cn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Passwording;integrated security=True;Encrypt=False");
        using var cmd = new SqlCommand() { Connection = cn};
        cmd.CommandText = "SELECT Id from dbo.Users WHERE Username = @UserName AND PWDCOMPARE(@Password,[Password]) = 1";
        cmd.Parameters.Add("@UserName", SqlDbType.NChar).Value = username;
        cmd.Parameters.Add("@Password", SqlDbType.NChar).Value = password.ToUnSecureString();

        cn.Open();
        return  cmd.ExecuteScalar() != null;
    }

    public static bool ValidateUser1()
    {
        using var cn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Passwording;integrated security=True;Encrypt=False");
        using var cmd = new SqlCommand() { Connection = cn };
        cmd.CommandText = "SELECT [dbo].[Password_Check]('@MySilly1Password');";


        cn.Open();
        return Convert.ToString(cmd.ExecuteScalar()) == "Valid" ;
    }
}