using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace ConsoleApp1;

partial class Program
{
    [ModuleInitializer]
    public static void Init()
    {
        Console.Title = "Exception without path code sample";
    }
}