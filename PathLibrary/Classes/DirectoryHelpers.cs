
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
                
            var parentFolder = Directory.GetParent(folderName);

            if (parentFolder == null)
            {
                break;
            }

            folderName = Directory.GetParent(folderName)!.FullName;
            folderList.Add(folderName);
        }
        var test = folderList.Count > 0 && level > 0
            ? level - 1 <= folderList.Count - 1 ? folderList[level - 1] : folderName
            : folderName;
        return folderList.Count > 0 && level > 0
            ? level - 1 <= folderList.Count - 1 ? folderList[level - 1] : folderName
            : folderName;
    }

    public static string ParentFolder(string sender)
    {
        return UpperFolder(sender,1);
    }

    public static string ParentFolder()
    {
        return Path.GetDirectoryName(Directory.GetCurrentDirectory());
    }
}