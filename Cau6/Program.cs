using System;
using System.Windows.Forms;

namespace Cau6
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormChinh());
        }
    }
}