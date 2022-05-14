using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Demo1
{
    public partial class Form1 : Form
    {
        private int drzava;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = DataSources[0];
            comboBox2.DataSource = DataSources[1];
            comboBox1.SelectedIndexChanged += ComboBox1OnSelectedIndexChanged;
            comboBox2.SelectionChangeCommitted += ComboBox2OnSelectionChangeCommitted;
        }

        private void ComboBox2OnSelectionChangeCommitted(object sender, EventArgs e)
        {
            drzava = comboBox2.SelectedIndex;
        }

        private void ComboBox1OnSelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text == DataSources[0][0])
            {
                comboBox2.DataSource = DataSources[1];
            }
            else if (comboBox1.Text == DataSources[0][1])
            {
                comboBox2.DataSource = DataSources[2];
            }
            else if (comboBox1.Text == DataSources[0][2])
            {
                comboBox2.DataSource = DataSources[3];
            }
        }

        public List<List<string>> DataSources { get; } = new List<List<string>>()
        {
            new List<string>() { "Balkan", "Europa", "SR" },
            new List<string>() { "BIH", "SRB" },
            new List<string>() { "Hrvatska", "Turska" },
            new List<string>() { "Beograd", "Niš" },
        };
    }
}
