using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using RangeForEach.Classes;

namespace RangeForEach
{
    internal partial class Program
    {
        static void Main(string[] args)
        {



            (int id, string firstName, string middleName, string lastName) = 
                new Person(1,"Karen", "", "Payne");

            Console.WriteLine($"{id}, {firstName}, {middleName}, {lastName}");
            //ForEachIndexing();
            Console.ReadLine();
        }

        private static void ForEachIndexing()
        {

            var table = CreateTable();
            var owners = new[] { "Karen", "Bob", "John" };
            var pets = new[] { "Dog", "Cat", "Bird" };
            
            foreach (var index in 1..3)
            {
                table.AddRow(owners[index], pets[index]);
            }


            AnsiConsole.Write(table);
            
            Console.ReadLine();
        }
    }

    public record Person(
        [property: Description("Key")] int Id,
        [property: Description("First Name")] string FirstName,
        [property: Description("Middle Name")] string MiddleName,
        [property: Description("Last Name")] string LastName
    );


}