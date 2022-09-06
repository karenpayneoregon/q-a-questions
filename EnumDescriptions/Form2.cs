using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using EnumDescriptions.Classes;
using EnumDescriptions.Models;

namespace EnumDescriptions
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            List<KeyValuePair<string, Enum>> result =
                EnumHelper.GetItemsAsDictionary<WindowKeys>();

            comboBox1.DisplayMember = "Key";
            comboBox1.ValueMember = "Value";
            comboBox1.DataSource = result;
        }

        private void CurrentButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedValue.ToString());
        }
    }
}
