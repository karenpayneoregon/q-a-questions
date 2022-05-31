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
        Me.GetButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SetButton = New System.Windows.Forms.Button()
        Me.ConnectionStringTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'GetButton
        '
        Me.GetButton.Location = New System.Drawing.Point(12, 27)
        Me.GetButton.Name = "GetButton"
        Me.GetButton.Size = New System.Drawing.Size(75, 23)
        Me.GetButton.TabIndex = 0
        Me.GetButton.Text = "Get"
        Me.GetButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'SetButton
        '
        Me.SetButton.Location = New System.Drawing.Point(12, 56)
        Me.SetButton.Name = "SetButton"
        Me.SetButton.Size = New System.Drawing.Size(75, 23)
        Me.SetButton.TabIndex = 2
        Me.SetButton.Text = "Set"
        Me.SetButton.UseVisualStyleBackColor = True
        '
        'ConnectionStringTextBox
        '
        Me.ConnectionStringTextBox.Location = New System.Drawing.Point(93, 59)
        Me.ConnectionStringTextBox.Name = "ConnectionStringTextBox"
        Me.ConnectionStringTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ConnectionStringTextBox.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 110)
        Me.Controls.Add(Me.ConnectionStringTextBox)
        Me.Controls.Add(Me.SetButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GetButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connection read/write"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GetButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents SetButton As Button
    Friend WithEvents ConnectionStringTextBox As TextBox
End Class
