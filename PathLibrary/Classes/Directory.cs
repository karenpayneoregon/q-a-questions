using System.IO;
using System.Text.RegularExpressions;

namespace PathLibrary.Classes
{
    public class Directory
    {
        private static readonly Regex _illegalRegex = 
            new($"[{Regex.Escape(new string(Path.GetInvalidFileNameChars()))}]", 
                RegexOptions.Compiled);

        public static bool IsValidFolderName(string folder) 
            => _illegalRegex.Replace(folder,"") == folder;
    }
}
