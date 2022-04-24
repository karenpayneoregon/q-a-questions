using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RadioButtonSelection.Classes;

namespace RadioButtonSelection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChicagoRadioButton.Tag = new Item() { Lodging = 125, CityName = "Chicago", Days = 3 };
            AustinRadioButton.Tag = new Item() { Lodging = 95, CityName = "Austin", Days = 3 };
            DallasRadioButton.Tag = new Item() { Lodging = 110, CityName = "Dallas", Days = 3 };
        }

        private void CostButton_Click(object sender, EventArgs e)
        {
            var selected = groupBox1.RadioButtonChecked();

            var item = (Item)selected.Tag;
            /*
             * numericUpDown1 range 0-4 to mimic workshoplistBox.SelectedIndex
             */
            item.Fee = DataOperations.FeeDictionary[numericUpDown1.AsInteger];

            totalCostlabel.Text = $"Total Cost: {item.Cost:C2}";

        }
    }
}
