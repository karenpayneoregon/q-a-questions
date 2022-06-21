using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XmlDemo.Classes;
using XmlDemo.Models;

namespace XmlDemo
{
    public partial class Form1 : Form
    {
        private readonly BindingSource _bindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            Root result = XmlOperations.Read();
            _bindingSource.DataSource = result.MachineProfile.ToList();
            MachineProfileComboBox.DataSource = _bindingSource;
            SerialNumberLabel.DataBindings.Add("Text", _bindingSource, nameof(RootMachineProfile.SerialNumber));
        }
    }
}
