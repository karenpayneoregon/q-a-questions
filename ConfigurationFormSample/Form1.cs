using ConfigurationFormSample.Classes;

namespace ConfigurationFormSample;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        Text = AppSettings.Role().IsAdmin
            ? AppSettings.Settings().Title + " (Admin)"
            : AppSettings.Settings().Title ;
    }

    private void GetLogInfoButton_Click(object sender, EventArgs e)
    {
        if (AppSettings.GetLogOptions().Use && AppSettings.GetLogOptions().Destination == LoggingDestination.LogFile)
        {
            MessageBox.Show($"{AppSettings.GetLogOptions().LogFileName}");
        }
    }
}