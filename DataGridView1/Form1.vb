Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Rows.Add(New Object() {"John", "USA", True})
        DataGridView1.Rows.Add(New Object() {"Mike", "AU", False})
        DataGridView1.Rows.Add(New Object() {"Jack", "EU", True})
        DataGridView1.Rows.Add(New Object() {"Mike", "AU", False})
    End Sub

    Private Sub DataGridView1_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) _
        Handles DataGridView1.CurrentCellDirtyStateChanged

        RemoveHandler DataGridView1.CurrentCellDirtyStateChanged,
            AddressOf DataGridView1_CurrentCellDirtyStateChanged

        If TypeOf DataGridView1.CurrentCell Is DataGridViewCheckBoxCell Then
            DataGridView1.EndEdit()
            Dim Checked As Boolean = CType(DataGridView1.CurrentCell.Value, Boolean)
            If Checked Then
                MessageBox.Show("You have checked")
            Else
                MessageBox.Show("You have un-checked")
            End If
        End If

        AddHandler DataGridView1.CurrentCellDirtyStateChanged,
            AddressOf DataGridView1_CurrentCellDirtyStateChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim rowsCheckedList As List(Of DataGridViewRow) =
                DataGridView1.GetCheckedRows1("ProcessColumn")

        For Each row As DataGridViewRow In rowsCheckedList
            Debug.WriteLine(row.Cells(0).Value)
        Next
    End Sub
End Class