using System;
using System.Linq;
using SequenceConsoleApp.Classes;

namespace SequenceConsoleApp
{
    partial class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 1, 2, 3, 5, 6, 8, 10 };
            
            if (array.IsSequenceBroken())
            {
                Console.WriteLine(string.Join(",", array.FindMissing()));
            }

            Console.WriteLine();
            var output = array.Missing();

            Console.WriteLine(string.Join(",", output));
            Console.ReadLine();
        }
    }
}
