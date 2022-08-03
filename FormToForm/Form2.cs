using System;
using System.Windows.Forms;

namespace FormToForm
{
    public partial class Form2 : Form
    {
        private readonly bool _someBool;

        public delegate void OnPassData(bool value);
        public event OnPassData PassEvent;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(bool someBool)
        {
            InitializeComponent();
            _someBool = someBool;
            checkBox1.Checked = _someBool;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PassEvent?.Invoke(checkBox1.Checked);
        }
    }
}
