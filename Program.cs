using System;
using System.Globalization;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Hospital1._0.Classes;
using Hospital1._0.Forms;

namespace Hospital1._0
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            Application.EnableVisualStyles();
            FirestoreHelper.SetEnvironmentVariable();
            Application.SetCompatibleTextRenderingDefault(false);
            // For English Locale
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

            Application.Run(new LoginForm());
        }
    }
}
