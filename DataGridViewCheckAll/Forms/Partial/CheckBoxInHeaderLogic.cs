using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

// ReSharper disable once CheckNamespace
namespace CheckBoxColumnCount
{
	public partial class frmMainForm
	{
		private void AddHeaderCheckBox()
		{
			_headerCheckBox = new CheckBox();
			_headerCheckBox.Size = new Size(15, 15);
			dataGridView1.Controls.Add(_headerCheckBox);
		}
		private void ResetHeaderCheckBoxLocation(int columnIndex, int rowIndex)
		{

			//Get the column header cell bounds
			Rectangle rect = dataGridView1.GetCellDisplayRectangle(columnIndex, rowIndex, true);

			Point pt = new Point();

			pt.X = rect.Location.X + (rect.Width - _headerCheckBox.Width) / 2 + 1;
			pt.Y = rect.Location.Y + (rect.Height - _headerCheckBox.Height) / 2 + 1;

			//Change the location of the CheckBox to make it stay on the header
			_headerCheckBox.Location = pt;
		}
		private void HeaderCheckBoxClick(CheckBox HCheckBox)
		{
			_isHeaderCheckBoxClicked = true;
            DataTable dt = ((DataTable)CustomersBindingSource.DataSource);
			foreach (DataRow row in dt.Rows)
			{
				row.SetField<bool>(CheckBoxColName, HCheckBox.Checked);
			}

			dataGridView1.RefreshEdit();

			_totalCheckedCheckBoxes = HCheckBox.Checked ? _totalCheckBoxes : 0;
			_isHeaderCheckBoxClicked = false;

		}
		private void dgvSelectAll_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (!_isHeaderCheckBoxClicked)
			{
				RowCheckBoxClick((DataGridViewCheckBoxCell)dataGridView1[e.ColumnIndex, e.RowIndex]);
			}
		}
		private void dgvSelectAll_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (dataGridView1.CurrentCell is DataGridViewCheckBoxCell)
			{
				dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
			}
		}
		private void HeaderCheckBox_MouseClick(object sender, MouseEventArgs e)
		{
			HeaderCheckBoxClick((CheckBox)sender);
		}
		private void HeaderCheckBox_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Space)
			{
				HeaderCheckBoxClick((CheckBox)sender);
			}
		}
		private void dgvSelectAll_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			if (e.RowIndex == -1 && e.ColumnIndex == 0)
			{
				ResetHeaderCheckBoxLocation(e.ColumnIndex, e.RowIndex);
			}
		}
		private void RowCheckBoxClick(DataGridViewCheckBoxCell checkBox)
		{
			if (checkBox != null)
			{
				if (Convert.ToBoolean(checkBox.Value) && _totalCheckedCheckBoxes < _totalCheckBoxes)
				{
					_totalCheckedCheckBoxes += 1;
				}
				else if (_totalCheckedCheckBoxes > 0)
				{
					_totalCheckedCheckBoxes -= 1;
				}

				//Change state of the header CheckBox.
				if (_totalCheckedCheckBoxes < _totalCheckBoxes)
				{
					_headerCheckBox.Checked = false;
				}
				else if (_totalCheckedCheckBoxes == _totalCheckBoxes)
				{
					_headerCheckBox.Checked = true;
				}
			}
		}
	}

}
