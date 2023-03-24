using System;
using System.ComponentModel;
using System.Windows.Forms;
using DataAdapterFormApp.Classes;
using DataAdapterFormApp.Models;

namespace DataAdapterFormApp
{
    public partial class Form2 : Form
    {
        private BindingList<Employee> _bindingList;
        private readonly BindingSource _bindingSource = new BindingSource();
        public Form2()
        {
            InitializeComponent();

            _bindingList = new BindingList<Employee>(EmployeeOperations.ReadEmployees());
            _bindingSource.DataSource = _bindingList;
            dataGridView1.DataSource = _bindingSource;
            dataGridView1.Columns["id"].Visible = false;

        }

        private void CurrentButton_Click(object sender, EventArgs e)
        {
            Employee employee = _bindingList[_bindingSource.Position];
        }

        private void AllButton_Click(object sender, EventArgs e)
        {
            foreach (var employee in _bindingList)
            {
                Console.WriteLine(employee.FirstName);
            }
        }
    }
}
