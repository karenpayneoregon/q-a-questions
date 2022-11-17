using ConsoleWorkingWithCsharp11.Data;
using ConsoleWorkingWithCsharp11.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleWorkingWithCsharp11.Classes;

internal class DataOperations
{
    public static async Task<List<Customer>> CustomersWithIncludesAsync()
    {
        await using var context = new Context();
        return await context.Customer
            .Include(x => x.ContactTypeIdentifierNavigation)
            .Include(x => x.GenderIdentifierNavigation)
            .ToListAsync();
    }

    public static List<Customer> SortByString()
    {
        using var context = new Context();
        return
            context.Customer.SortColumn(nameof(Customer.CompanyName),
                GenericSorterExtension.SortDirection.Descending).ToList();
    }
}