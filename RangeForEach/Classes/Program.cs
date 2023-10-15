﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

// ReSharper disable once CheckNamespace
namespace RangeForEach
{
    internal partial class Program
    {
        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Code sample";
            WindowUtility.SetConsoleWindowPosition(WindowUtility.AnchorWindow.Center);
        }
        private static Table CreateTable()
        {
            return new Table()
                .RoundedBorder().BorderColor(Color.LightSlateGrey)
                .AddColumn("[b]Owner[/]")
                .AddColumn("[b]Pet[/]")
                .Alignment(Justify.Left)
                .Title("[yellow]Results[/]");
        }
    }
}