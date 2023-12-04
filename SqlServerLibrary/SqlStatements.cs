namespace SqlServerLibrary;
public class SqlStatements
{
    public static string InsertCustomer => 
        """
        INSERT INTO dbo.Customer (CompanyName, ContactName, ContactTypeIdentifier, GenderIdentifier) 
        VALUES (@CompanyName,  @ContactName,  @ContactTypeIdentifier,  @GenderIdentifier);
        SELECT CAST(scope_identity() AS int);"
        """;
}
