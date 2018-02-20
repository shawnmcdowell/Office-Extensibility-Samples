using Microsoft.Office.Tools;

namespace SharedModule
{
    public static class SharedApp
    {
        private static TaskPanes m_taskPanes;

        public static TaskPanes AppTaskPanes
        {
            get
            {
                return m_taskPanes;
            }

            set
            {
                m_taskPanes = value;
            }
        }

        public static void InitAppTaskPanes(CustomTaskPaneCollection value)
        {
            m_taskPanes = new TaskPanes(value);
        }
    }
}
