using SnowPlatformMonitor.Core.Configuration;
using System;
using System.IO;

namespace SnowPlatformMonitor.Aggregator.Classes.Modules
{
    class GarbageCollector
    {
        readonly DirectoryConfiguration dc = new DirectoryConfiguration();
        readonly ApplicationConfiguration ac = new ApplicationConfiguration();
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(GarbageCollector));

        internal void Run()
        {
            try
            {
                log.Info("Garbage Collector started");
                int exportCounter = 0;
                foreach (var file in Directory.GetFiles(dc.Export))
                {
                    if (File.Exists(file))
                    {
                        File.Delete(file);
                        exportCounter += 1;
                        log.Info(string.Format("{0} deleted", file));
                    }
                }
                log.Info(exportCounter + " left over export deleted");
                log.Info("Garbage Collector finished");
            } catch (Exception ex)
            {
                log.Fatal(ex);
            }
        }
    }
}
