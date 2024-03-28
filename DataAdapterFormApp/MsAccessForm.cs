using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAdapterFormApp.Classes;

namespace DataAdapterFormApp
{
    public partial class MsAccessForm : Form
    {
        public MsAccessForm()
        {
            InitializeComponent();
            Shown += MsAccessForm_Shown;
        }

        private void MsAccessForm_Shown(object sender, EventArgs e)
        {
            var (success, exception) = DataOperations.Load();
            dataGridView1.DataSource = DataOperations.BindingSource;
        }
    }
}
