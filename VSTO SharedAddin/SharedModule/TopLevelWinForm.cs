using System;
using System.Windows.Forms;

namespace SharedModule
{
    public partial class TopLevelWinForm : Form
    {
        public TopLevelWinForm(string userControlName)
        {
            InitializeComponent();
            LoadUserControl(userControlName);
        }

        public void LoadUserControl(string userControlName)
        {
            UserControl userControlAdd = (UserControl)Activator.CreateInstance(null, String.Format("{0}.{1}", this.GetType().Namespace, userControlName)).Unwrap();
            UserControl userControlCopy = (UserControl)this.Controls["userControlWinForm1"];

            userControlCopy.Name = "userControlWinForm1Copy";
            userControlAdd.Name = "userControlWinForm1";
            userControlAdd.Anchor = userControlCopy.Anchor;
            userControlAdd.Location = userControlCopy.Location;
            userControlAdd.Dock = userControlCopy.Dock;
            userControlAdd.Visible = true;

            this.Controls.Add(userControlAdd);
            this.Controls.Remove(userControlCopy);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
