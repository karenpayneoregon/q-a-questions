using System.Diagnostics;

namespace CustomDateTimePicker;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void SetToNullButton_Click(object sender, EventArgs e)
    {

        nullableDateTimePicker1.Value = DateTime.MinValue;
    }
}
