using System;
using System.Windows.Forms;

namespace FormToForm
{
    public partial class Form1 : Form
    {
        public bool SomeBool { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new Form2();
            f.PassEvent += OnPassEvent;
            f.ShowDialog();
            f.Dispose();
        }

        private void OnPassEvent(bool value)
        {
            checkBox1.Checked = value;
            SomeBool = value;
        }
    }
}
