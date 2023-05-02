using System;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace LogForm
{
    internal static class Program
    {

        public static string sqlConnection = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
       
        public static string stringPath = Directory.GetCurrentDirectory();
        public static string pathToLogs = stringPath.Remove(stringPath.IndexOf("bin")) + "Logs\\Log.txt";
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-us");


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SelectFromWarehouse());
        }
       
    }
}
