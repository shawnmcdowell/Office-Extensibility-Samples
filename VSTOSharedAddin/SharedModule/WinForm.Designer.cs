﻿namespace SharedModule
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
            this.userControlWinForm1 = new SharedModule.UserControlWinForm();
            this.SuspendLayout();
            // 
            // userControlWinForm1
            // 
            this.userControlWinForm1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControlWinForm1.AutoScroll = true;
            this.userControlWinForm1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userControlWinForm1.Location = new System.Drawing.Point(1, 1);
            this.userControlWinForm1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userControlWinForm1.MinimumSize = new System.Drawing.Size(317, 0);
            this.userControlWinForm1.Name = "userControlWinForm1";
            this.userControlWinForm1.Size = new System.Drawing.Size(764, 945);
            this.userControlWinForm1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(846, 973);
            this.Controls.Add(this.userControlWinForm1);
            this.Name = "Form1";
            this.Text = "DDPI top-level form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlWinForm userControlWinForm1;
    }
}