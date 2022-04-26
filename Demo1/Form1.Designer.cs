
namespace Demo1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LoadButton1 = new System.Windows.Forms.Button();
            this.LoadButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // LoadButton1
            // 
            this.LoadButton1.Location = new System.Drawing.Point(177, 12);
            this.LoadButton1.Name = "LoadButton1";
            this.LoadButton1.Size = new System.Drawing.Size(75, 23);
            this.LoadButton1.TabIndex = 1;
            this.LoadButton1.Text = "button1";
            this.LoadButton1.UseVisualStyleBackColor = true;
            this.LoadButton1.Click += new System.EventHandler(this.LoadButton1_Click);
            // 
            // LoadButton2
            // 
            this.LoadButton2.Location = new System.Drawing.Point(177, 41);
            this.LoadButton2.Name = "LoadButton2";
            this.LoadButton2.Size = new System.Drawing.Size(75, 23);
            this.LoadButton2.TabIndex = 2;
            this.LoadButton2.Text = "button2";
            this.LoadButton2.UseVisualStyleBackColor = true;
            this.LoadButton2.Click += new System.EventHandler(this.LoadButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 230);
            this.Controls.Add(this.LoadButton2);
            this.Controls.Add(this.LoadButton1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Sample";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button LoadButton1;
        private System.Windows.Forms.Button LoadButton2;
    }
}

