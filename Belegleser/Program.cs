using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Belegleser
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            #if DEBUG
            Application.Run(new Form1());
            #endif
            #if !DEBUG
            Application.Run(new SplashScreen());
            #endif
        }
    }
}
