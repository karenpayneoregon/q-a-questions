using System.Data;

namespace WinFormsApp1;

public partial class Form1 : Form
{

    private Form2 _form2;
    private readonly BindingSource _bindingSource = new ();
    public Form1()
    {
        InitializeComponent();

        _bindingSource.DataSource = DataOperations.Table();
        dataGridView1.DataSource = _bindingSource;
        dataGridView2.DataSource = DataOperations.Table().Clone();
        dataGridView2.Columns["Process"]!.Visible = false;


        coreBindingNavigator1.BindingSource = _bindingSource;
    }

    private void ProcessButton_Click(object sender, EventArgs e)
    {

        _form2 ??= new Form2();

        if (_form2.IsDisposed)
        {
            _form2 = new Form2();
        }

        if (!_form2.Visible)
        {
            _form2.Top = 0;
            _form2.Left = 0;
            _form2.Show();
        }

        var checkedData = ((DataTable)dataGridView1.DataSource)
            .AsEnumerable().Where(dataRow => dataRow.Field<bool>("Process")).ToList();

        if (checkedData.Count <= 0) return;
        {
            var table = checkedData.CopyToDataTable();

            foreach (DataRow row in table.Rows)
            {
                _form2.Receive(row);
            }
        }
    }

    private void ProcessLocalButton_Click(object sender, EventArgs e)
    {
        var checkedData = ((DataTable)dataGridView1.DataSource)
            .AsEnumerable().Where(dataRow => dataRow.Field<bool>("Process")).ToList();

        if (checkedData.Count <= 0) return;


        var table1 = checkedData.CopyToDataTable();
        var table2 = ((DataTable)dataGridView2.DataSource);

        foreach (DataRow row in table1.Rows)
        {
            var test = table2.AsEnumerable()
                .FirstOrDefault(x => x.Field<int>("Id") == row.Field<int>("Id"));

            if (test == null)
            {
                table2.ImportRow(row);
            }
        }


    }

}