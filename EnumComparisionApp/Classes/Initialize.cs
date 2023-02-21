using System.Runtime.CompilerServices;
using ConsoleHelperLibrary.Classes;

namespace EnumComparisionApp.Classes;
internal class Initialize
{
    [ModuleInitializer]
    public static void Init()
    {
        Console.Title = "Code sample";
        WindowUtility.SetConsoleWindowPosition(WindowUtility.AnchorWindow.Center);
    }
}
