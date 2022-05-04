
namespace RadioButtonSelection
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DallasRadioButton = new System.Windows.Forms.RadioButton();
            this.ChicagoRadioButton = new System.Windows.Forms.RadioButton();
            this.AustinRadioButton = new System.Windows.Forms.RadioButton();
            this.GetButton = new System.Windows.Forms.Button();
            this.totalCostlabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new RadioButtonSelection.Classes.SpecialNumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DallasRadioButton);
            this.groupBox1.Controls.Add(this.ChicagoRadioButton);
            this.groupBox1.Controls.Add(this.AustinRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // DallasRadioButton
            // 
            this.DallasRadioButton.AutoSize = true;
            this.DallasRadioButton.Location = new System.Drawing.Point(6, 65);
            this.DallasRadioButton.Name = "DallasRadioButton";
            this.DallasRadioButton.Size = new System.Drawing.Size(54, 17);
            this.DallasRadioButton.TabIndex = 2;
            this.DallasRadioButton.TabStop = true;
            this.DallasRadioButton.Text = "Dallas";
            this.DallasRadioButton.UseVisualStyleBackColor = true;
            // 
            // ChicagoRadioButton
            // 
            this.ChicagoRadioButton.AutoSize = true;
            this.ChicagoRadioButton.Location = new System.Drawing.Point(6, 42);
            this.ChicagoRadioButton.Name = "ChicagoRadioButton";
            this.ChicagoRadioButton.Size = new System.Drawing.Size(64, 17);
            this.ChicagoRadioButton.TabIndex = 1;
            this.ChicagoRadioButton.TabStop = true;
            this.ChicagoRadioButton.Text = "Chicago";
            this.ChicagoRadioButton.UseVisualStyleBackColor = true;
            // 
            // AustinRadioButton
            // 
            this.AustinRadioButton.AutoSize = true;
            this.AustinRadioButton.Location = new System.Drawing.Point(6, 19);
            this.AustinRadioButton.Name = "AustinRadioButton";
            this.AustinRadioButton.Size = new System.Drawing.Size(54, 17);
            this.AustinRadioButton.TabIndex = 0;
            this.AustinRadioButton.TabStop = true;
            this.AustinRadioButton.Text = "Austin";
            this.AustinRadioButton.UseVisualStyleBackColor = true;
            // 
            // GetButton
            // 
            this.GetButton.Location = new System.Drawing.Point(174, 26);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(75, 23);
            this.GetButton.TabIndex = 1;
            this.GetButton.Text = "Get";
            this.GetButton.UseVisualStyleBackColor = true;
            this.GetButton.Click += new System.EventHandler(this.CostButton_Click);
            // 
            // totalCostlabel
            // 
            this.totalCostlabel.AutoSize = true;
            this.totalCostlabel.Location = new System.Drawing.Point(181, 88);
            this.totalCostlabel.Name = "totalCostlabel";
            this.totalCostlabel.Size = new System.Drawing.Size(58, 13);
            this.totalCostlabel.TabIndex = 3;
            this.totalCostlabel.Text = "Total Cost:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(255, 26);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 140);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.totalCostlabel);
            this.Controls.Add(this.GetButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Sample";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ChicagoRadioButton;
        private System.Windows.Forms.RadioButton AustinRadioButton;
        private System.Windows.Forms.Button GetButton;
        private System.Windows.Forms.RadioButton DallasRadioButton;
        private System.Windows.Forms.Label totalCostlabel;
        private Classes.SpecialNumericUpDown numericUpDown1;
    }
}

