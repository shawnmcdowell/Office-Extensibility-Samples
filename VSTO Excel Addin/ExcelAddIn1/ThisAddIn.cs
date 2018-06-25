using System;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using Microsoft.Office.Tools;
using SharedModule;

namespace ExcelAddIn1
{
    public partial class ThisAddIn
    {
        public Excel.Application ExcelApp;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            ExcelApp = Globals.ThisAddIn.Application;

            SharedApp.InitAppTaskPanes(ref this.CustomTaskPanes);
            SharedApp.AppTaskPanes.CreateTaskpaneInstance();

            //ExcelApp.WorkbookBeforeSave += new Microsoft.Office.Interop.Excel.AppEvents_WorkbookBeforeSaveEventHandler(Application_WorkbookBeforeSave);
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
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
