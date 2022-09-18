Module Module1
    <DebuggerStepThrough()>
    <Runtime.CompilerServices.Extension()>
    Public Function GetCheckedRows1(ByVal GridView As DataGridView, ByVal ColumnName As String) As List(Of DataGridViewRow)
        Return _
            (
                From SubRows In
                    (
                        From Rows In GridView.Rows.Cast(Of DataGridViewRow)()
                            Where Not Rows.IsNewRow
                        ).ToList
                    Where CBool(SubRows.Cells(ColumnName).Value) = True
                ).ToList
    End Function
End Module