using System.Data;

namespace WinFormsApp1;

public partial class Form1 : Form
{
    private readonly BindingSource _bindingSource = new ();
    public Form1()
    {
        InitializeComponent();

        var table = LoadDataTable();
        
        table.ColumnChanged += TableOnColumnChanged;
        table.RowDeleted += Table_RowDeleted;
        table.RowChanged += Table_RowChanged;
        
        _bindingSource.DataSource = table;
        dataGridView1.DataSource = _bindingSource;

        PerformCalculations();
    }

    private void Table_RowChanged(object sender, DataRowChangeEventArgs e)
    {
        if (e.Action == DataRowAction.Add)
        {
            PerformCalculations();
        }
    }

    private void Table_RowDeleted(object sender, DataRowChangeEventArgs e)
    {
        PerformCalculations();
    }

    private void TableOnColumnChanged(object sender, DataColumnChangeEventArgs e)
    {
        if (e.Column!.ColumnName == "CarStatus")
        {
            PerformCalculations();
        }
        
    }

    public static DataTable LoadDataTable()
    {
        DataTable dataTable = new ("Vechicle");

        dataTable.Columns.Add("ID", typeof(int));
        dataTable.Columns["Id"]!.ColumnMapping = MappingType.Hidden;
        dataTable.Columns.Add("CarId", typeof(string));
        dataTable.Columns.Add("CarStatus", typeof(string));

        dataTable.Rows.Add(1, "MN84", "CARS_AVAILABLE");
        dataTable.Rows.Add(2, "LW4C", "CARS_AVAILABLE");
        dataTable.Rows.Add(3, "1VAV", "RENT");
        dataTable.Rows.Add(4, "7F60", "CARS_AVAILABLE");
        dataTable.Rows.Add(5, "VNWH", "RENT");
        return dataTable;
    }

    private void PerformCalculations()
    {
        var table = (DataTable)_bindingSource.DataSource;
        var available = table.AsEnumerable()
            .Where(row => row.Field<string>("CarStatus") == "CARS_AVAILABLE");
        var rent = table.AsEnumerable()
            .Where(row => row.Field<string>("CarStatus") == "RENT");

        AvailableLabel.Text = $"Available {available.Count()}";
        RentLabel.Text = $"Rent {rent.Count()}";
    }
}
