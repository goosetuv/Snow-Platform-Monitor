#region Dependencies
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using Laim;
using OfficeOpenXml;
using OfficeOpenXml.Table;
using SnowPlatformMonitor.Core.Configuration;
#endregion

namespace SnowPlatformMonitor.Core.Classes
{
    // TODO (All): Change validation for when a function runs instead of checking if the file exists lol
    // TODO (TabColor):
    //      This method really isn't pretty, it gets the job done but it definitely has a performance impact (it must do...)
    //      This needs updated eventually to a nicer method because it's a mess

    public class DataRetriever
    {
        #region Fields
        private readonly DirectoryConfiguration dc = new DirectoryConfiguration();
        private readonly ApplicationConfiguration ac = new ApplicationConfiguration();
        public readonly string ExportName = Utilities.GenerateGUID() +".xlsx";
        private readonly TableStyles tableStyle = TableStyles.Light20;
        #endregion

        /// <summary>
        /// Gets the data update job data
        /// </summary>
        /// <returns>Excel Spreadsheet</returns>
        public bool GetDataUpdateJob()
        {

            SqlRunner sqlRunner = new SqlRunner();

            // create a work book and add the duj data into their own seperate sheets
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage pck = new ExcelPackage(new FileInfo(dc.Export + ExportName)))
            {
                pck.Workbook.Worksheets.Add("Status").Cells["A1"].LoadFromDataTable(sqlRunner.RunSQLDataTable("DataUpdateJobStatus"), true, tableStyle).AutoFitColumns();
                pck.Workbook.Worksheets.Add("Error Log").Cells["A1"].LoadFromDataTable(sqlRunner.RunSQLDataTable("DataUpdateJobErrorLog"), true, tableStyle).AutoFitColumns();
                pck.Workbook.Worksheets.Add("Error Severe").Cells["A1"].LoadFromDataTable(sqlRunner.RunSQLDataTable("DataUpdateJobErrorSevere"), true, tableStyle).AutoFitColumns();
                pck.Workbook.Worksheets.Add("Parallel Step").Cells["A1"].LoadFromDataTable(sqlRunner.RunSQLDataTable("DataUpdateJobParallel"), true, tableStyle).AutoFitColumns();

                TabColor(pck, "RowCount", wsName: "Status");
                TabColor(pck, "RowCount", wsName: "Error Log");
                TabColor(pck, "RowCount", wsName: "Error Severe");
                TabColor(pck, "RowCount", wsName: "Parallel Step");

                pck.Save();
            }

            if(File.Exists(dc.Export + ExportName))
            {
                return true;
            } else {
                return false;
            }
        }

        /// <summary>
        /// Returns the Adobe and Office 365 Import Tables
        /// </summary>
        /// <returns></returns>
        public bool GetConnectorImportTables()
        {
            LicenseManager licenseManager = new LicenseManager();

            // create a work book and add the duj data into their own seperate sheets
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage pck = new ExcelPackage(new FileInfo(dc.Export + ExportName)))
            {
                pck.Workbook.Worksheets.Add("Office 365").Cells["A1"].LoadFromDataTable(licenseManager.Office365Import(), true, tableStyle).AutoFitColumns();
                pck.Workbook.Worksheets.Add("Adobe Creative Cloud").Cells["A1"].LoadFromDataTable(licenseManager.AdobeImport(), true, tableStyle).AutoFitColumns();
                TabColor(pck, "RowCount", wsName: "Office 365");
                TabColor(pck, "RowCount", wsName: "Adobe Creative Cloud");

                pck.Save();
            }

