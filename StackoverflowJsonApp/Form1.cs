using StackoverflowJsonApp.Classes;
using StackoverflowJsonApp.Models;
using System.Text.Json;
#pragma warning disable CA1869

namespace StackoverflowJsonApp;

public partial class Form1 : Form
{
    private BindingSource _bindingSource = new();
    private SortableBindingList<Employee> _bindingList;
    private string _fileName => "Employees.json";
    public Form1()
    {
        InitializeComponent();
        Shown += Form1_Shown;
    }

    private void Form1_Shown(object sender, EventArgs e)
    {
        dataGridView1.AllowUserToAddRows = false;
        List<Employee> list = JsonSerializer.Deserialize<List<Employee>>(
            File.ReadAllText(_fileName));

        list = list.OrderBy(x => x.ID).ToList();

        _bindingList = new SortableBindingList<Employee>(list);
        _bindingSource.DataSource = _bindingList;
        dataGridView1.DataSource = _bindingSource;

        dataGridView1.Columns["ID"]!.Visible = false;

        dataGridView1.ExpandColumns();
    }

    private void AddNewEmployeeButton_Click(object sender, EventArgs e)
    {
        using AddEmployeeForm form = new();
        form.EmployeeAdded += Form_EmployeeAdded;
        form.ShowDialog();
    }

    private void Form_EmployeeAdded(Employee employee)
    {
        /*
         * Get last id, increment by 1
         */
        var id = _bindingList.Max(x => x.ID) + 1;
        employee.ID = id;
        _bindingList.Add(employee);
        File.WriteAllText(_fileName, JsonSerializer.Serialize(_bindingList, new JsonSerializerOptions
        {
            WriteIndented = true
        }));

        _bindingSource.MoveLast();
    }
}


