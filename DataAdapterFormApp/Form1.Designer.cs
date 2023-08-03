
namespace DataAdapterFormApp
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SaveChangeButton = new System.Windows.Forms.Button();
            this.GetChangesButton = new System.Windows.Forms.Button();
            this.ExportExcelButton = new System.Windows.Forms.Button();
            this.ExportToTxtButton = new System.Windows.Forms.Button();
            this.DumpButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(687, 218);
            this.dataGridView1.TabIndex = 0;
            // 
            // SaveChangeButton
            // 
            this.SaveChangeButton.Image = global::DataAdapterFormApp.Properties.Resources.SaveAll_16x;
            this.SaveChangeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveChangeButton.Location = new System.Drawing.Point(16, 241);
            this.SaveChangeButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveChangeButton.Name = "SaveChangeButton";
            this.SaveChangeButton.Size = new System.Drawing.Size(132, 28);
            this.SaveChangeButton.TabIndex = 1;
            this.SaveChangeButton.Text = "Save";
            this.SaveChangeButton.UseVisualStyleBackColor = true;
            this.SaveChangeButton.Click += new System.EventHandler(this.SaveChangeButton_Click);
            // 
            // GetChangesButton
            // 
            this.GetChangesButton.Location = new System.Drawing.Point(156, 241);
            this.GetChangesButton.Margin = new System.Windows.Forms.Padding(4);
            this.GetChangesButton.Name = "GetChangesButton";
            this.GetChangesButton.Size = new System.Drawing.Size(100, 28);
            this.GetChangesButton.TabIndex = 2;
            this.GetChangesButton.Text = "Changes";
            this.GetChangesButton.UseVisualStyleBackColor = true;
            this.GetChangesButton.Click += new System.EventHandler(this.GetChangesButton_Click);
            // 
            // ExportExcelButton
            // 
            this.ExportExcelButton.Location = new System.Drawing.Point(573, 241);
            this.ExportExcelButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExportExcelButton.Name = "ExportExcelButton";
            this.ExportExcelButton.Size = new System.Drawing.Size(100, 28);
            this.ExportExcelButton.TabIndex = 3;
            this.ExportExcelButton.Text = "To Excel";
            this.ExportExcelButton.UseVisualStyleBackColor = true;
            this.ExportExcelButton.Click += new System.EventHandler(this.ExportExcelButton_Click);
            // 
            // ExportToTxtButton
            // 
            this.ExportToTxtButton.Location = new System.Drawing.Point(277, 242);
            this.ExportToTxtButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExportToTxtButton.Name = "ExportToTxtButton";
            this.ExportToTxtButton.Size = new System.Drawing.Size(100, 28);
            this.ExportToTxtButton.TabIndex = 4;
            this.ExportToTxtButton.Text = "To Txt";
            this.ExportToTxtButton.UseVisualStyleBackColor = true;
            this.ExportToTxtButton.Click += new System.EventHandler(this.ExportToTxtButton_Click);
            // 
            // DumpButton
            // 
            this.DumpButton.Location = new System.Drawing.Point(465, 242);
            this.DumpButton.Margin = new System.Windows.Forms.Padding(4);
            this.DumpButton.Name = "DumpButton";
            this.DumpButton.Size = new System.Drawing.Size(100, 28);
            this.DumpButton.TabIndex = 5;
            this.DumpButton.Text = "Dump";
            this.DumpButton.UseVisualStyleBackColor = true;
            this.DumpButton.Click += new System.EventHandler(this.DumpButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 283);
            this.Controls.Add(this.DumpButton);
            this.Controls.Add(this.ExportToTxtButton);
            this.Controls.Add(this.ExportExcelButton);
            this.Controls.Add(this.GetChangesButton);
            this.Controls.Add(this.SaveChangeButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Sample";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SaveChangeButton;
        private System.Windows.Forms.Button GetChangesButton;
        private System.Windows.Forms.Button ExportExcelButton;
        private System.Windows.Forms.Button ExportToTxtButton;
        private System.Windows.Forms.Button DumpButton;
    }
}

