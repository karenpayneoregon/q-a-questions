#nullable disable
using System.Diagnostics;
using System.Text;
using Bogus;
using Bogus.Extensions;

namespace WinFormsApp1
{

    public partial class Form1 : Form
    {
        private List<TextBox> _textBoxes = new List<TextBox>();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button1PerformClick((Button)sender);
        }

  
        private void Button1PerformClick(Button button)
        {
            MessageBox.Show(button.Name);
        }
        private void button2_Click(object sender, EventArgs e)
        {
     
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("4");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.PerformClick();
        }
    }
}