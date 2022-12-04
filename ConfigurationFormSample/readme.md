# About

Basic example for working with `appsettings.json` file using .NET Core 7.

See also NuGet package [ConfigurationLibrary](https://www.nuget.org/packages/ConfigurationLibrary/).

**appsettings.json**

```json
{
  "Role": {
    "IsAdmin": true
  },
  "LogOptions": {
    "Use": true,
    "Destination": "LogFile",
    "LogFileName": "logs.txt"
  },
  "FormSettings": {
    "Title": "Code sample",
    "FullScreen": "true"
  }
}
```

**Sample usage**

```csharp
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
```