using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DataGridViewDistinctGroup.Classes;

namespace DataGridViewDistinctGroup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {

            DataGridView1.DataSource = Operations.LoadMockedData();

            ExecuteWork();
        }


        private void ExecuteWork()
        {
            var query = DataGridView1.Rows.OfType<DataGridViewRow>().Where((row) => !row.IsNewRow).GroupBy((row) => new
            {
                Priority = row.Cells["Priority"].Value,
                Status = row.Cells["Status"].Value
            }).Select((group) => new
            {
                Value = @group.Key,
                Count = @group.Count(),
                Rows = @group.ToList()
            }).OrderByDescending((x) => x.Count).ToList();

            StringBuilder sb = new();

            foreach (var item in query.Where(item => item.Count > 1))
            {
                sb.AppendLine($"{item.Value.Priority},{item.Value.Status} count {item.Count}");
                foreach (var row in item.Rows)
                {
                    sb.AppendLine($"   row: {row.Index}");
                }

                DataGridView2.Rows.Add(item.Value.Priority, item.Value.Status, item.Count);
            }

            TextBox1.Text = sb.ToString();
        }
    }
}
