using System.Data;
using RunningTotalsFormsApp.Classes;

namespace RunningTotalsFormsApp;

public partial class Form1 : Form
{
    
    private BindingSource _bindingSource = new ();
    public Form1()
    {
        InitializeComponent();
        dataGridView1.AutoGenerateColumns = false;
        
        DataOperations.Configure();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        _bindingSource.DataSource = DataOperations.GetData();
        dataGridView1.DataSource = _bindingSource;
        SetLastColumnValue();
        dataGridView1.CellPainting += DataGridView1_CellPainting;


    }
    private void DataGridView1_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
    {
        if (e.ColumnIndex == 3)
        {
            e.AdvancedBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            e.AdvancedBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
        }
        if (e.ColumnIndex == 4)
        {
            e.AdvancedBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            e.AdvancedBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
        }
    }

    private void CurrentButton_Click(object sender, EventArgs e)
    {
        var current = ((DataRowView)_bindingSource.Current).Row;
        MessageBox.Show($"Id {current.Field<int>("Id")}");
    }

    private void SetLastColumnValue()
    {
        foreach (DataGridViewRow row in dataGridView1.Rows)
        {
            if (row.Cells["debitcolumn"].Value == null || row.Cells["debitcolumn"].Value == DBNull.Value)
            {
                row.Cells["balancecolumn"].Style.ForeColor = Color.Green;
                row.Cells["typecolumn"].Value = "CR";
            }
            else
            {
                row.Cells["balancecolumn"].Style.ForeColor = Color.Red;
                row.Cells["typecolumn"].Value = "DR";
            }
        }
    }
}
