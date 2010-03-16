using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LcogClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //try
            //{
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Forms.Menu());
            //}
            //catch (Exception ex)
            //{
            //    LcogClient.Utility.LcogLogger.Log(ex.Message + "\n" + ex.StackTrace + "\n");
            //}
            //finally
            //{
            //    Application.Exit();
            //}
        }
    }
}
