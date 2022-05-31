using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlServerAsyncReadCore.Classes;

namespace SqlServerAsyncReadCore
{
    public partial class CheckedListBoxForm : Form
    {
        public CheckedListBoxForm()
        {
            InitializeComponent();
            
            Shown += OnShown;
        }
        private readonly CancellationTokenSource _cancellationTokenSource = new ();
        private async void OnShown(object? sender, EventArgs e)
        {
            var table = await DataOperations.ReadProductsTask(_cancellationTokenSource.Token);

            ProductCheckedListBox.DataSource = table;
            ProductCheckedListBox.DisplayMember = "ProductName";
        }

        private void GetCheckedButton_Click(object sender, EventArgs e)
        {
            List<CheckedListBoxExtensions.CheckedData> results = ProductCheckedListBox.IndexList("ProductID");

            foreach (var data in results)
            {
                Debug.WriteLine($"{data.Index},{data.Identifier}, [{string.Join(",", data.Row.ItemArray)}]");
            }
            
        }
    }
}
