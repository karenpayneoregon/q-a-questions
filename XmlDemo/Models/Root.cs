using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlDemo.Models
{
    [SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Root
    {

        private RootCompanyProfile companyProfileField;
        private RootMachineProfile[] machineProfileField;

        public RootCompanyProfile CompanyProfile
        {
            get => companyProfileField;
            set => companyProfileField = value;
        }
        [XmlElementAttribute("MachineProfile")]
        public RootMachineProfile[] MachineProfile
        {
            get => machineProfileField;
            set => machineProfileField = value;
        }

        public override string ToString() => $"{CompanyProfile.CompanyName}";
    }
}
