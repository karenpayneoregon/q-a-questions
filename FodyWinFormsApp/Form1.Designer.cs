namespace FodyWinFormsApp;

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
        FodyChangeCurrentBButton = new Button();
        FodyDataGridView = new DataGridView();
        ConventionalDataGridView = new DataGridView();
        ConventionalChangeCurrentBButton = new Button();
        ((System.ComponentModel.ISupportInitialize)FodyDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)ConventionalDataGridView).BeginInit();
        SuspendLayout();
        // 
        // FodyChangeCurrentBButton
        // 
        FodyChangeCurrentBButton.Location = new Point(12, 355);
        FodyChangeCurrentBButton.Name = "FodyChangeCurrentBButton";
        FodyChangeCurrentBButton.Size = new Size(155, 29);
        FodyChangeCurrentBButton.TabIndex = 1;
        FodyChangeCurrentBButton.Text = "Update current";
        FodyChangeCurrentBButton.UseVisualStyleBackColor = true;
        FodyChangeCurrentBButton.Click += FodyChangeCurrentBButton_Click;
        // 
        // FodyDataGridView
        // 
        FodyDataGridView.AllowUserToAddRows = false;
        FodyDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        FodyDataGridView.Location = new Point(12, 12);
        FodyDataGridView.Name = "FodyDataGridView";
        FodyDataGridView.RowHeadersWidth = 51;
        FodyDataGridView.Size = new Size(460, 337);
        FodyDataGridView.TabIndex = 2;
        // 
        // ConventionalDataGridView
        // 
        ConventionalDataGridView.AllowUserToAddRows = false;
        ConventionalDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        ConventionalDataGridView.Location = new Point(562, 12);
        ConventionalDataGridView.Name = "ConventionalDataGridView";
        ConventionalDataGridView.RowHeadersWidth = 51;
        ConventionalDataGridView.Size = new Size(460, 337);
        ConventionalDataGridView.TabIndex = 3;
        // 
        // ConventionalChangeCurrentBButton
        // 
        ConventionalChangeCurrentBButton.Location = new Point(562, 355);
        ConventionalChangeCurrentBButton.Name = "ConventionalChangeCurrentBButton";
        ConventionalChangeCurrentBButton.Size = new Size(155, 29);
        ConventionalChangeCurrentBButton.TabIndex = 4;
        ConventionalChangeCurrentBButton.Text = "Update current";
        ConventionalChangeCurrentBButton.UseVisualStyleBackColor = true;
        ConventionalChangeCurrentBButton.Click += ConventionalChangeCurrentBButton_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1034, 450);
        Controls.Add(ConventionalChangeCurrentBButton);
        Controls.Add(ConventionalDataGridView);
        Controls.Add(FodyDataGridView);
        Controls.Add(FodyChangeCurrentBButton);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)FodyDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)ConventionalDataGridView).EndInit();
        ResumeLayout(false);
    }

    #endregion
    private Button FodyChangeCurrentBButton;
    private DataGridView FodyDataGridView;
    private DataGridView ConventionalDataGridView;
    private Button ConventionalChangeCurrentBButton;
}
