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

        private void RefreshValues()
        {
            if (!this.Visible) return;

            IntPtr hWndHost = Process.GetCurrentProcess().MainWindowHandle;
            IntPtr hWndTaskpane = this.Handle;
            IntPtr hWndContainer = DPIHelper.FindParentWithClassName(hWndTaskpane, "MsoCommandBar");

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
                DPIHelper.GetChildWindowMixedMode(this.Handle).ToString();

            this.txtTaskpaneRect.Text = HwndInfoString(hWndTaskpane);
            this.txtContainerRect.Text = HwndInfoString(hWndContainer);
        }

        private string HwndInfoString(IntPtr hWnd)
        {
            RECT r = DPIHelper.GetWindowRectangle(hWnd);

            return String.Format("{0},{1} ({2:X}) (Parent {3:X})",
            (r.right - r.left).ToString(),
            (r.bottom - r.top).ToString(),
            hWnd.ToInt64(),
            DPIHelper.GetParentWindow(hWnd).ToInt64());
        }

        public UserControlWinForm()
        {
            InitializeComponent();
            // Setup timer callback
            refreshTimer.Tick += (Object o, EventArgs e) => RefreshValues();
            refreshTimer.Interval = 1000;
            AutoRefreshValues(true);
        }

        public void InitTaskpanes(TaskPanes tpc)
        {
            SharedApp.AppTaskPanes = tpc;
        }

        private void btnSATaskpane_Click(object sender, EventArgs e)
        {
            SetThreadDPI(DPIHelper.DPI_AWARENESS_CONTEXT.DPI_AWARENESS_CONTEXT_SYSTEM_AWARE, false);
            SharedApp.AppTaskPanes.CreateTaskpaneInstance();
        }

        private void btnSAForm_Click(object sender, EventArgs e)
        {
            SetThreadDPI(DPIHelper.DPI_AWARENESS_CONTEXT.DPI_AWARENESS_CONTEXT_SYSTEM_AWARE, false);
            Form f1 = new Form1();
            f1.Show();
        }

        private void btnCreatePMAV2Taskpane_Click(object sender, EventArgs e)
        {
            SetThreadDPI(DPIHelper.DPI_AWARENESS_CONTEXT.DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE_V2, false);
            SharedApp.AppTaskPanes.CreateTaskpaneInstance();
        }

        private void btnOpenNonModalSA_Click(object sender, EventArgs e)
        {
            SetThreadDPI(DPIHelper.DPI_AWARENESS_CONTEXT.DPI_AWARENESS_CONTEXT_SYSTEM_AWARE, false);
            Form f1 = new Form1();
            f1.Show();
        }

        private void btnSetCWMM_Click(object sender, EventArgs e)
        {
            DPIHelper.SetChildWindowMixedMode(DPIHelper.DPI_HOSTING_BEHAVIOR.DPI_HOSTING_BEHAVIOR_MIXED);
            // MessageBox.Show(String.Format("DPI Hosting Behavior is {0}", DPIHelper.GetChildWindowMixedMode(this.Handle).ToString()));
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

        private void SetThreadDPI(DPIHelper.DPI_AWARENESS_CONTEXT newvalue)
        {
            SetThreadDPI(newvalue, true);
        }
        private void SetThreadDPI(DPIHelper.DPI_AWARENESS_CONTEXT newvalue, bool showMessage)
        {
            DPIHelper.DPI_AWARENESS_CONTEXT previous =
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
    }
}
