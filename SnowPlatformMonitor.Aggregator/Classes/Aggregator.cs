using SnowPlatformMonitor.Aggregator.Classes.Modules;
using SnowPlatformMonitor.Core.Classes;
using SnowPlatformMonitor.Core.Configuration;
using System;
using System.Reflection;

namespace SnowPlatformMonitor.Aggregator.Classes
{
    public class Aggregator
    {

        readonly DirectoryConfiguration dc = new DirectoryConfiguration();
        readonly ApplicationConfiguration ac = new ApplicationConfiguration();
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(Aggregator));

        /// <summary>
        /// Run the Aggregator - Production Mode
        /// </summary>
        public void Run(RunMode rm)
        {
            try
            {
                if(rm == RunMode.NORMAL || rm == RunMode.TEST)
                {
                    log.Info($"Starting Aggregator in Run Mode {rm}");
                    string AppConfig = dc.Config + ac.AppConfig;
                    string ServerConfig = dc.Config + ac.ServerConfig;
                    log.Debug("Configuration variables set");

                    #region Log Retention Module
                    LogRetention logRetention = new LogRetention();
                    logRetention.Run();
                    #endregion

                    #region Garbage Collector Module
                    GarbageCollector garbageCollector = new GarbageCollector();
                    garbageCollector.Run();
                    #endregion

                    #region Set Variables
                    bool DataUpdateJobStatus = Convert.ToBoolean(Utilities.ReadXMLValue(AppConfig, "DataUpdateJobStatus"));
                    log.Debug("DataUpdateJobStatus bool value set");

                    bool Office365AdobeImportTables = Convert.ToBoolean(Utilities.ReadXMLValue(AppConfig, "Office365AdobeImportTables"));
                    log.Debug("Office365AdobeImportTables bool value set");

                    bool SRSImportDate = Convert.ToBoolean(Utilities.ReadXMLValue(AppConfig, "SRSImportDate"));
                    log.Debug("SRSImportDate bool value set");

                    bool LogInterrogator = Convert.ToBoolean(Utilities.ReadXMLValue(AppConfig, "LogInterrogator"));
                    log.Debug("LogInterrogator bool value set");

                    bool PlatformVersionCheck = Convert.ToBoolean(Utilities.ReadXMLValue(AppConfig, "PlatformVersionCheck"));
                    log.Debug("PlatformVersionCheck bool value set");

                    bool LicenseManagerServices = Convert.ToBoolean(Utilities.ReadXMLValue(AppConfig, "LicenseManagerServices"));
                    log.Debug("LicenseManagerServices bool value set");

                    bool LicenseManagerDeviceReporting = Convert.ToBoolean(Utilities.ReadXMLValue(AppConfig, "LicenseManagerDeviceReporting"));
                    log.Debug("LicenseManagerDeviceReporting bool value set");

                    bool LicenseManagerStorage = Convert.ToBoolean(Utilities.ReadXMLValue(AppConfig, "LicenseManagerStorage"));
                    log.Debug("LicenseManagerStorage bool value set");

                    bool InventoryServerServices = Convert.ToBoolean(Utilities.ReadXMLValue(AppConfig, "InventoryServerServices"));
                    log.Debug("InventoryServerServices bool value set");

                    bool InventoryServerStorage = Convert.ToBoolean(Utilities.ReadXMLValue(AppConfig, "InventoryServerStorage"));
                    log.Debug("InventoryServerStorage bool value set");

                    bool InventoryServerDeviceReporting = Convert.ToBoolean(Utilities.ReadXMLValue(AppConfig, "InventoryServerDeviceReporting"));
                    log.Debug("InventoryServerDeviceReporting bool value set");

                    bool InventoryServerProcessing = Convert.ToBoolean(Utilities.ReadXMLValue(AppConfig, "InventoryServerProcessing"));
                    log.Debug("InventoryServerProcessing bool value set");

                    string LicenseManagerServer = Utilities.ReadXMLValue(ServerConfig, "LicenseManager");
                    log.Debug("LicenseManagerServer string value set");

                    string InventoryServer = Utilities.ReadXMLValue(ServerConfig, "InventoryServer");
                    log.Debug("InventoryServer string value set");

                    log.Info("Configuration information has been loaded into memory");
                    #endregion

                    DataRetriever dataRetriever = new DataRetriever();
                    log.Info("Data Retriever has been initialized");

                    #region Exporters
                    log.Info("This might take a while, be patient...");
                    Console.WriteLine("This might take a while, be patient...");

                    // DUJ Status
                    try
                    {
                        if (DataUpdateJobStatus)
                        {
                            if (dataRetriever.GetDataUpdateJob())
                            {
                                log.Info("Data Update Job information exported");
                                Console.WriteLine("Data Update Job information exported");
                            }
                        }
                    }
                    catch (Exception ex) { log.Error(ex); }

                    // License Manager Services
                    try
                    {
                        if (LicenseManagerServices)
                        {
                            if (dataRetriever.GetWindowsServices("License Manager", LicenseManagerServer))
                            {
                                log.Info("Windows Services information exported for LicenseManager");
                                Console.WriteLine("Windows Services information exported for LicenseManager");
                            }
                        }
                    }
                    catch (Exception ex) { log.Error(ex); }

                    // Inventory Service Services
                    try
                    {
                        if (InventoryServerServices)
                        {
                            if (dataRetriever.GetWindowsServices("Inventory Server", InventoryServer))
                            {
                                log.Info("Windows Services information exported for InventoryServer");
                                Console.WriteLine("Windows Services information exported for InventoryServer");
                            }
                        }
                    }
                    catch (Exception ex) { log.Error(ex); }

                    // Inventory Server Storage
                    try
                    {
                        if (InventoryServerStorage)
                        {
                            if (dataRetriever.GetWindowsStorage("Inventory Server", InventoryServer))
                            {
                                log.Info("Windows Storage information exported for InventoryServer");
                                Console.WriteLine("Windows Storage information exported for InventoryServer");
                            }
                        }
                    }
                    catch (Exception ex) { log.Error(ex); }

                    // License Manager Storage
                    try
                    {
                        if (LicenseManagerStorage)
                        {
                            if (dataRetriever.GetWindowsStorage("License Manager", LicenseManagerServer))
                            {
                                log.Info("Windows Storage information exported for LicenseManager");
                                Console.WriteLine("Windows Storage information exported for LicenseManager");
                            }
                        }
                    }
                    catch (Exception ex) { log.Error(ex); }

                    // Office365 Adobe Import Tables
                    try
                    {
                        if (Office365AdobeImportTables)
                        {
                            if (dataRetriever.GetConnectorImportTables())
                            {
                                log.Info("Office 365 and Adobe Import tables exported");
                                Console.WriteLine("Office 365 and Adobe Import tables exported");
                            }
                        }
                    }
                    catch (Exception ex) { log.Error(ex); }

                    // Log Interrogator
                    try
                    {
                        if (LogInterrogator)
                        {
                            if (dataRetriever.GetSnowLogHealth())
                            {
                                log.Info("Snow Log Health exported");
                                Console.WriteLine("Snow Log Health exported");
                            }
                        }
                    }
                    catch (Exception ex) { log.Error(ex); }

                    // Platform Version Check
                    try
                    {
                        if (PlatformVersionCheck)
                        {
                            if (dataRetriever.GetProductVersions())
                            {
                                log.Info("Product Versions exported");
                                Console.WriteLine("Product Versions exported");
                            }
                        }
                    }
                    catch (Exception ex) { log.Error(ex); }

                    // License Manager Device Reporting
                    try
                    {
                        if (LicenseManagerDeviceReporting)
                        {
                            if (dataRetriever.GetReportedToday(slm: true))
                            {
                                log.Info("LicenseManager Device Reporting exported");
                                Console.WriteLine("LicenseManager Device Reporting exported");
                            }
                        }
                    }
                    catch (Exception ex) { log.Error(ex); }

                    // Inventory Server Device Reporting
                    try
                    {
                        if (InventoryServerDeviceReporting)
                        {
                            if (dataRetriever.GetReportedToday(sinv: true))
                            {
                                log.Info("SnowInventory Device Reporting exported");
                                Console.WriteLine("SnowInventory Device Reporting exported");
                            }
                        }
                    }
                    catch (Exception ex) { log.Error(ex); }

                    // SRS Import Date and Inventory Server Processing
                    try
                    {
                        if (SRSImportDate == true || InventoryServerProcessing == true)
                        {
                            if (dataRetriever.GetExtras(SRSImportDate, InventoryServerProcessing))
                            {
                                log.Info("GetExtras exported");
                                Console.WriteLine("GetExtras exported");
                            }
                        }
                    }
                    catch (Exception ex) { log.Error(ex); }
                    #endregion

                    #region Mailer

                    Mailer m = new Mailer();
                    string filename = dc.Export + dataRetriever.ExportName;
                    log.Info($"New mailer initialized in Run Mode {rm}");
                    Console.WriteLine($"New mailer initialized in Run Mode {rm}");

                    if (rm == RunMode.NORMAL)
                    {
                        m.SendEmail(filename, Assembly.GetExecutingAssembly().GetName().Version.ToString());
                    } else if(rm == RunMode.TEST)
                    {
                        m.SendEmail(filename, Assembly.GetExecutingAssembly().GetName().Version.ToString(), "TEST");
                    }
                    log.Debug("Email command sent");

                    #endregion

                    log.Info($"Aggregation finished");
                    Console.WriteLine($"Aggregation finished");
                }
            }
            catch (Exception ex)
            {
                log.Fatal(ex);
                Mailer m = new Mailer();
                m.SendFailureAlert("Failure to export" + Environment.NewLine + ex.Message + ex.StackTrace + Environment.NewLine + " Please investigate!");
            }
        }
    }
}
