using System;
using System.Collections.Generic;
using OrderDetailsStatusConsoleApp.Classes;
using OrderDetailsStatusConsoleApp.Data;
using OrderDetailsStatusConsoleApp.Models;
using Spectre.Console;

namespace OrderDetailsStatusConsoleApp
{
    partial class Program
    {
        static void Main(string[] args)
        {
            MultipleStatus();
            SingleStatus();

            Console.ReadLine();
        }

        private static void MultipleStatus()
        {
            AnsiConsole.MarkupLine($"[b]Running[/] [yellow]{nameof(MultipleStatus)}[/]");
            using var context = new NorthContext();
            int identifier = 10248;
            int[] identifiers = { 2, 3 };

            List<OrderDetails> orderDetailsList = DataOperations
                .OrdersDetailsList(identifier, identifiers);

            if (orderDetailsList.Count > 0)
            {
                foreach (var item in orderDetailsList)
                {
                    Console.WriteLine($"{item.Product.ProductName,-30}{item.Status.Description}");
                }
            }
            else
            {
                Console.WriteLine("No matches");
            }

            Console.WriteLine();
        }

        private static void SingleStatus()
        {
            AnsiConsole.MarkupLine($"[b]Running[/] [yellow]{nameof(SingleStatus)}[/]");
            using var context = new NorthContext();
            int identifier = 10248;
            int[] identifiers = { 2 };

            List<OrderDetails> orderDetailsList = DataOperations
                .OrdersDetailsList(identifier, identifiers);

            if (orderDetailsList.Count > 0)
            {
                foreach (var item in orderDetailsList)
                {
                    Console.WriteLine($"{item.Product.ProductName,-30}{item.Status.Description}");
                }
            }
            else
            {
                Console.WriteLine("No matches");
            }

            Console.WriteLine();
        }
    }
}
