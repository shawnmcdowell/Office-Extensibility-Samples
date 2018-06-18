using Microsoft.Office.Tools;

namespace SharedModule
{
    public class TaskPanes
    {
        private CustomTaskPaneCollection m_tpc;

        public TaskPanes(ref CustomTaskPaneCollection taskPanes)
        {
            m_tpc = taskPanes;
        }

        public void CreateTaskpaneInstance()
        {
            CreateTaskpaneInstance(700, 0, Microsoft.Office.Core.MsoCTPDockPosition.msoCTPDockPositionRight);
        }
        public void CreateTaskpaneInstance(int width, int height, Microsoft.Office.Core.MsoCTPDockPosition dockPosition)
        {
            CustomTaskPane customTaskpane;

            // Add a custom taskpane
            UserControlWinForm userControl = new UserControlWinForm();
            customTaskpane = m_tpc.Add(userControl, string.Format("DDPI Custom Taskpane {0}", m_tpc.Count + 1));
            customTaskpane.DockPosition = dockPosition;
            if (width != 0) customTaskpane.Width = width;
            if (height != 0) customTaskpane.Height = height;
            customTaskpane.Visible = true;
            userControl.SetCustomTaskpane(ref customTaskpane);
        }

        public void CloseAllTaskpanes()
        {
            int count = m_tpc.Count;
            for (int i = 0; i < count; i++)
            {
                m_tpc[0].Visible = false;
                m_tpc[0].Dispose();
                m_tpc.RemoveAt(0);
            }
        }
    }
}
