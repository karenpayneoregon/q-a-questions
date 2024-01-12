using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace EFCoreGroupByConsoleApp;

internal partial class Program
{
    [ModuleInitializer]
    public static void Init()
    {
        Console.Title = "Code sample: Grouping with multiple sorting";
        WindowUtility.SetConsoleWindowPosition(WindowUtility.AnchorWindow.Center);
    }
}