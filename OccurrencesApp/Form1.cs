using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OccurrencesApp.Classes;

namespace OccurrencesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            List<Item> items = Operations.GetAllItems(textBox1.Text);

            foreach (var item in items)
            {
                if (char.IsDigit(item.Character))
                {
                    listView1.Items.Add(new ListViewItem(item.ItemArray));
                }
                
            }
        }
    }
}
