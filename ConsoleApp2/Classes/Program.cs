using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace ConsoleApp2
{
    partial class Program
    {
        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Exception without path code sample";
            WindowUtility.SetConsoleWindowPosition(WindowUtility.AnchorWindow.Center);
        }
    }
}





