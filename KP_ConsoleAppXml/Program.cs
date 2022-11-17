using System.Xml;
using KP_ConsoleAppXml.Classes;
using Spectre.Console;
using static System.Net.Mime.MediaTypeNames;


namespace KP_ConsoleAppXml;

internal partial class Program
{
    static void Main(string[] args)
    {

        Dictionary<string, string> dictionary = new()
        {
            { "Something", "111" },
            { "Another", DateTime.Now.Hour.ToString() }
        };

        //StudentOperations.XDocFindByAttribute(3, dictionary);

        //DateTime dateTime = DateTime.Now;
        //var dateNow = DateOnly.FromDateTime(dateTime);
        //Console.WriteLine(dateNow);

        //FileOperations.ReadWriteSimple("Bob","Simpson", true);
        Example();
        Console.ReadLine();
    }

    static void Example()
    {
        XmlWriterSettings xmlWriterSettings = new XmlWriterSettings()
        {
            Indent = true, 
            IndentChars = new string(' ',4),
            NewLineOnAttributes = true
        };

        using XmlWriter writer = XmlWriter.Create(Console.Out, xmlWriterSettings);

        writer.WriteStartDocument();

        writer.WriteStartElement("Root");
            writer.WriteStartElement("Section");
                writer.WriteElementString("Method1", "1");
                writer.WriteElementString("Method2", "0");
            writer.WriteEndElement();
        writer.WriteEndElement();

        writer.WriteEndDocument();
        writer.Flush();
        writer.Close();
    }


}

public static class Extensions
{
    public static string ToDateOnly(this string sender) => 
        DateTime.TryParse(sender, out var dateTime) ? 
            DateOnly.FromDateTime(dateTime).ToString() : 
            sender;
}