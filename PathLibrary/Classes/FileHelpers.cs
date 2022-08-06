using System;

namespace PathLibrary.Classes
{
    public class FileHelpers
    {
        public static string UniqueFileName(bool useGuid, string extension = ".csv") => useGuid ?
            $"{DateTime.Now:yyyy-dd-M:HH-mm-ss-ms}{Guid.NewGuid()}{extension}" :
            $"{DateTime.Now:yyyy-dd-M:HH-mm-ss-ms}{extension}";
    }
}
