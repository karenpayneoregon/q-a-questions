using WinFormsApp1.Classes;
using WinFormsApp1.Models;

namespace WinFormsApp1;
public partial class MainForm : Form
{
    private SortableBindingList<Student> _students;
    private BindingSource _source = new();
    public MainForm()
    {
        InitializeComponent();
        Shown += OnShown;
    }

    private void OnShown(object sender, EventArgs e)
    {
        _students = new SortableBindingList<Student>(BogusOperations.MockedStudents(5));
        _source.DataSource = _students;
        dataGridView1.DataSource = _source;

        for (int index = 0; index < dataGridView1.Columns.Count; index++)
        {
            dataGridView1.Columns[index].HeaderText = 
                dataGridView1.Columns[index].HeaderText.SplitCamelCase();
        }
    }

    private void AddButton_Click(object sender, EventArgs e)
    {
        _source.Add(BogusOperations.MockedStudents(1).FirstOrDefault());
        _source.Position = _source.Count - 1;
    }

    private void EditCurrentButton_Click(object sender, EventArgs e)
    {
        Student currentStudent = _students[_source.Position];
        Student student = BogusOperations.MockedStudents(1).FirstOrDefault();
        currentStudent.FirstName = student!.FirstName;
        currentStudent.LastName = student.LastName;
    }

    private void RemoveCurrentButton_Click(object sender, EventArgs e)
    {
        if (_source.Current is not null)
        {
            _source.RemoveCurrent();
        }
    }
}