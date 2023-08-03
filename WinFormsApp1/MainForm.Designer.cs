namespace WinFormsApp1;

partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditCurrentButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RemoveCurrentButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(446, 286);
            this.dataGridView1.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 11);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(94, 29);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditCurrentButton
            // 
            this.EditCurrentButton.Location = new System.Drawing.Point(340, 11);
            this.EditCurrentButton.Name = "EditCurrentButton";
            this.EditCurrentButton.Size = new System.Drawing.Size(94, 29);
            this.EditCurrentButton.TabIndex = 2;
            this.EditCurrentButton.Text = "Edit";
            this.EditCurrentButton.UseVisualStyleBackColor = true;
            this.EditCurrentButton.Click += new System.EventHandler(this.EditCurrentButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RemoveCurrentButton);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.EditCurrentButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 286);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 52);
            this.panel1.TabIndex = 3;
            // 
            // RemoveCurrentButton
            // 
            this.RemoveCurrentButton.Location = new System.Drawing.Point(164, 11);
            this.RemoveCurrentButton.Name = "RemoveCurrentButton";
            this.RemoveCurrentButton.Size = new System.Drawing.Size(94, 29);
            this.RemoveCurrentButton.TabIndex = 3;
            this.RemoveCurrentButton.Text = "Remove";
            this.RemoveCurrentButton.UseVisualStyleBackColor = true;
            this.RemoveCurrentButton.Click += new System.EventHandler(this.RemoveCurrentButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 338);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "No Refresh required";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private DataGridView dataGridView1;
    private Button AddButton;
    private Button EditCurrentButton;
    private Panel panel1;
    private Button RemoveCurrentButton;
}