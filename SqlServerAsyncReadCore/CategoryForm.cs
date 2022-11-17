using System;

using System.Windows.Forms;
using SqlServerAsyncReadCore.Classes;

namespace SqlServerAsyncReadCore
{
    public partial class CategoryForm : Form
    {
        private readonly BindingSource _bindingSource = new();
        public CategoryForm()
        {
            InitializeComponent();
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            _bindingSource.DataSource = DataOperations.Categories();
            dataGridView1.DataSource = _bindingSource;
        }
    }
}
