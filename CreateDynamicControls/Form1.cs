using System;
using System.ComponentModel;
using System.Windows.Forms;
using CreateDynamicControls.Classes;
using CreateDynamicControls.Classes.Containers;
using CreateDynamicControls.Classes.Controls;
using CreateDynamicControls.Properties;

namespace CreateDynamicControls
{
    public partial class Form1 : Form
    {
        private BindingList<Product> _productsBindingList;
        private readonly BindingSource _productBindingSource = new BindingSource();
        
        public Form1()
        {
            InitializeComponent();

            Operations.BaseName = "CategoryButton";
            
            Operations.Initialize(this,20,30, 10,100, CategoryButtonClick);
            
            ProductsListBox.DoubleClick += ProductsListBoxOnDoubleClick;
            Operations.BuildButtons();

        }
        private void ProductsListBoxOnDoubleClick(object sender, EventArgs e)
        {
            if (_productBindingSource.Current is null)
            {
                return;
            }

            var product = (Product) _productBindingSource.Current;

            MessageBox.Show($"{product.Id}, {product.Name}");
        }
        
        private void CategoryButtonClick(object sender, EventArgs e)
        {
            Operations.ButtonsList.ForEach(b => b.Image = null);

            var button = (DataButton)sender;

            button.Image = Resources.CheckDot_6x_16x;
            
            _productsBindingList = new BindingList<Product>(DataOperations.ReadProducts(button.Identifier));
            _productBindingSource.DataSource = _productsBindingList;
            ProductsListBox.DataSource = _productBindingSource;

        }
        /// <summary>
        /// Requires SQL-Server and to run the script under DataScripts folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateCategoriesButton_Click(object sender, EventArgs e)
        {

        }

    }
}
