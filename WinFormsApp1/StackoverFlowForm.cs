using System.Data;
namespace WinFormsApp1;

public partial class StackoverFlowForm : Form
{
    private readonly BindingSource _bindingSource = new();
    private readonly string _dateFormat = "dd/MM/yyyy";
    public StackoverFlowForm()
    {
        InitializeComponent();

        _bindingSource.DataSource = Mocked.Table();
        dataGrid.DataSource = _bindingSource;
        dataGrid.Columns["DateItem"]!.DefaultCellStyle.Format = _dateFormat;
    }

    private void GetStartDateButton_Click(object sender, EventArgs e)
    {
        if (dataGrid.CurrentRow!.Cells["DateItem"].Value.IsNull())
        {
            txtDate.Text = "";
        }
        else
        {
            var dateTime = (((DataRowView)_bindingSource.Current)!)
                .Row.Field<DateTime>("DateItem");

            txtDate.Text = dateTime.ToString(_dateFormat);
        }
    }
}

#region Place these classes in separate files
public static class LanguageExtensions
{
    public static bool IsNull(this object sender)
        => sender == null || sender == DBNull.Value || Convert.IsDBNull(sender);
}
public class Mocked
{
    public static DataTable Table()
    {
        var dt = new DataTable();


        dt.Columns.Add(new DataColumn()
        {
            ColumnName = "Id",
            DataType = typeof(int),
            AutoIncrement = true,
            AutoIncrementSeed = 1,
            ColumnMapping = MappingType.Hidden
        });

        dt.Columns.Add(new DataColumn() { ColumnName = "FirstName", DataType = typeof(string) });
        dt.Columns.Add(new DataColumn() { ColumnName = "LastName", DataType = typeof(string) });
        dt.Columns.Add(new DataColumn() { ColumnName = "DateItem", DataType = typeof(DateTime) });

        dt.Rows.Add(null, "Jeanine", "Abbott",
            new DateTime(2018, 2, 12, 8, 0, 0));
        dt.Rows.Add(null, "Lester", "Lam",
            new DateTime(2018, 9, 8, 9, 0, 0));
        dt.Rows.Add(null, "Claire", "Cowan",
            new DateTime(2018, 1, 1, 10, 0, 0));
        dt.Rows.Add(null, "Karen", "Payne",
            new DateTime(2022, 1, 1, 10, 0, 0));

        return dt;
    }
} 
#endregion