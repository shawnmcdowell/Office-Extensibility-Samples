using System.Timers;

namespace SharedModule
{
    partial class UserControlWinForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlWinForm));
            this.txtThreadAwareness = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSATaskpane = new System.Windows.Forms.Button();
            this.btnSAForm = new System.Windows.Forms.Button();
            this.btnCreatePMAV2Taskpane = new System.Windows.Forms.Button();
            this.btnSetCWMM = new System.Windows.Forms.Button();
            this.txtProcessAwareness = new System.Windows.Forms.TextBox();
            this.txtTaskpaneWindowAwareness = new System.Windows.Forms.TextBox();
            this.txtHostWindowAwareness = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTaskpaneRect = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContainerRect = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtChildWindowMixedMode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtThreadAwareness
            // 
            this.txtThreadAwareness.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtThreadAwareness.Location = new System.Drawing.Point(237, 5);
            this.txtThreadAwareness.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtThreadAwareness.Name = "txtThreadAwareness";
            this.txtThreadAwareness.Size = new System.Drawing.Size(224, 26);
            this.txtThreadAwareness.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(26, 497);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(408, 397);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnSATaskpane
            // 
            this.btnSATaskpane.Location = new System.Drawing.Point(12, 269);
            this.btnSATaskpane.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSATaskpane.Name = "btnSATaskpane";
            this.btnSATaskpane.Size = new System.Drawing.Size(438, 35);
            this.btnSATaskpane.TabIndex = 4;
            this.btnSATaskpane.Text = "Create System Aware Taskpane";
            this.btnSATaskpane.UseVisualStyleBackColor = true;
            this.btnSATaskpane.Click += new System.EventHandler(this.btnSATaskpane_Click);
            // 
            // btnSAForm
            // 
            this.btnSAForm.Location = new System.Drawing.Point(12, 359);
            this.btnSAForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSAForm.Name = "btnSAForm";
            this.btnSAForm.Size = new System.Drawing.Size(438, 35);
            this.btnSAForm.TabIndex = 5;
            this.btnSAForm.Text = "Open Top-level System Aware Form";
            this.btnSAForm.UseVisualStyleBackColor = true;
            this.btnSAForm.Click += new System.EventHandler(this.btnSAForm_Click);
            // 
            // btnCreatePMAV2Taskpane
            // 
            this.btnCreatePMAV2Taskpane.Location = new System.Drawing.Point(12, 314);
            this.btnCreatePMAV2Taskpane.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreatePMAV2Taskpane.Name = "btnCreatePMAV2Taskpane";
            this.btnCreatePMAV2Taskpane.Size = new System.Drawing.Size(438, 35);
            this.btnCreatePMAV2Taskpane.TabIndex = 6;
            this.btnCreatePMAV2Taskpane.Text = "Create Per Mon V2 Taskpane";
            this.btnCreatePMAV2Taskpane.UseVisualStyleBackColor = true;
            this.btnCreatePMAV2Taskpane.Click += new System.EventHandler(this.btnCreatePMAV2Taskpane_Click);
            // 
            // btnSetCWMM
            // 
            this.btnSetCWMM.Location = new System.Drawing.Point(12, 404);
            this.btnSetCWMM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSetCWMM.Name = "btnSetCWMM";
            this.btnSetCWMM.Size = new System.Drawing.Size(438, 35);
            this.btnSetCWMM.TabIndex = 8;
            this.btnSetCWMM.Text = "Set Child Window Mixed Mode to Mixed";
            this.btnSetCWMM.UseVisualStyleBackColor = true;
            this.btnSetCWMM.Click += new System.EventHandler(this.btnSetCWMM_Click);
            // 
            // txtProcessAwareness
            // 
            this.txtProcessAwareness.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProcessAwareness.Location = new System.Drawing.Point(237, 41);
            this.txtProcessAwareness.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProcessAwareness.Name = "txtProcessAwareness";
            this.txtProcessAwareness.Size = new System.Drawing.Size(224, 26);
            this.txtProcessAwareness.TabIndex = 10;
            // 
            // txtTaskpaneWindowAwareness
            // 
            this.txtTaskpaneWindowAwareness.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTaskpaneWindowAwareness.Location = new System.Drawing.Point(237, 77);
            this.txtTaskpaneWindowAwareness.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTaskpaneWindowAwareness.Name = "txtTaskpaneWindowAwareness";
            this.txtTaskpaneWindowAwareness.Size = new System.Drawing.Size(224, 26);
            this.txtTaskpaneWindowAwareness.TabIndex = 11;
            // 
            // txtHostWindowAwareness
            // 
            this.txtHostWindowAwareness.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHostWindowAwareness.Location = new System.Drawing.Point(237, 113);
            this.txtHostWindowAwareness.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHostWindowAwareness.Name = "txtHostWindowAwareness";
            this.txtHostWindowAwareness.Size = new System.Drawing.Size(224, 26);
            this.txtHostWindowAwareness.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Thread Awareness";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Process Awareness";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Taskpane Window Awareness";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Host Window Awareness";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 449);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(438, 35);
            this.button1.TabIndex = 19;
            this.button1.Text = "Set Child Window Mixed Mode to Normal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.setCWMMNormal_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Taskpane w,h (hwnd)";
            // 
            // txtTaskpaneRect
            // 
            this.txtTaskpaneRect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTaskpaneRect.Location = new System.Drawing.Point(237, 181);
            this.txtTaskpaneRect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTaskpaneRect.Name = "txtTaskpaneRect";
            this.txtTaskpaneRect.Size = new System.Drawing.Size(224, 26);
            this.txtTaskpaneRect.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Container w,h (hwnd)";
            // 
            // txtContainerRect
            // 
            this.txtContainerRect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContainerRect.Location = new System.Drawing.Point(237, 217);
            this.txtContainerRect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtContainerRect.Name = "txtContainerRect";
            this.txtContainerRect.Size = new System.Drawing.Size(224, 26);
            this.txtContainerRect.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Child Window Mixed Mode";
            // 
            // txtChildWindowMixedMode
            // 
            this.txtChildWindowMixedMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChildWindowMixedMode.Location = new System.Drawing.Point(237, 147);
            this.txtChildWindowMixedMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChildWindowMixedMode.Name = "txtChildWindowMixedMode";
            this.txtChildWindowMixedMode.Size = new System.Drawing.Size(224, 26);
            this.txtChildWindowMixedMode.TabIndex = 24;
            // 
            // UserControlWinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtChildWindowMixedMode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtContainerRect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTaskpaneRect);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHostWindowAwareness);
            this.Controls.Add(this.txtTaskpaneWindowAwareness);
            this.Controls.Add(this.txtProcessAwareness);
            this.Controls.Add(this.btnSetCWMM);
            this.Controls.Add(this.btnCreatePMAV2Taskpane);
            this.Controls.Add(this.btnSAForm);
            this.Controls.Add(this.btnSATaskpane);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtThreadAwareness);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(475, 0);
            this.Name = "UserControlWinForm";
            this.Size = new System.Drawing.Size(475, 898);
            this.Load += new System.EventHandler(this.UserControlWinForm_Load);
            this.Resize += new System.EventHandler(this.UserControlWinForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtThreadAwareness;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSATaskpane;
        private System.Windows.Forms.Button btnSAForm;
        private System.Windows.Forms.Button btnCreatePMAV2Taskpane;
        private System.Windows.Forms.Button btnSetCWMM;
        private System.Windows.Forms.TextBox txtProcessAwareness;
        private System.Windows.Forms.TextBox txtTaskpaneWindowAwareness;
        private System.Windows.Forms.TextBox txtHostWindowAwareness;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTaskpaneRect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtContainerRect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtChildWindowMixedMode;
    }
}
