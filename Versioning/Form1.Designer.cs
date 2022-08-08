
namespace Versioning
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
            this.GetVersionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GetVersionButton
            // 
            this.GetVersionButton.Location = new System.Drawing.Point(129, 49);
            this.GetVersionButton.Name = "GetVersionButton";
            this.GetVersionButton.Size = new System.Drawing.Size(75, 23);
            this.GetVersionButton.TabIndex = 0;
            this.GetVersionButton.Text = "Execute";
            this.GetVersionButton.UseVisualStyleBackColor = true;
            this.GetVersionButton.Click += new System.EventHandler(this.GetZerosButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 120);
            this.Controls.Add(this.GetVersionButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code sample";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetVersionButton;
    }
}

