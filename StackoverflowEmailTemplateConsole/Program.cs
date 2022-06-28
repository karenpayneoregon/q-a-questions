using System;
using System.Collections.Generic;
using System.IO;
using StackoverflowEmailTemplateConsole.Classes;
using static StackoverflowEmailTemplateConsole.Models.TemplateOperations;

namespace StackoverflowEmailTemplateConsole
{
    partial class Program
    {
        static void Main(string[] args)
        {
            TemplateItem templateItem = new()
            {
                AppCom = "ABC",
                AppUser = new List<string>() { "Mike", "Jane", "Fran" },
                ResignDate = DateTime.Now,
                User = "Adam"
            };

            string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, 
                "MailTemplate", "Resignnotify.html");

            var body = Populate(fileName, templateItem);

            Console.WriteLine(body);
            Console.ReadLine();
        }
    }
}
