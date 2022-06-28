<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.checkedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.LastCheckedButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'checkedListBox1
        '
        Me.checkedListBox1.FormattingEnabled = True
        Me.checkedListBox1.Location = New System.Drawing.Point(49, 56)
        Me.checkedListBox1.Name = "checkedListBox1"
        Me.checkedListBox1.Size = New System.Drawing.Size(120, 256)
        Me.checkedListBox1.TabIndex = 0
        '
        'LastCheckedButton
        '
        Me.LastCheckedButton.Location = New System.Drawing.Point(49, 332)
        Me.LastCheckedButton.Name = "LastCheckedButton"
        Me.LastCheckedButton.Size = New System.Drawing.Size(120, 23)
        Me.LastCheckedButton.TabIndex = 1
        Me.LastCheckedButton.Text = "LastCheckedButton"
        Me.LastCheckedButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 450)
        Me.Controls.Add(Me.LastCheckedButton)
        Me.Controls.Add(Me.checkedListBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents checkedListBox1 As CheckedListBox
    Friend WithEvents LastCheckedButton As Button
End Class
