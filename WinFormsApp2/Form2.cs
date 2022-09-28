using Newtonsoft.Json;
using System.Data;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            var json = File.ReadAllText("Customers.json");
            DataTable dt = JsonConvert.DeserializeObject<DataTable>(json);
            dt.Columns["CustomerIdentifier"].ColumnMapping = MappingType.Hidden;
            dataGridView1.DataSource = dt;

        }
    }
}
