using System;
using System.IO;
using PathLibrary.Classes;
using D = PathLibrary.Classes.Directory1;
using static System.Globalization.DateTimeFormatInfo;
// ReSharper disable ConvertClosureToMethodGroup

namespace PathLibraryConsoleApp;

partial class Program
{
    private static List<string> _files = new();
    static async Task Main(string[] args)
    {

        string[] include = { "**/Data*.cs", "**/Ext*.cs" };
        string[] exclude =
        {
            "**/*DataG*.cs",
            "**/*DataR*.cs",
            "**/*.AssemblyInfo.cs",
            "**/*.g.cs"
        };

        DirectoryHelpers.TraverseFileMatch += DirectoryHelpers_TraverseFileMatch;
        DirectoryHelpers.Done += DirectoryHelpers_Done;  
        var solutionFolder = DirectoryHelpers.GetSolutionInfo().FullName;
        await DirectoryHelpers.GetFiles(solutionFolder, include, exclude);

        Console.ReadLine();
    }

    private static void DirectoryHelpers_Done(string message)
    {
        _files = _files.OrderBy(x => x).ToList();
        foreach (var file in _files)
        {
            Console.WriteLine(file);
        }
    }

    private static void DirectoryHelpers_TraverseFileMatch(FileMatchItem sender)
    {
        _files.Add(Path.Combine(sender.Folder, sender.FileName));

    }


}



