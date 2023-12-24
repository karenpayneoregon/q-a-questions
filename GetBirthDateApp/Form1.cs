using NodaTime;

namespace GetBirthDateApp;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        Shown += Form1_Shown;
    }

    private void Form1_Shown(object sender, EventArgs e)
    {
        var zones = DateTimeZoneProviders.Tzdb.Ids.Where(x => x.StartsWith("America")).ToList();
    }
}
