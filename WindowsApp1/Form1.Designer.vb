Imports WindowsControls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TextProgressBar1 = New TextProgressBar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextProgressBar1
        '
        Me.TextProgressBar1.CustomText = "Working"
        Me.TextProgressBar1.Location = New System.Drawing.Point(12, 24)
        Me.TextProgressBar1.Name = "TextProgressBar1"
        Me.TextProgressBar1.ProgressColor = System.Drawing.Color.LightGreen
        Me.TextProgressBar1.Size = New System.Drawing.Size(361, 23)
        Me.TextProgressBar1.TabIndex = 0
        Me.TextProgressBar1.TextColor = System.Drawing.Color.Black
        Me.TextProgressBar1.TextFont = New System.Drawing.Font("Times New Roman", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.TextProgressBar1.VisualMode = ProgressBarDisplayMode.TextAndCurrProgress
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 68)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 163)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextProgressBar1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextProgressBar1 As TextProgressBar
    Friend WithEvents Button1 As Button
End Class
