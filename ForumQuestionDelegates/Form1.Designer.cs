namespace ForumQuestionDelegates;

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
        label1 = new Label();
        UpdateValueButton = new Button();
        label2 = new Label();
        IsWeekendButton = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(21, 21);
        label1.Name = "label1";
        label1.Size = new Size(70, 20);
        label1.TabIndex = 0;
        label1.Text = "For event";
        // 
        // UpdateValueButton
        // 
        UpdateValueButton.Location = new Point(21, 53);
        UpdateValueButton.Name = "UpdateValueButton";
        UpdateValueButton.Size = new Size(94, 29);
        UpdateValueButton.TabIndex = 1;
        UpdateValueButton.Text = "Update";
        UpdateValueButton.UseVisualStyleBackColor = true;
        UpdateValueButton.Click += UpdateValueButton_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(21, 99);
        label2.Name = "label2";
        label2.Size = new Size(108, 20);
        label2.TabIndex = 2;
        label2.Text = "SingletonValue";
        // 
        // IsWeekendButton
        // 
        IsWeekendButton.Location = new Point(165, 53);
        IsWeekendButton.Name = "IsWeekendButton";
        IsWeekendButton.Size = new Size(94, 29);
        IsWeekendButton.TabIndex = 3;
        IsWeekendButton.Text = "IsWeekend";
        IsWeekendButton.UseVisualStyleBackColor = true;
        IsWeekendButton.Click += IsWeekendButton_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(308, 160);
        Controls.Add(IsWeekendButton);
        Controls.Add(label2);
        Controls.Add(UpdateValueButton);
        Controls.Add(label1);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Code sample";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Button UpdateValueButton;
    private Label label2;
    private Button IsWeekendButton;
}
