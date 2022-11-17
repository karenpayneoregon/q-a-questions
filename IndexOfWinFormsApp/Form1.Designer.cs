namespace IndexOfWinFormsApp
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
            this.cmbAnimals = new System.Windows.Forms.ComboBox();
            this.tbAnimal = new System.Windows.Forms.TextBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.GetCheckedRadioButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbAnimals
            // 
            this.cmbAnimals.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnimals.FormattingEnabled = true;
            this.cmbAnimals.Items.AddRange(new object[] {
            "Cat",
            "Dog",
            "Horse"});
            this.cmbAnimals.Location = new System.Drawing.Point(43, 26);
            this.cmbAnimals.Name = "cmbAnimals";
            this.cmbAnimals.Size = new System.Drawing.Size(151, 28);
            this.cmbAnimals.TabIndex = 0;
            // 
            // tbAnimal
            // 
            this.tbAnimal.Location = new System.Drawing.Point(218, 26);
            this.tbAnimal.Name = "tbAnimal";
            this.tbAnimal.Size = new System.Drawing.Size(125, 27);
            this.tbAnimal.TabIndex = 1;
            this.tbAnimal.Text = "dog";
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(373, 26);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(94, 29);
            this.FindButton.TabIndex = 2;
            this.FindButton.Text = "button1";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(43, 154);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(117, 24);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "Silver";
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(41, 190);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(117, 24);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "Dark blue";
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // GetCheckedRadioButton
            // 
            this.GetCheckedRadioButton.Location = new System.Drawing.Point(203, 174);
            this.GetCheckedRadioButton.Name = "GetCheckedRadioButton";
            this.GetCheckedRadioButton.Size = new System.Drawing.Size(94, 29);
            this.GetCheckedRadioButton.TabIndex = 6;
            this.GetCheckedRadioButton.Text = "button2";
            this.GetCheckedRadioButton.UseVisualStyleBackColor = true;
            this.GetCheckedRadioButton.Click += new System.EventHandler(this.GetCheckedRadioButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 262);
            this.Controls.Add(this.GetCheckedRadioButton);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.tbAnimal);
            this.Controls.Add(this.cmbAnimals);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbAnimals;
        private TextBox tbAnimal;
        private Button FindButton;
        private Button button1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button GetCheckedRadioButton;
    }
}