
using BulkDeleteRecords.Classes;
using BulkDeleteRecords.Models;

namespace BulkDeleteRecords;

public partial class Form1 : Form
{
    private BindingSource bindingSource = new ();
    public Form1()
    {
        InitializeComponent();

        bindingSource.DataSource = DataOperations.Read();
        dataGridView1.DataSource = bindingSource;
    }

    private void DeleteButton_Click(object sender, EventArgs e)
    {
        var list = ((List<Container>)bindingSource.DataSource).Select(x => $"'{x.Serial}'").Chunk(20).ToList();
        var deleteStatements = new List<string>();
        foreach (var serialLArray in list)
        {
            deleteStatements.Add($"DELETE FROM [Demo1] WHERE [Serial] IN ({string.Join(",", serialLArray)})");
        }

        if (DataOperations.DeleteRecords(deleteStatements))
        {
            bindingSource.DataSource = null;
            DeleteButton.Enabled = false;
        }
        else
        {
            MessageBox.Show("Failed");
        }
    }
}