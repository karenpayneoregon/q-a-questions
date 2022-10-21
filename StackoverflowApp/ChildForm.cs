namespace StackoverflowApp
{
    public partial class ChildForm : Form
    {
        public delegate void StudentUpdate(Student student);
        public event StudentUpdate OnStudentChanged;
        private readonly Student _student;

        public ChildForm()
        {
            InitializeComponent();
        }
        public ChildForm(Student student)
        {
            InitializeComponent();

            _student = student;

            FirstNameTextBox.DataBindings.Add(
                "Text", student, nameof(Student.FirstName));
            LastNameTextBox.DataBindings.Add(
                "Text", student, nameof(Student.LastName));
            ScoreNumericUpDown.DataBindings.Add(
                "Value", student, nameof(Student.Score));

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            // TODO - Validation
            OnStudentChanged?.Invoke(_student);
        }
    }
}