            if (File.Exists(dc.Export + ExportName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Returns inventoried devices today/yesterday for Inventory and SLM
        /// </summary>
        /// <returns></returns>
        public bool GetReportedToday(bool slm = false, bool sinv = false)
        {
            InventoryServer inventoryServer = new InventoryServer();
            LicenseManager licenseManager = new LicenseManager();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage pck = new ExcelPackage(new FileInfo(dc.Export + ExportName)))
            {
                if(slm)
                {
                    pck.Workbook.Worksheets.Add("SLM DeviceReporting (Yday)").Cells["A1"].LoadFromDataTable(licenseManager.ReportedYesterday(), true, tableStyle).AutoFitColumns();
                    TabColor(pck, "Default", Convert.ToInt32(XmlConfigurator.Read(dc.Config + ac.AppConfig, "LicenseManagerDeviceThreshold")), "SLM DeviceReporting (Yday)");
                }

                if(sinv)
                {
                    pck.Workbook.Worksheets.Add("SINV DeviceReporting (Today)").Cells["A1"].LoadFromDataTable(inventoryServer.ReportedToday(), true, tableStyle).AutoFitColumns();
                    TabColor(pck, "Default", Convert.ToInt32(XmlConfigurator.Read(dc.Config + ac.AppConfig, "InventoryServerDeviceThreshold")), "SINV DeviceReporting (Today)");
                }
                pck.Save();
            }

            if (File.Exists(dc.Export + ExportName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Returns the services and their status from the chosen server
        /// </summary>
        /// <param name="type">SLM or SINV</param>
        /// <param name="hostname">Server Name</param>
        /// <returns></returns>
        public bool GetWindowsServices(string type, string hostname)
        {
            WindowsServices windowsServices = new WindowsServices();

            DataTable dtWindowsServices = windowsServices.GetServices(hostname);

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage pck = new ExcelPackage(new FileInfo(dc.Export + ExportName)))
            {
                pck.Workbook.Worksheets.Add(type + " Services").Cells["A1"].LoadFromDataTable(dtWindowsServices, true, tableStyle).AutoFitColumns();
                TabColor(pck, "ServiceCheck", wsName: type + " Services");
                pck.Save();
            }

            if (File.Exists(dc.Export + ExportName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Returns the additional methods that need added into a datatable (such as, DirectoryCount, SRSImportDate etc.)
        /// </summary>
        /// <returns></returns>
        public bool GetExtras(bool SRS, bool InventoryCount)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Component");
            dt.Columns.Add("Value");
            if(SRS)
            {
                dt.Rows.Add("SRSImportDate", GetSRSImportDate());
            }
            if(InventoryCount)
            {
                dt.Rows.Add("InventoryDirectoryCount", GetInventoryDirectoryCount());
            }

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage pck = new ExcelPackage(new FileInfo(dc.Export + ExportName)))
            {
                pck.Workbook.Worksheets.Add("Extras").Cells["A1"].LoadFromDataTable(dt, true, tableStyle).AutoFitColumns();
                TabColor(pck, "Default", wsName: "Extras");
                pck.Save();
            }

            if (File.Exists(dc.Export + ExportName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetInventoryDirectoryCount()
        {
            InventoryServer inventoryServer = new InventoryServer();
            return inventoryServer.ProcessingDirectory();
        }

        public string GetSRSImportDate()
        {
            LicenseManager licenseManager = new LicenseManager();
            return licenseManager.SRSImportDate();
        }

        /// <summary>
        /// Gets the health status of log files, i.e if they contain ERROR, ERR, FATAL or FATL
        /// </summary>
        /// <returns></returns>
        public bool GetSnowLogHealth()
        {
            string ServerName = Utilities.ReadXMLValue(dc.Config + ac.ServerConfig, "LicenseManager");
            string ServerPath = @"\\" + ServerName + @"\" + Utilities.ReadXMLValue(dc.Config + ac.ServerConfig, "LicenseManagerDrive") + @"$\";

            List<string> directoryList = new List<string>
            {
                ServerPath + Utilities.ReadXMLValue(dc.Config + ac.AppConfig, "LicenseManagerWebLogs"),
                ServerPath + Utilities.ReadXMLValue(dc.Config + ac.AppConfig, "LicenseManagerServicesLogs")
            };

            SnowLogs sl = new SnowLogs();

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage pck = new ExcelPackage(new FileInfo(dc.Export + ExportName)))
            {
                int directoryCounter = 0;
                foreach(string directory in directoryList)
                {
                    directoryCounter += 1;
                    pck.Workbook.Worksheets.Add("Log Interrogator " + directoryCounter).Cells["A1"].LoadFromDataTable(sl.GetLogData(directory), true, tableStyle).AutoFitColumns();
                    TabColor(pck, "LogInterrogator", wsName: "Log Interrogator " + directoryCounter);
                    pck.Save();
                }
            }

            if (File.Exists(dc.Export + ExportName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool GetProductVersions()
        {
            SnowAPI snowAPI = new SnowAPI();

            DataTable dt = snowAPI.IsUpdateRequired(); 

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage pck = new ExcelPackage(new FileInfo(dc.Export + ExportName)))
            {
                pck.Workbook.Worksheets.Add("Versions").Cells["A1"].LoadFromDataTable(dt, true, tableStyle).AutoFitColumns();
                TabColor(pck, "LogInterrogator", wsName: "Versions");
                pck.Save();
            }

            if (File.Exists(dc.Export + ExportName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Returns the storage from the chosen server
        /// </summary>
        /// <param name="type">SLM or SINV</param>
        /// <param name="hostname">Server Name</param>
        /// <returns></returns>
        public bool GetWindowsStorage(string type, string hostname)
        {
            WindowsStorage windowsStorage = new WindowsStorage();

            DataTable dtWindowsStorage = windowsStorage.GetWindowStorage(hostname, "Win32_LogicalDisk");

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage pck = new ExcelPackage(new FileInfo(dc.Export + ExportName)))
            {
                pck.Workbook.Worksheets.Add(type + " Storage").Cells["A1"].LoadFromDataTable(dtWindowsStorage, true, tableStyle).AutoFitColumns();
                TabColor(pck, "Default", wsName: type + " Storage");
                pck.Save();
            }

            if (File.Exists(dc.Export + ExportName))
            {
                return true;
            }
            else
            {
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
        /// <param name="pck">Excel Package</param>
        /// <param name="type">The type of sheet</param>
        /// <param name="rowCount">How many rows the sheet should have (default: 0)</param>
        /// <param name="wsName">The name of the specific worksheet (default: blank)</param>
        /// <returns></returns>
        internal ExcelPackage TabColor(ExcelPackage pck, string type, int rowCount = 0, string wsName = "")
        {
            switch (type)
            {
                case "RowCount":
                    foreach (ExcelWorksheet ws in pck.Workbook.Worksheets)
                    {
                        if(ws.Name == wsName)
                        {
                            if (GetDimensionRows(ws) > 0)
                            {
                                ws.TabColor = Color.Red;
                            }
                            else
                            {
                                ws.TabColor = Color.Green;
                            }
                        }
                    }
                    return pck;
                    //break;
                //case "DeviceReporting":
                //    foreach (ExcelWorksheet ws in pck.Workbook.Worksheets)
                //    {
                //        if(ws.Name == wsName)
                //        {
                //            if (GetDimensionRows(ws) < rowCount)
                //            {
                //                ws.TabColor = Color.Red;
                //            }
                //            else
                //            {
                //                ws.TabColor = Color.Green;
                //            }
                //        }
                //    }
                //    return pck;
                    //break;
                case "ServiceCheck":
                    foreach (ExcelWorksheet ws in pck.Workbook.Worksheets)
                    {
                        if(ws.Name == wsName)
                        {
                            bool StoppedService = false;

                            foreach (var worksheetCell in ws.Cells)
                            {
                                if (worksheetCell.Value.ToString() == "Stopped")
                                {
                                    StoppedService = true;
                                }
                            }

                            if (StoppedService == true)
                            {
                                ws.TabColor = Color.Red;
                            }
                            else
                            {
                                ws.TabColor = Color.Green;
                            }
                        }
                    }
                    return pck;
                //break;
                case "LogInterrogator":
                    foreach (ExcelWorksheet ws in pck.Workbook.Worksheets)
                    {
                        if (ws.Name == wsName)
                        {
                            bool TrueValuePresent = false;

                            foreach (var worksheetCell in ws.Cells)
                            {
                                if (worksheetCell.Value.ToString() == "True")
                                {
                                    TrueValuePresent = true;
                                }
                            }

                            if (TrueValuePresent == true)
                            {
                                ws.TabColor = Color.Red;
                            }
                            else
                            {
                                ws.TabColor = Color.Green;
                            }
                        }
                    }
                    return pck;
                //break;
                case "Default":
                    foreach (ExcelWorksheet ws in pck.Workbook.Worksheets)
                    {
                        if(ws.Name == wsName)
                        {
                            ws.TabColor = Color.Orange;
                        }
                    }
                    return pck;
                    //break;
                default:
                    foreach (ExcelWorksheet ws in pck.Workbook.Worksheets)
                    {
                        ws.TabColor = Color.Orange;
                    }
                    return pck;
                    //break;
            }
        }
    }
}
