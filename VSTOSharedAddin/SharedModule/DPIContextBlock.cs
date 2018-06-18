using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using static SharedModule.DPIHelper;

namespace SharedModule
{
    class DPIContextBlock : IDisposable
    {
        private DPI_AWARENESS_CONTEXT resetContext;
        private bool disposed = false;

        public DPIContextBlock(DPI_AWARENESS_CONTEXT contextSwitchTo)
        {
            Trace.WriteLine(string.Format("Creating block {0}", contextSwitchTo.ToString()));
            resetContext = DPIHelper.SetThreadDpiAwareness(contextSwitchTo);
         }

        //~DPIContextBlock()
        //{
        //    Trace.WriteLine(string.Format("Destructing block {0}", resetContext.ToString()));
        //    // Dispose should have already switched context
        //    Trace.Assert(resetContext == GetThreadDpiAwareness());
        //}

        public void Dispose()
        {
            Trace.WriteLine(string.Format("Dispose block {0}", resetContext.ToString()));
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    SetThreadDpiAwareness(resetContext);
                }
            }
            disposed = true;
        }
    }
}
