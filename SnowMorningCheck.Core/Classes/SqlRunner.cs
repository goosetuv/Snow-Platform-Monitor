#region Dependencies
using Laim;
using SnowPlatformMonitor.Core.Configuration;
using System.Data;
#endregion

namespace SnowPlatformMonitor.Core.Classes
{
    public class SqlRunner
    {
        #region Fields
        private readonly DirectoryConfiguration dc = new DirectoryConfiguration();
        private readonly ApplicationConfiguration ac = new ApplicationConfiguration();
        #endregion

        public DataTable RunSQLDataTable(string resourceName)
        {
            // decrypt the connection string
            string ConnectionString = Utilities.Decrypt(Utilities.ReadXMLValue(dc.Config + ac.ServerConfig, "ConnectionString"));
            string ConnectionStringParameters = Utilities.Decrypt(Utilities.ReadXMLValue(dc.Config + ac.ServerConfig, "ConnectionStringParameters"));

            return RunResourceDataTable(resourceName, ConnectionString + ConnectionStringParameters);
        }

        public string RunSQLString(string resourceName)
        {
            // decrypt the connection string
            string ConnectionString = Utilities.Decrypt(Utilities.ReadXMLValue(dc.Config + ac.ServerConfig, "ConnectionString"));
            string ConnectionStringParameters = Utilities.Decrypt(Utilities.ReadXMLValue(dc.Config + ac.ServerConfig, "ConnectionStringParameters"));

            return RunResourceString(resourceName, ConnectionString + ConnectionStringParameters);
        }

        internal DataTable RunResourceDataTable(string resourceName, string connectionString)
        {
            return MSSqlServer.ExecuteReadDataTable(connectionString, Resources.SqlScripts.ResourceManager.GetString(resourceName));
        }

        internal string RunResourceString(string resourceName, string connectionString)
        {
            return MSSqlServer.ExecuteReadString(connectionString, Resources.SqlScripts.ResourceManager.GetString(resourceName));
        }
    }
}
