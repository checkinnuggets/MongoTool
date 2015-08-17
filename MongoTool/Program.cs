using System;
using System.Threading;
using System.Windows.Forms;

namespace MongoTool
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            // Add the event handler for handling UI thread exceptions to the event.
            Application.ThreadException += GlobalExceptionHandler;

            // Set the unhandled exception mode to force all Windows Forms errors to go through
            // our handler.
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            // Add the event handler for handling non-UI thread exceptions to the event. 
            /*
            AppDomain.CurrentDomain.UnhandledException += 
                new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            */
            // Runs the application.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
        /*
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            throw new NotImplementedException();
        }
        */
        private static void GlobalExceptionHandler(object sender, ThreadExceptionEventArgs t)
        {
            MessageBox.Show(t.Exception.Message, @"Unhandled Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);            
        }
        
    }
}
