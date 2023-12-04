
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.Extensions.FileSystemGlobbing;

namespace PathLibrary.Classes;

public static class DirectoryHelpers
{
    /// <summary>
    /// Traverse <seealso cref="folderName"/> backwards
    /// </summary>
    /// <param name="folderName">Existing folder</param>
    /// <param name="level">Level backwards</param>
    /// <returns>folder path <seealso cref="level"/> up</returns>
    public static string UpperFolder(this string folderName, int level)
    {
        var folderList = new List<string>();

        while (!string.IsNullOrWhiteSpace(folderName))
        {
            DirectoryInfo parentFolder = Directory.GetParent(folderName);

            if (parentFolder == null)
            {
                break;
            }

            folderName = Directory.GetParent(folderName)!.FullName;
            folderList.Add(folderName);
        }
        return folderList.Count > 0 && level > 0
            ? level - 1 <= folderList.Count - 1 ? folderList[level - 1] : folderName
            : folderName;
    }
    public static string ParentFolder(string sender) => UpperFolder(sender, 1);
    public static string ParentFolder() => Path.GetDirectoryName(Directory.GetCurrentDirectory());

    public static DirectoryInfo GetSolutionInfo(string path = null)
    {
        DirectoryInfo directory = new(path ?? Directory.GetCurrentDirectory());
        while (directory is not null && directory.GetFiles("*.sln").Length == 0)
        {
            directory = directory.Parent;
        }
        return directory;
    }
    public static DirectoryInfo GetProjectInfo(string path = null)
    {
        DirectoryInfo directory = new(path ?? Directory.GetCurrentDirectory());
        while (directory is not null && directory.GetFiles("*.csproj").Length == 0)
        {
            directory = directory.Parent;
        }
        return directory;
    }

    /// <summary>
    /// Pass back an object which can represent path and file name
    /// </summary>
    /// <param name="parentFolder">folder to start in</param>
    /// <param name="patterns">search include pattern</param>
    /// <param name="excludePatterns">pattern to exclude</param>
    public static async Task GetFiles(string parentFolder, string[] patterns, string[] excludePatterns)
    {

        Matcher matcher = new();
        matcher.AddIncludePatterns(patterns);
        matcher.AddExcludePatterns(excludePatterns);

        await Task.Run(() =>
        {
            foreach (string file in matcher.GetResultsInFullPath(parentFolder))
            {
                TraverseFileMatch?.Invoke(new FileMatchItem(file));
            }
        });

        Done?.Invoke("Finished - see log file");

    }
    public delegate void OnTraverseFileMatch(FileMatchItem sender);
    /// <summary>
    /// Informs listener of a <see cref="FileMatchItem"/>
    /// </summary>
    public static event OnTraverseFileMatch TraverseFileMatch;
    public delegate void OnDone(string message);
    /// <summary>
    /// Indicates processing has completed
    /// </summary>
    public static event OnDone Done;
}
public class FileMatchItem
{
    public FileMatchItem(string sender)
    {
        Folder = Path.GetDirectoryName(sender);
        FileName = Path.GetFileName(sender);
    }
    public string Folder { get; init; }
    public string FileName { get; init; }
    public override string ToString() => $"{Folder}\\{FileName}";

}