using System;
using System.Windows.Forms;
using RavenDevLauncher.Interface;
using System.Net;
using System.IO;


namespace RavenDevLauncher
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
                    Application.Run(new Interface.FrmMain());
                
        }
            
    }
}

           
            
            
            
            



