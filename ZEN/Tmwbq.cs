using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZEN
{
    internal static class Tmwbq
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!File.Exists("C:\\ProgramData\\Zen"))
                STMFa.Save();
            else
                STMFa.Load();

            Application.Run(new vYFEC());
        }
    }
}
