using System;
using System.Windows.Forms;

namespace HospitalSystemUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// Initializes the Global Connection
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            HospitalLibrary.DataAccess.GlobalConfiguration.InitializeConnections(true);
            Application.Run(new MainLoginForm());
        }
    }
}
