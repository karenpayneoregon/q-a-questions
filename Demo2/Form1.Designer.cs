
namespace Demo2
{
    partial class Form1
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
            this.TimeTextBox = new System.Windows.Forms.TextBox();
            this.GetTimeButton = new System.Windows.Forms.Button();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.Location = new System.Drawing.Point(26, 12);
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.TimeTextBox.TabIndex = 0;
            this.TimeTextBox.Text = "09:33";
            // 
            // GetTimeButton
            // 
            this.GetTimeButton.Location = new System.Drawing.Point(152, 12);
            this.GetTimeButton.Name = "GetTimeButton";
            this.GetTimeButton.Size = new System.Drawing.Size(75, 23);
            this.GetTimeButton.TabIndex = 1;
            this.GetTimeButton.Text = "button1";
            this.GetTimeButton.UseVisualStyleBackColor = true;
            this.GetTimeButton.Click += new System.EventHandler(this.GetTimeButton_Click);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(259, 15);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(35, 13);
            this.TimeLabel.TabIndex = 2;
            this.TimeLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 230);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.GetTimeButton);
            this.Controls.Add(this.TimeTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TimeTextBox;
        private System.Windows.Forms.Button GetTimeButton;
        private System.Windows.Forms.Label TimeLabel;
    }
}

