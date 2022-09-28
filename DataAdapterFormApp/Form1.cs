using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DataAdapterFormApp.Classes;
using DataAdapterFormApp.Extensions;

namespace DataAdapterFormApp
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Shown += OnShown;
        }

        /// <summary>
        /// Populate the DataTable with zero records
        /// </summary>
        private void OnShown(object sender, EventArgs e)
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
            if (modified != null)
            {
                Console.WriteLine();
            }

        }

        private void ExportExcelButton_Click(object sender, EventArgs e)
        {
            var dt = (DataTable)EmployeeOperations.BindingSource.DataSource;
            var (success, exception) = ExcelOperations.Export(dt, "SomeFile.xlsx");
            if (success)
            {
                // finished saving
            }
            else
            {
                // encountered issues, see exception
            }
        }

        private void ExportToTxtButton_Click(object sender, EventArgs e)
        {
            var success = dataGridView1.ExportToTextFile("SomeFile.txt");
            if (success)
            {
                // file saved
            }
            else
            {
                // failed
            }
        }
    }
}
