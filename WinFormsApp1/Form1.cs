#nullable disable

namespace WinFormsApp1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void OpenFormButton_Click(object sender, EventArgs e)
    {
        Form2 form2 = new ();

        try
        {
            form2.AddProduct += OnAddProduct;
            form2.ShowDialog();
        }
        finally
        {
            form2.Dispose();
        }
    }

    private void OnAddProduct(Product product)
    {
        label1.Text = $"{product.Name} {product.Price:C} {product.Quantity}";
    }
}