using ArduinoMonitor.Frontend.Forms;
using ArduinoMonitor.Network.DataHandler;
using ArduinoMonitor.Network.DataReceiver;

namespace ArduinoMonitor
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            NetComm.Instance.InitializeNetwork();
            NetworkDataProcessor p = new NetworkDataProcessor();
            p.Initialize();
            Application.Run(new MainPage(p));
        }
    }
}