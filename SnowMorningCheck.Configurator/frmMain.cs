
#region Dependencies
using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using System.Reflection;
using SnowPlatformMonitor.Core;
#endregion

namespace SnowPlatformMonitor.Configurator
{
    public partial class frmMain : Form
    {

        #region Fields
        ApplicationConfiguration ac = new ApplicationConfiguration();
        DirectoryConfiguration dc = new DirectoryConfiguration();
        private string ConnectionString;
        #endregion

        #region Constructor
        public frmMain()
        {
            InitializeComponent();
            RefreshConfigurationTab();
        }
        #endregion

        #region Configuration
        private void btnConfigSave_Click(object sender, EventArgs e)
        {
            try
            {

                string[] NodeList =
                {
                    "DataUpdateJobStatus",
                    "LicenseManagerServices",
                    "LicenseManagerDeviceReporting",
                    "LicenseManagerStorage",
                    "InventoryServerServices",
                    "InventoryServerDeviceReporting",
                    "InventoryServerProcessing",
                    "InventoryServerStorage",
                    "ExportType"
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
                    cbConfigDUJStatus.Checked.ToString(),
                    cbConfigSLMServices.Checked.ToString(),
                    cbConfigSLMDeviceReporting.Checked.ToString(),
                    cbConfigSLMStorage.Checked.ToString(),
                    cbConfigINVServices.Checked.ToString(),
                    cbConfigINVDeviceReporting.Checked.ToString(),
                    cbConfigINVProcessingDir.Checked.ToString(),
                    cbConfigINVStorage.Checked.ToString(),
                    ExportType
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
                string SqlConnection = "Data Source=" + txtServersSQL.Text + ";Application Name=" + Text + ";User=" + txtServersSQLUser.Text + ";Password=" + txtServersSQLPass.Text + txtServersSQLParam.Text;

                if (Utilities.IsSqlCorrect(SqlConnection))
                {
                    btnServersSave.Enabled = true;
                    MessageBox.Show("Connection successful", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ConnectionString = SqlConnection;
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
                        "ConnectionString"
                    };

                    string[] ValueList =
                    {
                        txtServersSLM.Text,
                        txtServersSLMDrive.Text,
                        txtServersINV.Text,
                        txtServersINVDrive.Text,
                        Utilities.Encrypt(ConnectionString)
                    };

                    string result = ac.SaveConfig("servers", NodeList, ValueList);
                    if (result == "configsaved")
                    {
                        MessageBox.Show("Configuration saved", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        /// Used for updating each tab when they are refreshed.
        /// </summary>
        private void TabConfigLoader(object sender, EventArgs e)
        {
            // done via tab name instead of index
            // reason: tab order may change, names wont

            TabControl tc = (TabControl)sender;
            switch (tc.SelectedTab.Name)
            {
                case "tabConfiguration":
                    RefreshConfigurationTab();
                    break;
                case "tabServers":
                    // load servers.config
                    break;
                case "tabSMTP":
                    // load smtp.config
                    break;
            }
        }

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

        private void RefreshConfigurationTab()
        {
            try
            {
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
            } catch (Exception ex)
            {
                Logger.Log("SPMConfigurator", ex.Message + ex.StackTrace, MethodBase.GetCurrentMethod().Name, "FATAL");
            }
        }

        private void RefreshServersTab()
        {
            try
            {

            } catch (Exception ex)
            {
                Logger.Log("SPMConfigurator", ex.Message + ex.StackTrace, MethodBase.GetCurrentMethod().Name, "FATAL");
            }
}
        #endregion
    }
}