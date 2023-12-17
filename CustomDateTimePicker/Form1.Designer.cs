namespace CustomDateTimePicker;

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
        button1 = new Button();
        nullableDateTimePicker1 = new Controls.NullableDateTimePicker();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new Point(268, 22);
        button1.Name = "button1";
        button1.Size = new Size(179, 29);
        button1.TabIndex = 1;
        button1.Text = "Null out date";
        button1.UseVisualStyleBackColor = true;
        button1.Click += SetToNullButton_Click;
        // 
        // nullableDateTimePicker1
        // 
        nullableDateTimePicker1.DateTime = new DateTime(0L);
        nullableDateTimePicker1.Location = new Point(12, 21);
        nullableDateTimePicker1.Name = "nullableDateTimePicker1";
        nullableDateTimePicker1.Size = new Size(250, 27);
        nullableDateTimePicker1.TabIndex = 2;
        nullableDateTimePicker1.Value = new DateTime(2023, 7, 22, 3, 39, 1, 82);
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(495, 344);
        Controls.Add(nullableDateTimePicker1);
        Controls.Add(button1);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form1";
        ResumeLayout(false);
    }

    #endregion
    private Button button1;
    private Controls.NullableDateTimePicker nullableDateTimePicker1;
}
