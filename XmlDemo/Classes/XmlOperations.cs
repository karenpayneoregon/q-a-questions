using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XmlDemo.Models;

namespace XmlDemo.Classes
{
    public class XmlOperations
    {
        public static Root Read()
        {
            const string fileName = @"XMLFile1.xml";
            var xmlSerializer = new XmlSerializer(typeof(Root), new XmlRootAttribute { ElementName = "Root", IsNullable = true });
            using (var fs = new FileStream(fileName, FileMode.Open))
            {
                return (Root)xmlSerializer.Deserialize(fs);

            }
        }
    }
}
