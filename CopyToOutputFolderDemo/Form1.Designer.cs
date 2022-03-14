
namespace CopyToOutputFolderDemo
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
            this.ValidateFolderExistsButton = new System.Windows.Forms.Button();
            this.ValidateFilesExistsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ValidateFolderExistsButton
            // 
            this.ValidateFolderExistsButton.Location = new System.Drawing.Point(25, 12);
            this.ValidateFolderExistsButton.Name = "ValidateFolderExistsButton";
            this.ValidateFolderExistsButton.Size = new System.Drawing.Size(173, 23);
            this.ValidateFolderExistsButton.TabIndex = 0;
            this.ValidateFolderExistsButton.Text = "Validate folder exists";
            this.ValidateFolderExistsButton.UseVisualStyleBackColor = true;
            this.ValidateFolderExistsButton.Click += new System.EventHandler(this.ValidateFolderExistsButton_Click);
            // 
            // ValidateFilesExistsButton
            // 
            this.ValidateFilesExistsButton.Location = new System.Drawing.Point(25, 41);
            this.ValidateFilesExistsButton.Name = "ValidateFilesExistsButton";
            this.ValidateFilesExistsButton.Size = new System.Drawing.Size(173, 23);
            this.ValidateFilesExistsButton.TabIndex = 1;
            this.ValidateFilesExistsButton.Text = "Validate files exists";
            this.ValidateFilesExistsButton.UseVisualStyleBackColor = true;
            this.ValidateFilesExistsButton.Click += new System.EventHandler(this.ValidateFilesExistsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 230);
            this.Controls.Add(this.ValidateFilesExistsButton);
            this.Controls.Add(this.ValidateFolderExistsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Sample";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ValidateFolderExistsButton;
        private System.Windows.Forms.Button ValidateFilesExistsButton;
    }
}

