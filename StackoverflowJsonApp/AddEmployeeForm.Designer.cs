namespace StackoverflowJsonApp;

partial class AddEmployeeForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        AddButton = new Button();
        CancelButton = new Button();
        SuspendLayout();
        // 
        // AddButton
        // 
        AddButton.Location = new Point(157, 59);
        AddButton.Name = "AddButton";
        AddButton.Size = new Size(94, 29);
        AddButton.TabIndex = 0;
        AddButton.Text = "Add";
        AddButton.UseVisualStyleBackColor = true;
        AddButton.Click += AddButton_Click;
        // 
        // CancelButton
        // 
        CancelButton.Location = new Point(157, 94);
        CancelButton.Name = "CancelButton";
        CancelButton.Size = new Size(94, 29);
        CancelButton.TabIndex = 1;
        CancelButton.Text = "Cancel";
        CancelButton.UseVisualStyleBackColor = true;
        CancelButton.Click += CancelButton_Click;
        // 
        // AddEmployeeForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(427, 158);
        Controls.Add(CancelButton);
        Controls.Add(AddButton);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "AddEmployeeForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Add new employee simulation";
        ResumeLayout(false);
    }

    #endregion

    private Button AddButton;
    private Button CancelButton;
}