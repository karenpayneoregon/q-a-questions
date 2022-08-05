using System;
using System.IO;
using Console1.Classes;
using SpreadsheetLight;

namespace Console1
{
    partial class Program
    {
 
        static void Main(string[] args)
        {
            var currentFolder = Directory.GetCurrentDirectory();

            try
            {
                Directory.SetCurrentDirectory(@"TODO");
                using (var sheet = new SLDocument("Test.xlsx"))
                {
                    SLWorksheetStatistics stats = sheet.GetWorksheetStatistics();
                    Console.WriteLine(stats.NumberOfRows);
                }
            }
            finally
            {
                Directory.SetCurrentDirectory(currentFolder);
            }

            Console.ReadLine();

        }


    }

    public class ExcelOperations
    {
        public string WorkingFolder { get; set; }

    }
}
