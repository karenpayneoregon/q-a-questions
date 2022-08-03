using System;
using System.Windows.Forms;

namespace FormToForm
{
    public partial class Form2 : Form
    {
        public delegate void OnPassData(bool value);
        public event OnPassData PassEvent;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PassEvent?.Invoke(checkBox1.Checked);
        }
    }
}
