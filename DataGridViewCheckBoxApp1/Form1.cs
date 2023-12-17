using System.Data;
using DataGridViewCheckBoxApp1.Classes;
using DataGridViewCheckBoxApp1.Models;

namespace DataGridViewCheckBoxApp1;

public partial class Form1 : Form
{

    private BindingSource _bindingSource = new();
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        _bindingSource.DataSource = BogusOperations.ProductsDataTable();
        dataGridView1.DataSource = _bindingSource;
        
        dataGridView1.FixHeaders();
        dataGridView1.ExpandColumns();

        dataGridView1.Columns["UnitPrice"]!.DefaultCellStyle.Format = "C2";
        dataGridView1.Columns["UnitsInStock"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    }

    private void GetAllCheckedButton_Click(object sender, EventArgs e)
    {
        EnumerableRowCollection<DataRow> results = _bindingSource.DataTable().AsEnumerable()
            .Where(row => row.Field<bool>("Process"));

        if (results.Any())
        {
            DataTable table = results.CopyToDataTable();
            // remove Process column as it does not exist in Product model
            table.Columns.RemoveAt(0);
            List<Product>? allCheckedProducts = table.AllCheckedProducts();

            // process checked
        }
        else
        {
            // nothing checked
        }
    }

    private void ToggleCurrentButton_Click(object sender, EventArgs e)
    {
        if (_bindingSource.Current is not null)
        {
            DataRow row = _bindingSource.CurrentRow();
            var value = row.Field<bool>("Process");
            row.SetField("Process", !value);
        }
    }

    private void ExitButton_Click(object sender, EventArgs e)
    {
        Close();
    }
}
