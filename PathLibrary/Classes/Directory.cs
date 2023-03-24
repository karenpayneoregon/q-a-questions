using System.Text.RegularExpressions;

namespace PathLibrary.Classes;

public class Directory
{
    private static readonly Regex IllegalRegex = new($"[{Regex.Escape(
        new string(Path.GetInvalidFileNameChars()))}]", 
        RegexOptions.Compiled);

    public static bool IsValidFolderName(string folder) 
        => IllegalRegex.Replace(folder,"") == folder;

    public static (bool isFolder, bool success) IsFileOrFolder(string path)
    {
        try
        {
            var attr = File.GetAttributes(path);
            return attr.HasFlag(FileAttributes.Directory) ? (true, true)! : (false, true)!;
        }
        catch (FileNotFoundException) 
        {
            return (false, false);
        }
    }
}