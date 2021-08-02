using Microsoft.Win32;
using System;

namespace SnowPlatformMonitor.Aggregator.Classes
{

    /// <summary>
    /// This class is not currently used
    /// </summary>
    public static class RegInfo
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(RegInfo));

        public static void SetLastAggregateRegistry()
        {
            try
            {
                log.Info("Setting last aggregate date in the registry");

                RegistryKey k = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\LaimMcKenzie\SnowPlatformMonitor");
                k.SetValue("LastAggregate", DateTime.Today.ToString("d-MM-yyyy"));
                k.Close();
            }
            catch (Exception ex) { log.Fatal(ex); }
        }

        public static string GetLastAggregateRegistry()
        {
            try
            {
                log.Info("Getting last aggregate date from registry");

                RegistryKey k = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\LaimMcKenzie\SnowPlatformMonitor");
                if (k != null)
                {
                    if (k.GetValue("LastAggregate") != null)
                    {
                        return (string)k.GetValue("LastAggregate");
                    }
                }

                return "01-01-1970";
            }
            catch (Exception ex) { log.Fatal(ex); return "01-01-1970"; }
        }
    }
}
