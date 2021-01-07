
#region Dependencies
using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using SnowPlatformMonitor.Core.Classes;
using SnowPlatformMonitor.Core.Configuration;
using System.Data.SqlClient;
using AutoUpdaterDotNET;
using System.Drawing;
using System.Configuration.Install;
using System.Xml;
#endregion

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace SnowPlatformMonitor.Configurator
{
    public partial class frmMain : Form
    {

        #region Fields
        readonly ApplicationConfiguration ac = new ApplicationConfiguration();
        readonly DirectoryConfiguration dc = new DirectoryConfiguration();
        readonly ServiceManager sc = new ServiceManager();
        private string ConnectionString;
        private string ConnectionStringParameters;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(frmMain));
        #endregion

        #region Constructor
        public frmMain()
        {
            InitializeComponent();
            AppLoad();
        }
        #endregion

        #region General (tab)
        private void btnConfigSave_Click(object sender, EventArgs e)
        {
            try
            {

                string[] NodeList =
                {
                    "ExportType",
                    "ScheduleHours",
                    "ScheduleMinutes",
                    "ScheduleSeconds",
                    "DataUpdateJobStatus",
                    "Office365AdobeImportTables",
                    "LicenseManagerServices",
                    "LicenseManagerDeviceReporting",
                    "LicenseManagerDeviceThreshold",
                    "LicenseManagerStorage",
                    "InventoryServerServices",
                    "InventoryServerDeviceReporting",
                    "InventoryServerDeviceThreshold",
                    "InventoryServerProcessing",
                    "InventoryServerStorage",
                    "InventoryServerProcessingDirectory",
                    "InventoryServerProcessingThreshold"
                };

                // works out which data type we're using
                // For future use
                string ExportType = "EXCELWORKBOOK"; // default

                string[] ValueList =
                {
                    ExportType,
                    numServiceMScheduleTimeHours.Value.ToString(),
                    numServiceMScheduleTimeMins.Value.ToString(),
                    numServiceMScheduleTimeSecs.Value.ToString(),
                    cbConfigDUJStatus.Checked.ToString(),
                    cbConfigOffice365Adobe.Checked.ToString(),
                    cbConfigSLMServices.Checked.ToString(),
                    cbConfigSLMDeviceReporting.Checked.ToString(),
                    numConfigAdvSLMDeviceThreshold.Value.ToString(),
                    cbConfigSLMStorage.Checked.ToString(),
                    cbConfigINVServices.Checked.ToString(),
                    cbConfigINVDeviceReporting.Checked.ToString(),
                    numConfigAdvINVDeviceThreshold.Value.ToString(),
                    cbConfigINVProcessingDir.Checked.ToString(),
                    cbConfigINVStorage.Checked.ToString(),
                    txtConfigAdvINVProcessingDirectory.Text,
                    numConfigAdvINVProcessingThreshold.Value.ToString()
                };

                string result = ac.SaveConfig("spm", NodeList, ValueList);
                if (result == "configsaved")
                {
                    MessageBox.Show("Configuration saved", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(result, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfigAdvanced_Click(object sender, EventArgs e)
        {
            if (Size.Width == MinimumSize.Width && Size.Height == MinimumSize.Height)
            {
                Size = new Size(MaximumSize.Width, MaximumSize.Height);
                gbConfigAdvanced.Visible = true;
            }
            else
            {
                Size = new Size(MinimumSize.Width, MinimumSize.Height);
                gbConfigAdvanced.Visible = false;
            }
        }
        #endregion

        #region Servers
        private void btnServersSQLTest_Click(object sender, EventArgs e)
        {
            if (txtServersSQL.Text == string.Empty || txtServersSQLPass.Text == string.Empty || txtServersSQLUser.Text == string.Empty)
            {
                MessageBox.Show("One or more required SQL fields are empty.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string SqlConnection = "Data Source=" + txtServersSQL.Text + ";Application Name=" + Text + ";User=" + txtServersSQLUser.Text + ";Password=" + txtServersSQLPass.Text;
                string SqlConnectionParam = txtServersSQLParam.Text;

                if (Utilities.IsSqlCorrect(SqlConnection + SqlConnectionParam))
                {
                    btnServersSave.Enabled = true;
                    MessageBox.Show("Connection successful", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ConnectionString = SqlConnection;
                    ConnectionStringParameters = SqlConnectionParam;
                }
                else
                {
                    btnServersSave.Enabled = false;
                    MessageBox.Show("Connection failed", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnServersSave_Click(object sender, EventArgs e)
        {
            try
            {

                if(txtServersSLM.Text == string.Empty || txtServersINV.Text == string.Empty || txtServersSQL.Text == string.Empty || txtServersSQLUser.Text == string.Empty || txtServersSQLPass.Text == string.Empty || txtServersINVDrive.Text == string.Empty || txtServersSLMDrive.Text == string.Empty)
                {
                    MessageBox.Show("One or more required fields are missing.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                } else
                {
                    string[] NodeList =
                    {
                        "LicenseManager",
                        "LicenseManagerDrive",
                        "InventoryServer",
                        "InventoryServerDrive",
                        "ConnectionString",
                        "ConnectionStringParameters"
                    };

                    string[] ValueList =
                    {
                        txtServersSLM.Text,
                        txtServersSLMDrive.Text,
                        txtServersINV.Text,
                        txtServersINVDrive.Text,
                        Utilities.Encrypt(ConnectionString),
                        Utilities.Encrypt(ConnectionStringParameters)
                    };

                    string result = ac.SaveConfig("servers", NodeList, ValueList);
                    if (result == "configsaved")
                    {
                        MessageBox.Show("Configuration saved", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnServersSave.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show(result, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        log.Error(result);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(ex);
            }
        }
        #endregion

        #region SMTP
        private void btnSMTPSave_Click(object sender, EventArgs e)
        {
            try
            {

                string[] NodeList = {
                    "Username",
                    "Password",
                    "Port",
                    "SSLEnabled",
                    "Host",
                    "Sender",
                    "SendTo",
                    "CC",
                    "Subject"
                };
                string[] ValueList = {
                    txtSMTPUsername.Text,
                    Utilities.Encrypt(txtSMTPPassword.Text),
                    numSMTPPort.Text,
                    cbxSMTPEnableSSL.Checked.ToString(),
                    txtSMTPHost.Text,
                    txtSMTPSender.Text,
                    txtSMTPSendTo.Text,
                    txtSMTPcc.Text,
                    txtSMTPSubject.Text
                };
                string result = ac.SaveConfig("smtp", NodeList, ValueList);
                if (result == "configsaved")
                {
                    MessageBox.Show("Configuration saved", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(result, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Service
        private void btnServiceMngrInstall_Click(object sender, EventArgs e)
        {
            try
            {
                ManagedInstallerClass.InstallHelper(new string[] { "SnowPlatformMonitor.Service.exe" });
                LoadServiceStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception thrown, please review ServiceInstaller logs in the root directory.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(ex);
            }
        }

        private void btnServiceMngrUninstall_Click(object sender, EventArgs e)
        {
            try
            {
                ManagedInstallerClass.InstallHelper(new string[] { "/u", "SnowPlatformMonitor.Service.exe" });
                LoadServiceStatus();
                btnServiceMngrStart.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception thrown, please review ServiceInstaller logs in the root directory.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(ex);
            }
        }

        private void btnServiceMngrStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (sc.ServiceStatus("SnowPlatformMonitor") != "Running")
                {
                    sc.Start("SnowPlatformMonitor");
                    log.Debug("Service Started via SPM GUI");
                    System.Threading.Thread.Sleep(3000);
                    LoadServiceStatus();
                    log.Debug("Service Manager refreshed");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Service error", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(ex);
            }
        }

        private void btnServiceMngrStop_Click(object sender, EventArgs e)
        {
            try
            {
                if (sc.ServiceStatus("SnowPlatformMonitor") == "Running")
                {
                    sc.Stop("SnowPlatformMonitor");
                    log.Debug("Service Stopped via SPM GUI");
                    System.Threading.Thread.Sleep(3000);
                    LoadServiceStatus();
                    log.Debug("Service Manager refreshed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Service error", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(ex);
            }
        }
        #endregion

        #region Logging
        private void btnLoggingSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Load log4net settings for the GUI
                XmlDocument guiLog4Net = new XmlDocument();
                guiLog4Net.Load("SnowPlatformMonitor.exe.config");
                guiLog4Net.SelectSingleNode("//log4net/root/level").Attributes["value"].Value = cbLoggingGUILevel.SelectedItem.ToString();
                guiLog4Net.SelectSingleNode("//log4net/appender/layout/conversionPattern").Attributes["value"].Value = txtLoggingGUIFormat.Text;
                guiLog4Net.SelectSingleNode("//log4net/appender/maximumFileSize").Attributes["value"].Value = string.Format("{0}{1}", numLoggingGUISize.Value, "MB");
                guiLog4Net.Save("SnowPlatformMonitor.exe.config");

                // Load log4net settings for the Service
                XmlDocument svcLog4Net = new XmlDocument();
                svcLog4Net.Load("SnowPlatformMonitor.Service.exe.config");
                svcLog4Net.SelectSingleNode("//log4net/root/level").Attributes["value"].Value = cbLoggingServiceLevel.SelectedItem.ToString();
                svcLog4Net.SelectSingleNode("//log4net/appender/layout/conversionPattern").Attributes["value"].Value = txtLoggingServiceFormat.Text;
                svcLog4Net.SelectSingleNode("//log4net/appender/maximumFileSize").Attributes["value"].Value = string.Format("{0}{1}", numLoggingServiceSize.Value, "MB");
                svcLog4Net.Save("SnowPlatformMonitor.Service.exe.config");
            } catch (Exception ex)
            {
                log.Error(ex);
            }
        }

        private void linkLoggingFormat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("https://logging.apache.org/log4net/log4net-1.2.13/release/sdk/log4net.Layout.PatternLayout.html");
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        #endregion

        #region Help
        private void btnHelpLogDir_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(dc.Logs);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHelpConfigDir_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(dc.Config);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHelpExportsDir_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(dc.Export);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHelpSupport_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://github.com/goosetuv/Snow-Platform-Monitor/issues");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHelpReleases_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://github.com/goosetuv/Snow-Platform-Monitor/releases");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHelpGuides_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://github.com/goosetuv/Snow-Platform-Monitor/wiki");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Functions

        /// <summary>
        /// Used for checking or unchecking all checkboxes on the configuration tab
        /// </summary>
        /// <param name="chk">true or false for checked or unchecked</param>
        private void CheckBoxChanger(bool chk)
        {
            foreach (Control ctrl in tabConfiguration.Controls)
            {
                if (ctrl is CheckBox cb)
                {
                    cb.Checked = chk;
                }
            }
        }

        private void LoadConfiguration()
        {
            try
            {
                if(File.Exists(dc.Config + ac.AppConfig))
                {

                    // Schedule
                    numServiceMScheduleTimeHours.Value = Convert.ToInt32(Utilities.ReadXMLValue(dc.Config + ac.AppConfig, "ScheduleHours"));
                    numServiceMScheduleTimeMins.Value = Convert.ToInt32(Utilities.ReadXMLValue(dc.Config + ac.AppConfig, "ScheduleMinutes"));
                    numServiceMScheduleTimeSecs.Value = Convert.ToInt32(Utilities.ReadXMLValue(dc.Config + ac.AppConfig, "ScheduleSeconds"));
                    log.Debug("Schedule values have been populated from Configuration File");

                    // Core
                    cbConfigDUJStatus.Checked = Convert.ToBoolean(Utilities.ReadXMLValue(dc.Config + ac.AppConfig, "DataUpdateJobStatus"));
                    cbConfigOffice365Adobe.Checked = Convert.ToBoolean(Utilities.ReadXMLValue(dc.Config + ac.AppConfig, "Office365AdobeImportTables"));
                    log.Debug("Core values have been populated from Configuration File");

                    // License Manager
                    cbConfigSLMServices.Checked = Convert.ToBoolean(Utilities.ReadXMLValue(dc.Config + ac.AppConfig, "LicenseManagerServices"));
                    cbConfigSLMDeviceReporting.Checked = Convert.ToBoolean(Utilities.ReadXMLValue(dc.Config + ac.AppConfig, "LicenseManagerDeviceReporting"));
                    cbConfigSLMStorage.Checked = Convert.ToBoolean(Utilities.ReadXMLValue(dc.Config + ac.AppConfig, "LicenseManagerStorage"));
                    log.Debug("License Manager values have been populated from Configuration File");

                    // Inventory Server
                    cbConfigINVServices.Checked = Convert.ToBoolean(Utilities.ReadXMLValue(dc.Config + ac.AppConfig, "InventoryServerServices"));
                    cbConfigINVDeviceReporting.Checked = Convert.ToBoolean(Utilities.ReadXMLValue(dc.Config + ac.AppConfig, "InventoryServerDeviceReporting"));
                    cbConfigINVProcessingDir.Checked = Convert.ToBoolean(Utilities.ReadXMLValue(dc.Config + ac.AppConfig, "InventoryServerProcessing"));
                    cbConfigINVStorage.Checked = Convert.ToBoolean(Utilities.ReadXMLValue(dc.Config + ac.AppConfig, "InventoryServerStorage"));
                    log.Debug("Inventory Server values have been populated from Configuration File");

                    // Advanced
                    numConfigAdvINVDeviceThreshold.Value = Convert.ToInt32(Utilities.ReadXMLValue(dc.Config + ac.AppConfig, "InventoryServerDeviceThreshold"));
                    numConfigAdvINVProcessingThreshold.Value = Convert.ToInt32(Utilities.ReadXMLValue(dc.Config + ac.AppConfig, "InventoryServerProcessingThreshold"));
                    numConfigAdvSLMDeviceThreshold.Value = Convert.ToInt32(Utilities.ReadXMLValue(dc.Config + ac.AppConfig, "LicenseManagerDeviceThreshold"));
                    txtConfigAdvINVProcessingDirectory.Text = Utilities.ReadXMLValue(dc.Config + ac.AppConfig, "InventoryServerProcessingDirectory");
                    log.Debug("Advanced Configuration values have been populated from Configuration File");
                }
            } catch (Exception ex)
            {
                log.Error(ex);
            }
        }

        private void LoadSMTPConfiguration()
        {
            try
            {
                if (ac.ConfigExists(ac.SMTPConfig))
                {
                    txtSMTPUsername.Text = Utilities.ReadXMLValue(dc.Config + ac.SMTPConfig, "Username");
                    txtSMTPPassword.Text = Utilities.Decrypt(Utilities.ReadXMLValue(dc.Config + ac.SMTPConfig, "Password"));
                    numSMTPPort.Text = Utilities.ReadXMLValue(dc.Config + ac.SMTPConfig, "Port");
                    cbxSMTPEnableSSL.Checked = Convert.ToBoolean(Utilities.ReadXMLValue(dc.Config + ac.SMTPConfig, "SSLEnabled"));
                    txtSMTPHost.Text = Utilities.ReadXMLValue(dc.Config + ac.SMTPConfig, "Host");
                    txtSMTPSender.Text = Utilities.ReadXMLValue(dc.Config + ac.SMTPConfig, "Sender");
                    txtSMTPSendTo.Text = Utilities.ReadXMLValue(dc.Config + ac.SMTPConfig, "SendTo");
                    txtSMTPcc.Text = Utilities.ReadXMLValue(dc.Config + ac.SMTPConfig, "CC");
                    txtSMTPSubject.Text = Utilities.ReadXMLValue(dc.Config + ac.SMTPConfig, "Subject");
                    log.Debug("SMTP values have been populated from Configuration File");
                }
            } catch (Exception ex)
            {
                log.Error(ex);
            }
        }

        private void LoadServersConfiguration()
        {
            try
            {
                if(File.Exists(dc.Config + ac.ServerConfig))
                {
                    // License Manager
                    txtServersSLM.Text = Utilities.ReadXMLValue(dc.Config + ac.ServerConfig, "LicenseManager");
                    txtServersSLMDrive.Text = Utilities.ReadXMLValue(dc.Config + ac.ServerConfig, "LicenseManagerDrive");
                    log.Debug("License Manager values have been populated from Configuration File");


                    // Inventory Server
                    txtServersINV.Text = Utilities.ReadXMLValue(dc.Config + ac.ServerConfig, "InventoryServer");
                    txtServersINVDrive.Text = Utilities.ReadXMLValue(dc.Config + ac.ServerConfig, "InventoryServerDrive");
                    log.Debug("Inventory Server values have been populated from Configuration File");

                    // SQL Configuration
                    var cs = new SqlConnectionStringBuilder(Utilities.Decrypt(Utilities.ReadXMLValue(dc.Config + ac.ServerConfig, "ConnectionString")));
                    txtServersSQL.Text = cs.DataSource;
                    txtServersSQLUser.Text = cs.UserID;
                    txtServersSQLPass.Text = cs.Password;
                    txtServersSQLParam.Text = Utilities.Decrypt(Utilities.ReadXMLValue(dc.Config + ac.ServerConfig, "ConnectionStringParameters"));
                    log.Debug("SQL Server values have been populated from Configuration File");
                }

            } catch (Exception ex)
            {
                log.Error(ex);
            }
        }

        private void LoadVisualDesign()
        {
            this.Size = new Size(MinimumSize.Width, MinimumSize.Height);

            lblHelpAppInfo.Text = $"v{ProductVersion}{Environment.NewLine}PRE-RELEASE-BUILD{Environment.NewLine}Copyright (c) 2020 - {DateTime.Now.Year} Laim McKenzie.";

            Text = string.Format("{0} Configurator", ProductName); 
        }

        private void LoadLogging()
        {
            try
            {

                // Load log4net settings for the GUI
                XmlDocument guiLog4Net = new XmlDocument();
                guiLog4Net.Load("SnowPlatformMonitor.exe.config");
                
                cbLoggingGUILevel.SelectedItem = guiLog4Net.SelectSingleNode("//log4net/root/level").Attributes["value"].Value;
                txtLoggingGUIFormat.Text = guiLog4Net.SelectSingleNode("//log4net/appender/layout/conversionPattern").Attributes["value"].Value;
                string guiFileSize = guiLog4Net.SelectSingleNode("//log4net/appender/maximumFileSize").Attributes["value"].Value;
                numLoggingGUISize.Value = Convert.ToInt32(guiFileSize.Remove(guiFileSize.Length - 2));

                // Load log4net settings for the Service
                XmlDocument svcLog4Net = new XmlDocument();
                svcLog4Net.Load("SnowPlatformMonitor.Service.exe.config");

                cbLoggingServiceLevel.SelectedItem = svcLog4Net.SelectSingleNode("//log4net/root/level").Attributes["value"].Value;
                txtLoggingServiceFormat.Text = svcLog4Net.SelectSingleNode("//log4net/appender/layout/conversionPattern").Attributes["value"].Value;
                string svcFileSize = svcLog4Net.SelectSingleNode("//log4net/appender/maximumFileSize").Attributes["value"].Value;
                numLoggingServiceSize.Value = Convert.ToInt32(svcFileSize.Remove(svcFileSize.Length - 2));

            } catch (Exception ex)
            {
                log.Fatal(ex);
            }
        }

        private void LoadServiceStatus()
        {
            try
            {
                string serviceStatus = sc.ServiceStatus("SnowPlatformMonitor");
                if (serviceStatus == "Running")
                {
                    log.Debug("SnowPlatformMonitor.Service : " + serviceStatus);

                    pbServiceMngrStatus.Image = Properties.Resources.play_button;
                    btnServiceMngrStart.Enabled = false;
                    btnServiceMngrStop.Enabled = true;
                    btnServiceMngrInstall.Enabled = false;
                    btnServiceMngrUninstall.Enabled = false;
                }
                else
                {
                    log.Debug("SnowPlatformMonitor.Service : " + serviceStatus);

                    pbServiceMngrStatus.Image = Properties.Resources.stop_button;
                    btnServiceMngrStop.Enabled = false;
                    btnServiceMngrStart.Enabled = true;
                    btnServiceMngrInstall.Enabled = false;
                    btnServiceMngrUninstall.Enabled = true;
                }
            } catch (Exception ex)
            {
                if(ex.Message.Contains("was not found on computer"))
                {
                    btnServiceMngrInstall.Enabled = true;
                    btnServiceMngrUninstall.Enabled = false;
                } else
                {
                    log.Error(ex);
                }
            }
        }

        private void AppLoad()
        {
            CheckForUpdates();
            LoadVisualDesign();
            LoadConfiguration();
            LoadServersConfiguration();
            LoadSMTPConfiguration();
            LoadLogging();
            LoadServiceStatus();
            log.Debug("AppLoad completed");
        }

        #region Updater
        /// <summary>
        ///  Checks if there are any updates available for the app, using AutoUpdater.NET
        /// </summary>
        private void CheckForUpdates()
        {
            log.Debug("Checking for updates...");
            AutoUpdater.Start("https://laim.scot/updates/spm.xml");
            AutoUpdater.ShowSkipButton = false;
            AutoUpdater.OpenDownloadPage = true;
            AutoUpdater.HttpUserAgent = "AutoUpdater-SPM";
            AutoUpdater.UpdateFormSize = new Size(Width, Height);
            AutoUpdater.PersistenceProvider = new JsonFilePersistenceProvider(Path.Combine(dc.Resources, "updates.json"));
            log.Debug("Update check finished, popup should appear if there are updates available");
        }

        #endregion

        #endregion


        //debug, remove in release
        private void button1_Click(object sender, EventArgs e)
        {
            DataRetriever exporter = new DataRetriever();
            exporter.GetDataUpdateJob();
            exporter.GetWindowsServices("Inventory", "localhost");
            exporter.GetConnectorImportTables();
            exporter.GetReportedToday(true, true);
            exporter.GetWindowsStorage("License Manager", txtServersSLM.Text);
            exporter.GetWindowsStorage("Inventory Server", txtServersINV.Text);

            MessageBox.Show(exporter.GetSRSImportDate());
            MessageBox.Show(exporter.GetInventoryDirectoryCount());
        }


    }
}