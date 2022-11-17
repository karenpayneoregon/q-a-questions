using ConsoleWorkingWithCsharp11.Classes;

namespace ConsoleWorkingWithCsharp11;

internal partial class Program
{
    static async Task Main(string[] args)
    {
        var customers = await DataOperations.CustomersWithIncludesAsync();
        var table = CreateTable();

        foreach (var customer in customers)
        {
            table.AddRow(
                customer.Identifier.ToString(),
                customer.CompanyName,
                customer.ContactFirstName,
                customer.ContactLastName,
                customer.GenderIdentifierNavigation.GenderType,
                customer.ContactTypeIdentifierNavigation.ContactType);
        }

        AnsiConsole.Write(table);
        ExitPrompt();

    }

}