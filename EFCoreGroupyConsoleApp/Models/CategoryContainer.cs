using System.Collections.Generic;

namespace EFCoreGroupByConsoleApp.Models;

public class CategoryContainer
{
    public string CategoryName { get; set; }
    public List<Products> Products { get; set; } = new();
    public override string ToString() => CategoryName;
}