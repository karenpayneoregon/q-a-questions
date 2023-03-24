using System.Data;
using System.Diagnostics;
using MultiColumnComboBoxApp.Classes;

namespace MultiColumnComboBoxApp;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        Shown += OnShown;
    }

    private DataTable _dataTable;
    private void OnShown(object? sender, EventArgs e)
    {
        _dataTable = DataOperations.Load();
        multiColumnComboBox1.Table = _dataTable;
        multiColumnComboBox1.DisplayMember = "Name";
        multiColumnComboBox1.ColumnsToDisplay = new[] { "Name", "EmployeeID", "Designation" };
    }

    private void CurrentButton_Click(object sender, EventArgs e)
    {
        var row = multiColumnComboBox1.CurrentRow;
        if (row is not null)
        {
            var name = row.Field<string>("Name");
            var designation = row.Field<string>("Designation");
            var id = row.Field<int>("EmployeeID");
            MessageBox.Show($"{id,-3}{name,-10}{designation}");
        }
        else
        {
            MessageBox.Show("Make a selection");
        }
    }

    private void ChangeButton_Click(object sender, EventArgs e)
    {
        _dataTable.Rows[0].SetField("Name","Karen");
    }
}