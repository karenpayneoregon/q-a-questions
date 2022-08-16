using System;
using System.Runtime.CompilerServices;
using W = ConsoleHelperLibrary.Classes.WindowUtility;

// ReSharper disable once CheckNamespace
namespace OrderDetailsStatusConsoleApp
{
    partial class Program
    {
        [ModuleInitializer]
        public static void Init()
        {
            W.SetConsoleWindowPosition(W.AnchorWindow.Center);
            Console.Title = "EF Core Code sample";
        }
    }
}





