using System;
using System.IO;
using System.Windows.Forms;

using static AbstractClassToStringExample.Classes.Mocked;

namespace AbstractClassToStringExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = MachineList1();
            comboBox2.DataSource = MachineList2();


        }
    }
}
