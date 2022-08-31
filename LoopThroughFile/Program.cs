using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using LoopThroughFile.Classes;

namespace LoopThroughFile
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var operations = new FileOperations();
            operations.ProcessLineEvent += OperationsOnProcessLineEvent;
            operations.ReadFile("example2.txt");
            Console.ReadLine();
        }

        private static void OperationsOnProcessLineEvent(string[] sender)
        {
            Console.WriteLine($"{sender[0]} - {sender[1]}");
        }

        private static void Dump()
        {
            var (total, badLines, exception) = Operations.GetTotals("example.txt");

            if (exception is null)
            {
                Console.WriteLine($"Total: {total:C2}");

                if (badLines.Any())
                {
                    Console.WriteLine($"Bad lines: {string.Join(",", badLines)}");
                }
            }
            else
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
