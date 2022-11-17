using System.Runtime.CompilerServices;
using W = ConsoleHelperLibrary.Classes.WindowUtility;

namespace ConsoleWorkingWithCsharp11.Classes;

internal class InitializeApplication
{
    [ModuleInitializer]
    public static void Init()
    {
        Console.Title = "Code sample: C#11";

        W.SetConsoleWindowPosition(W.AnchorWindow.Center);

    }
}