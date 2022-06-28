using System.IO;
using StackoverflowEmailTemplateConsole.Classes;

namespace StackoverflowEmailTemplateConsole.Models
{
    public class TemplateOperations
    {
        public static string Populate(string fileName, TemplateItem templateItem)
        {
            string contents = File.ReadAllText(fileName);
            
            contents = contents.Replace("##User##", templateItem.User);
            contents = contents.Replace("##AppCom##", templateItem.AppCom);
            contents = contents.Replace("##AppUser##", string.Join(",", templateItem.AppUser));
            contents = contents.Replace("##ResignDate##", templateItem.ResignDate.ToString("d"));

            return contents;

        }
    }
}