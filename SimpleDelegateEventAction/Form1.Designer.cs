
namespace SimpleDelegateEventAction
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
            this.ProgressErrorButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ActionAsyncButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ActionsButton = new System.Windows.Forms.Button();
            this.QuestionDialogButton = new System.Windows.Forms.Button();
            this.AutoCloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProgressErrorButton
            // 
            this.ProgressErrorButton.Location = new System.Drawing.Point(12, 26);
            this.ProgressErrorButton.Name = "ProgressErrorButton";
            this.ProgressErrorButton.Size = new System.Drawing.Size(211, 23);
            this.ProgressErrorButton.TabIndex = 0;
            this.ProgressErrorButton.Text = "Progress - error";
            this.ProgressErrorButton.UseVisualStyleBackColor = true;
            this.ProgressErrorButton.Click += new System.EventHandler(this.ProgressErrorButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(216, 229);
            this.listBox1.TabIndex = 1;
            // 
            // ActionAsyncButton
            // 
            this.ActionAsyncButton.Location = new System.Drawing.Point(12, 307);
            this.ActionAsyncButton.Name = "ActionAsyncButton";
            this.ActionAsyncButton.Size = new System.Drawing.Size(211, 23);
            this.ActionAsyncButton.TabIndex = 2;
            this.ActionAsyncButton.Text = "Action async";
            this.ActionAsyncButton.UseVisualStyleBackColor = true;
            this.ActionAsyncButton.Click += new System.EventHandler(this.ActionAsyncButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // ActionsButton
            // 
            this.ActionsButton.Location = new System.Drawing.Point(17, 371);
            this.ActionsButton.Name = "ActionsButton";
            this.ActionsButton.Size = new System.Drawing.Size(211, 23);
            this.ActionsButton.TabIndex = 4;
            this.ActionsButton.Text = "Actions";
            this.ActionsButton.UseVisualStyleBackColor = true;
            this.ActionsButton.Click += new System.EventHandler(this.ActionsButton_Click);
            // 
            // QuestionDialogButton
            // 
            this.QuestionDialogButton.Location = new System.Drawing.Point(17, 415);
            this.QuestionDialogButton.Name = "QuestionDialogButton";
            this.QuestionDialogButton.Size = new System.Drawing.Size(211, 23);
            this.QuestionDialogButton.TabIndex = 5;
            this.QuestionDialogButton.Text = "Question actions";
            this.QuestionDialogButton.UseVisualStyleBackColor = true;
            this.QuestionDialogButton.Click += new System.EventHandler(this.QuestionDialogButton_Click);
            // 
            // AutoCloseButton
            // 
            this.AutoCloseButton.Location = new System.Drawing.Point(17, 451);
            this.AutoCloseButton.Name = "AutoCloseButton";
            this.AutoCloseButton.Size = new System.Drawing.Size(211, 23);
            this.AutoCloseButton.TabIndex = 6;
            this.AutoCloseButton.Text = "Auto-close";
            this.AutoCloseButton.UseVisualStyleBackColor = true;
            this.AutoCloseButton.Click += new System.EventHandler(this.AutoCloseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 486);
            this.Controls.Add(this.AutoCloseButton);
            this.Controls.Add(this.QuestionDialogButton);
            this.Controls.Add(this.ActionsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ActionAsyncButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ProgressErrorButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ProgressErrorButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button ActionAsyncButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ActionsButton;
        private System.Windows.Forms.Button QuestionDialogButton;
        private System.Windows.Forms.Button AutoCloseButton;
    }
}

