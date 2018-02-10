using System;
using System.Windows.Forms;

namespace HospitalSystemUI
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
            //Initialize connection
            HospitalLibrary.DataAccess.GlobalConfiguration.InitializeConnections(true);
            Application.Run(new CreateEmployee());
        }
    }
}
