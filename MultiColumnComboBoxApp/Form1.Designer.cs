namespace MultiColumnComboBoxApp;

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
            this.components = new System.ComponentModel.Container();
            this.multiColumnComboBox1 = new MultiColumnComboBoxLibrary.MultiColumnComboBox(this.components);
            this.CurrentButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // multiColumnComboBox1
            // 
            this.multiColumnComboBox1.CurrentRow = null;
            this.multiColumnComboBox1.FormattingEnabled = true;
            this.multiColumnComboBox1.Location = new System.Drawing.Point(12, 51);
            this.multiColumnComboBox1.Name = "multiColumnComboBox1";
            this.multiColumnComboBox1.Size = new System.Drawing.Size(258, 28);
            this.multiColumnComboBox1.TabIndex = 0;
            // 
            // CurrentButton
            // 
            this.CurrentButton.Location = new System.Drawing.Point(276, 51);
            this.CurrentButton.Name = "CurrentButton";
            this.CurrentButton.Size = new System.Drawing.Size(94, 29);
            this.CurrentButton.TabIndex = 1;
            this.CurrentButton.Text = "Current";
            this.CurrentButton.UseVisualStyleBackColor = true;
            this.CurrentButton.Click += new System.EventHandler(this.CurrentButton_Click);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(390, 50);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(94, 29);
            this.ChangeButton.TabIndex = 2;
            this.ChangeButton.Text = "Change";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 193);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.CurrentButton);
            this.Controls.Add(this.multiColumnComboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

    }

    #endregion

    private MultiColumnComboBoxLibrary.MultiColumnComboBox multiColumnComboBox1;
    private Button CurrentButton;
    private Button ChangeButton;
}
