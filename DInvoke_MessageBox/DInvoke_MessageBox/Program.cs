using System;
using System.Runtime.InteropServices;

using DInvoke.DynamicInvoke;

namespace ConsoleApp1
{
    internal class Program
    {
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        delegate int MessageBoxW(IntPtr hWnd, string lpText, string pCaption, uint uType);

        static void Main(string[] args)
        {
            var address = Generic.GetLibraryAddress("user32.dll", "MessageBoxW");
            var messageBoxW = (MessageBoxW)Marshal.GetDelegateForFunctionPointer(address, typeof(MessageBoxW));

            messageBoxW(IntPtr.Zero, "Box 1", "Box 1", 0);
            messageBoxW(IntPtr.Zero, "Box 2", "Box 2", 0);
        }
    }
}