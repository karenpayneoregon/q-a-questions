using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using KP_ConsoleAppXml.Models;

namespace KP_ConsoleAppXml.Classes
{
    internal class FileOperations
    {
        /// <summary>
        /// Read file, find <see cref="Student.Dummy"/> where Dummy is not in the model and
        /// update if found
        /// </summary>
        public static void SelectAttribute1()
        {
            XDocument doc = XDocument.Load("Test2.xml");

            XElement foo = doc.Descendants().FirstOrDefault(x => x.Name.LocalName == "Dummy");
            foo?.SetValue("14.11.2222");

            doc.Save("DoneStudents.xml");

        }

        /// <summary>
        /// Same as about but by <see cref="Student.Name"/> which is in the model
        /// </summary>
        public static void SelectAttribute2()
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

        /// <summary>
        /// Simple add <see cref="XElement.AddBeforeSelf"/>
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public static void ReadWriteSimple(string firstName, string lastName, bool formType)
        {
            if (!File.Exists("Testpppp.xml"))
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
                xmlWriter.WriteElementString("FilingMethod", formType ? "1" : "0");

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
    }
}
