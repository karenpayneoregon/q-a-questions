
//INSTANT C# NOTE: Formerly VB project-level imports:

using System.Windows.Forms;

namespace CheckBoxColumnCount
{
	public partial class frmMainForm : System.Windows.Forms.Form
	{
	   //Form overrides dispose to clean up the component list.
	   [System.Diagnostics.DebuggerNonUserCode()]
	   protected override void Dispose(bool disposing)
	   {
		  try
		  {
			 if (disposing && components != null)
			 {
				components.Dispose();
			 }
		  }
		  finally
		  {
			 base.Dispose(disposing);
		  }
	   }

	   //Required by the Windows Form Designer
	   private System.ComponentModel.IContainer components;

	   //NOTE: The following procedure is required by the Windows Form Designer
	   //It can be modified using the Windows Form Designer.  
	   //Do not modify it using the code editor.
	   [System.Diagnostics.DebuggerStepThrough()]
	   private void InitializeComponent()
	   {
            this.components = new System.ComponentModel.Container();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ProcessButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip1.Location = new System.Drawing.Point(0, 425);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.StatusStrip1.Size = new System.Drawing.Size(441, 22);
            this.StatusStrip1.TabIndex = 0;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(869, 360);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.Sorted += new System.EventHandler(this.DataGridView1_Sorted);
            // 
            // ProcessButton
            // 
            this.ProcessButton.Location = new System.Drawing.Point(12, 382);
            this.ProcessButton.Name = "ProcessButton";
            this.ProcessButton.Size = new System.Drawing.Size(114, 23);
            this.ProcessButton.TabIndex = 3;
            this.ProcessButton.Text = "Process";
            this.ProcessButton.UseVisualStyleBackColor = true;
            this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "0";
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 447);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProcessButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.StatusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Process CheckBox Column in DataGridView";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
	   internal System.Windows.Forms.StatusStrip StatusStrip1;
	   internal System.Windows.Forms.DataGridView dataGridView1;
	   internal System.Windows.Forms.ToolTip ToolTip1;
        private Button ProcessButton;
        private Label label1;
    }

}
