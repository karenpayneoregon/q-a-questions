using System;
using System.Xml.Serialization;

namespace XmlDemo.Models
{
    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    public partial class RootCompanyProfile
    {

        private string companyNameField;
        private string siteNameField;
        private uint imoField;
        private int machineTotalField;

        public string CompanyName
        {
            get => companyNameField;
            set => companyNameField = value;
        }
        public string SiteName
        {
            get => siteNameField;
            set => siteNameField = value;
        }
        public uint Imo
        {
            get => imoField;
            set => imoField = value;
        }
        public int MachineTotal
        {
            get => machineTotalField;
            set => machineTotalField = value;
        }
    }
}