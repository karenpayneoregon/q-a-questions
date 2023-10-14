using ForumQuestion2023.Classes;
using ForumQuestion2023.Data;
using ForumQuestion2023.Models;

namespace ForumQuestion2023;

public partial class Form1 : Form
{
    private Context _context = new();
    private BindingSource _bindingSource = new();
    private SortableBindingList<Products> _bindingList;
    public Form1()
    {
        InitializeComponent();
        
        _bindingList = new SortableBindingList<Products>(
            _context.Products.OrderBy(p => p.ProductName).ToList());

        _bindingSource.DataSource = _bindingList;
        dataGridView1.DataSource = _bindingSource;
        dataGridView1.Columns["Id"]!.ReadOnly = true;
        dataGridView1.ExpandColumns();
        dataGridView1.Spread();
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
        var affected = _context.SaveChanges();
        MessageBox.Show(affected == 0 ? "Nothing saved" : "Saved");
    }
}
