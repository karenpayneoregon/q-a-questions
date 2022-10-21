using KP_ConsoleAppXml.Classes;
using KP_ConsoleAppXml.Models;

namespace KP_ConsoleAppXml;

internal partial class Program
{
    static void Main(string[] args)
    {

        Dictionary<string, string> dictionary = new Dictionary<string, string>
        {
            { "Something", "111" },
            { "Another", DateTime.Now.Hour.ToString() }
        };

        StudentOperations.XDocFindByAttribute(3, dictionary);

        Console.ReadLine();
    }


}