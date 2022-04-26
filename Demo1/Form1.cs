using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Demo1
{
    public partial class Form1 : Form
    {
        private readonly BindingSource _bindingSource = 
            new BindingSource();

        public Form1()
        {
            InitializeComponent();

            checkedListBox1.DataSource = Mocked.List;
            _bindingSource.DataSource = new List<Item>();
            dataGridView1.DataSource = _bindingSource;
        }

        private void GetSelectedButton_Click(object sender, EventArgs e)
        {
            List<Item> selected = checkedListBox1.CheckedList<Item>();

            if (selected.Any())
            {
                var data = (List<Item>)_bindingSource.DataSource;
                foreach (var item in selected)
                {
                    if (data.FirstOrDefault(x => x.Name == item.Name && x.Country == item.Country) == null)
                    {
                        _bindingSource.Add(item);
                    }
                }
            }

        }
    }
}
