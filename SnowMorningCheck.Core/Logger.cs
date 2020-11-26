using System;
using System.IO;

namespace SnowPlatformMonitor.Core
{
    public static class Logger
    {

        //-- File Names
        //SPMConfiguration
        //SPMCore

        //-- Types
        //INFO
        //ERROR
        //FATAL
        //DEBUG

        public static void Log(string name, string message, string thread, string type)
        {
            try
            {
                DirectoryConfiguration dc = new DirectoryConfiguration();
                ApplicationConfiguration ac = new ApplicationConfiguration();

                string timestamp = Utilities.DateFormat(DateTime.Now, "dd-MM-yyyy hh:mm:ss.fff tt");
                string logEntry = string.Format("{0} : {1} : {2} : {3}", timestamp, type.ToUpper(), thread, message);
                File.AppendAllText(dc.Logs + name + "-" + Utilities.DateFormat(DateTime.Now) + ".log", logEntry + Environment.NewLine);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
