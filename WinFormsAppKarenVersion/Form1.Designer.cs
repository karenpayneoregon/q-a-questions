using WinFormsAppKarenVersion.Controls;

namespace WinFormsAppKarenVersion
{
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
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentButton = new System.Windows.Forms.Button();
            this.SomeTextBox = new CustomTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "TextBox";
            // 
            // CurrentButton
            // 
            this.CurrentButton.Location = new System.Drawing.Point(35, 73);
            this.CurrentButton.Name = "CurrentButton";
            this.CurrentButton.Size = new System.Drawing.Size(153, 23);
            this.CurrentButton.TabIndex = 4;
            this.CurrentButton.Text = "Current";
            this.CurrentButton.UseVisualStyleBackColor = true;
            this.CurrentButton.Click += new System.EventHandler(this.CurrentButton_Click);
            // 
            // SomeTextBox
            // 
            this.SomeTextBox.Location = new System.Drawing.Point(88, 6);
            this.SomeTextBox.Name = "SomeTextBox";
            this.SomeTextBox.OverRideValue = 30D;
            this.SomeTextBox.Size = new System.Drawing.Size(100, 23);
            this.SomeTextBox.TabIndex = 5;
            this.SomeTextBox.Value = 40D;
            this.SomeTextBox.WatchValue = 40D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 137);
            this.Controls.Add(this.SomeTextBox);
            this.Controls.Add(this.CurrentButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
  private Label label1;
        private Button CurrentButton;
        private CustomTextBox SomeTextBox;
    }
}