namespace DDPIExcelAddIn
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
            this.userControlWinForm1 = new DDPIExcelAddIn.UserControlWinForm();
            this.SuspendLayout();
            // 
            // userControlWinForm1
            // 
            this.userControlWinForm1.Location = new System.Drawing.Point(12, 12);
            this.userControlWinForm1.Name = "userControlWinForm1";
            this.userControlWinForm1.Size = new System.Drawing.Size(307, 532);
            this.userControlWinForm1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 635);
            this.Controls.Add(this.userControlWinForm1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlWinForm userControlWinForm1;
    }
}