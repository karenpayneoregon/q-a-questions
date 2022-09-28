using System.Diagnostics;
using RangeForEach.Classes;

namespace RangeForEach
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            ForEachIndexing();
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

}