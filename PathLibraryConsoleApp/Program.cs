using System;
using System.IO;
using PathLibrary.Classes;
using D = PathLibrary.Classes.Directory1;

namespace PathLibraryConsoleApp
{
    partial class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine(DirectoryHelpers.ParentFolder(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"Files")));
            Console.WriteLine(DirectoryHelpers.ParentFolder());

            Console.ReadLine();
        }

        private static void ValidNames()
        {
            string[] folderNames = { "|OED", "!OED~", "<<Dir", "\"SomeName", "Another\tName" };

            foreach (var name in folderNames)
            {
                Console.WriteLine($"{name} is valid? {D.IsValidFolderName(name)}");
            }
        }
    }
}
