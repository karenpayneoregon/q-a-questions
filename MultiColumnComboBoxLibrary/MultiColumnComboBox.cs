using System.Data;
using System.Drawing;

namespace MultiColumnComboBoxLibrary
{
	/// <summary>
	/// Summary description for MultiColumnComboBox.
	/// </summary>
	public delegate void AfterSelectEventHandler();
	public class MultiColumnComboBox : ComboBox
	{

		private System.ComponentModel.Container components = null;
		private DataRow selectedRow = null;
		private string displayMember = "";
		private string displayValue = "";
		private DataTable dataTable = null;
		private DataRow[] dataRows = null;
		private string[] columnsToDisplay = null;
		public event AfterSelectEventHandler AfterSelectEvent;

		public MultiColumnComboBox(System.ComponentModel.IContainer container)
		{

			container.Add(this);
			InitializeComponent();
		}

		public MultiColumnComboBox()
		{
			InitializeComponent();
		}

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
		}
		#endregion

		protected override void OnDropDown(EventArgs e){

			Form parent = this.FindForm();

			// Added by Karen Payne
            base.DropDownHeight = 1;

            if (dataTable != null || dataRows!= null)
            {
				MultiColumnComboPopup popup = new MultiColumnComboPopup(dataTable,ref selectedRow,columnsToDisplay);
				popup.AfterRowSelectEvent+=MultiColumnComboBox_AfterSelectEvent;
				popup.Location = new Point(parent.Left + this.Left + 4 ,parent.Top + this.Bottom + this.Height);
				popup.Show();
				if(popup.SelectedRow!=null){
					try{
						selectedRow = popup.SelectedRow;
						displayValue = popup.SelectedRow[this.displayMember].ToString();
						Text = displayValue;
					}catch(Exception e2) 
                    {
						MessageBox.Show(e2.Message,"Error");	
					}
				}

				if(AfterSelectEvent!=null)
                {
                    AfterSelectEvent();
                }
            }
            
            base.OnDropDown(e);
		}

		/// <summary>
		/// The current row
		/// </summary>
		/// <remarks>
		/// Added by Karen Payne
		/// </remarks>
        public DataRow CurrentRow { get; set; }
		private void MultiColumnComboBox_AfterSelectEvent(object sender, DataRow drow){
			try
            {
				if(drow!=null)
                {
					Text = drow[displayMember].ToString();
                    CurrentRow = drow;
                }
			}catch(Exception exp)
            {
				MessageBox.Show(this,exp.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}

		public DataRow SelectedRow => selectedRow;

        public string DisplayValue => displayValue;

        public new string DisplayMember{
			set => displayMember = value;
        }

		public DataTable Table{
			set
            {
				dataTable = value;
				if(dataTable==null)
                {
                    return;
                }

                selectedRow=dataTable.NewRow();
			}
		}

		public DataRow[] Rows{
			set => dataRows = value;
        }

		public string[] ColumnsToDisplay{
			set => columnsToDisplay = value;
        }
	}
}
