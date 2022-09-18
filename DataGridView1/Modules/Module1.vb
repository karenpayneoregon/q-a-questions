Module Module1
    <DebuggerStepThrough()>
    <Runtime.CompilerServices.Extension()>
    Public Function GetCheckedRows1(ByVal gridView As DataGridView, ByVal columnName As String) As List(Of DataGridViewRow)
        Return _
            (
                From subRows In
                    (
                        From Rows In gridView.Rows.Cast(Of DataGridViewRow)()
                        Where Not Rows.IsNewRow
                        ).ToList
                Where CBool(subRows.Cells(columnName).Value) = True
                ).ToList
    End Function
End Module