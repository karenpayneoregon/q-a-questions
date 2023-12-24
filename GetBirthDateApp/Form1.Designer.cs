namespace GetBirthDateApp;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        ZonesComboBox = new ComboBox();
        SuspendLayout();
        // 
        // ZonesComboBox
        // 
        ZonesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        ZonesComboBox.FormattingEnabled = true;
        ZonesComboBox.Location = new Point(29, 32);
        ZonesComboBox.Name = "ZonesComboBox";
        ZonesComboBox.Size = new Size(271, 28);
        ZonesComboBox.TabIndex = 0;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(ZonesComboBox);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form1";
        ResumeLayout(false);
    }

    #endregion

    private ComboBox ZonesComboBox;
}
