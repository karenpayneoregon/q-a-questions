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
                var test = array.SequenceFindMissing();
                Console.WriteLine(string.Join(",", array.SequenceFindMissing()));
            }

            Console.ReadLine();
        }
    }
}
