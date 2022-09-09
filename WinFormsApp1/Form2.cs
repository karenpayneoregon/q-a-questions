using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            dataGridView1.DataSource = DataOperations.Table().Clone();
        }

        public void Receive(DataRow row)
        {
            var table = ((DataTable)dataGridView1.DataSource);
            var test = table.AsEnumerable().FirstOrDefault(x => x.Field<int>("Id") == row.Field<int>("Id"));
            if (test == null)
            {
                table.ImportRow(row);    
            }

        }

        
    }
}
