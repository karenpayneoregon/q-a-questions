using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        private readonly BindingList<Phone> _bindingList;
        private readonly BindingSource _bindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();

            _bindingList = new BindingList<Phone>(new List<Phone>()
            {
                new Phone() {Id = 1, PhoneNumber = "123-222-3456"},
                new Phone() {Id = 2, PhoneNumber = "333-666-2654"}
            });

            _bindingSource.DataSource = _bindingList;
            _bindingSource.Sort = "Id";
            listBox1.DataSource = _bindingSource;
            label1.DataBindings.Add("Text", _bindingSource, "Id");
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            var id = _bindingList.LastOrDefault().Id;
            _bindingList.Add(new Phone()
            {
                Id = ++id, 
                PhoneNumber = StackoverflowHelpers.FormattedPhoneNumber()
            });

            _bindingSource.MoveLast();
        }
    }

    public class Phone
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public override string ToString() => PhoneNumber;
    
    }

}
