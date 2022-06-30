using System;
using System.Runtime.CompilerServices;
using SwitchEnumsConsoleApp.Classes;
using W = ConsoleHelperLibrary.Classes.WindowUtility;

// ReSharper disable once CheckNamespace
namespace SwitchEnumsConsoleApp
{
    partial class Program
    {
        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Code sample: switch options";
            W.SetConsoleWindowPosition(W.AnchorWindow.Center);
        }

        #region Core

        public static int Selection(Item sender) => 
            (sender.Enum1, sender.Enum2) switch
            {
                (Enum1.Value1, Enum2.Value3) => 1,
                (Enum1.Value2, Enum2.Value4) => 2,
            _ => throw new NotSupportedException()
            };

        public static int Selection1(Item sender)
        {
            // pattern matching
            if (sender is { Enum1: Enum1.Value1, Enum2: Enum2.Value3 })
            {
                return 1;
            }
            else if (sender is { Enum1: Enum1.Value2, Enum2: Enum2.Value4 })
            {
                return 2;
            }
            else
            {
                throw new NotSupportedException();
            }
        }
        public static int Selection2(Item sender) =>
            sender switch
            {
                { Enum1: Enum1.Value1, Enum2: Enum2.Value3 } => 1,
                { Enum1: Enum1.Value2, Enum2: Enum2.Value4 } => 2,
                _ => throw new NotSupportedException()
            };

        #endregion

        #region 4.8

        public static int SelectionConventional(Item sender)
        {
            if (sender.Enum1 == Enum1.Value1 && sender.Enum2 == Enum2.Value3)
            {
                return 1;
            }
            else if (sender.Enum1 == Enum1.Value2 && sender.Enum2 == Enum2.Value4)
            {
                return 2;
            }
            else
            {
                throw new NotSupportedException();
            }
        }

        #endregion
    }
}





