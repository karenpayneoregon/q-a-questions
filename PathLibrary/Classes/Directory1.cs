using System.Text.RegularExpressions;

namespace PathLibrary.Classes;

public class Directory1
{
    private static readonly Regex IllegalRegex = 
        new($"[{Regex.Escape(new string(Path.GetInvalidFileNameChars()))}]", 
            RegexOptions.Compiled);

    /// <summary>
    /// Determine if <see cref="folder"/> is valid
    /// </summary>
    /// <param name="folder">directory to check</param>
    /// <returns>true if valid, false if not</returns>
    public static bool IsValidFolderName(string folder)
    {
        return IllegalRegex.Replace(folder, "") == folder;
    }
}