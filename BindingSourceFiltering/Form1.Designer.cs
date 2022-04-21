
namespace BindingSourceFiltering
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EndsWithTextBox = new System.Windows.Forms.TextBox();
            this.StartsWithTextBox = new System.Windows.Forms.TextBox();
            this.TwoConditionsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(665, 283);
            this.dataGridView1.TabIndex = 0;
            // 
            // EndsWithTextBox
            // 
            this.EndsWithTextBox.Location = new System.Drawing.Point(482, 311);
            this.EndsWithTextBox.Name = "EndsWithTextBox";
            this.EndsWithTextBox.PlaceholderText = "ends with";
            this.EndsWithTextBox.Size = new System.Drawing.Size(186, 23);
            this.EndsWithTextBox.TabIndex = 1;
            // 
            // StartsWithTextBox
            // 
            this.StartsWithTextBox.Location = new System.Drawing.Point(7, 311);
            this.StartsWithTextBox.Name = "StartsWithTextBox";
            this.StartsWithTextBox.PlaceholderText = "starts with";
            this.StartsWithTextBox.Size = new System.Drawing.Size(186, 23);
            this.StartsWithTextBox.TabIndex = 2;
            // 
            // TwoConditionsButton
            // 
            this.TwoConditionsButton.Location = new System.Drawing.Point(232, 310);
            this.TwoConditionsButton.Name = "TwoConditionsButton";
            this.TwoConditionsButton.Size = new System.Drawing.Size(108, 23);
            this.TwoConditionsButton.TabIndex = 3;
            this.TwoConditionsButton.Text = "2 Conditions";
            this.TwoConditionsButton.UseVisualStyleBackColor = true;
            this.TwoConditionsButton.Click += new System.EventHandler(this.TwoConditionsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 362);
            this.Controls.Add(this.TwoConditionsButton);
            this.Controls.Add(this.StartsWithTextBox);
            this.Controls.Add(this.EndsWithTextBox);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BindingSource row filter";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox EndsWithTextBox;
        private System.Windows.Forms.TextBox StartsWithTextBox;
        private System.Windows.Forms.Button TwoConditionsButton;
    }
}

