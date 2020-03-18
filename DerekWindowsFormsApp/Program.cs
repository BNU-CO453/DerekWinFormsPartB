using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DerekWindowsFormsApp.Game;
using DerekWindowsFormsApp.Unit3;
using DerekWindowsFormsApp.Unit1;

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
            Application.Run(new PizzaForm());
        }
    }
}
