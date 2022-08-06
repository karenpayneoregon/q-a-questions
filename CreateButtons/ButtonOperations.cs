using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CreateButtons
{
    public class ButtonOperations
    {
        public static List<Button> ButtonsList { get; set; }
        public static int Top { get; set; }
        public static int Left { get; set; }
        public static int Width { get; set; }
        public static int HeightPadding { get; set; }
        public static string BaseName { get; set; } = "Button";
        public static EventHandler EventHandler { get; set; }
        public static Control ParentControl { get; set; }
        public static int Index = 1;

        public static void Initialize(Control pControl, int pTop, int pBaseHeightPadding, int pLeft, int pWidth, EventHandler pButtonClick)
        {

            ParentControl = pControl;
            Top = pTop;
            HeightPadding = pBaseHeightPadding;
            Left = pLeft;
            Width = pWidth;
            EventHandler = pButtonClick;
            ButtonsList = new List<Button>();

        }
        public static void CreateButton(string text = "")
        {

            var button = new Button()
            {
                Name = $"{BaseName}{Index}",
                Text = text,
                Width = Width,
                Location = new Point(Left, Top),
                Parent = ParentControl,
                Visible = true, 
                Tag = Index
            };

            button.Click += EventHandler;
            ButtonsList.Add(button);

            ParentControl.Controls.Add(button);
            Top += HeightPadding;
            Index += 1;

        }
    }
}