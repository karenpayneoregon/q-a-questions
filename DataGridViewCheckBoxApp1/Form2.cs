using DataGridViewCheckBoxApp1.Classes;
using DataGridViewCheckBoxApp1.Models;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace DataGridViewCheckBoxApp1;
public partial class Form2 : Form
{
    private BindingSource _bindingSource = new();
    private SortableBindingList<ProductContainer> _bindingList;
    public Form2()
    {
        InitializeComponent();
    }

    private void Form2_Load(object sender, EventArgs e)
    {
        _bindingList = new SortableBindingList<ProductContainer>(BogusOperations.Products1());
        _bindingSource.DataSource = _bindingList;
        dataGridView1.DataSource = _bindingSource;

        dataGridView1.Columns["ProductId"]!.Visible = false;

        dataGridView1.FixHeaders();
        dataGridView1.ExpandColumns();

        dataGridView1.Columns["UnitPrice"]!.DefaultCellStyle.Format = "C2";
        dataGridView1.Columns["UnitsInStock"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    }

    private void ToggleCurrentButton_Click(object sender, EventArgs e)
    {
        ProductContainer? current = _bindingList[_bindingSource.Position];
        if (current == null) return;
        current.Process = !current.Process;
    }

    private void GetAllCheckedButton_Click(object sender, EventArgs e)
    {
        List<ProductContainer> products = _bindingList.Where(pc => pc.Process).ToList();
        List<ProductItem> results = products.Select(pc => (ProductItem)pc).ToList();

        if (results.Any())
        {
            // process checked
        }
        else
        {
            // nothing checked
        }
    }

}
