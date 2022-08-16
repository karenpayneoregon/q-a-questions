using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using W = ConsoleHelperLibrary.Classes.WindowUtility;
// ReSharper disable once CheckNamespace
namespace JsonConvertForColdFusion
{
    partial class Program
    {
        [ModuleInitializer]
        public static void Init()
        {

            W.SetConsoleWindowPosition(W.AnchorWindow.Center);
            Console.Title = "";
        }
    }

    public class JsonOperation
    {
        public static void GetTags()
        {
            var json = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"Json","tags.json"));
            json = json.Replace("\\n","</br>");
            json = json.Replace("**USAGE:**", "<b>USAGE:</b>");
            json = json.Replace("**PARAMETERS:**", "<b>PARAMETERS:</b>");
            json = json.Replace("OED_modified", "<b>OED_modified</b>");
            Tags[] result = JsonSerializer.Deserialize<Tags[]>(json);

            StringBuilder builder = new ();
            builder.AppendLine("<!DOCTYPE html>");
            builder.AppendLine("<html>");
            builder.AppendLine("<body>");

            builder.AppendLine("<table>");
            foreach (var tag in result)
            {

                builder.AppendLine($"<tr> <td style=\"width: 259px; vertical-align: top;\">{tag.prefix}</td><td>{tag.documentation}</td>   </tr>");
            }
            builder.AppendLine("</table>");
            builder.AppendLine("</body>");
            builder.AppendLine("</html>");

            File.WriteAllText("tags.html", builder.ToString());
        }
    }

    public class Tags
    {
        public string prefix { get; set; }
        public string body { get; set; }
        public string documentation { get; set; }
    }



}





