using System.Data;
using Bogus;
using DataGridViewCheckBoxApp1.Models;

namespace DataGridViewCheckBoxApp1.Classes;

public class BogusOperations 
{

    public static List<Product> Products(int productCount = 30)
    {
        int identifier = 1;
        Faker<Product> fake = new Faker<Product>()
            .CustomInstantiator(f => new Product(identifier++))
            .RuleFor(p => p.ProductName, f => f.Commerce.ProductName())
            .RuleFor(p => p.UnitPrice, f => f.Random.Decimal(10, 2))
            .RuleFor(p => p.UnitsInStock, f => f.Random.Short(1, 5));

        return fake.Generate(productCount).OrderBy(x => x.ProductName).ToList();
    }

    public static DataTable ProductsDataTable()
    {
        DataTable table = Products().ToDataTable();
        table.Columns.Add(new DataColumn()
        {
            ColumnName = "Process",
            DataType = typeof(bool),
            DefaultValue = false
        });

        table.Columns["ProductId"]!.ColumnMapping = MappingType.Hidden;

        table.Columns["Process"]!.SetOrdinal(0);
        return table;
    }
}