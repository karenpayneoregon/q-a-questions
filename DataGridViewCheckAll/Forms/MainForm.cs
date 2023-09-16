using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using CheckBoxColumnCount.Classes;
using CheckBoxColumnCount.Extensions;

// ReSharper disable once CheckNamespace
namespace CheckBoxColumnCount
{
    public partial class frmMainForm
    {

        private bool _instanceDataInitialized = false;

        public frmMainForm()
        {
            if (!_instanceDataInitialized)
            {
                InitializeInstanceData();
                _instanceDataInitialized = true;
            }

            InitializeComponent();
        }

        private void InitializeInstanceData()
        {
            CustomersBindingSource = new BindingSource();
        }

        [System.Runtime.CompilerServices.AccessedThroughProperty(nameof(CustomersBindingSource))]
        private BindingSource _bindingSource;
        private BindingSource CustomersBindingSource
        {

            get => _bindingSource;
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized), System.Diagnostics.DebuggerNonUserCode]
            set
            {
                if (_bindingSource != null)
                {
                    _bindingSource.PositionChanged -= mCustomersBindingSource_PositionChanged;
                }

                _bindingSource = value;

                if (value != null)
                {
                    _bindingSource.PositionChanged += mCustomersBindingSource_PositionChanged;
                }
            }
        }

        private int _totalCheckBoxes = 0;
        private int _totalCheckedCheckBoxes = 0;
        private CheckBox _headerCheckBox = null;
        private bool _isHeaderCheckBoxClicked = false;
        private string _identifier = "";
        private const string CheckBoxColName = "Process";
        private void Form1_Load(System.Object sender, System.EventArgs e)
        {
            Setup();
        }

        private void Setup()
        {
            AddHeaderCheckBox();

            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.AddRange(new DataGridViewColumn[]
            {
                new DataGridViewCheckBoxColumn
                {
                    HeaderText = "",
                    DataPropertyName = CheckBoxColName,
                    Name = CheckBoxColName
                },
                new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "CompanyName",
                    HeaderText = "Company",
                    Name = "CompanyName", 
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                },
                new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Identifier",
                    Name = "Identifier"
                }
            });

            CustomersBindingSource.DataSource = DataOperations.Read();

            dataGridView1.DataSource = CustomersBindingSource;
            dataGridView1.Columns["Identifier"].Visible = false;


            dataGridView1.AutoResizeColumns();

            _totalCheckBoxes = dataGridView1.RowCount;
            _totalCheckedCheckBoxes = 0;

            _headerCheckBox.KeyUp += HeaderCheckBox_KeyUp;
            _headerCheckBox.MouseClick += HeaderCheckBox_MouseClick;
            dataGridView1.CellValueChanged += dgvSelectAll_CellValueChanged;
            dataGridView1.CurrentCellDirtyStateChanged += dgvSelectAll_CurrentCellDirtyStateChanged;
            dataGridView1.CellPainting += dgvSelectAll_CellPainting;

            if (dataGridView1.CheckBoxCount(0, true) == dataGridView1.RowCount)
            {
                _headerCheckBox.Checked = true;
            }
        }

        private void mCustomersBindingSource_PositionChanged(object sender, System.EventArgs e)
        {
            _identifier = ((DataRowView)CustomersBindingSource.Current)["Identifier"].ToString();
        }
        private void DataGridView1_Sorted(object sender, System.EventArgs e)
        {
            CustomersBindingSource.Position = 
                CustomersBindingSource.Find("Identifier", _identifier);
        }

        private void ProcessButton_Click(object sender, System.EventArgs e)
        {
            DataTable table = (DataTable)CustomersBindingSource.DataSource;

            EnumerableRowCollection<DataRow> test = table
                .AsEnumerable()
                .Where(row => row.Field<bool>("Process"));

            if (test.Any())
            {
                var checkedTable = test.CopyToDataTable();
                label1.Text = $"There are {checkedTable.Rows.Count} checked";
            }
            else
            {
                // no rows checked
                label1.Text = "No rows checked";
            }
        }
    }

}
