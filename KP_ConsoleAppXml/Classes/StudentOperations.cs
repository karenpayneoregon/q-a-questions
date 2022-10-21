using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
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

        XmlNodeList nodes = doc.SelectNodes("//Students/Student");

        foreach (XmlElement node in nodes)
        {
            if (Convert.ToInt32(node.Attributes["Id"]!.Value) == 3)
            {
                Console.WriteLine($"{Convert.ToInt32(node.Attributes["Id"]!.Value),-4}{node.Attributes["Name"]!.Value}");
                
            }

        }


        string json = JsonConvert.SerializeXmlNode(doc, Formatting.Indented);

        Console.WriteLine();

        StudentsData results = JsonConvert.DeserializeObject<StudentsData>(json);


        foreach (var student in results!.Students.Student)
        {
            student.Activated = true;
            //Console.WriteLine($"{student.Id,-4}{student.Name,-7}{student.BirthDate:MM/dd/yyyy} {student.Activated}");
        }

        Console.WriteLine();

        var test = JsonConvert.SerializeObject(results, Formatting.Indented);
        //Console.WriteLine(test);
    }

    /// <summary>
    /// Find node by id, if found add elements defined by dictionary parameter
    /// </summary>
    /// <param name="identifier"></param>
    /// <param name="dictionary"></param>
    public static void XDocFindByAttribute(int identifier, Dictionary<string, string> dictionary)
    {
        XDocument doc = XDocument.Load("Test3.xml");

        XElement student = doc.XPathSelectElement($"/Students/Student[@Id='{identifier}']");

        if (student is not null)
        {
            
            foreach (var element in dictionary)
            {
                student.Add(new XElement(element.Key, element.Value));
            }

            Console.WriteLine(student.Attribute("Name")!.Value);

            Console.WriteLine(DateTime.TryParse(student.Element("SomeDate")!.Value, out var bDateTime)
                ? bDateTime.ToString("d")
                : $"Not a date {student.Element("SomeDate")!.Value}");

            Console.WriteLine(student.Element("Dummy")!.Value);

            Console.WriteLine(student);

            doc.Save("Test3Updated.xml");
        }
        else
        {
            Console.WriteLine($"Not found {identifier}");
        }
    }
}