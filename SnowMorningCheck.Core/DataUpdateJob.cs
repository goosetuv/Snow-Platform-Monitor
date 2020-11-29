using System.Collections.Generic;
using Laim;

namespace SnowPlatformMonitor.Core
{
    public class DataUpdateJob
    {
        public static List<string> GetJobStatus()
        {
            DirectoryConfiguration dc = new DirectoryConfiguration();
            ApplicationConfiguration ac = new ApplicationConfiguration();

            string ConnectionString = Utilities.Decrypt(Utilities.ReadXMLValue(dc.Config + ac.ServerConfig, "ConnectionString"));
            string ConnectionStringParameters = Utilities.Decrypt(Utilities.ReadXMLValue(dc.Config + ac.ServerConfig, "ConnectionStringParameters"));

            return MSSqlServer.ExecuteReadList(ConnectionString + ConnectionStringParameters, Resources.SqlScripts.DataUpdateJobStatus);

        }
    }
}
