using System;
using System.Windows.Forms;
using DerekWindowsFormsApp.Unit1;
using DerekWindowsFormsApp.Game;
using DerekWindowsFormsApp.Unit3;
using DerekWindowsFormsApp.Unit4;

namespace DerekWindowsFormsApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new MonkeyBash());
            //Application.Run(new PadForm());
            Application.Run(new WelcomeForm());

        }
    }
}
