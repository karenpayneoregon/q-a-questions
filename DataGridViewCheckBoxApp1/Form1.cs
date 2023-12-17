using System.Data;
using DataGridViewCheckBoxApp1.Classes;

namespace DataGridViewCheckBoxApp1;

public partial class Form1 : Form
{

    private BindingSource bsCustomers = new();
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        bsCustomers.DataSource = BogusOperations.ProductsDataTable();
        dataGridView1.DataSource = bsCustomers;
        dataGridView1.FixHeaders();
        dataGridView1.ExpandColumns();
        dataGridView1.Columns["UnitPrice"]!.DefaultCellStyle.Format = "C2";
        dataGridView1.Columns["UnitsInStock"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    }

    private void GetAllCheckedButton_Click(object sender, EventArgs e)
    {
        var results = ((DataTable)bsCustomers.DataSource)
            .AsEnumerable()
            .Where(row => row.Field<bool>("Process")); 

        if (results.Any())
        {
            var table = results.CopyToDataTable();
            table.Columns.RemoveAt(0);
            var allCheckedProducts = table.AllCheckedProducts();
        }
    }
}
