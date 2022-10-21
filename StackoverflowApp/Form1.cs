using System.ComponentModel;

namespace StackoverflowApp
{
    public partial class Form1 : Form
    {
        private readonly BindingSource _bindingSource = new BindingSource();
        private BindingList<Student> _bindingList = new BindingList<Student>();

        public Form1()
        {
            InitializeComponent();
            
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            _bindingList = new BindingList<Student>(Operations.Students());
            _bindingSource.DataSource = _bindingList;
            listBox1.DataSource = _bindingSource;
        }

        private void ShowFormButton_Click(object sender, EventArgs e)
        {
            using ChildForm form = new ChildForm(_bindingList[_bindingSource.Position]);
            form.OnStudentChanged += FrmOnOnStudentChanged;
            form.ShowDialog();
            form.OnStudentChanged -= FrmOnOnStudentChanged;
        }

        private void FrmOnOnStudentChanged(Student student)
        {
            _bindingList[_bindingSource.Position] = student;
            _bindingList.ResetItem(_bindingSource.Position);
        }

        private void CurrentButton_Click(object sender, EventArgs e)
        {
            var student = _bindingList[_bindingSource.Position];
            MessageBox.Show($"{student.Id}, {student.FirstName}, {student.LastName}, {student.Score}");
        }
    }
}
