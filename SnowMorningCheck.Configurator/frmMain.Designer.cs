namespace SnowMorningCheck.Configurator
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabServers = new System.Windows.Forms.TabPage();
            this.btnServersSave = new System.Windows.Forms.Button();
            this.gbServersSQL = new System.Windows.Forms.GroupBox();
            this.btnServersSQLTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtlServersSQLParam = new System.Windows.Forms.TextBox();
            this.lblServersSQLPass = new System.Windows.Forms.Label();
            this.txtlServersSQLPass = new System.Windows.Forms.TextBox();
            this.txtlServersSQLUser = new System.Windows.Forms.TextBox();
            this.lblServersSQLUser = new System.Windows.Forms.Label();
            this.lblServersSql = new System.Windows.Forms.Label();
            this.lblServersINV = new System.Windows.Forms.Label();
            this.txtServersSQL = new System.Windows.Forms.TextBox();
            this.txtServersINV = new System.Windows.Forms.TextBox();
            this.txtServersSLM = new System.Windows.Forms.TextBox();
            this.lblServersSLM = new System.Windows.Forms.Label();
            this.tabSMTP = new System.Windows.Forms.TabPage();
            this.tabServiceManager = new System.Windows.Forms.TabPage();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.Configuration = new System.Windows.Forms.TabPage();
            this.cbConfigDUJStatus = new System.Windows.Forms.CheckBox();
            this.cbConfigSLMServices = new System.Windows.Forms.CheckBox();
            this.cbConfigSLMDeviceReporting = new System.Windows.Forms.CheckBox();
            this.cbConfigINVDeviceReporting = new System.Windows.Forms.CheckBox();
            this.cbConfigINVServices = new System.Windows.Forms.CheckBox();
            this.cbConfigINVProcessingDir = new System.Windows.Forms.CheckBox();
            this.cbConfigSLMStorage = new System.Windows.Forms.CheckBox();
            this.cbConfigINVStorage = new System.Windows.Forms.CheckBox();
            this.btnConfigSave = new System.Windows.Forms.Button();
            this.btnConfigCheckAll = new System.Windows.Forms.Button();
            this.btnConfigUncheckAll = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabServers.SuspendLayout();
            this.gbServersSQL.SuspendLayout();
            this.Configuration.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.Configuration);
            this.tabControlMain.Controls.Add(this.tabServers);
            this.tabControlMain.Controls.Add(this.tabSMTP);
            this.tabControlMain.Controls.Add(this.tabServiceManager);
            this.tabControlMain.Controls.Add(this.tabAbout);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(316, 349);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabServers
            // 
            this.tabServers.Controls.Add(this.btnServersSave);
            this.tabServers.Controls.Add(this.gbServersSQL);
            this.tabServers.Controls.Add(this.lblServersSql);
            this.tabServers.Controls.Add(this.lblServersINV);
            this.tabServers.Controls.Add(this.txtServersSQL);
            this.tabServers.Controls.Add(this.txtServersINV);
            this.tabServers.Controls.Add(this.txtServersSLM);
            this.tabServers.Controls.Add(this.lblServersSLM);
            this.tabServers.Location = new System.Drawing.Point(4, 22);
            this.tabServers.Name = "tabServers";
            this.tabServers.Padding = new System.Windows.Forms.Padding(3);
            this.tabServers.Size = new System.Drawing.Size(308, 323);
            this.tabServers.TabIndex = 0;
            this.tabServers.Text = "Servers";
            this.tabServers.UseVisualStyleBackColor = true;
            // 
            // btnServersSave
            // 
            this.btnServersSave.Location = new System.Drawing.Point(213, 287);
            this.btnServersSave.Name = "btnServersSave";
            this.btnServersSave.Size = new System.Drawing.Size(75, 23);
            this.btnServersSave.TabIndex = 7;
            this.btnServersSave.Text = "Save";
            this.btnServersSave.UseVisualStyleBackColor = true;
            // 
            // gbServersSQL
            // 
            this.gbServersSQL.Controls.Add(this.btnServersSQLTest);
            this.gbServersSQL.Controls.Add(this.label1);
            this.gbServersSQL.Controls.Add(this.txtlServersSQLParam);
            this.gbServersSQL.Controls.Add(this.lblServersSQLPass);
            this.gbServersSQL.Controls.Add(this.txtlServersSQLPass);
            this.gbServersSQL.Controls.Add(this.txtlServersSQLUser);
            this.gbServersSQL.Controls.Add(this.lblServersSQLUser);
            this.gbServersSQL.Location = new System.Drawing.Point(17, 108);
            this.gbServersSQL.Name = "gbServersSQL";
            this.gbServersSQL.Size = new System.Drawing.Size(271, 133);
            this.gbServersSQL.TabIndex = 6;
            this.gbServersSQL.TabStop = false;
            this.gbServersSQL.Text = "SQL Configuration";
            // 
            // btnServersSQLTest
            // 
            this.btnServersSQLTest.Location = new System.Drawing.Point(175, 100);
            this.btnServersSQLTest.Name = "btnServersSQLTest";
            this.btnServersSQLTest.Size = new System.Drawing.Size(75, 23);
            this.btnServersSQLTest.TabIndex = 12;
            this.btnServersSQLTest.Text = "Test";
            this.btnServersSQLTest.UseVisualStyleBackColor = true;
            this.btnServersSQLTest.Click += new System.EventHandler(this.btnServersSQLTest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Parameters:";
            // 
            // txtlServersSQLParam
            // 
            this.txtlServersSQLParam.Location = new System.Drawing.Point(84, 74);
            this.txtlServersSQLParam.Name = "txtlServersSQLParam";
            this.txtlServersSQLParam.Size = new System.Drawing.Size(166, 20);
            this.txtlServersSQLParam.TabIndex = 10;
            // 
            // lblServersSQLPass
            // 
            this.lblServersSQLPass.AutoSize = true;
            this.lblServersSQLPass.Location = new System.Drawing.Point(22, 51);
            this.lblServersSQLPass.Name = "lblServersSQLPass";
            this.lblServersSQLPass.Size = new System.Drawing.Size(56, 13);
            this.lblServersSQLPass.TabIndex = 9;
            this.lblServersSQLPass.Text = "Password:";
            // 
            // txtlServersSQLPass
            // 
            this.txtlServersSQLPass.Location = new System.Drawing.Point(84, 48);
            this.txtlServersSQLPass.Name = "txtlServersSQLPass";
            this.txtlServersSQLPass.Size = new System.Drawing.Size(166, 20);
            this.txtlServersSQLPass.TabIndex = 8;
            // 
            // txtlServersSQLUser
            // 
            this.txtlServersSQLUser.Location = new System.Drawing.Point(84, 22);
            this.txtlServersSQLUser.Name = "txtlServersSQLUser";
            this.txtlServersSQLUser.Size = new System.Drawing.Size(166, 20);
            this.txtlServersSQLUser.TabIndex = 7;
            // 
            // lblServersSQLUser
            // 
            this.lblServersSQLUser.AutoSize = true;
            this.lblServersSQLUser.Location = new System.Drawing.Point(20, 25);
            this.lblServersSQLUser.Name = "lblServersSQLUser";
            this.lblServersSQLUser.Size = new System.Drawing.Size(58, 13);
            this.lblServersSQLUser.TabIndex = 0;
            this.lblServersSQLUser.Text = "Username:";
            // 
            // lblServersSql
            // 
            this.lblServersSql.AutoSize = true;
            this.lblServersSql.Location = new System.Drawing.Point(41, 72);
            this.lblServersSql.Name = "lblServersSql";
            this.lblServersSql.Size = new System.Drawing.Size(65, 13);
            this.lblServersSql.TabIndex = 5;
            this.lblServersSql.Text = "SQL Server:";
            // 
            // lblServersINV
            // 
            this.lblServersINV.AutoSize = true;
            this.lblServersINV.Location = new System.Drawing.Point(18, 46);
            this.lblServersINV.Name = "lblServersINV";
            this.lblServersINV.Size = new System.Drawing.Size(88, 13);
            this.lblServersINV.TabIndex = 4;
            this.lblServersINV.Text = "Inventory Server:";
            // 
            // txtServersSQL
            // 
            this.txtServersSQL.Location = new System.Drawing.Point(112, 69);
            this.txtServersSQL.Name = "txtServersSQL";
            this.txtServersSQL.Size = new System.Drawing.Size(176, 20);
            this.txtServersSQL.TabIndex = 3;
            // 
            // txtServersINV
            // 
            this.txtServersINV.Location = new System.Drawing.Point(112, 43);
            this.txtServersINV.Name = "txtServersINV";
            this.txtServersINV.Size = new System.Drawing.Size(176, 20);
            this.txtServersINV.TabIndex = 2;
            // 
            // txtServersSLM
            // 
            this.txtServersSLM.Location = new System.Drawing.Point(112, 17);
            this.txtServersSLM.Name = "txtServersSLM";
            this.txtServersSLM.Size = new System.Drawing.Size(176, 20);
            this.txtServersSLM.TabIndex = 1;
            // 
            // lblServersSLM
            // 
            this.lblServersSLM.AutoSize = true;
            this.lblServersSLM.Location = new System.Drawing.Point(14, 20);
            this.lblServersSLM.Name = "lblServersSLM";
            this.lblServersSLM.Size = new System.Drawing.Size(92, 13);
            this.lblServersSLM.TabIndex = 0;
            this.lblServersSLM.Text = "License Manager:";
            // 
            // tabSMTP
            // 
            this.tabSMTP.Location = new System.Drawing.Point(4, 22);
            this.tabSMTP.Name = "tabSMTP";
            this.tabSMTP.Padding = new System.Windows.Forms.Padding(3);
            this.tabSMTP.Size = new System.Drawing.Size(308, 323);
            this.tabSMTP.TabIndex = 1;
            this.tabSMTP.Text = "SMTP";
            this.tabSMTP.UseVisualStyleBackColor = true;
            // 
            // tabServiceManager
            // 
            this.tabServiceManager.Location = new System.Drawing.Point(4, 22);
            this.tabServiceManager.Name = "tabServiceManager";
            this.tabServiceManager.Size = new System.Drawing.Size(308, 323);
            this.tabServiceManager.TabIndex = 2;
            this.tabServiceManager.Text = "Service Manager";
            this.tabServiceManager.UseVisualStyleBackColor = true;
            // 
            // tabAbout
            // 
            this.tabAbout.Location = new System.Drawing.Point(4, 22);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Size = new System.Drawing.Size(308, 323);
            this.tabAbout.TabIndex = 3;
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // Configuration
            // 
            this.Configuration.Controls.Add(this.btnConfigUncheckAll);
            this.Configuration.Controls.Add(this.btnConfigCheckAll);
            this.Configuration.Controls.Add(this.btnConfigSave);
            this.Configuration.Controls.Add(this.cbConfigINVStorage);
            this.Configuration.Controls.Add(this.cbConfigSLMStorage);
            this.Configuration.Controls.Add(this.cbConfigINVProcessingDir);
            this.Configuration.Controls.Add(this.cbConfigINVServices);
            this.Configuration.Controls.Add(this.cbConfigINVDeviceReporting);
            this.Configuration.Controls.Add(this.cbConfigSLMDeviceReporting);
            this.Configuration.Controls.Add(this.cbConfigSLMServices);
            this.Configuration.Controls.Add(this.cbConfigDUJStatus);
            this.Configuration.Location = new System.Drawing.Point(4, 22);
            this.Configuration.Name = "Configuration";
            this.Configuration.Padding = new System.Windows.Forms.Padding(3);
            this.Configuration.Size = new System.Drawing.Size(308, 323);
            this.Configuration.TabIndex = 4;
            this.Configuration.Text = "Configuration";
            this.Configuration.UseVisualStyleBackColor = true;
            // 
            // cbConfigDUJStatus
            // 
            this.cbConfigDUJStatus.AutoSize = true;
            this.cbConfigDUJStatus.Location = new System.Drawing.Point(20, 20);
            this.cbConfigDUJStatus.Name = "cbConfigDUJStatus";
            this.cbConfigDUJStatus.Size = new System.Drawing.Size(140, 17);
            this.cbConfigDUJStatus.TabIndex = 0;
            this.cbConfigDUJStatus.Text = "Data Update Job Status";
            this.cbConfigDUJStatus.UseVisualStyleBackColor = true;
            // 
            // cbConfigSLMServices
            // 
            this.cbConfigSLMServices.AutoSize = true;
            this.cbConfigSLMServices.Location = new System.Drawing.Point(20, 43);
            this.cbConfigSLMServices.Name = "cbConfigSLMServices";
            this.cbConfigSLMServices.Size = new System.Drawing.Size(216, 17);
            this.cbConfigSLMServices.TabIndex = 1;
            this.cbConfigSLMServices.Text = "Snow License Manager Server Services";
            this.cbConfigSLMServices.UseVisualStyleBackColor = true;
            // 
            // cbConfigSLMDeviceReporting
            // 
            this.cbConfigSLMDeviceReporting.AutoSize = true;
            this.cbConfigSLMDeviceReporting.Location = new System.Drawing.Point(20, 66);
            this.cbConfigSLMDeviceReporting.Name = "cbConfigSLMDeviceReporting";
            this.cbConfigSLMDeviceReporting.Size = new System.Drawing.Size(224, 17);
            this.cbConfigSLMDeviceReporting.TabIndex = 2;
            this.cbConfigSLMDeviceReporting.Text = "Snow License Manager Device Reporting";
            this.cbConfigSLMDeviceReporting.UseVisualStyleBackColor = true;
            // 
            // cbConfigINVDeviceReporting
            // 
            this.cbConfigINVDeviceReporting.AutoSize = true;
            this.cbConfigINVDeviceReporting.Location = new System.Drawing.Point(20, 135);
            this.cbConfigINVDeviceReporting.Name = "cbConfigINVDeviceReporting";
            this.cbConfigINVDeviceReporting.Size = new System.Drawing.Size(186, 17);
            this.cbConfigINVDeviceReporting.TabIndex = 3;
            this.cbConfigINVDeviceReporting.Text = "Snow Inventory Device Reporting";
            this.cbConfigINVDeviceReporting.UseVisualStyleBackColor = true;
            // 
            // cbConfigINVServices
            // 
            this.cbConfigINVServices.AutoSize = true;
            this.cbConfigINVServices.Location = new System.Drawing.Point(20, 112);
            this.cbConfigINVServices.Name = "cbConfigINVServices";
            this.cbConfigINVServices.Size = new System.Drawing.Size(178, 17);
            this.cbConfigINVServices.TabIndex = 4;
            this.cbConfigINVServices.Text = "Snow Inventory Server Services";
            this.cbConfigINVServices.UseVisualStyleBackColor = true;
            // 
            // cbConfigINVProcessingDir
            // 
            this.cbConfigINVProcessingDir.AutoSize = true;
            this.cbConfigINVProcessingDir.Location = new System.Drawing.Point(20, 158);
            this.cbConfigINVProcessingDir.Name = "cbConfigINVProcessingDir";
            this.cbConfigINVProcessingDir.Size = new System.Drawing.Size(200, 17);
            this.cbConfigINVProcessingDir.TabIndex = 5;
            this.cbConfigINVProcessingDir.Text = "Snow Inventory Processing Directory";
            this.cbConfigINVProcessingDir.UseVisualStyleBackColor = true;
            // 
            // cbConfigSLMStorage
            // 
            this.cbConfigSLMStorage.AutoSize = true;
            this.cbConfigSLMStorage.Location = new System.Drawing.Point(20, 89);
            this.cbConfigSLMStorage.Name = "cbConfigSLMStorage";
            this.cbConfigSLMStorage.Size = new System.Drawing.Size(212, 17);
            this.cbConfigSLMStorage.TabIndex = 6;
            this.cbConfigSLMStorage.Text = "Snow License Manager Server Storage";
            this.cbConfigSLMStorage.UseVisualStyleBackColor = true;
            // 
            // cbConfigINVStorage
            // 
            this.cbConfigINVStorage.AutoSize = true;
            this.cbConfigINVStorage.Location = new System.Drawing.Point(20, 181);
            this.cbConfigINVStorage.Name = "cbConfigINVStorage";
            this.cbConfigINVStorage.Size = new System.Drawing.Size(174, 17);
            this.cbConfigINVStorage.TabIndex = 7;
            this.cbConfigINVStorage.Text = "Snow Inventory Server Storage";
            this.cbConfigINVStorage.UseVisualStyleBackColor = true;
            // 
            // btnConfigSave
            // 
            this.btnConfigSave.Location = new System.Drawing.Point(213, 287);
            this.btnConfigSave.Name = "btnConfigSave";
            this.btnConfigSave.Size = new System.Drawing.Size(75, 23);
            this.btnConfigSave.TabIndex = 8;
            this.btnConfigSave.Text = "Save";
            this.btnConfigSave.UseVisualStyleBackColor = true;
            // 
            // btnConfigCheckAll
            // 
            this.btnConfigCheckAll.Location = new System.Drawing.Point(213, 258);
            this.btnConfigCheckAll.Name = "btnConfigCheckAll";
            this.btnConfigCheckAll.Size = new System.Drawing.Size(75, 23);
            this.btnConfigCheckAll.TabIndex = 9;
            this.btnConfigCheckAll.Text = "Check All";
            this.btnConfigCheckAll.UseVisualStyleBackColor = true;
            // 
            // btnConfigUncheckAll
            // 
            this.btnConfigUncheckAll.Location = new System.Drawing.Point(213, 229);
            this.btnConfigUncheckAll.Name = "btnConfigUncheckAll";
            this.btnConfigUncheckAll.Size = new System.Drawing.Size(75, 23);
            this.btnConfigUncheckAll.TabIndex = 10;
            this.btnConfigUncheckAll.Text = "Uncheck All";
            this.btnConfigUncheckAll.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(340, 373);
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Snow Morning Check";
            this.tabControlMain.ResumeLayout(false);
            this.tabServers.ResumeLayout(false);
            this.tabServers.PerformLayout();
            this.gbServersSQL.ResumeLayout(false);
            this.gbServersSQL.PerformLayout();
            this.Configuration.ResumeLayout(false);
            this.Configuration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabServers;
        private System.Windows.Forms.TabPage tabSMTP;
        private System.Windows.Forms.TabPage tabServiceManager;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.TextBox txtServersSLM;
        private System.Windows.Forms.Label lblServersSLM;
        private System.Windows.Forms.Label lblServersSql;
        private System.Windows.Forms.Label lblServersINV;
        private System.Windows.Forms.TextBox txtServersSQL;
        private System.Windows.Forms.TextBox txtServersINV;
        private System.Windows.Forms.GroupBox gbServersSQL;
        private System.Windows.Forms.Label lblServersSQLUser;
        private System.Windows.Forms.TextBox txtlServersSQLUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtlServersSQLParam;
        private System.Windows.Forms.Label lblServersSQLPass;
        private System.Windows.Forms.TextBox txtlServersSQLPass;
        private System.Windows.Forms.Button btnServersSQLTest;
        private System.Windows.Forms.Button btnServersSave;
        private System.Windows.Forms.TabPage Configuration;
        private System.Windows.Forms.CheckBox cbConfigDUJStatus;
        private System.Windows.Forms.CheckBox cbConfigSLMServices;
        private System.Windows.Forms.CheckBox cbConfigSLMDeviceReporting;
        private System.Windows.Forms.CheckBox cbConfigINVServices;
        private System.Windows.Forms.CheckBox cbConfigINVDeviceReporting;
        private System.Windows.Forms.CheckBox cbConfigINVProcessingDir;
        private System.Windows.Forms.CheckBox cbConfigINVStorage;
        private System.Windows.Forms.CheckBox cbConfigSLMStorage;
        private System.Windows.Forms.Button btnConfigSave;
        private System.Windows.Forms.Button btnConfigCheckAll;
        private System.Windows.Forms.Button btnConfigUncheckAll;
    }
}

