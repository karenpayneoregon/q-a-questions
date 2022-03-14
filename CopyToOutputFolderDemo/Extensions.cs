using System.Diagnostics;

namespace CopyToOutputFolderDemo
{
    public static class Extensions
    {
        [DebuggerStepThrough]
        public static string ToYesNoString(this bool value) => (value ? "Yes" : "No");

    }
}