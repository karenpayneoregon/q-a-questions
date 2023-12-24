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
        groupBox1 = new GroupBox();
        FodyComboBox = new ComboBox();
        groupBox2 = new GroupBox();
        ConventionalComboBox = new ComboBox();
        ((System.ComponentModel.ISupportInitialize)FodyDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)ConventionalDataGridView).BeginInit();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // FodyChangeCurrentBButton
        // 
        FodyChangeCurrentBButton.Image = Properties.Resources.Save;
        FodyChangeCurrentBButton.ImageAlign = ContentAlignment.MiddleLeft;
        FodyChangeCurrentBButton.Location = new Point(27, 391);
        FodyChangeCurrentBButton.Name = "FodyChangeCurrentBButton";
        FodyChangeCurrentBButton.Padding = new Padding(5, 0, 0, 0);
        FodyChangeCurrentBButton.Size = new Size(460, 29);
        FodyChangeCurrentBButton.TabIndex = 1;
        FodyChangeCurrentBButton.Text = "Update current";
        FodyChangeCurrentBButton.UseVisualStyleBackColor = true;
        FodyChangeCurrentBButton.Click += FodyChangeCurrentBButton_Click;
        // 
        // FodyDataGridView
        // 
        FodyDataGridView.AllowUserToAddRows = false;
        FodyDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        FodyDataGridView.Location = new Point(27, 34);
        FodyDataGridView.Name = "FodyDataGridView";
        FodyDataGridView.RowHeadersWidth = 51;
        FodyDataGridView.Size = new Size(460, 337);
        FodyDataGridView.TabIndex = 2;
        // 
        // ConventionalDataGridView
        // 
        ConventionalDataGridView.AllowUserToAddRows = false;
        ConventionalDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        ConventionalDataGridView.Location = new Point(32, 34);
        ConventionalDataGridView.Name = "ConventionalDataGridView";
        ConventionalDataGridView.RowHeadersWidth = 51;
        ConventionalDataGridView.Size = new Size(460, 337);
        ConventionalDataGridView.TabIndex = 3;
        // 
        // ConventionalChangeCurrentBButton
        // 
        ConventionalChangeCurrentBButton.Image = Properties.Resources.Save;
        ConventionalChangeCurrentBButton.ImageAlign = ContentAlignment.MiddleLeft;
        ConventionalChangeCurrentBButton.Location = new Point(32, 391);
        ConventionalChangeCurrentBButton.Name = "ConventionalChangeCurrentBButton";
        ConventionalChangeCurrentBButton.Padding = new Padding(5, 0, 0, 0);
        ConventionalChangeCurrentBButton.Size = new Size(460, 29);
        ConventionalChangeCurrentBButton.TabIndex = 4;
        ConventionalChangeCurrentBButton.Text = "Update current";
        ConventionalChangeCurrentBButton.UseVisualStyleBackColor = true;
        ConventionalChangeCurrentBButton.Click += ConventionalChangeCurrentBButton_Click;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(FodyComboBox);
        groupBox1.Controls.Add(FodyDataGridView);
        groupBox1.Controls.Add(FodyChangeCurrentBButton);
        groupBox1.Location = new Point(11, 6);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(511, 543);
        groupBox1.TabIndex = 5;
        groupBox1.TabStop = false;
        groupBox1.Text = "Fody";
        // 
        // FodyComboBox
        // 
        FodyComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        FodyComboBox.FormattingEnabled = true;
        FodyComboBox.Location = new Point(27, 445);
        FodyComboBox.Name = "FodyComboBox";
        FodyComboBox.Size = new Size(230, 28);
        FodyComboBox.TabIndex = 6;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(ConventionalComboBox);
        groupBox2.Controls.Add(ConventionalDataGridView);
        groupBox2.Controls.Add(ConventionalChangeCurrentBButton);
        groupBox2.Location = new Point(566, 6);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(518, 543);
        groupBox2.TabIndex = 6;
        groupBox2.TabStop = false;
        groupBox2.Text = "Conventional";
        // 
        // ConventionalComboBox
        // 
        ConventionalComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        ConventionalComboBox.FormattingEnabled = true;
        ConventionalComboBox.Location = new Point(32, 445);
        ConventionalComboBox.Name = "ConventionalComboBox";
        ConventionalComboBox.Size = new Size(230, 28);
        ConventionalComboBox.TabIndex = 5;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1096, 567);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)FodyDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)ConventionalDataGridView).EndInit();
        groupBox1.ResumeLayout(false);
        groupBox2.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
    private Button FodyChangeCurrentBButton;
    private DataGridView FodyDataGridView;
    private DataGridView ConventionalDataGridView;
    private Button ConventionalChangeCurrentBButton;
    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private ComboBox ConventionalComboBox;
    private ComboBox FodyComboBox;
}
