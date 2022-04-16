using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewConditionalImagesDataGridView
{
    public partial class Form1 : Form
    {
        private readonly BindingSource _bindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            var list = DataOperations.LoadPeople();

            _bindingSource.DataSource = DataOperations.LoadPeople();
            dataGridView1.DataSource = _bindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var list = (List<Person>) _bindingSource.DataSource;
            var dict = DataOperations.Images();

            foreach (var person in list)
            {
                if (dict.ContainsKey(person.Priority))
                {
                    person.Image = dict[person.Priority];
                }
            }

            _bindingSource.ResetBindings(false);

        }
    }
}
