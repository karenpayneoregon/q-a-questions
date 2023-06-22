namespace WinFormsApp1;

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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AvailableLabel = new System.Windows.Forms.Label();
            this.RentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(417, 219);
            this.dataGridView1.TabIndex = 0;
            // 
            // AvailableLabel
            // 
            this.AvailableLabel.AutoSize = true;
            this.AvailableLabel.Location = new System.Drawing.Point(12, 266);
            this.AvailableLabel.Name = "AvailableLabel";
            this.AvailableLabel.Size = new System.Drawing.Size(71, 20);
            this.AvailableLabel.TabIndex = 1;
            this.AvailableLabel.Text = "Available";
            // 
            // RentLabel
            // 
            this.RentLabel.AutoSize = true;
            this.RentLabel.Location = new System.Drawing.Point(12, 305);
            this.RentLabel.Name = "RentLabel";
            this.RentLabel.Size = new System.Drawing.Size(39, 20);
            this.RentLabel.TabIndex = 3;
            this.RentLabel.Text = "Rent";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 369);
            this.Controls.Add(this.RentLabel);
            this.Controls.Add(this.AvailableLabel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private DataGridView dataGridView1;
    private Label AvailableLabel;
    private Label RentLabel;
}
