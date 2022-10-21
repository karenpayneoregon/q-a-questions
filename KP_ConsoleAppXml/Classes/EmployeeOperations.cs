using System.Text.Json;
using System.Xml.Serialization;
using KP_ConsoleAppXml.Models;

namespace KP_ConsoleAppXml.Classes;

/// <summary>
/// http://www.binaryintellect.net/articles/d56c7798-703d-45cf-be74-a8b0cec94a3c.aspx
/// </summary>
internal class EmployeeOperations
{
    public static string EmployeeToXml(Employee emp)
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));
        using StringWriter textWriter = new StringWriter();
        xmlSerializer.Serialize(textWriter, emp);
        return textWriter.ToString();
    }
    public static string EmployeeToJson(Employee emp) => JsonSerializer.Serialize(emp);

    /// <summary>
    /// Converting from XML to JSON
    /// </summary>
    /// <param name="xmlData"></param>
    /// <returns></returns>
    public static string XmlToJson(string xmlData)
    {
        Employee emp;
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));
        using StringReader textReader = new StringReader(xmlData);
        emp = (Employee)xmlSerializer.Deserialize(textReader);
        return EmployeeToJson(emp);
    }

    /// <summary>
    /// Converting from JSON to XML
    /// </summary>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    public static string JsonToXml(string jsonData)
    {
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        Employee emp = JsonSerializer.
            Deserialize<Employee>(jsonData, options);

        return EmployeeToXml(emp);
    }


}