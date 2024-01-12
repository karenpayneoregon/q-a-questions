using System;
using System.Collections.Generic;
using System.Linq;
using EFCoreGroupByConsoleApp.Data;
using EFCoreGroupByConsoleApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreGroupByConsoleApp;

internal partial class Program
{
    static void Main(string[] args)
    {
        GroupByCategories();
        EmployeeReportTo();
        Console.ReadLine();
    }

    private static void GroupByCategories()
    {
        List<CategoryContainer> containers = new();

        using var context = new Context();

        List<List<Products>> groupedCategories = context.Products
            .Include(p => p.Category)
            .OrderBy(p => p.Category.CategoryName)
            .ThenBy(p => p.ProductName)
            .GroupBy(p => p.CategoryId)
            .Select(g => g.ToList())
            .ToList();

        groupedCategories.ForEach(products =>
        {
            CategoryContainer container = new()
            {
                CategoryName = products.FirstOrDefault()?.Category.CategoryName
            };
            products.ForEach(p => container.Products.Add(p));
            containers.Add(container);
        });

        var root = new Tree("[lightsteelblue]Grouped products by category[/]");
        root.Style(Style.Parse("grey"));

        foreach (var container in containers)
        {
            var currentNode = root.AddNode($"[palegreen1_1]{container.CategoryName}[/]");
            container.Products.ForEach(p => 
                currentNode.AddNode($"[white]{p.ProductId,-4}[/]{p.ProductName}"));
        }

        AnsiConsole.Write(root);
    }


    private static void EmployeeReportTo()
    {
        using var context = new Context();

        List<Employees> employees = context.Employees.ToList();

        List<IGrouping<int?, Employees>> groupedData = employees
            .Where(employee => employee.ReportsTo.HasValue)
            .OrderBy(employee => employee.LastName)
            .GroupBy(employee => employee.ReportsTo)
            .ToList();

        List<Manager> managers = new();

        foreach (var group in groupedData)
        {
            Employees current = employees
                .Find(employee => group.Key != null && employee.EmployeeId == group.Key.Value);


            Manager manager = new() { Employee = current };

            foreach (var groupedItem in group)
            {
                manager.Workers.Add(groupedItem);
            }

            managers.Add(manager);
        }

        managers = managers.OrderBy(m => m.Employee.LastName).ToList();

        foreach (var manager in managers)
        {
            Console.WriteLine($"{manager.Employee.FirstName} {manager.Employee.LastName}");
            foreach (var worker in manager.Workers)
            {
                Console.WriteLine($"\t{worker.FirstName} {worker.LastName}");
            }
        }
    }
}