using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsLibrary.LanguageExtensions;

namespace RadioInTabControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (var index = 0; index < tabControl1.TabPages.Count; index++)
            {
                TabPage page = tabControl1.TabPages[index];
                RadioButton selected = page.RadioButtonChecked();
                if (selected is not null)
                {
                    Debug.WriteLine($"{selected.Parent.Name}");
                }
                else
                {
                    // no selected RadioButton on TabPage
                }
            }
        }
    }
}
