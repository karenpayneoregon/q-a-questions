
using BulkDeleteRecords.Classes;
using BulkDeleteRecords.Models;

namespace BulkDeleteRecords;

public partial class Form1 : Form
{
    private readonly BindingSource _bindingSource = new ();
    public Form1()
    {
        InitializeComponent();

        _bindingSource.DataSource = DataOperations.Read();
        dataGridView1.DataSource = _bindingSource;
    }

    private void DeleteButton_Click(object sender, EventArgs e)
    {
        var list = ((List<Container>)_bindingSource.DataSource).Select(x => $"'{x.Serial}'").Chunk(20).ToList();
        var deleteStatements = new List<string>();
        foreach (var serialLArray in list)
        {
            deleteStatements.Add($"DELETE FROM [Demo1] WHERE [Serial] IN ({string.Join(",", serialLArray)})");
        }

        if (DataOperations.DeleteRecords(deleteStatements))
        {
            _bindingSource.DataSource = null;
            DeleteButton.Enabled = false;
        }
        else
        {
            MessageBox.Show("Failed");
        }
    }
}