using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SnowPlatformMonitor.Core.Classes
{
    public class SnowAPI
    {

        /// <summary>
        /// Gets the data from the API
        /// </summary>
        /// <param name="type">json, raw, xml</param>
        /// <returns></returns>
        public IRestResponse GetDataFromAPI(string type = "xml")
        {
            var client = new RestClient("https://ext.laim.scot/snowapi/api/1.0/?format=" + type)
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            return (response);
        }

        /// <summary>
        /// Does the platform version check
        /// </summary>
        /// <param name="UserVersion">Local app version</param>
        /// <param name="APIVersion">Versio from the API</param>
        /// <returns></returns>
        public static bool VersionCheck(string UserVersion, string APIVersion)
        {
            var Latest = new Version(APIVersion);
            var Installed = new Version(UserVersion);

            if (Latest.CompareTo(Installed) > 0)
            {
                return true;
            }
            else if (Latest.CompareTo(Installed) < 0)
            {
                return false;
            }
            else
            {
                return false;
            }
        }

        public DataTable IsUpdateRequired()
        {
            XmlDocument doc = new XmlDocument();
            DataTable dt = new DataTable();
            SqlRunner sql = new SqlRunner();

            var o = GetDataFromAPI().Content;
            doc.LoadXml(o);

            dt.Columns.Add("Type");
            dt.Columns.Add("Current Version");
            dt.Columns.Add("Latest Version");
            dt.Columns.Add("Update Required");

            foreach (XmlNode appNode in doc.DocumentElement.ChildNodes)
            {
                if (appNode.InnerText.Contains("Snow License Manager 9"))
                {
                    foreach (XmlNode versionNode in appNode.ChildNodes)
                    {
                        if (versionNode.Name == "Version")
                        {
                            DataRow dr = dt.NewRow();
                            string SVRLicenseManagerVersion = sql.RunSQLString("LicenseManagerVersion");
                            dr["Type"] = "Snow License Manager";
                            dr["Current Version"] = SVRLicenseManagerVersion;
                            dr["Latest Version"] = versionNode.InnerText;
                            dr["Update Required"] = VersionCheck(SVRLicenseManagerVersion, versionNode.InnerText);
                            dt.Rows.Add(dr);
                        }
                    }
                }

                if (appNode.InnerText.Contains("Snow Inventory Server 6"))
                {
                    foreach (XmlNode versionNode in appNode.ChildNodes)
                    {
                        if (versionNode.Name == "Version")
                        {
                            DataRow dr = dt.NewRow();
                            string SVRInventoryServerVersion = sql.RunSQLString("InventoryServerVersion");
                            dr["Type"] = "Snow Inventory Server";
                            dr["Current Version"] = SVRInventoryServerVersion;
                            dr["Latest Version"] = versionNode.InnerText;
                            dr["Update Required"] = VersionCheck(SVRInventoryServerVersion, versionNode.InnerText);
                            dt.Rows.Add(dr);
                        }
                    }
                }
            }

            return dt;
        }
    }
}
