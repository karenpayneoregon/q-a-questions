using System;
using System.Collections.Generic;

namespace StackoverflowEmailTemplateConsole.Classes
{
    public class TemplateItem
    {
        public string User { get; set; }
        public string AppCom { get; set; }
        public List<string> AppUser { get; set; }
        public DateTime ResignDate { get; set; }
    }
}
