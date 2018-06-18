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
            this.txtThreadAwareness = new System.Windows.Forms.TextBox();
            this.txtProcessAwareness = new System.Windows.Forms.TextBox();
            this.txtTaskpaneWindowAwareness = new System.Windows.Forms.TextBox();
            this.txtHostWindowAwareness = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTaskpaneRect = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContainerRect = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtChildWindowMixedMode = new System.Windows.Forms.TextBox();
            this.Properties = new System.Windows.Forms.MenuStrip();
            this.setHeight = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSetHeight = new System.Windows.Forms.ToolStripTextBox();
            this.setWidth = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSetWidth = new System.Windows.Forms.ToolStripTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGetWidthHeight = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboDpiContext = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboNewDockLocation = new System.Windows.Forms.ComboBox();
            this.btnTopLevelForm = new System.Windows.Forms.Button();
            this.btnAddTaskpane = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.wpfUserControl11 = new SharedModule.WPFUserControl1();
            this.Properties.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtThreadAwareness
            // 
            this.txtThreadAwareness.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtThreadAwareness.Location = new System.Drawing.Point(173, 112);
            this.txtThreadAwareness.Name = "txtThreadAwareness";
            this.txtThreadAwareness.Size = new System.Drawing.Size(251, 20);
            this.txtThreadAwareness.TabIndex = 1;
            // 
            // txtProcessAwareness
            // 
            this.txtProcessAwareness.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProcessAwareness.Location = new System.Drawing.Point(173, 136);
            this.txtProcessAwareness.Name = "txtProcessAwareness";
            this.txtProcessAwareness.Size = new System.Drawing.Size(251, 20);
            this.txtProcessAwareness.TabIndex = 10;
            // 
            // txtTaskpaneWindowAwareness
            // 
            this.txtTaskpaneWindowAwareness.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTaskpaneWindowAwareness.Location = new System.Drawing.Point(173, 159);
            this.txtTaskpaneWindowAwareness.Name = "txtTaskpaneWindowAwareness";
            this.txtTaskpaneWindowAwareness.Size = new System.Drawing.Size(251, 20);
            this.txtTaskpaneWindowAwareness.TabIndex = 11;
            // 
            // txtHostWindowAwareness
            // 
            this.txtHostWindowAwareness.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHostWindowAwareness.Location = new System.Drawing.Point(173, 182);
            this.txtHostWindowAwareness.Name = "txtHostWindowAwareness";
            this.txtHostWindowAwareness.Size = new System.Drawing.Size(251, 20);
            this.txtHostWindowAwareness.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Thread Awareness";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Process Awareness";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Taskpane Window Awareness";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "App Window Awareness";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 250);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Taskpane w,h";
            // 
            // txtTaskpaneRect
            // 
            this.txtTaskpaneRect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTaskpaneRect.Location = new System.Drawing.Point(173, 250);
            this.txtTaskpaneRect.Name = "txtTaskpaneRect";
            this.txtTaskpaneRect.Size = new System.Drawing.Size(251, 20);
            this.txtTaskpaneRect.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 227);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "MsoCommandBar w,h";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtContainerRect
            // 
            this.txtContainerRect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContainerRect.Location = new System.Drawing.Point(173, 227);
            this.txtContainerRect.Name = "txtContainerRect";
            this.txtContainerRect.Size = new System.Drawing.Size(251, 20);
            this.txtContainerRect.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 205);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Taskpane Dpi Hosting Mode";
            // 
            // txtChildWindowMixedMode
            // 
            this.txtChildWindowMixedMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChildWindowMixedMode.Location = new System.Drawing.Point(173, 205);
            this.txtChildWindowMixedMode.Name = "txtChildWindowMixedMode";
            this.txtChildWindowMixedMode.Size = new System.Drawing.Size(251, 20);
            this.txtChildWindowMixedMode.TabIndex = 24;
            // 
            // Properties
            // 
            this.Properties.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Properties.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setHeight,
            this.txtSetHeight,
            this.setWidth,
            this.txtSetWidth});
            this.Properties.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.Properties.Location = new System.Drawing.Point(0, 0);
            this.Properties.Name = "Properties";
            this.Properties.Size = new System.Drawing.Size(439, 27);
            this.Properties.TabIndex = 27;
            this.Properties.Text = "&Properties";
            this.Properties.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // setHeight
            // 
            this.setHeight.Name = "setHeight";
            this.setHeight.Size = new System.Drawing.Size(74, 23);
            this.setHeight.Text = "Set &Height";
            // 
            // txtSetHeight
            // 
            this.txtSetHeight.Name = "txtSetHeight";
            this.txtSetHeight.Size = new System.Drawing.Size(68, 23);
            this.txtSetHeight.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSetHeight_KeyUp);
            this.txtSetHeight.Click += new System.EventHandler(this.txtSetHeight_Click);
            // 
            // setWidth
            // 
            this.setWidth.Name = "setWidth";
            this.setWidth.Size = new System.Drawing.Size(70, 23);
            this.setWidth.Text = "Set &Width";
            // 
            // txtSetWidth
            // 
            this.txtSetWidth.Name = "txtSetWidth";
            this.txtSetWidth.Size = new System.Drawing.Size(68, 23);
            this.txtSetWidth.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSetWidth_KeyUp);
            this.txtSetWidth.Click += new System.EventHandler(this.txtSetWidth_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 272);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = ".Width, .Height";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtGetWidthHeight
            // 
            this.txtGetWidthHeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGetWidthHeight.Location = new System.Drawing.Point(173, 272);
            this.txtGetWidthHeight.Name = "txtGetWidthHeight";
            this.txtGetWidthHeight.Size = new System.Drawing.Size(251, 20);
            this.txtGetWidthHeight.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(170, 70);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Context";
            // 
            // cboDpiContext
            // 
            this.cboDpiContext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDpiContext.FormattingEnabled = true;
            this.cboDpiContext.Location = new System.Drawing.Point(246, 68);
            this.cboDpiContext.Margin = new System.Windows.Forms.Padding(1);
            this.cboDpiContext.Name = "cboDpiContext";
            this.cboDpiContext.Size = new System.Drawing.Size(177, 21);
            this.cboDpiContext.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(170, 40);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Dock";
            // 
            // cboNewDockLocation
            // 
            this.cboNewDockLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboNewDockLocation.FormattingEnabled = true;
            this.cboNewDockLocation.Location = new System.Drawing.Point(246, 40);
            this.cboNewDockLocation.Margin = new System.Windows.Forms.Padding(1);
            this.cboNewDockLocation.Name = "cboNewDockLocation";
            this.cboNewDockLocation.Size = new System.Drawing.Size(177, 21);
            this.cboNewDockLocation.TabIndex = 36;
            // 
            // btnTopLevelForm
            // 
            this.btnTopLevelForm.Location = new System.Drawing.Point(14, 67);
            this.btnTopLevelForm.Name = "btnTopLevelForm";
            this.btnTopLevelForm.Size = new System.Drawing.Size(145, 23);
            this.btnTopLevelForm.TabIndex = 35;
            this.btnTopLevelForm.Text = "Open Top-level Form";
            this.btnTopLevelForm.UseVisualStyleBackColor = true;
            this.btnTopLevelForm.Click += new System.EventHandler(this.btnTopLevelForm_Click);
            // 
            // btnAddTaskpane
            // 
            this.btnAddTaskpane.Location = new System.Drawing.Point(14, 38);
            this.btnAddTaskpane.Name = "btnAddTaskpane";
            this.btnAddTaskpane.Size = new System.Drawing.Size(145, 23);
            this.btnAddTaskpane.TabIndex = 34;
            this.btnAddTaskpane.Text = "Add Taskpane";
            this.btnAddTaskpane.UseVisualStyleBackColor = true;
            this.btnAddTaskpane.Click += new System.EventHandler(this.btnAddTaskpane_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(14, 502);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(13, 13);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(408, 121);
            this.webBrowser1.TabIndex = 40;
            this.webBrowser1.Url = new System.Uri("https://www.bing.com/search?q=dynamic+dpi+office+developers&cc=US&setlang=en-US", System.UriKind.Absolute);
            // 
            // elementHost1
            // 
            this.elementHost1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.elementHost1.Location = new System.Drawing.Point(2, 297);
            this.elementHost1.Margin = new System.Windows.Forms.Padding(2);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(422, 187);
            this.elementHost1.TabIndex = 26;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.elementHost1_ChildChanged);
            this.elementHost1.Child = this.wpfUserControl11;
            // 
            // UserControlWinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboDpiContext);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboNewDockLocation);
            this.Controls.Add(this.btnTopLevelForm);
            this.Controls.Add(this.btnAddTaskpane);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGetWidthHeight);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtChildWindowMixedMode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtContainerRect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTaskpaneRect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHostWindowAwareness);
            this.Controls.Add(this.txtTaskpaneWindowAwareness);
            this.Controls.Add(this.txtProcessAwareness);
            this.Controls.Add(this.txtThreadAwareness);
            this.Controls.Add(this.Properties);
            this.MinimumSize = new System.Drawing.Size(317, 0);
            this.Name = "UserControlWinForm";
            this.Size = new System.Drawing.Size(439, 625);
            this.Load += new System.EventHandler(this.UserControlWinForm_Load);
            this.Resize += new System.EventHandler(this.UserControlWinForm_Resize);
            this.Properties.ResumeLayout(false);
            this.Properties.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtThreadAwareness;
        private System.Windows.Forms.TextBox txtProcessAwareness;
        private System.Windows.Forms.TextBox txtTaskpaneWindowAwareness;
        private System.Windows.Forms.TextBox txtHostWindowAwareness;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTaskpaneRect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtContainerRect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtChildWindowMixedMode;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private WPFUserControl1 wpfUserControl11;
        private System.Windows.Forms.MenuStrip Properties;
        private System.Windows.Forms.ToolStripMenuItem setHeight;
        private System.Windows.Forms.ToolStripTextBox txtSetHeight;
        private System.Windows.Forms.ToolStripMenuItem setWidth;
        private System.Windows.Forms.ToolStripTextBox txtSetWidth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGetWidthHeight;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboDpiContext;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboNewDockLocation;
        private System.Windows.Forms.Button btnTopLevelForm;
        private System.Windows.Forms.Button btnAddTaskpane;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}
