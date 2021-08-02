using SnowPlatformMonitor.Core.Classes;
using SnowPlatformMonitor.Core.Configuration;
using System;
using System.Configuration;

namespace SnowPlatformMonitor.Aggregator.Classes.Modules
{
    class LogRetention
    {
        readonly DirectoryConfiguration dc = new DirectoryConfiguration();
        readonly ApplicationConfiguration ac = new ApplicationConfiguration();
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(LogRetention));

        internal void Run()
        {
            try
            {
                log.Info("Log Retention started");
                log.Debug($"Retention Period: {ConfigurationManager.AppSettings["logRetention"]} days");
                Utilities.LogRetention(dc.Logs, Convert.ToInt32(ConfigurationManager.AppSettings["logRetention"]));
                log.Info("Log Retention finished");
            } catch (Exception ex)
            {
                log.Fatal(ex);
            }
        }
    }
}
