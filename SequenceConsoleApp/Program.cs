using System;
using System.Linq;
using SequenceConsoleApp.Classes;

namespace SequenceConsoleApp
{
    partial class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 3, 4, 5, 7, 8, 1 };

            Console.WriteLine(array.IsSequenceBroken());
            var output = array.Missing1();
            Console.WriteLine(string.Join(",", output));
            Console.ReadLine();
        }
    }
}
