
#region Dependencies
using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Reflection;
using SnowPlatformMonitor.Core;
using System.Data.SqlClient;
using AutoUpdaterDotNET;
using System.Net;
using System.Collections.Generic;
#endregion

namespace SnowPlatformMonitor.Configurator
{
    public partial class frmMain : Form
    {

        #region Fields
        ApplicationConfiguration ac = new ApplicationConfiguration();
        DirectoryConfiguration dc = new DirectoryConfiguration();
        private string ConnectionString;
        private string ConnectionStringParameters;
        #endregion

        #region Constructor
        public frmMain()
        {
            InitializeComponent();
            CheckForUpdates();
            LoadConfiguration();
            LoadServersConfiguration();
        }
        #endregion

        #region Configuration
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
                    "LicenseManagerServices",
                    "LicenseManagerDeviceReporting",
                    "LicenseManagerStorage",
                    "InventoryServerServices",
                    "InventoryServerDeviceReporting",
                    "InventoryServerProcessing",
                    "InventoryServerStorage",
                    "InventoryServerProcessingDirectory",
                    "InventoryServerProcessingThreshold"
                };

                // works out which data type we're using
                string ExportType = "EXCELWORKBOOK"; // default
                if(rbConfigPDF.Checked)
                {
                    ExportType = "PDF";
                } 
                else if (rbConfigExcelWB.Checked) 
                {
                    ExportType = "EXCELWORKBOOK";
                }

                string[] ValueList =
                {
                    ExportType,
                    numServiceMScheduleTimeHours.Value.ToString(),
                    numServiceMScheduleTimeMins.Value.ToString(),
                    numServiceMScheduleTimeSecs.Value.ToString(),
                    cbConfigDUJStatus.Checked.ToString(),
                    cbConfigSLMServices.Checked.ToString(),
                    cbConfigSLMDeviceReporting.Checked.ToString(),
                    cbConfigSLMStorage.Checked.ToString(),
                    cbConfigINVServices.Checked.ToString(),
                    cbConfigINVDeviceReporting.Checked.ToString(),
                    cbConfigINVProcessingDir.Checked.ToString(),
                    cbConfigINVStorage.Checked.ToString(),
                    @"\Program Files\Snow Software\Snow Inventory\Server\Incoming\data\processing",
                    "100"
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

        private void btnConfigCheckAll_Click(object sender, EventArgs e)
        {
            CheckBoxChanger(true);
        }
 
        private void btnConfigUncheckAll_Click(object sender, EventArgs e)
        {
            CheckBoxChanger(false);
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
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region About
        private void btnAboutLogDir_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(dc.Logs);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAboutConfigDir_Click(object sender, EventArgs e)
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

                    // Export type
                    if (Utilities.ReadXMLValue(dc.Config + ac.AppConfig, "ExportType") == "EXCELWORKBOOK")
                    {
                        rbConfigExcelWB.Checked = true;
                        rbConfigPDF.Checked = false;
                    }
                    else
                    {
                        rbConfigExcelWB.Checked = false;
                        rbConfigPDF.Checked = true;
                    }

                    // Schedule
                    numServiceMScheduleTimeHours.Value = Convert.ToInt32(Utilities.ReadXMLValue(dc.Config + ac.AppConfig, "ScheduleHours"));
                    numServiceMScheduleTimeMins.Value = Convert.ToInt32(Utilities.ReadXMLValue(dc.Config + ac.AppConfig, "ScheduleMinutes"));
                    numServiceMScheduleTimeSecs.Value = Convert.ToInt32(Utilities.ReadXMLValue(dc.Config + ac.AppConfig, "ScheduleSeconds"));

                    // Data Update Job
                    cbConfigDUJStatus.Checked = Convert.ToBoolean(Utilities.ReadXMLValue(dc.Config + ac.AppConfig, "DataUpdateJobStatus"));
                    // License Manager
                    cbConfigSLMServices.Checked = Convert.ToBoolean(Utilities.ReadXMLValue(dc.Config + ac.AppConfig, "LicenseManagerServices"));
                    cbConfigSLMDeviceReporting.Checked = Convert.ToBoolean(Utilities.ReadXMLValue(dc.Config + ac.AppConfig, "LicenseManagerDeviceReporting"));
                    cbConfigSLMStorage.Checked = Convert.ToBoolean(Utilities.ReadXMLValue(dc.Config + ac.AppConfig, "LicenseManagerStorage"));
                    // Inventory Server
                    cbConfigINVServices.Checked = Convert.ToBoolean(Utilities.ReadXMLValue(dc.Config + ac.AppConfig, "InventoryServerServices"));
                    cbConfigINVDeviceReporting.Checked = Convert.ToBoolean(Utilities.ReadXMLValue(dc.Config + ac.AppConfig, "InventoryServerDeviceReporting"));
                    cbConfigINVProcessingDir.Checked = Convert.ToBoolean(Utilities.ReadXMLValue(dc.Config + ac.AppConfig, "InventoryServerProcessing"));
                    cbConfigINVStorage.Checked = Convert.ToBoolean(Utilities.ReadXMLValue(dc.Config + ac.AppConfig, "InventoryServerStorage"));
                }
            } catch (Exception ex)
            {
                Logger.Log("SPMConfigurator", ex.Message + ex.StackTrace, MethodBase.GetCurrentMethod().Name, "FATAL");
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
                    // Inventory Server
                    txtServersINV.Text = Utilities.ReadXMLValue(dc.Config + ac.ServerConfig, "InventoryServer");
                    txtServersINVDrive.Text = Utilities.ReadXMLValue(dc.Config + ac.ServerConfig, "InventoryServerDrive");
                    // SQL Configuration
                    var cs = new SqlConnectionStringBuilder(Utilities.Decrypt(Utilities.ReadXMLValue(dc.Config + ac.ServerConfig, "ConnectionString")));
                    txtServersSQL.Text = cs.DataSource;
                    txtServersSQLUser.Text = cs.UserID;
                    txtServersSQLPass.Text = cs.Password;
                    txtServersSQLParam.Text = Utilities.Decrypt(Utilities.ReadXMLValue(dc.Config + ac.ServerConfig, "ConnectionStringParameters"));
                }

            } catch (Exception ex)
            {
                Logger.Log("SPMConfigurator", ex.Message + ex.StackTrace, MethodBase.GetCurrentMethod().Name, "FATAL");
            }
}

        #region Updater
        /// <summary>
        ///  Checks if there are any updates available for the app, using AutoUpdater.NET
        /// </summary>
        private void CheckForUpdates()
        {
            AutoUpdater.Start("https://laim.scot/updates/spm.xml");
            AutoUpdater.ShowSkipButton = false;
            AutoUpdater.OpenDownloadPage = true;
            AutoUpdater.HttpUserAgent = "AutoUpdater-SPM";
            AutoUpdater.UpdateFormSize = new System.Drawing.Size(Width, Height);
            AutoUpdater.PersistenceProvider = new JsonFilePersistenceProvider(Path.Combine(Environment.CurrentDirectory, "updates.json"));
        }

        #endregion

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            InventoryServer inventoryServer = new InventoryServer();
            MessageBox.Show(inventoryServer.ProcessingDirectory());
        }
    }
}