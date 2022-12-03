namespace ConfigurationFormSample.Classes;

public class FormSettings
{
    public string Title { get; set; }
    public bool FullScreen { get; set; }
}
public class Role
{
    public bool IsAdmin { get; set; }
}
public class Logging
{
    public bool Use { get; set; }
    public LoggingDestination Destination { get; set; }
    public string LogFileName { get; set; }
}
public enum LoggingDestination
{
    DebugWindow,
    LogFile,
    None
}