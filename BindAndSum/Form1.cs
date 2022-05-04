using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BindAndSum
{
    public partial class Form1 : Form
    {
        private readonly BindingSource _bindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            textBox1.KeyPress += TextBoxOnKeyPress;
            textBox2.KeyPress += TextBoxOnKeyPress;

            // setting properties is optional as they default to 0
            _bindingSource.DataSource = new List<Item>()
            {
                new Item() {Value1 = 12, Value2 = 4}
            };

            textBox1.DataBindings.Add("Text", _bindingSource, 
                nameof(Item.Value1));

            textBox2.DataBindings.Add("Text", _bindingSource, 
                nameof(Item.Value2));

            label1.DataBindings.Add("Text", _bindingSource, 
                nameof(Item.Total));

        }

        private void TextBoxOnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == 46 && (sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
            {
                e.Handled = true;
            }
        }


    }
}
