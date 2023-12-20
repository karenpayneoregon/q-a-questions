using StackoverflowJsonApp.Models;

namespace StackoverflowJsonApp;

/// <summary>
/// Simulate without form controls, adding a new <see cref="Employee"/>
/// For a real application with controls
/// Perform validation e.g. are there required properties and if not entered reject,
/// else proceed.
/// </summary>
public partial class AddEmployeeForm : Form
{
    public delegate void OnAddEmployee(Employee sender);
    public event OnAddEmployee? EmployeeAdded;
    public AddEmployeeForm()
    {
        InitializeComponent();
    }

    private void AddButton_Click(object sender, EventArgs e)
    {
        Employee employee = new Employee()
        {
            Age = 26,
            Name = "Mary",
            Surname = "Jones",
            Position = "Clerk",
            Salary = 50_000
        };

        EmployeeAdded?.Invoke(employee);
        DialogResult = DialogResult.OK;
    }

    private void CancelButton_Click(object sender, EventArgs e)
    {
        // this can be set in the property window
        DialogResult = DialogResult.Cancel;
    }
}
