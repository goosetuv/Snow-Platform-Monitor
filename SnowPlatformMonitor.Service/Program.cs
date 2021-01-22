using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using SnowPlatformMonitor.Core.Configuration;

namespace SnowPlatformMonitor.Service
{
    static class Program
    {

        // defines for commandline output
        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);
        private const int ATTACH_PARENT_PROCESS = -1;

        static DirectoryConfiguration dc = new DirectoryConfiguration();
        static ApplicationConfiguration ac = new ApplicationConfiguration();

        static readonly string logPath = dc.Logs + "spm_svc_" + DateTime.Now.ToString("yyyy-MM-dd") + ".log";

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            if(args.Length > 0)
            {
                AttachConsole(ATTACH_PARENT_PROCESS); // redirects the console to the command window

                if (args[0] == "test" || args[0] == "--test" || args[0] == "-test")
                {
                    Console.ForegroundColor = ConsoleColor.Green;

                    SnowPlatformMonitor snowPlatformMonitor = new SnowPlatformMonitor();
                    log.Debug("Test export started...");
                    
                    Console.WriteLine("Service Export started, please wait.");

                    snowPlatformMonitor.ServiceExporter();

                    log.Debug("Test export finished...");
                    Console.WriteLine("Service Export finished!");

                    Console.ForegroundColor = ConsoleColor.White;
                }
            } else
            {
                ServiceBase[] ServicesToRun;
                ServicesToRun = new ServiceBase[]
                {
                new SnowPlatformMonitor()
                };
                ServiceBase.Run(ServicesToRun);
            }
        }
    }
}
