using System;
using System.Data;
using System.IO;
using Laim;
using OfficeOpenXml;

namespace SnowPlatformMonitor.Core
{
    public class DataUpdateJob
    {
        private readonly DirectoryConfiguration dc = new DirectoryConfiguration();
        private readonly ApplicationConfiguration ac = new ApplicationConfiguration();

        internal DataTable RunResourceScript(string resourceName, string connectionString)
        {           
            return MSSqlServer.ExecuteReadDataTable(connectionString, Resources.SqlScripts.ResourceManager.GetString(resourceName));
        }

        public bool GetExport()
        {
                // decrypt the connection string
                string ConnectionString = Utilities.Decrypt(Utilities.ReadXMLValue(dc.Config + ac.ServerConfig, "ConnectionString"));
                string ConnectionStringParameters = Utilities.Decrypt(Utilities.ReadXMLValue(dc.Config + ac.ServerConfig, "ConnectionStringParameters"));

                // pull the duj data into data tables
                DataTable DataUpdateJobStatus = RunResourceScript("DataUpdateJobStatus", ConnectionString + ConnectionStringParameters);
                DataTable DataUpdateJobErrorLog = RunResourceScript("DataUpdateJobErrorLog", ConnectionString + ConnectionStringParameters);
                DataTable DataUpdateJobErrorSevere = RunResourceScript("DataUpdateJobErrorSevere", ConnectionString + ConnectionStringParameters);
                DataTable DataUpdateJobParallel = RunResourceScript("DataUpdateJobParallel", ConnectionString + ConnectionStringParameters);

                // create a work book and add the duj data into their own seperate sheets
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (ExcelPackage pck = new ExcelPackage(new FileInfo(dc.Export + DateTime.Now.ToString("ddMMyyyy") + "-DataUpdateJob.xlsx")))
                {
                    pck.Workbook.Worksheets.Add("Status").Cells["A1"].LoadFromDataTable(DataUpdateJobStatus, true);
                    pck.Workbook.Worksheets.Add("Error Log").Cells["A1"].LoadFromDataTable(DataUpdateJobErrorLog, true);
                    pck.Workbook.Worksheets.Add("Error Severe").Cells["A1"].LoadFromDataTable(DataUpdateJobErrorSevere, true);
                    pck.Workbook.Worksheets.Add("Parallel Step").Cells["A1"].LoadFromDataTable(DataUpdateJobParallel, true);
                    pck.Save();
                }

                if(File.Exists(dc.Export + DateTime.Now.ToString("ddMMyyyy") + "-DataUpdateJob.xlsx"))
                {
                    return true;
                } else
                {
                    return false;
                }
        }
    }
}
