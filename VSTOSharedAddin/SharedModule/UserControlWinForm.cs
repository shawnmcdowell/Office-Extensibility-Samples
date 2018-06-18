using Microsoft.Office.Tools;
using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using static SharedModule.DPIHelper;

namespace SharedModule
{
    public partial class UserControlWinForm : UserControl
    {
        private System.Windows.Forms.Timer refreshTimer = new System.Windows.Forms.Timer();
        private CustomTaskPane m_customTaskPane = null;

        private void RefreshValues()
        {
            if (!this.Visible || this.Disposing) return;

            IntPtr hWndHost = Process.GetCurrentProcess().MainWindowHandle;
            IntPtr hWndTaskpane = this.Handle;
            IntPtr hWndContainer = DPIHelper.FindParentWithClassName(hWndTaskpane, "MsoCommandBar");
            IntPtr hWndTaskpaneHost = DPIHelper.FindParentWithClassName(hWndTaskpane, "CMMOcxHostChildWindowMixedMode");

            this.txtThreadAwareness.Text = DPIHelper.GetThreadDpiAwareness().ToString();
            this.txtProcessAwareness.Text = DPIHelper.GetProcessDpi().ToString();

            if (this.Handle != null)
            {
                this.txtTaskpaneWindowAwareness.Text =
                    DPIHelper.GetWindowDpiAwareness(this.Handle).ToString();
            }

            this.txtHostWindowAwareness.Text = 
                DPIHelper.GetWindowDpiAwareness(hWndHost).ToString();

            this.txtChildWindowMixedMode.Text =
                DPIHelper.GetThreadDpiHostingBehavior(hWndTaskpaneHost).ToString();

            this.txtTaskpaneRect.Text = HwndInfoString(hWndTaskpane);
            this.txtContainerRect.Text = HwndInfoString(hWndContainer);

            if (m_customTaskPane != null)
            {
                this.txtGetWidthHeight.Text = string.Format("{0}, {1}", m_customTaskPane.Width, m_customTaskPane.Height);
            }
        }

        private string HwndInfoString(IntPtr hWnd)
        {
            RECT rSA;
            RECT rPMA;

            {
                DPIContextBlock saBlock = new DPIContextBlock(DPI_AWARENESS_CONTEXT_SYSTEM_AWARE);
                rSA = DPIHelper.GetWindowRectangle(hWnd);
            }
            {
                DPIContextBlock saBlock = new DPIContextBlock(DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE);
                rPMA = DPIHelper.GetWindowRectangle(hWnd);
            }

            return String.Format("SA: {0}, {1} PMA: {2}, {3}",
            (rSA.right - rSA.left).ToString(),
            (rSA.bottom - rSA.top).ToString(),
            (rPMA.right - rPMA.left).ToString(),
            (rPMA.bottom - rPMA.top).ToString());
        }

        public UserControlWinForm()
        {
            InitializeComponent();
            // Setup timer callback
            refreshTimer.Tick += (Object o, EventArgs e) => RefreshValues();
            refreshTimer.Interval = 1000;

            cboNewDockLocation.DataSource = Enum.GetValues(typeof(Microsoft.Office.Core.MsoCTPDockPosition));
            cboDpiContext.DataSource = DpiAwarenessContexts;

            AutoRefreshValues(true);
        }

        public void SetCustomTaskpane(ref CustomTaskPane ctp)
        {
            m_customTaskPane = ctp;
        }

        private DPI_AWARENESS_CONTEXT GetSelectedDpiAwarenessContext()
        {
            int index = Array.FindIndex(DpiAwarenessContexts, match => match.Equals(cboDpiContext.SelectedValue.ToString()));
            if (index >= 0)
            {
                return DpiAwarenessContexts[index];
            }
            return DPI_AWARENESS_CONTEXT_SYSTEM_AWARE;
        }

        private void CreateNewTaskpane()
        {
            int width = 0;
            int height = 0;
            Microsoft.Office.Core.MsoCTPDockPosition dock;

            if (!Enum.TryParse<Microsoft.Office.Core.MsoCTPDockPosition>(cboNewDockLocation.SelectedValue.ToString(), out dock))
            {
                dock = Microsoft.Office.Core.MsoCTPDockPosition.msoCTPDockPositionRight;
            }
            Int32.TryParse(txtSetWidth.Text, out width);
            Int32.TryParse(txtSetHeight.Text, out height);

            SharedApp.AppTaskPanes.CreateTaskpaneInstance(width, height, dock);
        }


        private void btnAddTaskpane_Click(object sender, EventArgs e)
        {
            CreateNewTaskpane();
        }

        private void btnTopLevelForm_Click(object sender, EventArgs e)
        {
            DPIContextBlock context = new DPIContextBlock(GetSelectedDpiAwarenessContext());
            Form f1 = new Form1();
            f1.Show();
        }

        private void AutoRefreshValues(bool start)
        {
            if (start)
            {
                refreshTimer.Start();
            }
            else
            {
                refreshTimer.Stop();
            }
        }

        private void SetThreadDPI(DPI_AWARENESS_CONTEXT newvalue)
        {
            SetThreadDPI(newvalue, true);
        }
        private void SetThreadDPI(DPI_AWARENESS_CONTEXT newvalue, bool showMessage)
        {
            DPI_AWARENESS_CONTEXT previous =
                DPIHelper.SetThreadDpiAwareness(newvalue);
            int processId = Process.GetCurrentProcess().Id;
            int threadId = Thread.CurrentThread.ManagedThreadId;
            if (showMessage)
            {
                MessageBox.Show(String.Format("DPI Awareness set to {0}, was {1}\nProcessId {2}, ThreadId {3}", newvalue, previous, processId, threadId));
            }
        }

        private void setCWMMNormal_Click(object sender, EventArgs e)
        {
            DPIHelper.SetChildWindowMixedMode(DPIHelper.DPI_HOSTING_BEHAVIOR.DPI_HOSTING_BEHAVIOR_DEFAULT);
            // MessageBox.Show(String.Format("DPI Hosting Behavior is {0}", DPIHelper.GetChildWindowMixedMode(this.Handle).ToString()));

        }

        private void UserControlWinForm_Load(object sender, EventArgs e)
        {
            RefreshValues();
        }

        private void UserControlWinForm_Resize(object sender, EventArgs e)
        {
            RefreshValues();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtSetHeight_Click(object sender, EventArgs e)
        {

        }

        private void txtSetHeight_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                int height = m_customTaskPane.Height;
                if (int.TryParse(txtSetHeight.Text, out height))
                {
                    try
                    {
                        m_customTaskPane.Height = height;
                    }
                    catch (System.Runtime.InteropServices.COMException except)
                    {
                        MessageBox.Show(except.Message);
                    }
                }
            }
        }

        private void txtSetWidth_Click(object sender, EventArgs e)
        {

        }

        private void txtSetWidth_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int width = m_customTaskPane.Width;
                if (int.TryParse(txtSetWidth.Text, out width))
                {
                    try
                    {
                        m_customTaskPane.Width = width;
                    }
                    catch (System.Runtime.InteropServices.COMException except)
                    {
                        MessageBox.Show(except.Message);
                    }
            }
        }

        }
    }
}
