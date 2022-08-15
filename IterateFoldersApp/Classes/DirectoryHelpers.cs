using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace IterateFoldersApp.Classes
{
    public class DirectoryHelpers
    {
        public static int FileCount(string directory)
        {
            DirectoryInfo dirInfo = new(directory);
            return dirInfo.EnumerateDirectories().AsParallel()
                .SelectMany(di => di.EnumerateFiles("*.*", SearchOption.AllDirectories)).Count();
        }
        public static int FileCount(string directory, SearchOption searchOption)
        {
            DirectoryInfo dirInfo = new(directory);
            return dirInfo.EnumerateDirectories().AsParallel()
                .SelectMany(di => di.EnumerateFiles("*.*", searchOption)).Count();
        }
        public static int FileCount(string directory, SearchOption searchOption, string searchPattern)
        {
            DirectoryInfo dirInfo = new(directory);
            return dirInfo.EnumerateDirectories().AsParallel()
                .SelectMany(di => di.EnumerateFiles(searchPattern, searchOption)).Count();
        }
        public static (int directoryCount, int fileCount) DirectoryFileCount(string directory)
        {
            Dictionary<bool, int> dictionary = new DirectoryInfo(directory)
                .EnumerateFileSystemInfos("*", SearchOption.AllDirectories)
                .GroupBy(fsi => fsi is DirectoryInfo)
                .ToDictionary(item => item.Key, s => s.Count());

            return (dictionary.ContainsKey(true) ? dictionary[true] : 0, dictionary.ContainsKey(false) ? dictionary[false] : 0);
        }
    }

}