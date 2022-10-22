namespace WinFormsApp1
{
    partial class StackoverFlowForm
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.GetStartDateButton = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(0, 0);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 25;
            this.dataGrid.Size = new System.Drawing.Size(648, 298);
            this.dataGrid.TabIndex = 1;
            // 
            // GetStartDateButton
            // 
            this.GetStartDateButton.Location = new System.Drawing.Point(12, 18);
            this.GetStartDateButton.Name = "GetStartDateButton";
            this.GetStartDateButton.Size = new System.Drawing.Size(94, 29);
            this.GetStartDateButton.TabIndex = 2;
            this.GetStartDateButton.Text = "Get";
            this.GetStartDateButton.UseVisualStyleBackColor = true;
            this.GetStartDateButton.Click += new System.EventHandler(this.GetStartDateButton_Click);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(128, 19);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(125, 27);
            this.txtDate.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GetStartDateButton);
            this.panel1.Controls.Add(this.txtDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 239);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 59);
            this.panel1.TabIndex = 4;
            // 
            // StackoverFlowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 298);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGrid);
            this.Name = "StackoverFlowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StackoverFlowForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGrid;
        private Button GetStartDateButton;
        private TextBox txtDate;
        private Panel panel1;
    }
}