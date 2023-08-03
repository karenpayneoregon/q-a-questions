using System;
using System.ComponentModel;
using System.Linq;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RangeForEach.Classes;

namespace RangeForEach
{
    internal partial class Program
    {
        static void Main(string[] args)
        {

            var owners = new[] { "Karen", "Bob", "John", "Anne", "Jim" };
            var pets = new[] { "Dog", "Cat", "Bird", "Fish", "Rabbit" };

            foreach (var index in 1..3)
            {
                Console.WriteLine($"  {owners[index],-8}{pets[index]}");
            }

            Console.WriteLine();

            for (int index = 1; index < 3; index++)
            {
                Console.WriteLine($"  {owners[index],-8}{pets[index]}");
            }

            Console.WriteLine();

            Range range = new(1, 3);

            foreach (var index in range)
            {
                Console.WriteLine($"  {owners[index],-8}{pets[index]}");
            }


            Console.ReadLine();
        }

        private static void Stuff()
        {
            (int id, string firstName, string middleName, string lastName) =
                new Person(1, "Karen", "", "Payne");

            Console.WriteLine($"{id}, {firstName}, {middleName}, {lastName}");
        }

        private static void ForEachIndexing()
        {

            var table = CreateTable();
            var owners = new[] { "Karen", "Bob", "John", "Anne" };
            var pets = new[] { "Dog", "Cat", "Bird", "Fish" };
 
            foreach (var index in ..3)
            {
                table.AddRow(owners[index], pets[index]);
            }
            
            AnsiConsole.Write(table);

        }
    }

    public record Person(
        [property: Description("Key")] int Id,
        [property: Description("First Name")] string FirstName,
        [property: Description("Middle Name")] string MiddleName,
        [property: Description("Last Name")] string LastName
    );


}