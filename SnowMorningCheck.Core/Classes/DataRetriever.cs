using System;
using System.Data;
using System.Drawing;
using System.IO;
using Laim;
using OfficeOpenXml;
using SnowPlatformMonitor.Core.Configuration;

namespace SnowPlatformMonitor.Core.Classes
{
    public class DataRetriever
    {
        private readonly DirectoryConfiguration dc = new DirectoryConfiguration();
        private readonly ApplicationConfiguration ac = new ApplicationConfiguration();
        private readonly string ExportName = "-SnowPlatformMonitor.xlsx";

        internal DataTable RunResourceDataTable(string resourceName, string connectionString)
        {           
            return MSSqlServer.ExecuteReadDataTable(connectionString, Resources.SqlScripts.ResourceManager.GetString(resourceName));
        }

        public bool GetDataUpdateJob()
        {
            // decrypt the connection string
            string ConnectionString = Utilities.Decrypt(Utilities.ReadXMLValue(dc.Config + ac.ServerConfig, "ConnectionString"));
            string ConnectionStringParameters = Utilities.Decrypt(Utilities.ReadXMLValue(dc.Config + ac.ServerConfig, "ConnectionStringParameters"));

            // pull the duj data into data tables
            DataTable DataUpdateJobStatus = RunResourceDataTable("DataUpdateJobStatus", ConnectionString + ConnectionStringParameters);
            DataTable DataUpdateJobErrorLog = RunResourceDataTable("DataUpdateJobErrorLog", ConnectionString + ConnectionStringParameters);
            DataTable DataUpdateJobErrorSevere = RunResourceDataTable("DataUpdateJobErrorSevere", ConnectionString + ConnectionStringParameters);
            DataTable DataUpdateJobParallel = RunResourceDataTable("DataUpdateJobParallel", ConnectionString + ConnectionStringParameters);

            // create a work book and add the duj data into their own seperate sheets
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage pck = new ExcelPackage(new FileInfo(dc.Export + DateTime.Now.ToString("ddMMyyyy") + ExportName)))
            {
                pck.Workbook.Worksheets.Add("Status").Cells["A1"].LoadFromDataTable(DataUpdateJobStatus, true);
                pck.Workbook.Worksheets.Add("Error Log").Cells["A1"].LoadFromDataTable(DataUpdateJobErrorLog, true);
                pck.Workbook.Worksheets.Add("Error Severe").Cells["A1"].LoadFromDataTable(DataUpdateJobErrorSevere, true);
                pck.Workbook.Worksheets.Add("Parallel Step").Cells["A1"].LoadFromDataTable(DataUpdateJobParallel, true);

                TabColor(pck);
                    
                pck.Save();
            }

            if(File.Exists(dc.Export + DateTime.Now.ToString("ddMMyyyy") + ExportName))
            {
                return true;
            } else {
                return false;
            }
        }

        /// <summary>
        /// Returns the amount of rows in a worksheet, excl. headers
        /// </summary>
        /// <param name="sheet">ExcelWorksheet from an ExcelWorkbook</param>
        /// <returns></returns>
        internal int GetDimensionRows(ExcelWorksheet sheet)
        {
            var startRow = sheet.Dimension.Start.Row;
            var endRow = sheet.Dimension.End.Row;
            return endRow - startRow;
        }

        /// <summary>
        /// Changes the tab color of an ExcelWorksheet if it has more than 0 rows
        /// </summary>
        /// <param name="pck">The ExcelPackage</param>
        /// <returns></returns>
        internal ExcelPackage TabColor(ExcelPackage pck)
        {
            foreach (ExcelWorksheet worksheet in pck.Workbook.Worksheets)
            {
                if (GetDimensionRows(worksheet) > 0)
                {
                    worksheet.TabColor = Color.Red;
                }
                else
                {
                    worksheet.TabColor = Color.Green;
                }
            }

            return pck;
        }


        public string GetInventoryDirectoryCount()
        {
            InventoryServer inventoryServer = new InventoryServer();
            return inventoryServer.ProcessingDirectory();
        }
    }
}
