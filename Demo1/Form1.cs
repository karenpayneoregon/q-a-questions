using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1
{
    public partial class Form1 : Form
    {
        private BindingListSpecial<string> _bindingList;
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadButton1_Click(object sender, EventArgs e)
        {
            _bindingList = new BindingListSpecial<string>(File.ReadAllLines("TextFile1.txt").ToList());
            comboBox1.DataSource = _bindingList;
        }
        private void LoadButton2_Click(object sender, EventArgs e)
        {
            _bindingList.AddRange(File.ReadAllLines("TextFile2.txt").ToList());
        }
    }
}
