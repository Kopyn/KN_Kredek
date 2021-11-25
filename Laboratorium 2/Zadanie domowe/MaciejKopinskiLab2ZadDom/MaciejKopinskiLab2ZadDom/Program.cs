using System;
using System.Windows.Forms;
using MaciejKopinskiLab2ZadDom.Forms;

namespace MaciejKopinskiLab2ZadDom
{
    static class Program
    {

        public static bool Logged;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());

            //if you were able to log-in, then open FormMain, close the application otherwise
            if (Logged)
                Application.Run(new FormMain());
        }
    }
}
