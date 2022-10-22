// ReSharper disable once CheckNamespace
namespace KP_ConsoleAppJokes
{
    internal partial class Program
    {
        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Random jokes";
            WindowUtility.SetConsoleWindowPosition(WindowUtility.AnchorWindow.Center);
        }
    }
}
