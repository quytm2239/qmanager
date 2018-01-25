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

        [STAThread]
        static void Main()
        {
            //DBConnection.GetInstance().CheckConnectity();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreen());
        }
    }
}
