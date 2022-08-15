
namespace ChangeImage
{
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AllImagesListBox = new System.Windows.Forms.ListBox();
            this.SelectFromAllImagesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IconListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BitmapListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(234, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // AllImagesListBox
            // 
            this.AllImagesListBox.FormattingEnabled = true;
            this.AllImagesListBox.ItemHeight = 15;
            this.AllImagesListBox.Location = new System.Drawing.Point(20, 51);
            this.AllImagesListBox.Name = "AllImagesListBox";
            this.AllImagesListBox.Size = new System.Drawing.Size(185, 154);
            this.AllImagesListBox.TabIndex = 2;
            // 
            // SelectFromAllImagesButton
            // 
            this.SelectFromAllImagesButton.Location = new System.Drawing.Point(130, 25);
            this.SelectFromAllImagesButton.Name = "SelectFromAllImagesButton";
            this.SelectFromAllImagesButton.Size = new System.Drawing.Size(75, 23);
            this.SelectFromAllImagesButton.TabIndex = 3;
            this.SelectFromAllImagesButton.Text = "Select";
            this.SelectFromAllImagesButton.UseVisualStyleBackColor = true;
            this.SelectFromAllImagesButton.Click += new System.EventHandler(this.SelectFromAllImagesButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Icons and Bitmaps";
            // 
            // IconListBox
            // 
            this.IconListBox.FormattingEnabled = true;
            this.IconListBox.ItemHeight = 15;
            this.IconListBox.Location = new System.Drawing.Point(12, 272);
            this.IconListBox.Name = "IconListBox";
            this.IconListBox.Size = new System.Drawing.Size(185, 94);
            this.IconListBox.Sorted = true;
            this.IconListBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Icons only";
            // 
            // BitmapListBox
            // 
            this.BitmapListBox.FormattingEnabled = true;
            this.BitmapListBox.ItemHeight = 15;
            this.BitmapListBox.Location = new System.Drawing.Point(370, 271);
            this.BitmapListBox.Name = "BitmapListBox";
            this.BitmapListBox.Size = new System.Drawing.Size(185, 94);
            this.BitmapListBox.Sorted = true;
            this.BitmapListBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bitmaps only";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SelectFromAllImagesButton);
            this.groupBox1.Controls.Add(this.AllImagesListBox);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 226);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 387);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BitmapListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IconListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code sample";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox AllImagesListBox;
        private System.Windows.Forms.Button SelectFromAllImagesButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox IconListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox BitmapListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}