using BindingListLibrary;
using DataGridViewCheckBoxApp.Models;

namespace DataGridViewCheckBoxApp;

public partial class Form1 : Form
{
    private readonly BindingSource _bindingSource = new ();
    private SortableBindingList<Item> _bindingList;
    public Form1()
    {
        InitializeComponent();
        Shown += OnShown;
    }
    
    private void OnShown(object sender, EventArgs e)
    {

        _bindingList = new SortableBindingList<Item>(new List<Item>()
        {
            new() { Selected = false, Id = 1, Description = "A"},
            new() { Selected = false, Id = 2, Description = "B"},
            new() { Selected = false, Id = 3, Description = "B"},
            new() { Selected = false, Id = 4, Description = "A"},
        });

        _bindingSource.DataSource = _bindingList;
        dataGridView1.DataSource = _bindingSource;
        dataGridView1.Columns[nameof(Item.Id)]!.ReadOnly = true;
        dataGridView1.CellContentClick += DataGridView1OnCellContentClick;
    }

    private void DataGridView1OnCellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex != 0) return;

        dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);

        for (int index = 0; index < _bindingList.Count; index++)
        {
            if (_bindingList[index].Selected)
            {
                // TODO
            }
            else
            {
                // TODO
            }
        }
    }
}