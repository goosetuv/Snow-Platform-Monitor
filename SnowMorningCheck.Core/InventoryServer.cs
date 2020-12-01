using System;
using System.IO;
using System.Linq;

namespace SnowPlatformMonitor.Core
{
    public class InventoryServer
    {
        private readonly DirectoryConfiguration dc = new DirectoryConfiguration();
        private readonly ApplicationConfiguration ac = new ApplicationConfiguration();

        public string ProcessingDirectory()
        {
            string ServerName = Utilities.ReadXMLValue(dc.Config + ac.ServerConfig, "InventoryServer");
            string InventoryPath = Utilities.ReadXMLValue(dc.Config + ac.ServerConfig, "InventoryServerDrive") + ":" +Utilities.ReadXMLValue(dc.Config + ac.AppConfig, "InventoryServerProcessingDirectory");
            int InventoryThreshold = Convert.ToInt32(Utilities.ReadXMLValue(dc.Config + ac.AppConfig, "InventoryServerProcessingThreshold"));
            int FileCount = 0;
            
            if(Utilities.PingHost(ServerName))
            {
                if(Directory.Exists(InventoryPath))
                {
                    var allowedExtensions = new[] { ".snowpack", ".inv" };
                    var files = Directory
                        .GetFiles(InventoryPath)
                        .Where(file => allowedExtensions.Any(file.ToLower().EndsWith))
                        .ToList();

                    foreach (var file in files) {
                        FileCount += 1;
                    }

                    if(FileCount > InventoryThreshold)
                    {
                        return "Threshold hit! " + FileCount.ToString() + " files";
                    } else
                    {
                        return FileCount.ToString() + " files";
                    }
                } else
                {
                    return "Inventory path does not exist";
                }
            } else
            {
                return "Host is unreachable";
            }
        }
    }
}
