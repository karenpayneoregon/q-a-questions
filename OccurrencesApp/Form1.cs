using System;
using System.Collections.Generic;
using System.Linq;
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

            foreach (var item in items.Where(item => char.IsDigit(item.Character)))
            {
                listView1.Items.Add(new ListViewItem(item.ItemArray));
            }

            items = Operations.GetAllItems(textBox2.Text);

            foreach (var item in items.Where(item => char.IsDigit(item.Character)))
            {
                listView2.Items.Add(new ListViewItem(item.ItemArray));
            }

        }

        private void ReadFileButton_Click(object sender, EventArgs e)
        {
            List<List<Item>> itemList = Operations.ReadFromFile();
            
            var one = Operations.GetInfo(itemList, '1').Sum(x => x.Occurrences);
            var eight = Operations.GetInfo(itemList, '8').Sum(x => x.Occurrences);
            Console.WriteLine($"1 = {one,-4}8 = {eight}");
   
        }
    }
}
