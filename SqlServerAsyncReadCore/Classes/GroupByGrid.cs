namespace SqlServerAsyncReadCore.Classes;
/// <summary>
/// https://social.msdn.microsoft.com/Forums/en-US/a44622c0-74e1-463b-97b9-27b87513747e/windows-forms-data-controls-and-databinding-faq?forum=winformsdatacontrols#faq8
/// </summary>
public class GroupByGrid : DataGridView
{
    protected override void OnCellFormatting(DataGridViewCellFormattingEventArgs args)
    {
        base.OnCellFormatting(args);

        // First row always displays
        if (args.RowIndex == 0)
        {
            return;
        }

        if (IsRepeatedCellValue(args.RowIndex, args.ColumnIndex))
        {
            args.Value = string.Empty;
            args.FormattingApplied = true;
        }
    }
    private bool IsRepeatedCellValue(int rowIndex, int colIndex)
    {
        DataGridViewCell currentCell = Rows[rowIndex].Cells[colIndex];
        DataGridViewCell prevCell = Rows[rowIndex - 1].Cells[colIndex];

        if ((currentCell.Value == prevCell.Value) || 
            (currentCell.Value != null && prevCell.Value != null && 
             currentCell.Value.ToString() == prevCell.Value.ToString()))
        {
            return true;
        }
        else
        {
            return false;
        }

    }
    protected override void OnCellPainting(DataGridViewCellPaintingEventArgs args)
    {

        base.OnCellPainting(args);

        args.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;

        // Ignore column and row headers and first row
        if (args.RowIndex < 1 || args.ColumnIndex < 0)
        {
            return;
        }

        args.AdvancedBorderStyle.Top = IsRepeatedCellValue(args.RowIndex, args.ColumnIndex) ? 
            DataGridViewAdvancedCellBorderStyle.None : 
            AdvancedCellBorderStyle.Top;

    }
}
