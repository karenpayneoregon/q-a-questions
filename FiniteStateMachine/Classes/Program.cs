using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace FiniteStateMachine;
internal partial class Program
{
    [ModuleInitializer]
    public static void Init()
    {
        AnsiConsole.MarkupLine("");
        Console.Title = "Code sample: Finite State Machine";
        WindowUtility.SetConsoleWindowPosition(WindowUtility.AnchorWindow.Center);
    }
}
