using System;
using System.IO;
using PathLibrary.Classes;
using D = PathLibrary.Classes.Directory;

namespace PathLibraryConsoleApp
{
    partial class Program
    {
        static void Main(string[] args)
        {

            string[] folderNames = { "|OED", "!OED~", "<<Dir", "\"SomeName","Another\tName" };

            foreach (var name in folderNames)
            {
                Console.WriteLine($"{name} is valid? {D.IsValidFolderName(name)}");
            }

            Console.WriteLine(FileHelpers.UniqueFileName(false));
            Console.WriteLine();

            string[] questionableFolderNames =
            {
                "C:\\Windows", 
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConsoleHelperLibrary.dll"),
                "C:\\ABSASDD.txt"

            };

            foreach (var name in questionableFolderNames)
            {
                var (isFolder, success) = D.IsFileOrFolder(name);
                if (success)
                {
                    Console.WriteLine($"{name} Is folder: {isFolder}");
                }
                else
                {
                    Console.WriteLine($"{name} not found");
                }
                
            }
            Console.ReadLine();
        }
    }
}
