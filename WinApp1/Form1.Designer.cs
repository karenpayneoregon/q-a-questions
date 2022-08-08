
namespace WinApp1
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
            this.EnglishComboBox1 = new System.Windows.Forms.ComboBox();
            this.TimeZonesCombox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // EnglishComboBox1
            // 
            this.EnglishComboBox1.FormattingEnabled = true;
            this.EnglishComboBox1.Location = new System.Drawing.Point(12, 27);
            this.EnglishComboBox1.Name = "EnglishComboBox1";
            this.EnglishComboBox1.Size = new System.Drawing.Size(188, 21);
            this.EnglishComboBox1.TabIndex = 0;
            // 
            // TimeZonesCombox
            // 
            this.TimeZonesCombox.FormattingEnabled = true;
            this.TimeZonesCombox.Location = new System.Drawing.Point(219, 27);
            this.TimeZonesCombox.Name = "TimeZonesCombox";
            this.TimeZonesCombox.Size = new System.Drawing.Size(188, 21);
            this.TimeZonesCombox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 79);
            this.Controls.Add(this.TimeZonesCombox);
            this.Controls.Add(this.EnglishComboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Sample";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox EnglishComboBox1;
        private System.Windows.Forms.ComboBox TimeZonesCombox;
    }
}

