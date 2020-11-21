using System;
using System.IO;
using Laim;

namespace SnowMorningCheck.Core
{
    class ApplicationConfiguration
    {
        // code reused from gooseFTP

        DirectoryConfiguration dc = new DirectoryConfiguration();
        public string ServerConfig = "snowservers.config";
        public string SMTPConfig = "smtp.config";

        public string SaveConfig(string config, string[] nl, string[] vl)
        {
            try
            {
                if (config == "snowservers")
                {
                    XmlConfigurator.Write(dc.Config + ServerConfig, nl, vl);
                }
                else if (config == "smtp")
                {
                    XmlConfigurator.Write(dc.Config + SMTPConfig, nl, vl);
                }
                return "configsaved";
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
