using System;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using static LogForm.InnerFunctions;


namespace LogForm
{
    internal static class Program
    {

        public static string sqlConnection = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
       
        public static string stringPath = Directory.GetCurrentDirectory();

        public static string pathToLogs = stringPath.Remove(stringPath.IndexOf("bin")) + "Logs\\Log.txt";
        public static string pathToProductList= stringPath.Remove(stringPath.IndexOf("bin")) + "ProductList";
        public static string pathToWarehouseList= stringPath.Remove(stringPath.IndexOf("bin")) + "WarehouseList";
        public static string pathToSpeechCommands = stringPath.Remove(stringPath.IndexOf("bin")) + "SpeechCommands\\Commands.txt";


        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-us");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += Application_ThreadException;
            Application.Run(new Login());
        }
        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show($"Произошла ошибка");
            LogException(e.Exception);
        }

    }
}
