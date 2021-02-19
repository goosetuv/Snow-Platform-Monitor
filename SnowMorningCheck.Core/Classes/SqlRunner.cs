#region Dependencies
using Laim;
using SnowPlatformMonitor.Core.Configuration;
using System.Data;
using System.IO;
#endregion

namespace SnowPlatformMonitor.Core.Classes
{
    public class SqlRunner
    {
        #region Fields
        private readonly DirectoryConfiguration dc = new DirectoryConfiguration();
        private readonly ApplicationConfiguration ac = new ApplicationConfiguration();
        private readonly string SqlResourceFileName = "sql.resource";
        #endregion

        public void OnLoad()
        {
            if (!File.Exists(dc.Resources + SqlResourceFileName))
            {
                File.WriteAllText(dc.Resources + SqlResourceFileName, Properties.Resources.sqlresource);
            }
        }

        // Runs a SQL Script and returns it as a DataTable based on resourceName (uses VS Resources)
        public DataTable RunSQLDataTable(string resourceName)
        {
            // decrypt the connection string
            string ConnectionString = Utilities.Decrypt(Utilities.ReadXMLValue(dc.Config + ac.ServerConfig, "ConnectionString"));
            string ConnectionStringParameters = Utilities.Decrypt(Utilities.ReadXMLValue(dc.Config + ac.ServerConfig, "ConnectionStringParameters"));

            return RunResourceDataTable(resourceName, ConnectionString + ConnectionStringParameters);
        }

        // Runs a SQL Script and returns it as a string based on resourceName (uses VS Resources)
        public string RunSQLString(string resourceName)
        {
            // decrypt the connection string
            string ConnectionString = Utilities.Decrypt(Utilities.ReadXMLValue(dc.Config + ac.ServerConfig, "ConnectionString"));
            string ConnectionStringParameters = Utilities.Decrypt(Utilities.ReadXMLValue(dc.Config + ac.ServerConfig, "ConnectionStringParameters"));

            return RunResourceString(resourceName, ConnectionString + ConnectionStringParameters);
        }

        internal DataTable RunResourceDataTable(string resourceName, string connectionString)
        {
            return MSSqlServer.ExecuteReadDataTable(connectionString, Utilities.ReadXMLValue(dc.Resources + SqlResourceFileName, resourceName, "Resource"));
            //return MSSqlServer.ExecuteReadDataTable(connectionString, Resources.SqlScripts.ResourceManager.GetString(resourceName));
        }

        internal string RunResourceString(string resourceName, string connectionString)
        {
            return MSSqlServer.ExecuteReadString(connectionString, Utilities.ReadXMLValue(dc.Resources + SqlResourceFileName, resourceName, "Resource"));
            //return MSSqlServer.ExecuteReadString(connectionString, Resources.SqlScripts.ResourceManager.GetString(resourceName));
        }
    }
}
