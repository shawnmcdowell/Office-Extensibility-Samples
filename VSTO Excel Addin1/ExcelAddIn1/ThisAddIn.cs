using ExcelAddIn1;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using Microsoft.Office.Tools;

namespace DDPIExcelAddIn
{
    public partial class ThisAddIn
    {
        private IntPtr m_hProcess;
        private CustomTaskPane myCustomTaskPane;

        public Excel.Application ExcelApp;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            ExcelApp = Globals.ThisAddIn.Application;

            ExcelApp.WorkbookBeforeSave += new Microsoft.Office.Interop.Excel.AppEvents_WorkbookBeforeSaveEventHandler(Application_WorkbookBeforeSave);
            m_hProcess = Process.GetCurrentProcess().Handle;
            DPIHelper.DebugPrintDPIAwareness(m_hProcess, "startup");

            // Add a custom taskpane - Win Form
            UserControlWinForm myUserControl1 = new UserControlWinForm();
            DPIHelper.DebugPrintDPIAwareness(m_hProcess, "after usercontrol1 create");
            myCustomTaskPane = this.CustomTaskPanes.Add(myUserControl1, "WinForm");
            myCustomTaskPane.Width = 500;
            myCustomTaskPane.Visible = true;

            DPIHelper.DebugPrintDPIAwareness(m_hProcess, "startup end");
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            DPIHelper.DebugPrintDPIAwareness(m_hProcess, "** shutdown");
        }

        void Application_WorkbookBeforeSave(Microsoft.Office.Interop.Excel.Workbook Wb, bool SaveAsUI, ref bool Cancel)
        {
            Excel.Worksheet activeWorksheet = ((Excel.Worksheet)ExcelApp.ActiveSheet);
            Excel.Range firstRow = activeWorksheet.get_Range("A1");
            firstRow.EntireRow.Insert(Excel.XlInsertShiftDirection.xlShiftDown);
            Excel.Range newFirstRow = activeWorksheet.get_Range("A1");
            newFirstRow.Value2 = String.Format("Save triggered at {0}, {1}", DateTime.Now, DPIHelper.DPIAwarenessText("BeforeSave"));
            DPIHelper.DebugPrintDPIAwareness(m_hProcess, "BeforeSave");

            System.Windows.Forms.Form f1 = new Form1();
            f1.ShowDialog();
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
