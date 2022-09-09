using System.Data;

namespace WinFormsApp1;

public partial class Form1 : Form
{

    private Form2 _form2;
    public Form1()
    {
        InitializeComponent();

        dataGridView1.DataSource = DataOperations.Table();
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
}