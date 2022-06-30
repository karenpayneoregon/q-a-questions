using System;
using SwitchEnumsConsoleApp.Classes;

namespace SwitchEnumsConsoleApp
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Selection(new Item()  { Enum1 = Enum1.Value1, Enum2 = Enum2.Value3 }));
            Console.WriteLine(Selection1(new Item() { Enum1 = Enum1.Value1, Enum2 = Enum2.Value3 }));
            Console.WriteLine(SelectionConventional(new Item() { Enum1 = Enum1.Value1, Enum2 = Enum2.Value3 }));
            Console.ReadLine();
        }
    }
}
