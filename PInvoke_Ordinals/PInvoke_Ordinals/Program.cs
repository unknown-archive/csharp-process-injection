using System;
using System.Runtime.InteropServices;

namespace PInvoke
{
    internal class Program
    {
        [DllImport("user32.dll", EntryPoint = "#2156", CharSet = CharSet.Unicode)]
        static extern int LegitCallerAPi(IntPtr hWnd, string lpText, string lpCaption, uint uType);

        static void Main(string[] args)
        {
            LegitCallerAPi(IntPtr.Zero, "MessageBoxW from Ordinal", "Ordinals", 0);
        }
    }
}