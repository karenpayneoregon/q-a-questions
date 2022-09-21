using WinFormsApp2.Classes;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Shown += OnShown;
   
        }

        private void OnShown(object? sender, EventArgs e)
        {

            dataGridView1.DataSource = Mocked.GetData();
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.HeaderText = column.HeaderText.SplitCamelCase().ToLower();
            }
            dataGridView1.ExpandColumns(10);


            var references = LookupReferences.Columns();
            dataGridView2.DataSource = Mocked.GetData();
            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                if (references.ContainsKey(column.HeaderText))
                {
                    column.HeaderText = references[column.HeaderText];
                }
            }
            dataGridView2.ExpandColumns(10);
        }
    }
}