namespace GetImageFromSqlServerFormApp
{
    partial class VarForm
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
            this.InsertImageButton = new System.Windows.Forms.Button();
            this.ReadButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.InsertFromPictureBoxButton = new System.Windows.Forms.Button();
            this.PeekButton = new System.Windows.Forms.Button();
            this.TruncateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // InsertImageButton
            // 
            this.InsertImageButton.Location = new System.Drawing.Point(12, 12);
            this.InsertImageButton.Name = "InsertImageButton";
            this.InsertImageButton.Size = new System.Drawing.Size(102, 29);
            this.InsertImageButton.TabIndex = 0;
            this.InsertImageButton.Text = "Insert";
            this.InsertImageButton.UseVisualStyleBackColor = true;
            this.InsertImageButton.Click += new System.EventHandler(this.InsertImageButton_Click);
            // 
            // ReadButton
            // 
            this.ReadButton.Location = new System.Drawing.Point(12, 56);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(102, 29);
            this.ReadButton.TabIndex = 1;
            this.ReadButton.Text = "Read";
            this.ReadButton.UseVisualStyleBackColor = true;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(331, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(331, 159);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(265, 141);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // InsertFromPictureBoxButton
            // 
            this.InsertFromPictureBoxButton.Location = new System.Drawing.Point(152, 12);
            this.InsertFromPictureBoxButton.Name = "InsertFromPictureBoxButton";
            this.InsertFromPictureBoxButton.Size = new System.Drawing.Size(102, 29);
            this.InsertFromPictureBoxButton.TabIndex = 4;
            this.InsertFromPictureBoxButton.Text = "Insert 1";
            this.InsertFromPictureBoxButton.UseVisualStyleBackColor = true;
            this.InsertFromPictureBoxButton.Click += new System.EventHandler(this.InsertFromPictureBoxButton_Click);
            // 
            // PeekButton
            // 
            this.PeekButton.Location = new System.Drawing.Point(12, 108);
            this.PeekButton.Name = "PeekButton";
            this.PeekButton.Size = new System.Drawing.Size(102, 29);
            this.PeekButton.TabIndex = 5;
            this.PeekButton.Text = "Peek";
            this.PeekButton.UseVisualStyleBackColor = true;
            this.PeekButton.Click += new System.EventHandler(this.PeekButton_Click);
            // 
            // TruncateButton
            // 
            this.TruncateButton.Location = new System.Drawing.Point(12, 159);
            this.TruncateButton.Name = "TruncateButton";
            this.TruncateButton.Size = new System.Drawing.Size(102, 29);
            this.TruncateButton.TabIndex = 6;
            this.TruncateButton.Text = "Truncate";
            this.TruncateButton.UseVisualStyleBackColor = true;
            this.TruncateButton.Click += new System.EventHandler(this.TruncateButton_Click);
            // 
            // VarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TruncateButton);
            this.Controls.Add(this.PeekButton);
            this.Controls.Add(this.InsertFromPictureBoxButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ReadButton);
            this.Controls.Add(this.InsertImageButton);
            this.Name = "VarForm";
            this.Text = "VarForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InsertImageButton;
        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button InsertFromPictureBoxButton;
        private System.Windows.Forms.Button PeekButton;
        private System.Windows.Forms.Button TruncateButton;
    }
}