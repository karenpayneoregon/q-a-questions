namespace WinFormsApp1;

public partial class Form2 : Form
{
    public delegate void OnAddProduct(Product product);
    public event OnAddProduct AddProduct;
    public Form2()
    {
        InitializeComponent();
    }

    private void AddProductButton_Click(object sender, EventArgs e)
    {
        AddProduct?.Invoke(new Product()
        {
            Name = "pepperoni pizza", 
            Price = 5.99m, 
            Quantity = 1
        });
    }
}