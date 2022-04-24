using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Versioning
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void GetZerosButton_Click(object sender, EventArgs e)
        {

            List<Container> list = Helpers.GetZeros("####0.0%;(####0.00%);####0.0000%");

            Debug.WriteLine("Index     Length    Value ");
            foreach (var container in list)
            {
                Debug.WriteLine($"{container.Index,-10}{container.Length, -10}{container.Value}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }

    public class Container
    {
        public int Index { get; set; }
        public string Value { get; set; }
        public int Length { get; set; }
    }
}
