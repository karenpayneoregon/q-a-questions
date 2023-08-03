using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static WindowsFormsApp2.NorthWindDataSet;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            productsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(northWindDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            productsTableAdapter.Fill(northWindDataSet.Products);

            string[] products = ((NorthWindDataSet)productsBindingSource.DataSource)
                .Products.Select(p => p.ProductName).ToArray();

            textBox1.Text = products[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductsRow product = ((NorthWindDataSet)productsBindingSource.DataSource)
                .Products[productsBindingSource.Position];

            textBox1.Text = product.ProductName;
        }
    }
}
