using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SqlServerAsyncReadCore.Classes
{
    public class ComboBoxClear : ComboBox
    {
        private string _firstItemText;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]

        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, 
            [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        [DllImport("user32", EntryPoint = "FindWindowExA", ExactSpelling = true, 
            CharSet = CharSet.Ansi, SetLastError = true)]

        private static extern IntPtr FindWindowEx(IntPtr hWnd1, IntPtr hWnd2, string lpsz1, string lpsz2);
        private const int EmSetCueBanner = 0x1501;
        public ComboBoxClear()
        {
            FirstItemText = "Clear";
            SetCueText();
        }

        private void SetCueText()
        {
            var handle = FindWindowEx(Handle, IntPtr.Zero, "Edit", null);

            if (!(handle == IntPtr.Zero))
            {
                SendMessage(handle, EmSetCueBanner, 0, FirstItemText);
            }
        }

        [Category("Appearance")]
        [Description("Set text for first item")]
        public string FirstItemText
        {
            get => _firstItemText;
            set
            {
                _firstItemText = value; 
                SetCueText();
            }
        }
    }
}
