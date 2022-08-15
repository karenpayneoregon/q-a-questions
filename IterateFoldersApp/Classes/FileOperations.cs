using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace IterateFoldersApp.Classes
{
    public class FileOperations
    {
        public delegate void OnTraverse(string sender);
        public event OnTraverse Traverse;
        public delegate void OnDone();
        public event OnDone Done;

        public async Task EnumerateFiles(string path, string searchPattern, SearchOption searchOption, CancellationToken ct)
        {
            using var enumerator = await Task.Run(() => Directory.EnumerateFiles(path, searchPattern, searchOption).GetEnumerator(), ct);
            while (await Task.Run(() => enumerator.MoveNext(), ct))
            {
                Traverse?.Invoke(enumerator.Current);
            }

            Done?.Invoke();
        }

    }
}
