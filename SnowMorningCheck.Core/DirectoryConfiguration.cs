using System;
using System.IO;
using System.Reflection;

namespace SnowPlatformMonitor.Core
{
    public class DirectoryConfiguration
    {
        // code reused from gooseFTP

        public string Logs = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\Logs\"; // logs directory
        public string Config = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\Configuration\"; // file configuration directory

        // check if the directory exists else create it
        public bool DirectoryExists(string path)
        {
            if (Directory.Exists(path))
            {
                return true;
            }
            else
            {
                try
                {
                    Directory.CreateDirectory(path);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}
