using System;

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

            Console.ReadLine();
        }
    }
}
