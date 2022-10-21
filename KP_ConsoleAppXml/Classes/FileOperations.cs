using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using KP_ConsoleAppXml.Models;

namespace KP_ConsoleAppXml.Classes
{
    internal class FileOperations
    {
        public static void SelectAttribute()
        {
            XmlDocument doc = new ();
            doc.LoadXml(File.ReadAllText("Test2.xml"));
            XmlNodeList names = doc.SelectNodes("//Student/@name");

            for (int index = 0; index < names!.Count; index++)
            {
                if (names[index]!.InnerText.Length > 0)
                {
                    
                    Console.WriteLine(names[index].InnerText);
                }
            }

            XmlNode node = doc.SelectSingleNode("//Student/@name");
            node!.Value = "Kate";

            doc.Save("DoneStudents.xml");
        }

        public static void SelectAttribute1()
        {
            XDocument doc = XDocument.Load("Test2.xml");

            XElement foo = doc.Descendants().FirstOrDefault(x => x.Name.LocalName == "FOO");
            foo?.SetValue("14.11.2222");

            doc.Save("DoneStudents.xml");

        }
        public static void ReadWriteSimple(string firstName, string lastName)
        {
            if (!File.Exists("Test.xml"))
            {
                XmlWriterSettings xmlWriterSettings = new()
                {
                    Indent = true,
                    NewLineOnAttributes = true
                };

                using XmlWriter xmlWriter = XmlWriter.Create("Test1.xml", xmlWriterSettings);
                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("School");

                xmlWriter.WriteStartElement("Student");
                xmlWriter.WriteElementString("FirstName", firstName);
                xmlWriter.WriteElementString("LastName", lastName);
                xmlWriter.WriteEndElement();

                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();
                xmlWriter.Flush();
                xmlWriter.Close();
            }
            else
            {
                XDocument xDocument = XDocument.Load("Test1.xml");
                XElement root = xDocument.Element("School");
                IEnumerable<XElement> rows = root!.Descendants("Student");
                XElement firstRow = rows.First();

                firstRow.AddBeforeSelf(
                    new XElement("Student",
                        new XElement("FirstName", firstName),
                        new XElement("LastName", lastName)));

                xDocument.Save("done.xml");
            }
        }


        //public static string XmlToPrettyJson(string xml)
        //{
        //    var doc = XDocument.Parse(xml);
        //    return JsonConvert.SerializeXNode(doc, Formatting.Indented);
        //}

        public static string XmlToJson()
        {
            List<Student> emp;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
            using (StringReader textReader = new StringReader(File.ReadAllText("Test3.xml")))
            {
                emp = (List<Student>)xmlSerializer.Deserialize(textReader);
            }

            return "";
            //return EmployeeToJson(emp);
        }
        public static string EmployeeToJson(Student emp)
        {
            return JsonSerializer.Serialize(emp);
        }
    }



}
