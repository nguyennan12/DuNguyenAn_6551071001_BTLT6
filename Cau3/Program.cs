using System;
using System.Windows.Forms;

namespace Cau3
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormNhapDiem());
        }
    }
}