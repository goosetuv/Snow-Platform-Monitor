﻿#region Dependencies
using System;
using System.Reflection;
using System.ServiceProcess;
using System.Threading;
using System.Xml;
using SnowPlatformMonitor.Core.Classes;
using SnowPlatformMonitor.Core.Configuration;
#endregion

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace SnowPlatformMonitor.Service
{
    public partial class SnowPlatformMonitor : ServiceBase
    {

        #region Fields
        private Timer _timer = null;
        readonly DirectoryConfiguration dc = new DirectoryConfiguration();
        readonly ApplicationConfiguration ac = new ApplicationConfiguration();
        private double firstExecution;
        public static string ServiceVersion { get; private set; }
        private bool Configured = false;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(SnowPlatformMonitor));
        #endregion

        #region Constructor
        public SnowPlatformMonitor()
        {
            InitializeComponent();
        }
        #endregion

        #region Service Events
        protected override void OnStart(string[] args)
        {
            try
            {
                ServiceVersion = typeof(Program).Assembly.GetName().Version.ToString();

                log.Info(string.Format("Version: {0}", ServiceVersion));
                log.Info("Service is starting up...");

                InitializeConfiguration();

                if(Configured == true)
                {
                    InitializeSchedule();
                } else
                {
                    log.Info("Exports are not configured, the service will now stop");
                    Stop();
                }

            } catch (Exception ex)
            {
                log.Fatal(ex);
                Stop();
            }
        }

        protected override void OnStop()
        {
            log.Info("Service has been shutdown");
        }
        #endregion

        #region Functions
        protected void InitializeSchedule()
        {
            try
            {
                int Hours = Convert.ToInt32(Utilities.ReadXMLValue(dc.Config + ac.AppConfig, "ScheduleHours"));
                int Minutes = Convert.ToInt32(Utilities.ReadXMLValue(dc.Config + ac.AppConfig, "ScheduleMinutes"));
                int Seconds = Convert.ToInt32(Utilities.ReadXMLValue(dc.Config + ac.AppConfig, "ScheduleSeconds"));
                int FrequencyHours = 24;
                int FrequencyMinutes = 0;
                int FrequencySeconds = 0;

                log.Info(string.Format("Schedule loaded from configuration file, run at {0:00}:{1:00}:{2:00} every {3:00}h{4:00}m{5:00}s.", Hours, Minutes, Seconds, FrequencyHours, FrequencyMinutes, FrequencySeconds));

                ServiceSchedule(new TimeSpan(Hours, Minutes, Seconds), new TimeSpan(FrequencyHours, FrequencyMinutes, FrequencySeconds));
            } catch (Exception ex)
            {
                log.Fatal(ex);
                Stop();
            }
        }

        protected void InitializeConfiguration()
        {
            try
            {
                //Load the XML file in XmlDocument.
                XmlDocument doc = new XmlDocument();
                doc.Load(dc.Config + ac.AppConfig);

                //Fetch all the Nodes.
                XmlNodeList nodeList = doc.SelectNodes("//text()");

                //Loop through the Nodes.
                foreach (XmlNode node in nodeList)
                {
                    //Fetch the Node's Name and InnerText values.
                    log.Debug(string.Format("{0} : {1}", node.ParentNode.Name, node.InnerText));

                    if(node.InnerText.ToLower() == "true")
                    {
                        Configured = true;
                    }
                }

            } catch (Exception ex)
            {
                log.Fatal(ex);
                Stop(); 
            }
        }

        protected void ServiceSchedule(TimeSpan scheduledRunTime, TimeSpan timeBetweenEachRun)
        {
           try
            {
                // Initialize timer
                double current = DateTime.Now.TimeOfDay.TotalMilliseconds;
                double scheduledTime = scheduledRunTime.TotalMilliseconds;
                double intervalPeriod = timeBetweenEachRun.TotalMilliseconds;
                // calculates the first execution of the method, either its today at the scheduled time or tomorrow (if scheduled time has already occurred today)
                firstExecution = current > scheduledTime ? intervalPeriod - (current - scheduledTime) : scheduledTime - current;

                // create callback - this is the method that is called on every interval
                TimerCallback callback = new TimerCallback(ServiceExporter);

                // create timer
                _timer = new Timer(callback, null, Convert.ToInt32(firstExecution), Convert.ToInt32(intervalPeriod));

                // Add some log events so the user knows what's actually happening 
                log.Info(string.Format("Next run is scheduled for - {0}.", DateTime.Now.AddMilliseconds(firstExecution).ToString()));
            } catch (Exception ex)
            {
                log.Fatal(ex);
                Stop();
            }
        }

        /// <summary>
        /// Used for pulling the data that has been selected in the configuration
        /// </summary>
        /// <param name="state"></param>
        public void ServiceExporter(object state = null)
        {
            try
            {
                log.Info("Starting Module");
                string AppConfig = dc.Config + ac.AppConfig;
                string ServerConfig = dc.Config + ac.ServerConfig;
                log.Debug("AppConfig and ServerConfig set");

                #region Set Variables
                bool DataUpdateJobStatus = Convert.ToBoolean(Utilities.ReadXMLValue(AppConfig, "DataUpdateJobStatus"));
                log.Debug("DataUpdateJobStatus bool value set");

                bool Office365AdobeImportTables = Convert.ToBoolean(Utilities.ReadXMLValue(AppConfig, "Office365AdobeImportTables"));
                log.Debug("Office365AdobeImportTables bool value set");

                bool SRSImportDate = Convert.ToBoolean(Utilities.ReadXMLValue(AppConfig, "SRSImportDate"));
                log.Debug("SRSImportDate bool value set");

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
                #endregion
                log.Info("Configuration files loaded");

                DataRetriever dataRetriever = new DataRetriever();

                log.Info("Data Retriever loaded");

                #region Garbage Collector
                log.Info("Export garbage collector starting...");
                int exportCounter = 0;
                foreach (var file in System.IO.Directory.GetFiles(dc.Export))
                {
                    if (System.IO.File.Exists(file))
                    {
                        System.IO.File.Delete(file);
                        exportCounter += 1;
                        log.Debug(string.Format("{0} deleted!", file));
                    }
                }
                log.Info(exportCounter + " files deleted, for more details in future enable debug logging!");
                log.Info("Export garbage collector finished...");
                #endregion

                #region Log Retention
                log.Info("Log Retention module starting...");
                Utilities.LogRetention(dc.Logs, 10);
                log.Info("Log Retention module finished...");
                #endregion

                if (DataUpdateJobStatus)
                {
                    if (dataRetriever.GetDataUpdateJob())
                    {
                        log.Info("Data Update Job information exported");
                    }
                }

                if (LicenseManagerServices)
                {
                    if (dataRetriever.GetWindowsServices("License Manager", LicenseManagerServer))
                    {
                        log.Info("Windows Services information exported for LicenseManager");
                    }
                }

                if (InventoryServerServices)
                {
                    if (dataRetriever.GetWindowsServices("Inventory Server", InventoryServer))
                    {
                        log.Info("Windows Services information exported for InventoryServer");
                    }
                }

                if (InventoryServerStorage)
                {
                    if (dataRetriever.GetWindowsStorage("Inventory Server", InventoryServer))
                    {
                        log.Info("Windows Storage information exported for InventoryServer");
                    }
                }

                if (LicenseManagerStorage)
                {
                    if (dataRetriever.GetWindowsStorage("License Manager", LicenseManagerServer))
                    {
                        log.Info("Windows Storage information exported for LicenseManager");
                    }
                }

                if (Office365AdobeImportTables)
                {
                    if(dataRetriever.GetConnectorImportTables())
                    {
                        log.Info("Office 365 and Adobe Import tables exported");
                    }
                }

                if (LicenseManagerDeviceReporting)
                {
                    if (dataRetriever.GetReportedToday(slm: true))
                    {
                        log.Info("LicenseManager Device Reporting exported");
                    }
                }

                if (InventoryServerDeviceReporting)
                {
                    if (dataRetriever.GetReportedToday(sinv: true))
                    {
                        log.Info("SnowInventory Device Reporting exported");
                    }
                }

                if(SRSImportDate == true || InventoryServerProcessing == true)
                {
                    if (dataRetriever.GetExtras(SRSImportDate, InventoryServerProcessing))
                    {
                        log.Info("GetExtras exported");
                    }
                }


                Mailer m = new Mailer();
                string filename = dc.Export + DateTime.Now.ToString(dataRetriever.DateFormat) + dataRetriever.ExportName;
                log.Debug("New mailer initialized");

                m.SendEmail(filename, Assembly.GetExecutingAssembly().GetName().Version.ToString());
                log.Debug("Email command sent");

                log.Info("Schedule will now be refreshed for next run!");
                
                if(state != null)
                {
                    _timer.Dispose();
                }

                InitializeSchedule();
            } catch (Exception ex)
            {
                log.Fatal(ex);
                Stop();
            }
        }
        #endregion
    }
}
