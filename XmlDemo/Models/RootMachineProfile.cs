using System;
using System.Xml.Serialization;

namespace XmlDemo.Models
{
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    public partial class RootMachineProfile
    {

        private string machineNameField;
        private uint serialNumberField;
        private string typeNumberField;
        private string typeField;
        private ushort nominalSpeedField;
        private byte frequencyField;
        private ushort nominalPowerField;

        public string MachineName
        {
            get => machineNameField;
            set => machineNameField = value;
        }

        public uint SerialNumber
        {
            get => serialNumberField;
            set => serialNumberField = value;
        }
        public string TypeNumber
        {
            get => typeNumberField;
            set => typeNumberField = value;
        }
        public string Type
        {
            get => typeField;
            set => typeField = value;
        }
        public ushort NominalSpeed
        {
            get => nominalSpeedField;
            set => nominalSpeedField = value;
        }
        public byte Frequency
        {
            get => frequencyField;
            set => frequencyField = value;
        }
        public ushort NominalPower
        {
            get => nominalPowerField;
            set => nominalPowerField = value;
        }
        public override string ToString() => MachineName;
    }
}