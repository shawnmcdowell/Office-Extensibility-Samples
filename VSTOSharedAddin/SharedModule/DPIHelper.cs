﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;

namespace SharedModule
{
    public static class DPIHelper
    {
        // Hack until sdk version of windef.h is updated
        public enum DPI_HOSTING_BEHAVIOR
        {
            DPI_HOSTING_BEHAVIOR_INVALID = -1,
            DPI_HOSTING_BEHAVIOR_DEFAULT = 0,
            DPI_HOSTING_BEHAVIOR_MIXED = 1
        }
        public struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        [DllImport("SHCore.dll", SetLastError = true)]
        private static extern bool SetProcessDpiAwareness(DPI_AWARENESS awareness);

        [DllImport("SHCore.dll", SetLastError = true)]
        private static extern void GetProcessDpiAwareness(IntPtr hprocess, out DPI_AWARENESS awareness);

        [DllImport("User32.dll", SetLastError = true)]
        private static extern DPI_AWARENESS_CONTEXT SetThreadDpiAwarenessContext(DPI_AWARENESS_CONTEXT awareness);

        [DllImport("User32.dll", SetLastError = true)]
        private static extern DPI_AWARENESS_CONTEXT GetThreadDpiAwarenessContext();

        [DllImport("User32.dll", SetLastError = true)]
        private static extern DPI_AWARENESS_CONTEXT GetWindowDpiAwarenessContext(IntPtr hWnd);

        [DllImport("User32.dll", SetLastError = true)]
        private static extern DPI_AWARENESS GetAwarenessFromDpiAwarenessContext(DPI_AWARENESS_CONTEXT value);

        // DPI_HOSTING_BEHAVIOR WINAPI SetThreadDpiHostingBehavior(_In_ DPI_HOSTING_BEHAVIOR dpiHostingBehavior);
        [DllImport("User32.dll", SetLastError = true)]
        private static extern DPI_HOSTING_BEHAVIOR SetThreadDpiHostingBehavior(DPI_HOSTING_BEHAVIOR dpiHostingBehavior);

        // DPI_HOSTING_BEHAVIOR WINAPI GetThreadDpiHostingBehavior(_In_ HWND hwnd);
        [DllImport("User32.dll", SetLastError = true)]
        private static extern DPI_HOSTING_BEHAVIOR GetThreadDpiHostingBehavior(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool GetWindowRect(IntPtr hWnd, ref RECT rect);

        [DllImport("user32.dll")]
        private static extern IntPtr GetParent(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern int GetClassName(IntPtr hWnd, StringBuilder className, int charCount);

        private const uint DPI_AWARENESS_CONTEXT_HANDLE = 0;

        public enum DPI_AWARENESS_CONTEXT : uint
        {
            DPI_AWARENESS_CONTEXT_UNAWARE = unchecked(DPI_AWARENESS_CONTEXT_HANDLE - 1),
            DPI_AWARENESS_CONTEXT_SYSTEM_AWARE = unchecked(DPI_AWARENESS_CONTEXT_HANDLE - 2),
            DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE = unchecked(DPI_AWARENESS_CONTEXT_HANDLE - 3),
            DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE_V2 = unchecked(DPI_AWARENESS_CONTEXT_HANDLE - 4)
        }

        public enum DPI_AWARENESS
        {
            DPI_AWARENESS_INVALID = -1,
            DPI_AWARENESS_UNAWARE = 0,
            DPI_AWARENESS_SYSTEM_AWARE = 1,
            DPI_AWARENESS_PER_MONITOR_AWARE = 2
        }

        public static bool SetDpiAwareness(DPI_AWARENESS awareness)
        {
            return SetProcessDpiAwareness(awareness);
        }

        public static DPI_AWARENESS_CONTEXT SetThreadDpiAwareness(DPI_AWARENESS_CONTEXT awareness)
        {
            return SetThreadDpiAwarenessContext(awareness);
        }

        public static DPI_AWARENESS GetProcessDpi()
        {
            return GetProcessDpi(Process.GetCurrentProcess().Handle);
        }

        public static DPI_AWARENESS GetProcessDpi(IntPtr hprocess)
        {
            DPI_AWARENESS awareness;
            GetProcessDpiAwareness(hprocess, out awareness);
            return awareness;
        }

        public static DPI_AWARENESS GetThreadDpiAwareness()
        {
            DPI_AWARENESS_CONTEXT context = GetThreadDpiAwarenessContext();
            return GetAwarenessFromDpiAwarenessContext(context);
        }

        public static DPI_AWARENESS GetWindowDpiAwareness(IntPtr hWnd)
        {
            DPI_AWARENESS_CONTEXT context = GetWindowDpiAwarenessContext(hWnd);
            return GetAwarenessFromDpiAwarenessContext(context);
        }

        public static DPI_HOSTING_BEHAVIOR SetChildWindowMixedMode(DPI_HOSTING_BEHAVIOR value)
        {
            return SetThreadDpiHostingBehavior(value);
        }

        public static DPI_HOSTING_BEHAVIOR GetChildWindowMixedMode(IntPtr hWnd)
        {
            return GetThreadDpiHostingBehavior(hWnd);
        }

        public static void DebugPrintDPIAwareness(IntPtr hprocess, string message)
        {
            Debug.WriteLine(DPIAwarenessText(hprocess, message));
        }

        public static string DPIAwarenessText(IntPtr hprocess, string message)
        {
            return String.Format("***{0}: Process {1}, Thread {2}", message, GetProcessDpi(hprocess), GetThreadDpiAwareness());
        }

        public static string DPIAwarenessText(string message)
        {
            return DPIAwarenessText(Process.GetCurrentProcess().Handle, message);
        }

        public static RECT GetWindowRectangle(IntPtr hWnd)
        {
            RECT rect = new RECT();
            GetWindowRect(hWnd, ref rect);

            return rect;
        }

        public static IntPtr GetParentWindow(IntPtr hWnd)
        {
            return GetParent(hWnd);
        }

        public static string GetWindowClassName(IntPtr hWnd)
        {
            StringBuilder buff = new StringBuilder(256);
            int retCount = 0;

            retCount = GetClassName(hWnd, buff, 256);

            return buff.ToString();
        }

        public static IntPtr FindParentWithClassName(IntPtr hWndChild, string className)
        {
            IntPtr hwndParent = GetParent(hWndChild);

            while (hwndParent != IntPtr.Zero)
            {
                if (GetWindowClassName(hwndParent).Equals(className, StringComparison.InvariantCultureIgnoreCase))
                {
                    return hwndParent;
                }
                hwndParent = GetParent(hwndParent);
            }
            return IntPtr.Zero;
        }
    }
}