namespace WinFormsApp1
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
            this.ProcessButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ProcessLocalButton = new System.Windows.Forms.Button();
            this.coreBindingNavigator1 = new WinFormHelpers.CoreBindingNavigator();
            this.txtDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coreBindingNavigator1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 41);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(585, 216);
            this.dataGridView1.TabIndex = 0;
            // 
            // ProcessButton
            // 
            this.ProcessButton.Location = new System.Drawing.Point(14, 267);
            this.ProcessButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProcessButton.Name = "ProcessButton";
            this.ProcessButton.Size = new System.Drawing.Size(167, 31);
            this.ProcessButton.TabIndex = 1;
            this.ProcessButton.Text = "Process - form3";
            this.ProcessButton.UseVisualStyleBackColor = true;
            this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(14, 348);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(585, 216);
            this.dataGridView2.TabIndex = 2;
            // 
            // ProcessLocalButton
            // 
            this.ProcessLocalButton.Location = new System.Drawing.Point(14, 305);
            this.ProcessLocalButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProcessLocalButton.Name = "ProcessLocalButton";
            this.ProcessLocalButton.Size = new System.Drawing.Size(167, 31);
            this.ProcessLocalButton.TabIndex = 3;
            this.ProcessLocalButton.Text = "Process local";
            this.ProcessLocalButton.UseVisualStyleBackColor = true;
            this.ProcessLocalButton.Click += new System.EventHandler(this.ProcessLocalButton_Click);
            // 
            // coreBindingNavigator1
            // 
            this.coreBindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.coreBindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.coreBindingNavigator1.Name = "coreBindingNavigator1";
            this.coreBindingNavigator1.Size = new System.Drawing.Size(613, 27);
            this.coreBindingNavigator1.TabIndex = 4;
            this.coreBindingNavigator1.Text = "coreBindingNavigator1";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(474, 304);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(125, 27);
            this.txtDate.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 605);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.coreBindingNavigator1);
            this.Controls.Add(this.ProcessLocalButton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.ProcessButton);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coreBindingNavigator1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button ProcessButton;
        private DataGridView dataGridView2;
        private Button ProcessLocalButton;
        private WinFormHelpers.CoreBindingNavigator coreBindingNavigator1;
        private TextBox txtDate;
    }
}