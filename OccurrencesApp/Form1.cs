using System;
using System.Collections.Generic;
using System.IO;
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

        /// <summary>
        /// Get occurrences for each char in both TextBoxes
        /// </summary>
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

        /// <summary>
        /// Read lines in a file, get occurrences for each char
        /// </summary>
        private void ReadFileButton_Click(object sender, EventArgs e)
        {
            string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data.txt");
            List<List<Item>> itemList = Operations.ReadFromFile(fileName);
            
            var one = Operations.GetInfo(itemList, '1').Sum(item => item.Occurrences);
            var eight = Operations.GetInfo(itemList, '8').Sum(item => item.Occurrences);
            Console.WriteLine($"1 = {one,-4}8 = {eight}");
   
        }
    }
}
