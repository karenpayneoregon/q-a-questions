using System.Xml;
using KP_ConsoleAppXml.Models;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

namespace KP_ConsoleAppXml.Classes;

internal class StudentOperations
{
    public static void Example1()
    {

        string xml = File.ReadAllText("Test3.xml");

        XmlDocument doc = new XmlDocument();
        doc.LoadXml(xml);

        string json = JsonConvert.SerializeXmlNode(doc, Formatting.Indented);
        Console.WriteLine(json);

        Console.WriteLine();

        StudentsData results = JsonConvert.DeserializeObject<StudentsData>(json);


        foreach (var student in results.Students.Student)
        {
            Console.WriteLine($"{student.Id,-4}{student.Name}");
        }
    }
}