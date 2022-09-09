using System.Data;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            dataGridView1.DataSource = DataOperations.Table().Clone();
            dataGridView1.Columns["Process"]!.Visible = false;
        }

        public void Receive(DataRow row)
        {
            var table = ((DataTable)dataGridView1.DataSource);
            
            var test = table.AsEnumerable()
                .FirstOrDefault(x => x.Field<int>("Id") == row.Field<int>("Id"));

            if (test == null)
            {
                table.ImportRow(row);    
            }

        }
    }
}
