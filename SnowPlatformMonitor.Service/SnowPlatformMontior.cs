using System;
using System.Reflection;
using System.ServiceProcess;
using System.Threading;
using System.Xml;
using SnowPlatformMonitor.Core.Classes;
using SnowPlatformMonitor.Core.Configuration;

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

                Logger.Log("SPMService", string.Format("Version: {0}", ServiceVersion), MethodBase.GetCurrentMethod().Name, "INFO");
                Logger.Log("SPMService", "Service is starting up...", MethodBase.GetCurrentMethod().Name, "INFO");

                InitializeConfiguration();

                if(Configured == true)
                {
                    InitializeSchedule();
                } else
                {
                    Logger.Log("SPMService", "Exports are not configured, the service will now stop.", MethodBase.GetCurrentMethod().Name, "INFO");
                    Stop();
                }

            } catch (Exception ex)
            {
                Logger.Log("SPMService", ex.Message, MethodBase.GetCurrentMethod().Name, "FATAL");
                Stop();
            }
        }
        

        protected override void OnStop()
        {
            Logger.Log("SPMService", "Service has been shutdown.", MethodBase.GetCurrentMethod().Name, "INFO");
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

                Logger.Log("SPMService", string.Format("Schedule loaded from configuration file, run at {0}h{1}m{2}s every {3}h{4}m{5}s.", Hours, Minutes, Seconds, FrequencyHours, FrequencyMinutes, FrequencySeconds), MethodBase.GetCurrentMethod().Name, "INFO");

                ServiceSchedule(new TimeSpan(Hours, Minutes, Seconds), new TimeSpan(FrequencyHours, FrequencyMinutes, FrequencySeconds));
            } catch (Exception ex)
            {
                Logger.Log("SPMService", ex.Message, MethodBase.GetCurrentMethod().Name, "FATAL");
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
                    Logger.Log("SPMService", node.ParentNode.Name + ": " + node.InnerText, MethodBase.GetCurrentMethod().Name, "DEBUG");

                    if(node.InnerText.ToLower() == "true")
                    {
                        Configured = true;
                    }
                }

            } catch (Exception ex)
            {
                Logger.Log("SPMService", ex.Message, MethodBase.GetCurrentMethod().Name, "FATAL");
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
                Logger.Log("SPMService", string.Format("Next run is scheduled for - {0}.", DateTime.Now.AddMilliseconds(firstExecution).ToString()), MethodBase.GetCurrentMethod().Name, "INFO");
            } catch (Exception ex)
            {
                Logger.Log("SPMService", ex.Message, MethodBase.GetCurrentMethod().Name, "FATAL");
                Stop();
            }
        }

        /// <summary>
        /// Used for pulling the data that has been selected in the configuration
        /// </summary>
        /// <param name="state"></param>
        public void ServiceExporter(object state)
        {
            try
            {
                Logger.Log("SPMService", "Starting Module.", MethodBase.GetCurrentMethod().Name, "INFO");
                string AppConfig = dc.Config + ac.AppConfig;
                string ServerConfig = dc.Config + ac.ServerConfig;

                bool DataUpdateJobStatus = Convert.ToBoolean(Utilities.ReadXMLValue(AppConfig, "DataUpdateJobStatus"));
                bool Office365AdobeImportTables = Convert.ToBoolean(Utilities.ReadXMLValue(AppConfig, "Office365AdobeImportTables"));
                bool LicenseManagerServices = Convert.ToBoolean(Utilities.ReadXMLValue(AppConfig, "LicenseManagerServices"));
                bool LicenseManagerDeviceReporting = Convert.ToBoolean(Utilities.ReadXMLValue(AppConfig, "LicenseManagerDeviceReporting"));
                bool LicenseManagerStorage = Convert.ToBoolean(Utilities.ReadXMLValue(AppConfig, "LicenseManagerStorage"));
                bool InventoryServerServices = Convert.ToBoolean(Utilities.ReadXMLValue(AppConfig, "InventoryServerServices"));
                bool InventoryServerStorage = Convert.ToBoolean(Utilities.ReadXMLValue(AppConfig, "InventoryServerStorage"));
                bool InventoryServerDeviceReporting = Convert.ToBoolean(Utilities.ReadXMLValue(AppConfig, "InventoryServerDeviceReporting"));
                bool InventoryServerProcessing = Convert.ToBoolean(Utilities.ReadXMLValue(AppConfig, "InventoryServerProcessing"));
                string LicenseManagerServer = Utilities.ReadXMLValue(ServerConfig, "LicenseManager");
                string InventoryServer = Utilities.ReadXMLValue(ServerConfig, "InventoryServer");

                Logger.Log("SPMService", "Configuration loaded.", MethodBase.GetCurrentMethod().Name, "INFO");

                DataRetriever dataRetriever = new DataRetriever();

                Logger.Log("SPMService", "Data Retriever loaded.", MethodBase.GetCurrentMethod().Name, "INFO");
                
                if (DataUpdateJobStatus)
                {
                    if (dataRetriever.GetDataUpdateJob())
                    {
                        Logger.Log("SPMService", "Data Update Job information exported.", MethodBase.GetCurrentMethod().Name, "INFO");
                    }
                }

                if (LicenseManagerServices)
                {
                    if (dataRetriever.GetServices("License Manager", LicenseManagerServer))
                    {
                        Logger.Log("SPMService", "Windows Services information exported for LicenseManager.", MethodBase.GetCurrentMethod().Name, "INFO");
                    }
                }

                if (InventoryServerServices)
                {
                    if (dataRetriever.GetServices("Inventory Server", InventoryServer))
                    {
                        Logger.Log("SPMService", "Windows Services information exported for InventoryServer.", MethodBase.GetCurrentMethod().Name, "INFO");
                    }
                }

                if (Office365AdobeImportTables)
                {
                    if(dataRetriever.GetConnectorImportTables())
                    {
                        Logger.Log("SPMService", "Office 365 and Adobe Import tables exported.", MethodBase.GetCurrentMethod().Name, "INFO");
                    }
                }

                if (LicenseManagerDeviceReporting)
                {
                    if (dataRetriever.GetReportedToday(slm: true))
                    {
                        Logger.Log("SPMService", "LicenseManager Device Reporting exported.", MethodBase.GetCurrentMethod().Name, "INFO");
                    }
                }

                if (InventoryServerDeviceReporting)
                {
                    if (dataRetriever.GetReportedToday(sinv: true))
                    {
                        Logger.Log("SPMService", "SnowInvenotry Device Reporting exported.", MethodBase.GetCurrentMethod().Name, "INFO");
                    }
                }

                Logger.Log("SPMService", "Schedule will now be refreshed!", MethodBase.GetCurrentMethod().Name, "INFO");
                _timer.Dispose();
                InitializeSchedule();
            } catch (Exception ex)
            {
                Logger.Log("SPMService", ex.Message, MethodBase.GetCurrentMethod().Name, "FATAL");
                Stop();
            }
        }
        #endregion
    }
}
