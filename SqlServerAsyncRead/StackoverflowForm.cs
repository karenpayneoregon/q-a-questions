using System;
using System.Windows.Forms;
using SqlServerAsyncRead.Classes;

namespace SqlServerAsyncRead
{
    public partial class StackoverflowForm : Form
    {
        public StackoverflowForm()
        {
            InitializeComponent();
            DataOperations.Processed += DataOperationsOnProcessed;
        }

        private void DataOperationsOnProcessed(string text)
        {
            if (text == "Insufficient stock")
            {
                MessageBox.Show($"Sorry {text} ");
            }
            else
            {
                MessageBox.Show(text);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            DataOperations.UpdateProductStockCount(21,1);
        }
    }
}
