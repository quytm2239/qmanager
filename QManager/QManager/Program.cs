using System;
using System.Windows.Forms;
using QManager.GUI;
namespace QManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static bool IsAppClosed = false;
        public static AppStatus AppStatus = new AppStatus();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreen());
        }
    }
}
