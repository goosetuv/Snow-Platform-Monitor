using System;
using System.IO;
using Laim;

namespace SnowPlatformMonitor.Core
{
    public class ApplicationConfiguration
    {
        // code reused from gooseFTP

        readonly DirectoryConfiguration dc = new DirectoryConfiguration();
        public string AppConfig = "spm.config"; // snow platform monitor, the main app.config (instead of using app.config, laim why?)
        public string ServerConfig = "servers.config"; // snow servers, the configuration file for storing the server information
        public string SMTPConfig = "smtp.config"; // mail server, the configuration file for storing the SMTP information for emailing 

        public string SaveConfig(string config, string[] nl, string[] vl)
        {
            try
            {
                if (config == "servers")
                {
                    XmlConfigurator.Write(dc.Config + ServerConfig, nl, vl);
                    return "configsaved";
                }
                else if (config == "smtp")
                {
                    XmlConfigurator.Write(dc.Config + SMTPConfig, nl, vl);
                    return "configsaved";
                }
                else if (config == "spm")
                {
                    XmlConfigurator.Write(dc.Config + AppConfig, nl, vl);
                    return "configsaved";
                }
                else
                {
                    return "";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public bool ConfigExists(string config)
        {
            if (File.Exists(dc.Config + config))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
