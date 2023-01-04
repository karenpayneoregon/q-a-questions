// ReSharper disable once CheckNamespace
namespace PythonOedLibrary;
public class EnvironmentOperations
{
    /// <summary>
    /// Writes a greeting with time of day
    /// </summary>
    /// <param name="name">person name</param>
    /// <returns>greeting</returns>
    public static string Hello(string name)
        => $"{Howdy.TimeOfDay()} {name}";
}