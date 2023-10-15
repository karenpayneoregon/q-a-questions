using ForumQuestionDelegates.Classes;

namespace ForumQuestionDelegates;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        Operations.ColorsChanged += Operations_ColorsChanged;
    }

    private void Operations_ColorsChanged(Color color)
    {
        label1.ForeColor = color;
    }

    private void UpdateValueButton_Click(object sender, EventArgs e)
    {
        Singleton.Instance.Value += 1;
        Operations.DoSomeWork();
        label2.Text = $@"Singleton value is {Singleton.Instance.Value}";
    }
}
