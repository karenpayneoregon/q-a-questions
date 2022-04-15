using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

    public class Helpers
    {
        public static List<Container> GetZeros(string value)
        {
            List<Container> list = new();
            Regex regex = new(@"\d+(\.\d+)?");
            var matches = regex.Matches(value);
            int index = 0;

            foreach (Match match in matches)
            {
                var length = match.Value.Replace("0.", "").Length;
                list.Add(new Container() {Index = index, Value = match.Value, Length = length});
                index++;
            }

            return list;
        }
    }

    public class Container
    {
        public int Index { get; set; }
        public string Value { get; set; }
        public int Length { get; set; }
    }
}
