using System.Collections.Generic;
using Microsoft.Office.Tools;

namespace SharedModule
{
    public class TaskPanes
    {
        private CustomTaskPaneCollection m_tpc;

        public TaskPanes(CustomTaskPaneCollection taskPanes)
        {
            m_tpc = taskPanes;
        }

        public void CreateTaskpaneInstance()
        {
            CustomTaskPane myCustomTaskPane;

            // Add a custom taskpane - Win Form
            UserControlWinForm myUserControl1 = new UserControlWinForm();
            myCustomTaskPane = m_tpc.Add(myUserControl1, "DDPI Custom Taskpane");
            myCustomTaskPane.Width = 700;
            myCustomTaskPane.Visible = true;
        }

        public void CloseAllTaskpanes()
        {
            int count = m_tpc.Count;
            for (int i = 0; i < count; i++)
            {
                m_tpc[0].Visible = false;
                m_tpc.RemoveAt(0);
            }
        }
    }
}
