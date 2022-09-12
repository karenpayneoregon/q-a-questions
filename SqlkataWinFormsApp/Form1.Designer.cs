namespace SqlkataWinFormsApp
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
            this.ContactFirstNameComboBox = new System.Windows.Forms.ComboBox();
            this.ContactLastNameComboBox = new System.Windows.Forms.ComboBox();
            this.BuildButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ContactFirstNameComboBox
            // 
            this.ContactFirstNameComboBox.FormattingEnabled = true;
            this.ContactFirstNameComboBox.Items.AddRange(new object[] {
            "Karen",
            "Jim"});
            this.ContactFirstNameComboBox.Location = new System.Drawing.Point(50, 29);
            this.ContactFirstNameComboBox.Name = "ContactFirstNameComboBox";
            this.ContactFirstNameComboBox.Size = new System.Drawing.Size(121, 23);
            this.ContactFirstNameComboBox.TabIndex = 0;
            // 
            // ContactLastNameComboBox
            // 
            this.ContactLastNameComboBox.FormattingEnabled = true;
            this.ContactLastNameComboBox.Items.AddRange(new object[] {
            "Smith",
            "Jones"});
            this.ContactLastNameComboBox.Location = new System.Drawing.Point(197, 29);
            this.ContactLastNameComboBox.Name = "ContactLastNameComboBox";
            this.ContactLastNameComboBox.Size = new System.Drawing.Size(121, 23);
            this.ContactLastNameComboBox.TabIndex = 1;
            // 
            // BuildButton
            // 
            this.BuildButton.Location = new System.Drawing.Point(50, 81);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(75, 23);
            this.BuildButton.TabIndex = 2;
            this.BuildButton.Text = "Build";
            this.BuildButton.UseVisualStyleBackColor = true;
            this.BuildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 290);
            this.Controls.Add(this.BuildButton);
            this.Controls.Add(this.ContactLastNameComboBox);
            this.Controls.Add(this.ContactFirstNameComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox ContactFirstNameComboBox;
        private ComboBox ContactLastNameComboBox;
        private Button BuildButton;
    }
}