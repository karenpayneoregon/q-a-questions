using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DataAdapterFormApp.Classes;

namespace DataAdapterFormApp
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
            LoadData();
        }

        /// <summary>
        /// Load data in <seealso cref="OnShown"/> or reload in <seealso cref="ReloadDataButton_Click"/>
        /// </summary>
        private void LoadData()
        {
            var (success, exception) = EmployeeOperations.Load();

            if (success)
            {
                dataGridView1.DataSource = EmployeeOperations.BindingSource;
                dataGridView1.Columns[0].ReadOnly = true;
            }
            else
            {
                SaveChangeButton.Enabled = false;
                MessageBox.Show($@"Failed to load data\n{exception.Message}");
            }
        }

        /// <summary>
        /// Save all changes
        /// </summary>
        private void SaveChangeButton_Click(object sender, EventArgs e)
        {
            var (affected, exception) = EmployeeOperations.SaveChanges();
            if (exception != null)
            {
                MessageBox.Show($@"Save failed\n{exception.Message}");
            }
            else
            {
                MessageBox.Show($@"Affected records {affected}");
            }
        }

        private void GetChangesButton_Click(object sender, EventArgs e)
        {
            DataTable modified = EmployeeOperations.DataTable().GetChanges(DataRowState.Modified);

            MessageBox.Show(modified != null ? "Has change" : "No change");
        }

        private void ShowColumnNamesButton_Click(object sender, EventArgs e)
        {
            List<string> columnNames = SqlServerUtilities.ColumnNameForTable("employee");
            foreach (var name in columnNames)
            {
                Console.WriteLine(name);
            }
        }

        private void MockedEditButton_Click(object sender, EventArgs e)
        {
            var row = EmployeeOperations.Current();
            row.SetField("FirstName", "Karen");
        }

        private void ReloadDataButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
