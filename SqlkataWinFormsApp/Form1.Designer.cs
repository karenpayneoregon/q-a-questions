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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ContactFirstNameComboBox
            // 
            this.ContactFirstNameComboBox.FormattingEnabled = true;
            this.ContactFirstNameComboBox.Items.AddRange(new object[] {
            "Karen",
            "Jim"});
            this.ContactFirstNameComboBox.Location = new System.Drawing.Point(57, 39);
            this.ContactFirstNameComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ContactFirstNameComboBox.Name = "ContactFirstNameComboBox";
            this.ContactFirstNameComboBox.Size = new System.Drawing.Size(138, 28);
            this.ContactFirstNameComboBox.TabIndex = 0;
            // 
            // ContactLastNameComboBox
            // 
            this.ContactLastNameComboBox.FormattingEnabled = true;
            this.ContactLastNameComboBox.Items.AddRange(new object[] {
            "Smith",
            "Jones"});
            this.ContactLastNameComboBox.Location = new System.Drawing.Point(225, 39);
            this.ContactLastNameComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ContactLastNameComboBox.Name = "ContactLastNameComboBox";
            this.ContactLastNameComboBox.Size = new System.Drawing.Size(138, 28);
            this.ContactLastNameComboBox.TabIndex = 1;
            // 
            // BuildButton
            // 
            this.BuildButton.Location = new System.Drawing.Point(57, 108);
            this.BuildButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(86, 31);
            this.BuildButton.TabIndex = 2;
            this.BuildButton.Text = "Build";
            this.BuildButton.UseVisualStyleBackColor = true;
            this.BuildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(87, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 387);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BuildButton);
            this.Controls.Add(this.ContactLastNameComboBox);
            this.Controls.Add(this.ContactFirstNameComboBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox ContactFirstNameComboBox;
        private ComboBox ContactLastNameComboBox;
        private Button BuildButton;
        private Button button1;
        private Button button2;
    }
}