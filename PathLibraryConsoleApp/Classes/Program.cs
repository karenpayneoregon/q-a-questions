﻿using System.Runtime.CompilerServices;
using W = ConsoleHelperLibrary.Classes.WindowUtility;

// ReSharper disable once CheckNamespace
namespace PathLibraryConsoleApp
{
    partial class Program
    {
        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Code sample: Upper folders";
            W.SetConsoleWindowPosition(W.AnchorWindow.Center);
        }
    }
}





