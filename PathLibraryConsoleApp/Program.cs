using System;
using PathLibrary.Classes;
using D = PathLibrary.Classes.Directory1;

namespace PathLibraryConsoleApp
{
    partial class Program
    {
        static void Main(string[] args)
        {
            string folderName = @"\VS2022";
            string parentFolder = DirectoryHelpers.ParentFolder(folderName);

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
