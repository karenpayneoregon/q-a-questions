using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataGridViewCombo1.Classes;

namespace DataGridViewCombo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            ActiveControl = payneDataGridView1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var (customerTable, colorTable) = DataOperations.LoadData();
            payneDataGridView1.DataSource = customerTable;
            payneDataGridView1.Columns[0].Visible = false;
        }
    }
}
