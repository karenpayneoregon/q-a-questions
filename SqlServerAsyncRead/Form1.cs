using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlServerAsyncRead.Classes;

namespace SqlServerAsyncRead
{
    public partial class Form1 : Form
    {

        private CancellationTokenSource _cancellationTokenSource = 
            new CancellationTokenSource(TimeSpan.FromSeconds(4));

        private readonly BindingSource _bindingSource = new BindingSource();
        
        public Form1()
        {
            InitializeComponent();
            Shown += OnShown;
        }

        private async void OnShown(object sender, EventArgs e)
        {
            await LoadData();
        }

       
        /// <summary>
        /// Load data from database table, if not first time calling this method
        /// create a new CancellationTokenSource
        /// </summary>
        private async Task LoadData()
        {
            DataTableResults dataResults = await DataOperations.ReadProductsTask(_cancellationTokenSource.Token);

            if (dataResults.HasException)
            {
                MessageBox.Show(dataResults.ConnectionFailed ? @"Connection failed" : dataResults.GeneralException.Message);
            }
            else
            {
                _bindingSource.DataSource = dataResults.DataTable;
                bindingNavigator1.BindingSource = _bindingSource;
                dataGridView1.DataSource = _bindingSource;
            }


        }
    }
}
