#region Dependencies
using System;
using System.Data;
using System.Drawing;
using System.IO;
using Laim;
using OfficeOpenXml;
using SnowPlatformMonitor.Core.Configuration;
#endregion

namespace SnowPlatformMonitor.Core.Classes
{
    public class DataRetriever
    {
        #region Fields
        private readonly DirectoryConfiguration dc = new DirectoryConfiguration();
        private readonly ApplicationConfiguration ac = new ApplicationConfiguration();
        public readonly string ExportName = "-SnowPlatformMonitor.xlsx";
        public readonly string DateFormat = "ddMMyyyy";
        #endregion

        public bool GetDataUpdateJob()
        {
            SqlRunner sqlRunner = new SqlRunner();

            // create a work book and add the duj data into their own seperate sheets
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage pck = new ExcelPackage(new FileInfo(dc.Export + DateTime.Now.ToString(DateFormat) + ExportName)))
            {
                pck.Workbook.Worksheets.Add("Status").Cells["A1"].LoadFromDataTable(sqlRunner.RunSQLDataTable("DataUpdateJobStatus"), true).AutoFitColumns();
                pck.Workbook.Worksheets.Add("Error Log").Cells["A1"].LoadFromDataTable(sqlRunner.RunSQLDataTable("DataUpdateJobErrorLog"), true).AutoFitColumns();
                pck.Workbook.Worksheets.Add("Error Severe").Cells["A1"].LoadFromDataTable(sqlRunner.RunSQLDataTable("DataUpdateJobErrorSevere"), true).AutoFitColumns();
                pck.Workbook.Worksheets.Add("Parallel Step").Cells["A1"].LoadFromDataTable(sqlRunner.RunSQLDataTable("DataUpdateJobParallel"), true).AutoFitColumns();

                TabColor(pck, "RowCount");

                pck.Save();
            }

            if(File.Exists(dc.Export + DateTime.Now.ToString(DateFormat) + ExportName))
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
            using (ExcelPackage pck = new ExcelPackage(new FileInfo(dc.Export + DateTime.Now.ToString(DateFormat) + ExportName)))
            {
                pck.Workbook.Worksheets.Add("Office 365").Cells["A1"].LoadFromDataTable(licenseManager.Office365Import(), true).AutoFitColumns();
                pck.Workbook.Worksheets.Add("Adobe Creative Cloud").Cells["A1"].LoadFromDataTable(licenseManager.AdobeImport(), true).AutoFitColumns();
                TabColor(pck, "RowCount");

                pck.Save();
            }

            if (File.Exists(dc.Export + DateTime.Now.ToString(DateFormat) + ExportName))
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
            using (ExcelPackage pck = new ExcelPackage(new FileInfo(dc.Export + DateTime.Now.ToString(DateFormat) + ExportName)))
            {
                if(slm)
                {
                    pck.Workbook.Worksheets.Add("SLM DeviceReporting (Yday)").Cells["A1"].LoadFromDataTable(licenseManager.ReportedYesterday(), true).AutoFitColumns();
                    TabColor(pck, "DeviceReporting", Convert.ToInt32(XmlConfigurator.Read(dc.Config + ac.AppConfig, "LicenseManagerDeviceThreshold")), "SLM DeviceReporting (Yday)");
                }

                if(sinv)
                {
                    pck.Workbook.Worksheets.Add("SINV DeviceReporting (Today)").Cells["A1"].LoadFromDataTable(inventoryServer.ReportedToday(), true).AutoFitColumns();
                    TabColor(pck, "DeviceReporting", Convert.ToInt32(XmlConfigurator.Read(dc.Config + ac.AppConfig, "InventoryServerDeviceThreshold")), "SINV DeviceReporting (Today)");
                }
                pck.Save();
            }

            if (File.Exists(dc.Export + DateTime.Now.ToString(DateFormat) + ExportName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool GetServices(string type, string hostname)
        {
            WindowsServices windowsServices = new WindowsServices();

            DataTable dtWindowsServices = windowsServices.GetServices(hostname);

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage pck = new ExcelPackage(new FileInfo(dc.Export + DateTime.Now.ToString(DateFormat) + ExportName)))
            {
                pck.Workbook.Worksheets.Add(type + " Services").Cells["A1"].LoadFromDataTable(dtWindowsServices, true).AutoFitColumns();
                TabColor(pck, "ServiceCheck");
                pck.Save();
            }

            if (File.Exists(dc.Export + DateTime.Now.ToString(DateFormat) + ExportName))
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
        internal ExcelPackage TabColor(ExcelPackage pck, string type, int rowCount = 0, string worksheetName = "")
        {
            foreach (ExcelWorksheet worksheet in pck.Workbook.Worksheets)
            {
                if(type == "RowCount")
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

                if (type == "DeviceReporting" && worksheet.Name == worksheetName)
                {
                    if (GetDimensionRows(worksheet) < rowCount)
                    {
                        worksheet.TabColor = Color.Red;
                    }
                    else
                    {
                        worksheet.TabColor = Color.Green;
                    }
                }

                if (type == "ServiceCheck")
                {
                    bool StoppedService = false;

                    foreach (var worksheetCell in worksheet.Cells)
                    {
                        if (worksheetCell.Value.ToString() == "Stopped")
                        {
                            StoppedService = true;
                        }
                    }

                    if(StoppedService == true)
                    {
                        worksheet.TabColor = Color.Red;
                    } else
                    {
                        worksheet.TabColor = Color.Green;
                    }
                }
            }

            return pck;
        }
    }
}
