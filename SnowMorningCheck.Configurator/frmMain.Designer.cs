namespace SnowPlatformMonitor.Configurator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabConfiguration = new System.Windows.Forms.TabPage();
            this.btnConfigTest = new System.Windows.Forms.Button();
            this.cbConfigSRSImport = new System.Windows.Forms.CheckBox();
            this.btnConfigAdvanced = new System.Windows.Forms.Button();
            this.btnConfigSave = new System.Windows.Forms.Button();
            this.cbConfigLogInterrogator = new System.Windows.Forms.CheckBox();
            this.gbConfigAdvanced = new System.Windows.Forms.GroupBox();
            this.lblConfigAdvProcessingDirectory = new System.Windows.Forms.Label();
            this.txtConfigAdvINVProcessingDirectory = new System.Windows.Forms.TextBox();
            this.lblConfigAdvINVProcessingThreshold = new System.Windows.Forms.Label();
            this.numConfigAdvINVProcessingThreshold = new System.Windows.Forms.NumericUpDown();
            this.lblConfigAdvINVDeviceThreshold = new System.Windows.Forms.Label();
            this.numConfigAdvINVDeviceThreshold = new System.Windows.Forms.NumericUpDown();
            this.numConfigAdvSLMDeviceThreshold = new System.Windows.Forms.NumericUpDown();
            this.lblConfigAdvSLMDeviceThreshold = new System.Windows.Forms.Label();
            this.cbConfigOffice365Adobe = new System.Windows.Forms.CheckBox();
            this.gbServiceMSchedule = new System.Windows.Forms.GroupBox();
            this.lblServiceMTimeSecs = new System.Windows.Forms.Label();
            this.lblServiceMTimeMins = new System.Windows.Forms.Label();
            this.numServiceMScheduleTimeSecs = new System.Windows.Forms.NumericUpDown();
            this.lblServiceMTimeHours = new System.Windows.Forms.Label();
            this.numServiceMScheduleTimeMins = new System.Windows.Forms.NumericUpDown();
            this.numServiceMScheduleTimeHours = new System.Windows.Forms.NumericUpDown();
            this.lblServiceMScheduleTime = new System.Windows.Forms.Label();
            this.cbConfigINVStorage = new System.Windows.Forms.CheckBox();
            this.cbConfigSLMStorage = new System.Windows.Forms.CheckBox();
            this.cbConfigINVProcessingDir = new System.Windows.Forms.CheckBox();
            this.cbConfigINVServices = new System.Windows.Forms.CheckBox();
            this.cbConfigINVDeviceReporting = new System.Windows.Forms.CheckBox();
            this.cbConfigSLMDeviceReporting = new System.Windows.Forms.CheckBox();
            this.cbConfigSLMServices = new System.Windows.Forms.CheckBox();
            this.cbConfigDUJStatus = new System.Windows.Forms.CheckBox();
            this.tabServers = new System.Windows.Forms.TabPage();
            this.gbServersINV = new System.Windows.Forms.GroupBox();
            this.lblServersINVDrive = new System.Windows.Forms.Label();
            this.txtServersINVDrive = new System.Windows.Forms.TextBox();
            this.lblServersINV = new System.Windows.Forms.Label();
            this.txtServersINV = new System.Windows.Forms.TextBox();
            this.gbServersSLM = new System.Windows.Forms.GroupBox();
            this.lblServersSLMDrive = new System.Windows.Forms.Label();
            this.txtServersSLMDrive = new System.Windows.Forms.TextBox();
            this.txtServersSLM = new System.Windows.Forms.TextBox();
            this.lblServersSLM = new System.Windows.Forms.Label();
            this.btnServersSave = new System.Windows.Forms.Button();
            this.gbServersSQL = new System.Windows.Forms.GroupBox();
            this.btnServersSQLTest = new System.Windows.Forms.Button();
            this.lblServersSQLParam = new System.Windows.Forms.Label();
            this.lblServersSql = new System.Windows.Forms.Label();
            this.txtServersSQLParam = new System.Windows.Forms.TextBox();
            this.lblServersSQLPass = new System.Windows.Forms.Label();
            this.txtServersSQL = new System.Windows.Forms.TextBox();
            this.txtServersSQLPass = new System.Windows.Forms.TextBox();
            this.txtServersSQLUser = new System.Windows.Forms.TextBox();
            this.lblServersSQLUser = new System.Windows.Forms.Label();
            this.tabSMTP = new System.Windows.Forms.TabPage();
            this.lblSMTPSenderName = new System.Windows.Forms.Label();
            this.txtSMTPSenderName = new System.Windows.Forms.TextBox();
            this.lblSMTPSubject = new System.Windows.Forms.Label();
            this.txtSMTPSubject = new System.Windows.Forms.TextBox();
            this.cbxSMTPEnableSSL = new System.Windows.Forms.CheckBox();
            this.numSMTPPort = new System.Windows.Forms.NumericUpDown();
            this.btnSMTPTest = new System.Windows.Forms.Button();
            this.btnSMTPSave = new System.Windows.Forms.Button();
            this.lblSMTPcc = new System.Windows.Forms.Label();
            this.txtSMTPcc = new System.Windows.Forms.TextBox();
            this.lbSMTPSendTo = new System.Windows.Forms.Label();
            this.txtSMTPSendTo = new System.Windows.Forms.TextBox();
            this.lblSMTPSender = new System.Windows.Forms.Label();
            this.txtSMTPSender = new System.Windows.Forms.TextBox();
            this.lblSMTPHost = new System.Windows.Forms.Label();
            this.txtSMTPHost = new System.Windows.Forms.TextBox();
            this.lblSMTPPort = new System.Windows.Forms.Label();
            this.lblSMTPPassword = new System.Windows.Forms.Label();
            this.txtSMTPPassword = new System.Windows.Forms.TextBox();
            this.lblSMTPUsername = new System.Windows.Forms.Label();
            this.txtSMTPUsername = new System.Windows.Forms.TextBox();
            this.tabServiceManager = new System.Windows.Forms.TabPage();
            this.btnServiceMngrRefresh = new System.Windows.Forms.Button();
            this.btnServiceMngrUninstall = new System.Windows.Forms.Button();
            this.btnServiceMngrInstall = new System.Windows.Forms.Button();
            this.btnServiceMngrStop = new System.Windows.Forms.Button();
            this.btnServiceMngrStart = new System.Windows.Forms.Button();
            this.pbServiceMngrStatus = new System.Windows.Forms.PictureBox();
            this.tabLogging = new System.Windows.Forms.TabPage();
            this.linkLoggingFormat = new System.Windows.Forms.LinkLabel();
            this.btnLoggingSave = new System.Windows.Forms.Button();
            this.gbLoggingService = new System.Windows.Forms.GroupBox();
            this.lblLoggingServiceSizeMB = new System.Windows.Forms.Label();
            this.lblLoggingServiceFormat = new System.Windows.Forms.Label();
            this.numLoggingServiceSize = new System.Windows.Forms.NumericUpDown();
            this.lblLoggingServiceSize = new System.Windows.Forms.Label();
            this.txtLoggingServiceFormat = new System.Windows.Forms.TextBox();
            this.cbLoggingServiceLevel = new System.Windows.Forms.ComboBox();
            this.lblLoggingServiceLevel = new System.Windows.Forms.Label();
            this.gbLoggingGUI = new System.Windows.Forms.GroupBox();
            this.lblLoggingGUISizeMB = new System.Windows.Forms.Label();
            this.numLoggingGUISize = new System.Windows.Forms.NumericUpDown();
            this.lblLoggingGUISize = new System.Windows.Forms.Label();
            this.txtLoggingGUIFormat = new System.Windows.Forms.TextBox();
            this.lblLoggingGUIFormat = new System.Windows.Forms.Label();
            this.cbLoggingGUILevel = new System.Windows.Forms.ComboBox();
            this.lblLoggingGUILevel = new System.Windows.Forms.Label();
            this.tabHelp = new System.Windows.Forms.TabPage();
            this.btnHelpWiki = new System.Windows.Forms.Button();
            this.btnHelpReleases = new System.Windows.Forms.Button();
            this.btnHelpSupport = new System.Windows.Forms.Button();
            this.btnHelpExportsDir = new System.Windows.Forms.Button();
            this.btnHelpConfigDir = new System.Windows.Forms.Button();
            this.btnHelpLogDir = new System.Windows.Forms.Button();
            this.lblHelpAppInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControlMain.SuspendLayout();
            this.tabConfiguration.SuspendLayout();
            this.gbConfigAdvanced.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numConfigAdvINVProcessingThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numConfigAdvINVDeviceThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numConfigAdvSLMDeviceThreshold)).BeginInit();
            this.gbServiceMSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numServiceMScheduleTimeSecs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServiceMScheduleTimeMins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServiceMScheduleTimeHours)).BeginInit();
            this.tabServers.SuspendLayout();
            this.gbServersINV.SuspendLayout();
            this.gbServersSLM.SuspendLayout();
            this.gbServersSQL.SuspendLayout();
            this.tabSMTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSMTPPort)).BeginInit();
            this.tabServiceManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbServiceMngrStatus)).BeginInit();
            this.tabLogging.SuspendLayout();
            this.gbLoggingService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLoggingServiceSize)).BeginInit();
            this.gbLoggingGUI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLoggingGUISize)).BeginInit();
            this.tabHelp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabConfiguration);
            this.tabControlMain.Controls.Add(this.tabServers);
            this.tabControlMain.Controls.Add(this.tabSMTP);
            this.tabControlMain.Controls.Add(this.tabServiceManager);
            this.tabControlMain.Controls.Add(this.tabLogging);
            this.tabControlMain.Controls.Add(this.tabHelp);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(316, 620);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.TabStop = false;
            // 
            // tabConfiguration
            // 
            this.tabConfiguration.Controls.Add(this.btnConfigTest);
            this.tabConfiguration.Controls.Add(this.cbConfigSRSImport);
            this.tabConfiguration.Controls.Add(this.btnConfigAdvanced);
            this.tabConfiguration.Controls.Add(this.btnConfigSave);
            this.tabConfiguration.Controls.Add(this.cbConfigLogInterrogator);
            this.tabConfiguration.Controls.Add(this.gbConfigAdvanced);
            this.tabConfiguration.Controls.Add(this.cbConfigOffice365Adobe);
            this.tabConfiguration.Controls.Add(this.gbServiceMSchedule);
            this.tabConfiguration.Controls.Add(this.cbConfigINVStorage);
            this.tabConfiguration.Controls.Add(this.cbConfigSLMStorage);
            this.tabConfiguration.Controls.Add(this.cbConfigINVProcessingDir);
            this.tabConfiguration.Controls.Add(this.cbConfigINVServices);
            this.tabConfiguration.Controls.Add(this.cbConfigINVDeviceReporting);
            this.tabConfiguration.Controls.Add(this.cbConfigSLMDeviceReporting);
            this.tabConfiguration.Controls.Add(this.cbConfigSLMServices);
            this.tabConfiguration.Controls.Add(this.cbConfigDUJStatus);
            this.tabConfiguration.Location = new System.Drawing.Point(4, 22);
            this.tabConfiguration.Name = "tabConfiguration";
            this.tabConfiguration.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfiguration.Size = new System.Drawing.Size(308, 594);
            this.tabConfiguration.TabIndex = 4;
            this.tabConfiguration.Text = "General";
            this.tabConfiguration.UseVisualStyleBackColor = true;
            // 
            // btnConfigTest
            // 
            this.btnConfigTest.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConfigTest.Location = new System.Drawing.Point(117, 565);
            this.btnConfigTest.Name = "btnConfigTest";
            this.btnConfigTest.Size = new System.Drawing.Size(75, 23);
            this.btnConfigTest.TabIndex = 16;
            this.btnConfigTest.Text = "Test";
            this.btnConfigTest.UseVisualStyleBackColor = true;
            this.btnConfigTest.Click += new System.EventHandler(this.btnConfigTest_Click);
            // 
            // cbConfigSRSImport
            // 
            this.cbConfigSRSImport.AutoSize = true;
            this.cbConfigSRSImport.Location = new System.Drawing.Point(20, 136);
            this.cbConfigSRSImport.Name = "cbConfigSRSImport";
            this.cbConfigSRSImport.Size = new System.Drawing.Size(106, 17);
            this.cbConfigSRSImport.TabIndex = 6;
            this.cbConfigSRSImport.Text = "SRS Import Date";
            this.cbConfigSRSImport.UseVisualStyleBackColor = true;
            // 
            // btnConfigAdvanced
            // 
            this.btnConfigAdvanced.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConfigAdvanced.Location = new System.Drawing.Point(20, 565);
            this.btnConfigAdvanced.Name = "btnConfigAdvanced";
            this.btnConfigAdvanced.Size = new System.Drawing.Size(75, 23);
            this.btnConfigAdvanced.TabIndex = 15;
            this.btnConfigAdvanced.Text = "Advanced";
            this.btnConfigAdvanced.UseVisualStyleBackColor = true;
            this.btnConfigAdvanced.Click += new System.EventHandler(this.btnConfigAdvanced_Click);
            // 
            // btnConfigSave
            // 
            this.btnConfigSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConfigSave.Location = new System.Drawing.Point(213, 565);
            this.btnConfigSave.Name = "btnConfigSave";
            this.btnConfigSave.Size = new System.Drawing.Size(75, 23);
            this.btnConfigSave.TabIndex = 17;
            this.btnConfigSave.Text = "Save";
            this.btnConfigSave.UseVisualStyleBackColor = true;
            this.btnConfigSave.Click += new System.EventHandler(this.btnConfigSave_Click);
            // 
            // cbConfigLogInterrogator
            // 
            this.cbConfigLogInterrogator.AutoSize = true;
            this.cbConfigLogInterrogator.Enabled = false;
            this.cbConfigLogInterrogator.Location = new System.Drawing.Point(20, 159);
            this.cbConfigLogInterrogator.Name = "cbConfigLogInterrogator";
            this.cbConfigLogInterrogator.Size = new System.Drawing.Size(147, 17);
            this.cbConfigLogInterrogator.TabIndex = 7;
            this.cbConfigLogInterrogator.Text = "Platform Logs Interrogator";
            this.cbConfigLogInterrogator.UseVisualStyleBackColor = true;
            // 
            // gbConfigAdvanced
            // 
            this.gbConfigAdvanced.Controls.Add(this.lblConfigAdvProcessingDirectory);
            this.gbConfigAdvanced.Controls.Add(this.txtConfigAdvINVProcessingDirectory);
            this.gbConfigAdvanced.Controls.Add(this.lblConfigAdvINVProcessingThreshold);
            this.gbConfigAdvanced.Controls.Add(this.numConfigAdvINVProcessingThreshold);
            this.gbConfigAdvanced.Controls.Add(this.lblConfigAdvINVDeviceThreshold);
            this.gbConfigAdvanced.Controls.Add(this.numConfigAdvINVDeviceThreshold);
            this.gbConfigAdvanced.Controls.Add(this.numConfigAdvSLMDeviceThreshold);
            this.gbConfigAdvanced.Controls.Add(this.lblConfigAdvSLMDeviceThreshold);
            this.gbConfigAdvanced.Location = new System.Drawing.Point(20, 347);
            this.gbConfigAdvanced.Name = "gbConfigAdvanced";
            this.gbConfigAdvanced.Size = new System.Drawing.Size(268, 211);
            this.gbConfigAdvanced.TabIndex = 17;
            this.gbConfigAdvanced.TabStop = false;
            this.gbConfigAdvanced.Text = "Advanced Preferences";
            this.gbConfigAdvanced.Visible = false;
            // 
            // lblConfigAdvProcessingDirectory
            // 
            this.lblConfigAdvProcessingDirectory.AutoSize = true;
            this.lblConfigAdvProcessingDirectory.Location = new System.Drawing.Point(17, 157);
            this.lblConfigAdvProcessingDirectory.Name = "lblConfigAdvProcessingDirectory";
            this.lblConfigAdvProcessingDirectory.Size = new System.Drawing.Size(135, 13);
            this.lblConfigAdvProcessingDirectory.TabIndex = 7;
            this.lblConfigAdvProcessingDirectory.Text = "SINV Processing Directory:";
            // 
            // txtConfigAdvINVProcessingDirectory
            // 
            this.txtConfigAdvINVProcessingDirectory.Location = new System.Drawing.Point(20, 173);
            this.txtConfigAdvINVProcessingDirectory.Name = "txtConfigAdvINVProcessingDirectory";
            this.txtConfigAdvINVProcessingDirectory.Size = new System.Drawing.Size(227, 20);
            this.txtConfigAdvINVProcessingDirectory.TabIndex = 6;
            this.txtConfigAdvINVProcessingDirectory.TabStop = false;
            this.txtConfigAdvINVProcessingDirectory.Text = "\\Program Files\\Snow Software\\Snow Inventory\\Server\\Incoming\\data\\processing";
            // 
            // lblConfigAdvINVProcessingThreshold
            // 
            this.lblConfigAdvINVProcessingThreshold.AutoSize = true;
            this.lblConfigAdvINVProcessingThreshold.Location = new System.Drawing.Point(17, 113);
            this.lblConfigAdvINVProcessingThreshold.Name = "lblConfigAdvINVProcessingThreshold";
            this.lblConfigAdvINVProcessingThreshold.Size = new System.Drawing.Size(163, 13);
            this.lblConfigAdvINVProcessingThreshold.TabIndex = 5;
            this.lblConfigAdvINVProcessingThreshold.Text = "SINV Max Processing Threshold:";
            // 
            // numConfigAdvINVProcessingThreshold
            // 
            this.numConfigAdvINVProcessingThreshold.Location = new System.Drawing.Point(20, 129);
            this.numConfigAdvINVProcessingThreshold.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numConfigAdvINVProcessingThreshold.Name = "numConfigAdvINVProcessingThreshold";
            this.numConfigAdvINVProcessingThreshold.Size = new System.Drawing.Size(227, 20);
            this.numConfigAdvINVProcessingThreshold.TabIndex = 4;
            this.numConfigAdvINVProcessingThreshold.TabStop = false;
            this.numConfigAdvINVProcessingThreshold.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblConfigAdvINVDeviceThreshold
            // 
            this.lblConfigAdvINVDeviceThreshold.AutoSize = true;
            this.lblConfigAdvINVDeviceThreshold.Location = new System.Drawing.Point(17, 69);
            this.lblConfigAdvINVDeviceThreshold.Name = "lblConfigAdvINVDeviceThreshold";
            this.lblConfigAdvINVDeviceThreshold.Size = new System.Drawing.Size(193, 13);
            this.lblConfigAdvINVDeviceThreshold.TabIndex = 3;
            this.lblConfigAdvINVDeviceThreshold.Text = "SINV min. Device Reporting Threshold:";
            // 
            // numConfigAdvINVDeviceThreshold
            // 
            this.numConfigAdvINVDeviceThreshold.Location = new System.Drawing.Point(20, 85);
            this.numConfigAdvINVDeviceThreshold.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numConfigAdvINVDeviceThreshold.Name = "numConfigAdvINVDeviceThreshold";
            this.numConfigAdvINVDeviceThreshold.Size = new System.Drawing.Size(227, 20);
            this.numConfigAdvINVDeviceThreshold.TabIndex = 2;
            this.numConfigAdvINVDeviceThreshold.TabStop = false;
            this.numConfigAdvINVDeviceThreshold.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // numConfigAdvSLMDeviceThreshold
            // 
            this.numConfigAdvSLMDeviceThreshold.Location = new System.Drawing.Point(20, 41);
            this.numConfigAdvSLMDeviceThreshold.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numConfigAdvSLMDeviceThreshold.Name = "numConfigAdvSLMDeviceThreshold";
            this.numConfigAdvSLMDeviceThreshold.Size = new System.Drawing.Size(227, 20);
            this.numConfigAdvSLMDeviceThreshold.TabIndex = 1;
            this.numConfigAdvSLMDeviceThreshold.TabStop = false;
            this.numConfigAdvSLMDeviceThreshold.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // lblConfigAdvSLMDeviceThreshold
            // 
            this.lblConfigAdvSLMDeviceThreshold.AutoSize = true;
            this.lblConfigAdvSLMDeviceThreshold.Location = new System.Drawing.Point(17, 25);
            this.lblConfigAdvSLMDeviceThreshold.Name = "lblConfigAdvSLMDeviceThreshold";
            this.lblConfigAdvSLMDeviceThreshold.Size = new System.Drawing.Size(190, 13);
            this.lblConfigAdvSLMDeviceThreshold.TabIndex = 0;
            this.lblConfigAdvSLMDeviceThreshold.Text = "SLM min. Device Reporting Threshold:";
            // 
            // cbConfigOffice365Adobe
            // 
            this.cbConfigOffice365Adobe.AutoSize = true;
            this.cbConfigOffice365Adobe.Location = new System.Drawing.Point(20, 113);
            this.cbConfigOffice365Adobe.Name = "cbConfigOffice365Adobe";
            this.cbConfigOffice365Adobe.Size = new System.Drawing.Size(197, 17);
            this.cbConfigOffice365Adobe.TabIndex = 5;
            this.cbConfigOffice365Adobe.Text = "Office 365 and Adobe Import Tables";
            this.cbConfigOffice365Adobe.UseVisualStyleBackColor = true;
            // 
            // gbServiceMSchedule
            // 
            this.gbServiceMSchedule.Controls.Add(this.lblServiceMTimeSecs);
            this.gbServiceMSchedule.Controls.Add(this.lblServiceMTimeMins);
            this.gbServiceMSchedule.Controls.Add(this.numServiceMScheduleTimeSecs);
            this.gbServiceMSchedule.Controls.Add(this.lblServiceMTimeHours);
            this.gbServiceMSchedule.Controls.Add(this.numServiceMScheduleTimeMins);
            this.gbServiceMSchedule.Controls.Add(this.numServiceMScheduleTimeHours);
            this.gbServiceMSchedule.Controls.Add(this.lblServiceMScheduleTime);
            this.gbServiceMSchedule.Location = new System.Drawing.Point(20, 20);
            this.gbServiceMSchedule.Name = "gbServiceMSchedule";
            this.gbServiceMSchedule.Size = new System.Drawing.Size(268, 53);
            this.gbServiceMSchedule.TabIndex = 14;
            this.gbServiceMSchedule.TabStop = false;
            this.gbServiceMSchedule.Text = "Schedule (Daily)";
            // 
            // lblServiceMTimeSecs
            // 
            this.lblServiceMTimeSecs.AutoSize = true;
            this.lblServiceMTimeSecs.Location = new System.Drawing.Point(249, 22);
            this.lblServiceMTimeSecs.Name = "lblServiceMTimeSecs";
            this.lblServiceMTimeSecs.Size = new System.Drawing.Size(14, 13);
            this.lblServiceMTimeSecs.TabIndex = 4;
            this.lblServiceMTimeSecs.Text = "S";
            // 
            // lblServiceMTimeMins
            // 
            this.lblServiceMTimeMins.AutoSize = true;
            this.lblServiceMTimeMins.Location = new System.Drawing.Point(178, 22);
            this.lblServiceMTimeMins.Name = "lblServiceMTimeMins";
            this.lblServiceMTimeMins.Size = new System.Drawing.Size(16, 13);
            this.lblServiceMTimeMins.TabIndex = 3;
            this.lblServiceMTimeMins.Text = "M";
            // 
            // numServiceMScheduleTimeSecs
            // 
            this.numServiceMScheduleTimeSecs.Location = new System.Drawing.Point(200, 18);
            this.numServiceMScheduleTimeSecs.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numServiceMScheduleTimeSecs.Name = "numServiceMScheduleTimeSecs";
            this.numServiceMScheduleTimeSecs.Size = new System.Drawing.Size(47, 20);
            this.numServiceMScheduleTimeSecs.TabIndex = 3;
            // 
            // lblServiceMTimeHours
            // 
            this.lblServiceMTimeHours.AutoSize = true;
            this.lblServiceMTimeHours.Location = new System.Drawing.Point(108, 22);
            this.lblServiceMTimeHours.Name = "lblServiceMTimeHours";
            this.lblServiceMTimeHours.Size = new System.Drawing.Size(15, 13);
            this.lblServiceMTimeHours.TabIndex = 2;
            this.lblServiceMTimeHours.Text = "H";
            // 
            // numServiceMScheduleTimeMins
            // 
            this.numServiceMScheduleTimeMins.Location = new System.Drawing.Point(129, 18);
            this.numServiceMScheduleTimeMins.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numServiceMScheduleTimeMins.Name = "numServiceMScheduleTimeMins";
            this.numServiceMScheduleTimeMins.Size = new System.Drawing.Size(47, 20);
            this.numServiceMScheduleTimeMins.TabIndex = 2;
            // 
            // numServiceMScheduleTimeHours
            // 
            this.numServiceMScheduleTimeHours.Location = new System.Drawing.Point(59, 18);
            this.numServiceMScheduleTimeHours.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numServiceMScheduleTimeHours.Name = "numServiceMScheduleTimeHours";
            this.numServiceMScheduleTimeHours.Size = new System.Drawing.Size(47, 20);
            this.numServiceMScheduleTimeHours.TabIndex = 1;
            // 
            // lblServiceMScheduleTime
            // 
            this.lblServiceMScheduleTime.AutoSize = true;
            this.lblServiceMScheduleTime.Location = new System.Drawing.Point(20, 20);
            this.lblServiceMScheduleTime.Name = "lblServiceMScheduleTime";
            this.lblServiceMScheduleTime.Size = new System.Drawing.Size(33, 13);
            this.lblServiceMScheduleTime.TabIndex = 0;
            this.lblServiceMScheduleTime.Text = "Time:";
            // 
            // cbConfigINVStorage
            // 
            this.cbConfigINVStorage.AutoSize = true;
            this.cbConfigINVStorage.Location = new System.Drawing.Point(20, 320);
            this.cbConfigINVStorage.Name = "cbConfigINVStorage";
            this.cbConfigINVStorage.Size = new System.Drawing.Size(174, 17);
            this.cbConfigINVStorage.TabIndex = 14;
            this.cbConfigINVStorage.Text = "Snow Inventory Server Storage";
            this.cbConfigINVStorage.UseVisualStyleBackColor = true;
            // 
            // cbConfigSLMStorage
            // 
            this.cbConfigSLMStorage.AutoSize = true;
            this.cbConfigSLMStorage.Location = new System.Drawing.Point(20, 228);
            this.cbConfigSLMStorage.Name = "cbConfigSLMStorage";
            this.cbConfigSLMStorage.Size = new System.Drawing.Size(212, 17);
            this.cbConfigSLMStorage.TabIndex = 10;
            this.cbConfigSLMStorage.Text = "Snow License Manager Server Storage";
            this.cbConfigSLMStorage.UseVisualStyleBackColor = true;
            // 
            // cbConfigINVProcessingDir
            // 
            this.cbConfigINVProcessingDir.AutoSize = true;
            this.cbConfigINVProcessingDir.Location = new System.Drawing.Point(20, 297);
            this.cbConfigINVProcessingDir.Name = "cbConfigINVProcessingDir";
            this.cbConfigINVProcessingDir.Size = new System.Drawing.Size(200, 17);
            this.cbConfigINVProcessingDir.TabIndex = 13;
            this.cbConfigINVProcessingDir.Text = "Snow Inventory Processing Directory";
            this.cbConfigINVProcessingDir.UseVisualStyleBackColor = true;
            // 
            // cbConfigINVServices
            // 
            this.cbConfigINVServices.AutoSize = true;
            this.cbConfigINVServices.Location = new System.Drawing.Point(20, 251);
            this.cbConfigINVServices.Name = "cbConfigINVServices";
            this.cbConfigINVServices.Size = new System.Drawing.Size(178, 17);
            this.cbConfigINVServices.TabIndex = 11;
            this.cbConfigINVServices.Text = "Snow Inventory Server Services";
            this.cbConfigINVServices.UseVisualStyleBackColor = true;
            // 
            // cbConfigINVDeviceReporting
            // 
            this.cbConfigINVDeviceReporting.AutoSize = true;
            this.cbConfigINVDeviceReporting.Location = new System.Drawing.Point(20, 274);
            this.cbConfigINVDeviceReporting.Name = "cbConfigINVDeviceReporting";
            this.cbConfigINVDeviceReporting.Size = new System.Drawing.Size(186, 17);
            this.cbConfigINVDeviceReporting.TabIndex = 12;
            this.cbConfigINVDeviceReporting.Text = "Snow Inventory Device Reporting";
            this.cbConfigINVDeviceReporting.UseVisualStyleBackColor = true;
            // 
            // cbConfigSLMDeviceReporting
            // 
            this.cbConfigSLMDeviceReporting.AutoSize = true;
            this.cbConfigSLMDeviceReporting.Location = new System.Drawing.Point(20, 205);
            this.cbConfigSLMDeviceReporting.Name = "cbConfigSLMDeviceReporting";
            this.cbConfigSLMDeviceReporting.Size = new System.Drawing.Size(224, 17);
            this.cbConfigSLMDeviceReporting.TabIndex = 9;
            this.cbConfigSLMDeviceReporting.Text = "Snow License Manager Device Reporting";
            this.cbConfigSLMDeviceReporting.UseVisualStyleBackColor = true;
            // 
            // cbConfigSLMServices
            // 
            this.cbConfigSLMServices.AutoSize = true;
            this.cbConfigSLMServices.Location = new System.Drawing.Point(20, 182);
            this.cbConfigSLMServices.Name = "cbConfigSLMServices";
            this.cbConfigSLMServices.Size = new System.Drawing.Size(216, 17);
            this.cbConfigSLMServices.TabIndex = 8;
            this.cbConfigSLMServices.Text = "Snow License Manager Server Services";
            this.cbConfigSLMServices.UseVisualStyleBackColor = true;
            // 
            // cbConfigDUJStatus
            // 
            this.cbConfigDUJStatus.AutoSize = true;
            this.cbConfigDUJStatus.Location = new System.Drawing.Point(20, 90);
            this.cbConfigDUJStatus.Name = "cbConfigDUJStatus";
            this.cbConfigDUJStatus.Size = new System.Drawing.Size(140, 17);
            this.cbConfigDUJStatus.TabIndex = 4;
            this.cbConfigDUJStatus.Text = "Data Update Job Status";
            this.cbConfigDUJStatus.UseVisualStyleBackColor = true;
            // 
            // tabServers
            // 
            this.tabServers.Controls.Add(this.gbServersINV);
            this.tabServers.Controls.Add(this.gbServersSLM);
            this.tabServers.Controls.Add(this.btnServersSave);
            this.tabServers.Controls.Add(this.gbServersSQL);
            this.tabServers.Location = new System.Drawing.Point(4, 22);
            this.tabServers.Name = "tabServers";
            this.tabServers.Padding = new System.Windows.Forms.Padding(3);
            this.tabServers.Size = new System.Drawing.Size(308, 594);
            this.tabServers.TabIndex = 0;
            this.tabServers.Text = "Servers";
            this.tabServers.UseVisualStyleBackColor = true;
            // 
            // gbServersINV
            // 
            this.gbServersINV.Controls.Add(this.lblServersINVDrive);
            this.gbServersINV.Controls.Add(this.txtServersINVDrive);
            this.gbServersINV.Controls.Add(this.lblServersINV);
            this.gbServersINV.Controls.Add(this.txtServersINV);
            this.gbServersINV.Location = new System.Drawing.Point(20, 106);
            this.gbServersINV.Name = "gbServersINV";
            this.gbServersINV.Size = new System.Drawing.Size(271, 80);
            this.gbServersINV.TabIndex = 9;
            this.gbServersINV.TabStop = false;
            this.gbServersINV.Text = "Inventory Server";
            // 
            // lblServersINVDrive
            // 
            this.lblServersINVDrive.AutoSize = true;
            this.lblServersINVDrive.Location = new System.Drawing.Point(9, 49);
            this.lblServersINVDrive.Name = "lblServersINVDrive";
            this.lblServersINVDrive.Size = new System.Drawing.Size(69, 13);
            this.lblServersINVDrive.TabIndex = 4;
            this.lblServersINVDrive.Text = "Install Drive*:";
            // 
            // txtServersINVDrive
            // 
            this.txtServersINVDrive.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtServersINVDrive.Location = new System.Drawing.Point(84, 46);
            this.txtServersINVDrive.Name = "txtServersINVDrive";
            this.txtServersINVDrive.Size = new System.Drawing.Size(166, 20);
            this.txtServersINVDrive.TabIndex = 4;
            // 
            // lblServersINV
            // 
            this.lblServersINV.AutoSize = true;
            this.lblServersINV.Location = new System.Drawing.Point(33, 22);
            this.lblServersINV.Name = "lblServersINV";
            this.lblServersINV.Size = new System.Drawing.Size(45, 13);
            this.lblServersINV.TabIndex = 4;
            this.lblServersINV.Text = "Server*:";
            // 
            // txtServersINV
            // 
            this.txtServersINV.Location = new System.Drawing.Point(84, 19);
            this.txtServersINV.Name = "txtServersINV";
            this.txtServersINV.Size = new System.Drawing.Size(166, 20);
            this.txtServersINV.TabIndex = 3;
            // 
            // gbServersSLM
            // 
            this.gbServersSLM.Controls.Add(this.lblServersSLMDrive);
            this.gbServersSLM.Controls.Add(this.txtServersSLMDrive);
            this.gbServersSLM.Controls.Add(this.txtServersSLM);
            this.gbServersSLM.Controls.Add(this.lblServersSLM);
            this.gbServersSLM.Location = new System.Drawing.Point(20, 20);
            this.gbServersSLM.Name = "gbServersSLM";
            this.gbServersSLM.Size = new System.Drawing.Size(271, 80);
            this.gbServersSLM.TabIndex = 8;
            this.gbServersSLM.TabStop = false;
            this.gbServersSLM.Text = "License Manager";
            // 
            // lblServersSLMDrive
            // 
            this.lblServersSLMDrive.AutoSize = true;
            this.lblServersSLMDrive.Location = new System.Drawing.Point(9, 49);
            this.lblServersSLMDrive.Name = "lblServersSLMDrive";
            this.lblServersSLMDrive.Size = new System.Drawing.Size(69, 13);
            this.lblServersSLMDrive.TabIndex = 3;
            this.lblServersSLMDrive.Text = "Install Drive*:";
            // 
            // txtServersSLMDrive
            // 
            this.txtServersSLMDrive.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtServersSLMDrive.Location = new System.Drawing.Point(84, 46);
            this.txtServersSLMDrive.Name = "txtServersSLMDrive";
            this.txtServersSLMDrive.Size = new System.Drawing.Size(166, 20);
            this.txtServersSLMDrive.TabIndex = 2;
            // 
            // txtServersSLM
            // 
            this.txtServersSLM.Location = new System.Drawing.Point(84, 20);
            this.txtServersSLM.Name = "txtServersSLM";
            this.txtServersSLM.Size = new System.Drawing.Size(166, 20);
            this.txtServersSLM.TabIndex = 1;
            // 
            // lblServersSLM
            // 
            this.lblServersSLM.AutoSize = true;
            this.lblServersSLM.Location = new System.Drawing.Point(33, 23);
            this.lblServersSLM.Name = "lblServersSLM";
            this.lblServersSLM.Size = new System.Drawing.Size(45, 13);
            this.lblServersSLM.TabIndex = 0;
            this.lblServersSLM.Text = "Server*:";
            // 
            // btnServersSave
            // 
            this.btnServersSave.Enabled = false;
            this.btnServersSave.Location = new System.Drawing.Point(213, 352);
            this.btnServersSave.Name = "btnServersSave";
            this.btnServersSave.Size = new System.Drawing.Size(75, 23);
            this.btnServersSave.TabIndex = 10;
            this.btnServersSave.TabStop = false;
            this.btnServersSave.Text = "Save";
            this.btnServersSave.UseVisualStyleBackColor = true;
            this.btnServersSave.Click += new System.EventHandler(this.btnServersSave_Click);
            // 
            // gbServersSQL
            // 
            this.gbServersSQL.Controls.Add(this.btnServersSQLTest);
            this.gbServersSQL.Controls.Add(this.lblServersSQLParam);
            this.gbServersSQL.Controls.Add(this.lblServersSql);
            this.gbServersSQL.Controls.Add(this.txtServersSQLParam);
            this.gbServersSQL.Controls.Add(this.lblServersSQLPass);
            this.gbServersSQL.Controls.Add(this.txtServersSQL);
            this.gbServersSQL.Controls.Add(this.txtServersSQLPass);
            this.gbServersSQL.Controls.Add(this.txtServersSQLUser);
            this.gbServersSQL.Controls.Add(this.lblServersSQLUser);
            this.gbServersSQL.Location = new System.Drawing.Point(20, 192);
            this.gbServersSQL.Name = "gbServersSQL";
            this.gbServersSQL.Size = new System.Drawing.Size(271, 154);
            this.gbServersSQL.TabIndex = 6;
            this.gbServersSQL.TabStop = false;
            this.gbServersSQL.Text = "SQL Configuration";
            // 
            // btnServersSQLTest
            // 
            this.btnServersSQLTest.Location = new System.Drawing.Point(175, 123);
            this.btnServersSQLTest.Name = "btnServersSQLTest";
            this.btnServersSQLTest.Size = new System.Drawing.Size(75, 23);
            this.btnServersSQLTest.TabIndex = 9;
            this.btnServersSQLTest.Text = "Test";
            this.btnServersSQLTest.UseVisualStyleBackColor = true;
            this.btnServersSQLTest.Click += new System.EventHandler(this.btnServersSQLTest_Click);
            // 
            // lblServersSQLParam
            // 
            this.lblServersSQLParam.AutoSize = true;
            this.lblServersSQLParam.Location = new System.Drawing.Point(15, 100);
            this.lblServersSQLParam.Name = "lblServersSQLParam";
            this.lblServersSQLParam.Size = new System.Drawing.Size(63, 13);
            this.lblServersSQLParam.TabIndex = 11;
            this.lblServersSQLParam.Text = "Parameters:";
            // 
            // lblServersSql
            // 
            this.lblServersSql.AutoSize = true;
            this.lblServersSql.Location = new System.Drawing.Point(9, 22);
            this.lblServersSql.Name = "lblServersSql";
            this.lblServersSql.Size = new System.Drawing.Size(69, 13);
            this.lblServersSql.TabIndex = 5;
            this.lblServersSql.Text = "SQL Server*:";
            // 
            // txtServersSQLParam
            // 
            this.txtServersSQLParam.Location = new System.Drawing.Point(84, 97);
            this.txtServersSQLParam.Name = "txtServersSQLParam";
            this.txtServersSQLParam.Size = new System.Drawing.Size(166, 20);
            this.txtServersSQLParam.TabIndex = 8;
            // 
            // lblServersSQLPass
            // 
            this.lblServersSQLPass.AutoSize = true;
            this.lblServersSQLPass.Location = new System.Drawing.Point(18, 74);
            this.lblServersSQLPass.Name = "lblServersSQLPass";
            this.lblServersSQLPass.Size = new System.Drawing.Size(60, 13);
            this.lblServersSQLPass.TabIndex = 9;
            this.lblServersSQLPass.Text = "Password*:";
            // 
            // txtServersSQL
            // 
            this.txtServersSQL.Location = new System.Drawing.Point(84, 19);
            this.txtServersSQL.Name = "txtServersSQL";
            this.txtServersSQL.Size = new System.Drawing.Size(166, 20);
            this.txtServersSQL.TabIndex = 5;
            // 
            // txtServersSQLPass
            // 
            this.txtServersSQLPass.Location = new System.Drawing.Point(84, 71);
            this.txtServersSQLPass.Name = "txtServersSQLPass";
            this.txtServersSQLPass.Size = new System.Drawing.Size(166, 20);
            this.txtServersSQLPass.TabIndex = 7;
            this.txtServersSQLPass.UseSystemPasswordChar = true;
            // 
            // txtServersSQLUser
            // 
            this.txtServersSQLUser.Location = new System.Drawing.Point(84, 45);
            this.txtServersSQLUser.Name = "txtServersSQLUser";
            this.txtServersSQLUser.Size = new System.Drawing.Size(166, 20);
            this.txtServersSQLUser.TabIndex = 6;
            // 
            // lblServersSQLUser
            // 
            this.lblServersSQLUser.AutoSize = true;
            this.lblServersSQLUser.Location = new System.Drawing.Point(16, 48);
            this.lblServersSQLUser.Name = "lblServersSQLUser";
            this.lblServersSQLUser.Size = new System.Drawing.Size(62, 13);
            this.lblServersSQLUser.TabIndex = 0;
            this.lblServersSQLUser.Text = "Username*:";
            // 
            // tabSMTP
            // 
            this.tabSMTP.Controls.Add(this.lblSMTPSenderName);
            this.tabSMTP.Controls.Add(this.txtSMTPSenderName);
            this.tabSMTP.Controls.Add(this.lblSMTPSubject);
            this.tabSMTP.Controls.Add(this.txtSMTPSubject);
            this.tabSMTP.Controls.Add(this.cbxSMTPEnableSSL);
            this.tabSMTP.Controls.Add(this.numSMTPPort);
            this.tabSMTP.Controls.Add(this.btnSMTPTest);
            this.tabSMTP.Controls.Add(this.btnSMTPSave);
            this.tabSMTP.Controls.Add(this.lblSMTPcc);
            this.tabSMTP.Controls.Add(this.txtSMTPcc);
            this.tabSMTP.Controls.Add(this.lbSMTPSendTo);
            this.tabSMTP.Controls.Add(this.txtSMTPSendTo);
            this.tabSMTP.Controls.Add(this.lblSMTPSender);
            this.tabSMTP.Controls.Add(this.txtSMTPSender);
            this.tabSMTP.Controls.Add(this.lblSMTPHost);
            this.tabSMTP.Controls.Add(this.txtSMTPHost);
            this.tabSMTP.Controls.Add(this.lblSMTPPort);
            this.tabSMTP.Controls.Add(this.lblSMTPPassword);
            this.tabSMTP.Controls.Add(this.txtSMTPPassword);
            this.tabSMTP.Controls.Add(this.lblSMTPUsername);
            this.tabSMTP.Controls.Add(this.txtSMTPUsername);
            this.tabSMTP.Location = new System.Drawing.Point(4, 22);
            this.tabSMTP.Name = "tabSMTP";
            this.tabSMTP.Padding = new System.Windows.Forms.Padding(3);
            this.tabSMTP.Size = new System.Drawing.Size(308, 594);
            this.tabSMTP.TabIndex = 1;
            this.tabSMTP.Text = "SMTP";
            this.tabSMTP.UseVisualStyleBackColor = true;
            // 
            // lblSMTPSenderName
            // 
            this.lblSMTPSenderName.AutoSize = true;
            this.lblSMTPSenderName.Location = new System.Drawing.Point(3, 124);
            this.lblSMTPSenderName.Name = "lblSMTPSenderName";
            this.lblSMTPSenderName.Size = new System.Drawing.Size(75, 13);
            this.lblSMTPSenderName.TabIndex = 43;
            this.lblSMTPSenderName.Text = "Sender Name:";
            // 
            // txtSMTPSenderName
            // 
            this.txtSMTPSenderName.Location = new System.Drawing.Point(84, 121);
            this.txtSMTPSenderName.Name = "txtSMTPSenderName";
            this.txtSMTPSenderName.Size = new System.Drawing.Size(204, 20);
            this.txtSMTPSenderName.TabIndex = 5;
            // 
            // lblSMTPSubject
            // 
            this.lblSMTPSubject.AutoSize = true;
            this.lblSMTPSubject.Location = new System.Drawing.Point(32, 228);
            this.lblSMTPSubject.Name = "lblSMTPSubject";
            this.lblSMTPSubject.Size = new System.Drawing.Size(46, 13);
            this.lblSMTPSubject.TabIndex = 41;
            this.lblSMTPSubject.Text = "Subject:";
            // 
            // txtSMTPSubject
            // 
            this.txtSMTPSubject.Location = new System.Drawing.Point(84, 225);
            this.txtSMTPSubject.Name = "txtSMTPSubject";
            this.txtSMTPSubject.Size = new System.Drawing.Size(204, 20);
            this.txtSMTPSubject.TabIndex = 9;
            // 
            // cbxSMTPEnableSSL
            // 
            this.cbxSMTPEnableSSL.AutoSize = true;
            this.cbxSMTPEnableSSL.Location = new System.Drawing.Point(84, 251);
            this.cbxSMTPEnableSSL.Name = "cbxSMTPEnableSSL";
            this.cbxSMTPEnableSSL.Size = new System.Drawing.Size(130, 17);
            this.cbxSMTPEnableSSL.TabIndex = 10;
            this.cbxSMTPEnableSSL.Text = "Enable SSL (Optional)";
            this.cbxSMTPEnableSSL.UseVisualStyleBackColor = true;
            // 
            // numSMTPPort
            // 
            this.numSMTPPort.Location = new System.Drawing.Point(84, 69);
            this.numSMTPPort.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.numSMTPPort.Name = "numSMTPPort";
            this.numSMTPPort.Size = new System.Drawing.Size(204, 20);
            this.numSMTPPort.TabIndex = 3;
            // 
            // btnSMTPTest
            // 
            this.btnSMTPTest.Location = new System.Drawing.Point(213, 323);
            this.btnSMTPTest.Name = "btnSMTPTest";
            this.btnSMTPTest.Size = new System.Drawing.Size(75, 23);
            this.btnSMTPTest.TabIndex = 11;
            this.btnSMTPTest.Text = "Test";
            this.btnSMTPTest.UseVisualStyleBackColor = true;
            this.btnSMTPTest.Click += new System.EventHandler(this.btnSMTPTest_Click);
            // 
            // btnSMTPSave
            // 
            this.btnSMTPSave.Location = new System.Drawing.Point(213, 352);
            this.btnSMTPSave.Name = "btnSMTPSave";
            this.btnSMTPSave.Size = new System.Drawing.Size(75, 23);
            this.btnSMTPSave.TabIndex = 12;
            this.btnSMTPSave.Text = "Save";
            this.btnSMTPSave.UseVisualStyleBackColor = true;
            this.btnSMTPSave.Click += new System.EventHandler(this.btnSMTPSave_Click);
            // 
            // lblSMTPcc
            // 
            this.lblSMTPcc.AutoSize = true;
            this.lblSMTPcc.Location = new System.Drawing.Point(54, 202);
            this.lblSMTPcc.Name = "lblSMTPcc";
            this.lblSMTPcc.Size = new System.Drawing.Size(24, 13);
            this.lblSMTPcc.TabIndex = 36;
            this.lblSMTPcc.Text = "CC:";
            // 
            // txtSMTPcc
            // 
            this.txtSMTPcc.Location = new System.Drawing.Point(84, 199);
            this.txtSMTPcc.Name = "txtSMTPcc";
            this.txtSMTPcc.Size = new System.Drawing.Size(204, 20);
            this.txtSMTPcc.TabIndex = 8;
            // 
            // lbSMTPSendTo
            // 
            this.lbSMTPSendTo.AutoSize = true;
            this.lbSMTPSendTo.Location = new System.Drawing.Point(27, 176);
            this.lbSMTPSendTo.Name = "lbSMTPSendTo";
            this.lbSMTPSendTo.Size = new System.Drawing.Size(51, 13);
            this.lbSMTPSendTo.TabIndex = 34;
            this.lbSMTPSendTo.Text = "Send To:";
            // 
            // txtSMTPSendTo
            // 
            this.txtSMTPSendTo.Location = new System.Drawing.Point(84, 173);
            this.txtSMTPSendTo.Name = "txtSMTPSendTo";
            this.txtSMTPSendTo.Size = new System.Drawing.Size(204, 20);
            this.txtSMTPSendTo.TabIndex = 7;
            // 
            // lblSMTPSender
            // 
            this.lblSMTPSender.AutoSize = true;
            this.lblSMTPSender.Location = new System.Drawing.Point(34, 150);
            this.lblSMTPSender.Name = "lblSMTPSender";
            this.lblSMTPSender.Size = new System.Drawing.Size(44, 13);
            this.lblSMTPSender.TabIndex = 31;
            this.lblSMTPSender.Text = "Sender:";
            // 
            // txtSMTPSender
            // 
            this.txtSMTPSender.Location = new System.Drawing.Point(84, 147);
            this.txtSMTPSender.Name = "txtSMTPSender";
            this.txtSMTPSender.Size = new System.Drawing.Size(204, 20);
            this.txtSMTPSender.TabIndex = 6;
            // 
            // lblSMTPHost
            // 
            this.lblSMTPHost.AutoSize = true;
            this.lblSMTPHost.Location = new System.Drawing.Point(46, 98);
            this.lblSMTPHost.Name = "lblSMTPHost";
            this.lblSMTPHost.Size = new System.Drawing.Size(32, 13);
            this.lblSMTPHost.TabIndex = 29;
            this.lblSMTPHost.Text = "Host:";
            // 
            // txtSMTPHost
            // 
            this.txtSMTPHost.Location = new System.Drawing.Point(84, 95);
            this.txtSMTPHost.Name = "txtSMTPHost";
            this.txtSMTPHost.Size = new System.Drawing.Size(204, 20);
            this.txtSMTPHost.TabIndex = 4;
            // 
            // lblSMTPPort
            // 
            this.lblSMTPPort.AutoSize = true;
            this.lblSMTPPort.Location = new System.Drawing.Point(49, 71);
            this.lblSMTPPort.Name = "lblSMTPPort";
            this.lblSMTPPort.Size = new System.Drawing.Size(29, 13);
            this.lblSMTPPort.TabIndex = 27;
            this.lblSMTPPort.Text = "Port:";
            // 
            // lblSMTPPassword
            // 
            this.lblSMTPPassword.AutoSize = true;
            this.lblSMTPPassword.Location = new System.Drawing.Point(22, 46);
            this.lblSMTPPassword.Name = "lblSMTPPassword";
            this.lblSMTPPassword.Size = new System.Drawing.Size(56, 13);
            this.lblSMTPPassword.TabIndex = 26;
            this.lblSMTPPassword.Text = "Password:";
            // 
            // txtSMTPPassword
            // 
            this.txtSMTPPassword.Location = new System.Drawing.Point(84, 43);
            this.txtSMTPPassword.Name = "txtSMTPPassword";
            this.txtSMTPPassword.Size = new System.Drawing.Size(204, 20);
            this.txtSMTPPassword.TabIndex = 2;
            this.txtSMTPPassword.UseSystemPasswordChar = true;
            // 
            // lblSMTPUsername
            // 
            this.lblSMTPUsername.AutoSize = true;
            this.lblSMTPUsername.Location = new System.Drawing.Point(20, 20);
            this.lblSMTPUsername.Name = "lblSMTPUsername";
            this.lblSMTPUsername.Size = new System.Drawing.Size(58, 13);
            this.lblSMTPUsername.TabIndex = 24;
            this.lblSMTPUsername.Text = "Username:";
            // 
            // txtSMTPUsername
            // 
            this.txtSMTPUsername.Location = new System.Drawing.Point(84, 17);
            this.txtSMTPUsername.Name = "txtSMTPUsername";
            this.txtSMTPUsername.Size = new System.Drawing.Size(204, 20);
            this.txtSMTPUsername.TabIndex = 1;
            // 
            // tabServiceManager
            // 
            this.tabServiceManager.Controls.Add(this.btnServiceMngrRefresh);
            this.tabServiceManager.Controls.Add(this.btnServiceMngrUninstall);
            this.tabServiceManager.Controls.Add(this.btnServiceMngrInstall);
            this.tabServiceManager.Controls.Add(this.btnServiceMngrStop);
            this.tabServiceManager.Controls.Add(this.btnServiceMngrStart);
            this.tabServiceManager.Controls.Add(this.pbServiceMngrStatus);
            this.tabServiceManager.Location = new System.Drawing.Point(4, 22);
            this.tabServiceManager.Name = "tabServiceManager";
            this.tabServiceManager.Size = new System.Drawing.Size(308, 594);
            this.tabServiceManager.TabIndex = 2;
            this.tabServiceManager.Text = "Service";
            this.tabServiceManager.UseVisualStyleBackColor = true;
            // 
            // btnServiceMngrRefresh
            // 
            this.btnServiceMngrRefresh.Location = new System.Drawing.Point(90, 306);
            this.btnServiceMngrRefresh.Name = "btnServiceMngrRefresh";
            this.btnServiceMngrRefresh.Size = new System.Drawing.Size(128, 23);
            this.btnServiceMngrRefresh.TabIndex = 6;
            this.btnServiceMngrRefresh.Text = "Refresh";
            this.btnServiceMngrRefresh.UseVisualStyleBackColor = true;
            this.btnServiceMngrRefresh.Click += new System.EventHandler(this.btnServiceMngrRefresh_Click);
            // 
            // btnServiceMngrUninstall
            // 
            this.btnServiceMngrUninstall.Enabled = false;
            this.btnServiceMngrUninstall.Location = new System.Drawing.Point(90, 241);
            this.btnServiceMngrUninstall.Name = "btnServiceMngrUninstall";
            this.btnServiceMngrUninstall.Size = new System.Drawing.Size(128, 23);
            this.btnServiceMngrUninstall.TabIndex = 5;
            this.btnServiceMngrUninstall.Text = "Uninstall Service";
            this.btnServiceMngrUninstall.UseVisualStyleBackColor = true;
            this.btnServiceMngrUninstall.Click += new System.EventHandler(this.btnServiceMngrUninstall_Click);
            // 
            // btnServiceMngrInstall
            // 
            this.btnServiceMngrInstall.Enabled = false;
            this.btnServiceMngrInstall.Location = new System.Drawing.Point(90, 212);
            this.btnServiceMngrInstall.Name = "btnServiceMngrInstall";
            this.btnServiceMngrInstall.Size = new System.Drawing.Size(128, 23);
            this.btnServiceMngrInstall.TabIndex = 4;
            this.btnServiceMngrInstall.Text = "Install Service";
            this.btnServiceMngrInstall.UseVisualStyleBackColor = true;
            this.btnServiceMngrInstall.Click += new System.EventHandler(this.btnServiceMngrInstall_Click);
            // 
            // btnServiceMngrStop
            // 
            this.btnServiceMngrStop.Enabled = false;
            this.btnServiceMngrStop.Location = new System.Drawing.Point(90, 183);
            this.btnServiceMngrStop.Name = "btnServiceMngrStop";
            this.btnServiceMngrStop.Size = new System.Drawing.Size(128, 23);
            this.btnServiceMngrStop.TabIndex = 3;
            this.btnServiceMngrStop.Text = "Stop";
            this.btnServiceMngrStop.UseVisualStyleBackColor = true;
            this.btnServiceMngrStop.Click += new System.EventHandler(this.btnServiceMngrStop_Click);
            // 
            // btnServiceMngrStart
            // 
            this.btnServiceMngrStart.Enabled = false;
            this.btnServiceMngrStart.Location = new System.Drawing.Point(90, 154);
            this.btnServiceMngrStart.Name = "btnServiceMngrStart";
            this.btnServiceMngrStart.Size = new System.Drawing.Size(128, 23);
            this.btnServiceMngrStart.TabIndex = 2;
            this.btnServiceMngrStart.Text = "Start";
            this.btnServiceMngrStart.UseVisualStyleBackColor = true;
            this.btnServiceMngrStart.Click += new System.EventHandler(this.btnServiceMngrStart_Click);
            // 
            // pbServiceMngrStatus
            // 
            this.pbServiceMngrStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbServiceMngrStatus.Location = new System.Drawing.Point(90, 20);
            this.pbServiceMngrStatus.Name = "pbServiceMngrStatus";
            this.pbServiceMngrStatus.Size = new System.Drawing.Size(128, 128);
            this.pbServiceMngrStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbServiceMngrStatus.TabIndex = 1;
            this.pbServiceMngrStatus.TabStop = false;
            // 
            // tabLogging
            // 
            this.tabLogging.Controls.Add(this.linkLoggingFormat);
            this.tabLogging.Controls.Add(this.btnLoggingSave);
            this.tabLogging.Controls.Add(this.gbLoggingService);
            this.tabLogging.Controls.Add(this.gbLoggingGUI);
            this.tabLogging.Location = new System.Drawing.Point(4, 22);
            this.tabLogging.Name = "tabLogging";
            this.tabLogging.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogging.Size = new System.Drawing.Size(308, 594);
            this.tabLogging.TabIndex = 5;
            this.tabLogging.Text = "Logging";
            this.tabLogging.UseVisualStyleBackColor = true;
            // 
            // linkLoggingFormat
            // 
            this.linkLoggingFormat.AutoSize = true;
            this.linkLoggingFormat.Location = new System.Drawing.Point(17, 275);
            this.linkLoggingFormat.Name = "linkLoggingFormat";
            this.linkLoggingFormat.Size = new System.Drawing.Size(161, 13);
            this.linkLoggingFormat.TabIndex = 9;
            this.linkLoggingFormat.TabStop = true;
            this.linkLoggingFormat.Text = "Log Format Conversion Patterns.";
            this.linkLoggingFormat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLoggingFormat_LinkClicked);
            // 
            // btnLoggingSave
            // 
            this.btnLoggingSave.Location = new System.Drawing.Point(213, 352);
            this.btnLoggingSave.Name = "btnLoggingSave";
            this.btnLoggingSave.Size = new System.Drawing.Size(75, 23);
            this.btnLoggingSave.TabIndex = 8;
            this.btnLoggingSave.TabStop = false;
            this.btnLoggingSave.Text = "Save";
            this.btnLoggingSave.UseVisualStyleBackColor = true;
            this.btnLoggingSave.Click += new System.EventHandler(this.btnLoggingSave_Click);
            // 
            // gbLoggingService
            // 
            this.gbLoggingService.Controls.Add(this.lblLoggingServiceSizeMB);
            this.gbLoggingService.Controls.Add(this.lblLoggingServiceFormat);
            this.gbLoggingService.Controls.Add(this.numLoggingServiceSize);
            this.gbLoggingService.Controls.Add(this.lblLoggingServiceSize);
            this.gbLoggingService.Controls.Add(this.txtLoggingServiceFormat);
            this.gbLoggingService.Controls.Add(this.cbLoggingServiceLevel);
            this.gbLoggingService.Controls.Add(this.lblLoggingServiceLevel);
            this.gbLoggingService.Location = new System.Drawing.Point(20, 144);
            this.gbLoggingService.Name = "gbLoggingService";
            this.gbLoggingService.Size = new System.Drawing.Size(268, 118);
            this.gbLoggingService.TabIndex = 1;
            this.gbLoggingService.TabStop = false;
            this.gbLoggingService.Text = "Service Configuration";
            // 
            // lblLoggingServiceSizeMB
            // 
            this.lblLoggingServiceSizeMB.AutoSize = true;
            this.lblLoggingServiceSizeMB.Location = new System.Drawing.Point(223, 82);
            this.lblLoggingServiceSizeMB.Name = "lblLoggingServiceSizeMB";
            this.lblLoggingServiceSizeMB.Size = new System.Drawing.Size(23, 13);
            this.lblLoggingServiceSizeMB.TabIndex = 9;
            this.lblLoggingServiceSizeMB.Text = "MB";
            // 
            // lblLoggingServiceFormat
            // 
            this.lblLoggingServiceFormat.AutoSize = true;
            this.lblLoggingServiceFormat.Location = new System.Drawing.Point(14, 57);
            this.lblLoggingServiceFormat.Name = "lblLoggingServiceFormat";
            this.lblLoggingServiceFormat.Size = new System.Drawing.Size(63, 13);
            this.lblLoggingServiceFormat.TabIndex = 4;
            this.lblLoggingServiceFormat.Text = "Log Format:";
            // 
            // numLoggingServiceSize
            // 
            this.numLoggingServiceSize.Location = new System.Drawing.Point(83, 80);
            this.numLoggingServiceSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLoggingServiceSize.Name = "numLoggingServiceSize";
            this.numLoggingServiceSize.Size = new System.Drawing.Size(134, 20);
            this.numLoggingServiceSize.TabIndex = 8;
            this.numLoggingServiceSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblLoggingServiceSize
            // 
            this.lblLoggingServiceSize.AutoSize = true;
            this.lblLoggingServiceSize.Location = new System.Drawing.Point(5, 82);
            this.lblLoggingServiceSize.Name = "lblLoggingServiceSize";
            this.lblLoggingServiceSize.Size = new System.Drawing.Size(72, 13);
            this.lblLoggingServiceSize.TabIndex = 7;
            this.lblLoggingServiceSize.Text = "Max File Size:";
            // 
            // txtLoggingServiceFormat
            // 
            this.txtLoggingServiceFormat.Location = new System.Drawing.Point(83, 54);
            this.txtLoggingServiceFormat.Name = "txtLoggingServiceFormat";
            this.txtLoggingServiceFormat.Size = new System.Drawing.Size(163, 20);
            this.txtLoggingServiceFormat.TabIndex = 4;
            // 
            // cbLoggingServiceLevel
            // 
            this.cbLoggingServiceLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoggingServiceLevel.FormattingEnabled = true;
            this.cbLoggingServiceLevel.Items.AddRange(new object[] {
            "ALL",
            "DEBUG",
            "INFO",
            "WARN",
            "ERROR",
            "FATAL"});
            this.cbLoggingServiceLevel.Location = new System.Drawing.Point(83, 27);
            this.cbLoggingServiceLevel.Name = "cbLoggingServiceLevel";
            this.cbLoggingServiceLevel.Size = new System.Drawing.Size(163, 21);
            this.cbLoggingServiceLevel.TabIndex = 2;
            // 
            // lblLoggingServiceLevel
            // 
            this.lblLoggingServiceLevel.AutoSize = true;
            this.lblLoggingServiceLevel.Location = new System.Drawing.Point(20, 30);
            this.lblLoggingServiceLevel.Name = "lblLoggingServiceLevel";
            this.lblLoggingServiceLevel.Size = new System.Drawing.Size(57, 13);
            this.lblLoggingServiceLevel.TabIndex = 2;
            this.lblLoggingServiceLevel.Text = "Log Level:";
            // 
            // gbLoggingGUI
            // 
            this.gbLoggingGUI.Controls.Add(this.lblLoggingGUISizeMB);
            this.gbLoggingGUI.Controls.Add(this.numLoggingGUISize);
            this.gbLoggingGUI.Controls.Add(this.lblLoggingGUISize);
            this.gbLoggingGUI.Controls.Add(this.txtLoggingGUIFormat);
            this.gbLoggingGUI.Controls.Add(this.lblLoggingGUIFormat);
            this.gbLoggingGUI.Controls.Add(this.cbLoggingGUILevel);
            this.gbLoggingGUI.Controls.Add(this.lblLoggingGUILevel);
            this.gbLoggingGUI.Location = new System.Drawing.Point(20, 20);
            this.gbLoggingGUI.Name = "gbLoggingGUI";
            this.gbLoggingGUI.Size = new System.Drawing.Size(268, 118);
            this.gbLoggingGUI.TabIndex = 0;
            this.gbLoggingGUI.TabStop = false;
            this.gbLoggingGUI.Text = "GUI Configuration";
            // 
            // lblLoggingGUISizeMB
            // 
            this.lblLoggingGUISizeMB.AutoSize = true;
            this.lblLoggingGUISizeMB.Location = new System.Drawing.Point(223, 82);
            this.lblLoggingGUISizeMB.Name = "lblLoggingGUISizeMB";
            this.lblLoggingGUISizeMB.Size = new System.Drawing.Size(23, 13);
            this.lblLoggingGUISizeMB.TabIndex = 6;
            this.lblLoggingGUISizeMB.Text = "MB";
            // 
            // numLoggingGUISize
            // 
            this.numLoggingGUISize.Location = new System.Drawing.Point(83, 80);
            this.numLoggingGUISize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLoggingGUISize.Name = "numLoggingGUISize";
            this.numLoggingGUISize.Size = new System.Drawing.Size(134, 20);
            this.numLoggingGUISize.TabIndex = 5;
            this.numLoggingGUISize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblLoggingGUISize
            // 
            this.lblLoggingGUISize.AutoSize = true;
            this.lblLoggingGUISize.Location = new System.Drawing.Point(5, 82);
            this.lblLoggingGUISize.Name = "lblLoggingGUISize";
            this.lblLoggingGUISize.Size = new System.Drawing.Size(72, 13);
            this.lblLoggingGUISize.TabIndex = 4;
            this.lblLoggingGUISize.Text = "Max File Size:";
            // 
            // txtLoggingGUIFormat
            // 
            this.txtLoggingGUIFormat.Location = new System.Drawing.Point(83, 54);
            this.txtLoggingGUIFormat.Name = "txtLoggingGUIFormat";
            this.txtLoggingGUIFormat.Size = new System.Drawing.Size(163, 20);
            this.txtLoggingGUIFormat.TabIndex = 3;
            // 
            // lblLoggingGUIFormat
            // 
            this.lblLoggingGUIFormat.AutoSize = true;
            this.lblLoggingGUIFormat.Location = new System.Drawing.Point(14, 57);
            this.lblLoggingGUIFormat.Name = "lblLoggingGUIFormat";
            this.lblLoggingGUIFormat.Size = new System.Drawing.Size(63, 13);
            this.lblLoggingGUIFormat.TabIndex = 2;
            this.lblLoggingGUIFormat.Text = "Log Format:";
            // 
            // cbLoggingGUILevel
            // 
            this.cbLoggingGUILevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoggingGUILevel.FormattingEnabled = true;
            this.cbLoggingGUILevel.Items.AddRange(new object[] {
            "ALL",
            "DEBUG",
            "INFO",
            "WARN",
            "ERROR",
            "FATAL"});
            this.cbLoggingGUILevel.Location = new System.Drawing.Point(83, 27);
            this.cbLoggingGUILevel.Name = "cbLoggingGUILevel";
            this.cbLoggingGUILevel.Size = new System.Drawing.Size(163, 21);
            this.cbLoggingGUILevel.TabIndex = 1;
            // 
            // lblLoggingGUILevel
            // 
            this.lblLoggingGUILevel.AutoSize = true;
            this.lblLoggingGUILevel.Location = new System.Drawing.Point(20, 30);
            this.lblLoggingGUILevel.Name = "lblLoggingGUILevel";
            this.lblLoggingGUILevel.Size = new System.Drawing.Size(57, 13);
            this.lblLoggingGUILevel.TabIndex = 0;
            this.lblLoggingGUILevel.Text = "Log Level:";
            // 
            // tabHelp
            // 
            this.tabHelp.Controls.Add(this.btnHelpWiki);
            this.tabHelp.Controls.Add(this.btnHelpReleases);
            this.tabHelp.Controls.Add(this.btnHelpSupport);
            this.tabHelp.Controls.Add(this.btnHelpExportsDir);
            this.tabHelp.Controls.Add(this.btnHelpConfigDir);
            this.tabHelp.Controls.Add(this.btnHelpLogDir);
            this.tabHelp.Controls.Add(this.lblHelpAppInfo);
            this.tabHelp.Controls.Add(this.pictureBox1);
            this.tabHelp.Location = new System.Drawing.Point(4, 22);
            this.tabHelp.Name = "tabHelp";
            this.tabHelp.Size = new System.Drawing.Size(308, 594);
            this.tabHelp.TabIndex = 3;
            this.tabHelp.Text = "Help";
            this.tabHelp.UseVisualStyleBackColor = true;
            // 
            // btnHelpWiki
            // 
            this.btnHelpWiki.Location = new System.Drawing.Point(210, 166);
            this.btnHelpWiki.Name = "btnHelpWiki";
            this.btnHelpWiki.Size = new System.Drawing.Size(75, 23);
            this.btnHelpWiki.TabIndex = 9;
            this.btnHelpWiki.Text = "Wiki";
            this.btnHelpWiki.UseVisualStyleBackColor = true;
            this.btnHelpWiki.Click += new System.EventHandler(this.btnHelpWiki_Click);
            // 
            // btnHelpReleases
            // 
            this.btnHelpReleases.Location = new System.Drawing.Point(117, 166);
            this.btnHelpReleases.Name = "btnHelpReleases";
            this.btnHelpReleases.Size = new System.Drawing.Size(75, 23);
            this.btnHelpReleases.TabIndex = 8;
            this.btnHelpReleases.Text = "Releases";
            this.btnHelpReleases.UseVisualStyleBackColor = true;
            this.btnHelpReleases.Click += new System.EventHandler(this.btnHelpReleases_Click);
            // 
            // btnHelpSupport
            // 
            this.btnHelpSupport.Location = new System.Drawing.Point(20, 166);
            this.btnHelpSupport.Name = "btnHelpSupport";
            this.btnHelpSupport.Size = new System.Drawing.Size(75, 23);
            this.btnHelpSupport.TabIndex = 7;
            this.btnHelpSupport.Text = "Support";
            this.btnHelpSupport.UseVisualStyleBackColor = true;
            this.btnHelpSupport.Click += new System.EventHandler(this.btnHelpSupport_Click);
            // 
            // btnHelpExportsDir
            // 
            this.btnHelpExportsDir.Location = new System.Drawing.Point(117, 215);
            this.btnHelpExportsDir.Name = "btnHelpExportsDir";
            this.btnHelpExportsDir.Size = new System.Drawing.Size(75, 23);
            this.btnHelpExportsDir.TabIndex = 5;
            this.btnHelpExportsDir.Text = "Exports";
            this.btnHelpExportsDir.UseVisualStyleBackColor = true;
            this.btnHelpExportsDir.Click += new System.EventHandler(this.btnHelpExportsDir_Click);
            // 
            // btnHelpConfigDir
            // 
            this.btnHelpConfigDir.Location = new System.Drawing.Point(210, 215);
            this.btnHelpConfigDir.Name = "btnHelpConfigDir";
            this.btnHelpConfigDir.Size = new System.Drawing.Size(75, 23);
            this.btnHelpConfigDir.TabIndex = 4;
            this.btnHelpConfigDir.Text = "Configuraton";
            this.btnHelpConfigDir.UseVisualStyleBackColor = true;
            this.btnHelpConfigDir.Click += new System.EventHandler(this.btnHelpConfigDir_Click);
            // 
            // btnHelpLogDir
            // 
            this.btnHelpLogDir.Location = new System.Drawing.Point(20, 215);
            this.btnHelpLogDir.Name = "btnHelpLogDir";
            this.btnHelpLogDir.Size = new System.Drawing.Size(75, 23);
            this.btnHelpLogDir.TabIndex = 3;
            this.btnHelpLogDir.Text = "Logs";
            this.btnHelpLogDir.UseVisualStyleBackColor = true;
            this.btnHelpLogDir.Click += new System.EventHandler(this.btnHelpLogDir_Click);
            // 
            // lblHelpAppInfo
            // 
            this.lblHelpAppInfo.Location = new System.Drawing.Point(3, 317);
            this.lblHelpAppInfo.Name = "lblHelpAppInfo";
            this.lblHelpAppInfo.Size = new System.Drawing.Size(302, 64);
            this.lblHelpAppInfo.TabIndex = 2;
            this.lblHelpAppInfo.Text = "{0}\r\n{1}";
            this.lblHelpAppInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::SnowPlatformMonitor.Configurator.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(340, 644);
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(356, 683);
            this.MinimumSize = new System.Drawing.Size(356, 470);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppName AppType";
            this.tabControlMain.ResumeLayout(false);
            this.tabConfiguration.ResumeLayout(false);
            this.tabConfiguration.PerformLayout();
            this.gbConfigAdvanced.ResumeLayout(false);
            this.gbConfigAdvanced.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numConfigAdvINVProcessingThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numConfigAdvINVDeviceThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numConfigAdvSLMDeviceThreshold)).EndInit();
            this.gbServiceMSchedule.ResumeLayout(false);
            this.gbServiceMSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numServiceMScheduleTimeSecs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServiceMScheduleTimeMins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServiceMScheduleTimeHours)).EndInit();
            this.tabServers.ResumeLayout(false);
            this.gbServersINV.ResumeLayout(false);
            this.gbServersINV.PerformLayout();
            this.gbServersSLM.ResumeLayout(false);
            this.gbServersSLM.PerformLayout();
            this.gbServersSQL.ResumeLayout(false);
            this.gbServersSQL.PerformLayout();
            this.tabSMTP.ResumeLayout(false);
            this.tabSMTP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSMTPPort)).EndInit();
            this.tabServiceManager.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbServiceMngrStatus)).EndInit();
            this.tabLogging.ResumeLayout(false);
            this.tabLogging.PerformLayout();
            this.gbLoggingService.ResumeLayout(false);
            this.gbLoggingService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLoggingServiceSize)).EndInit();
            this.gbLoggingGUI.ResumeLayout(false);
            this.gbLoggingGUI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLoggingGUISize)).EndInit();
            this.tabHelp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabServers;
        private System.Windows.Forms.TabPage tabSMTP;
        private System.Windows.Forms.TabPage tabServiceManager;
        private System.Windows.Forms.TabPage tabHelp;
        private System.Windows.Forms.TextBox txtServersSLM;
        private System.Windows.Forms.Label lblServersSLM;
        private System.Windows.Forms.Label lblServersSql;
        private System.Windows.Forms.Label lblServersINV;
        private System.Windows.Forms.TextBox txtServersSQL;
        private System.Windows.Forms.TextBox txtServersINV;
        private System.Windows.Forms.GroupBox gbServersSQL;
        private System.Windows.Forms.Label lblServersSQLUser;
        private System.Windows.Forms.TextBox txtServersSQLUser;
        private System.Windows.Forms.Label lblServersSQLParam;
        private System.Windows.Forms.TextBox txtServersSQLParam;
        private System.Windows.Forms.Label lblServersSQLPass;
        private System.Windows.Forms.TextBox txtServersSQLPass;
        private System.Windows.Forms.Button btnServersSQLTest;
        private System.Windows.Forms.Button btnServersSave;
        private System.Windows.Forms.TabPage tabConfiguration;
        private System.Windows.Forms.CheckBox cbConfigDUJStatus;
        private System.Windows.Forms.CheckBox cbConfigSLMServices;
        private System.Windows.Forms.CheckBox cbConfigSLMDeviceReporting;
        private System.Windows.Forms.CheckBox cbConfigINVServices;
        private System.Windows.Forms.CheckBox cbConfigINVDeviceReporting;
        private System.Windows.Forms.CheckBox cbConfigINVProcessingDir;
        private System.Windows.Forms.CheckBox cbConfigINVStorage;
        private System.Windows.Forms.CheckBox cbConfigSLMStorage;
        private System.Windows.Forms.Button btnConfigSave;
        private System.Windows.Forms.Label lblHelpAppInfo;
        private System.Windows.Forms.Button btnHelpLogDir;
        private System.Windows.Forms.Button btnHelpConfigDir;
        private System.Windows.Forms.GroupBox gbServersSLM;
        private System.Windows.Forms.TextBox txtServersSLMDrive;
        private System.Windows.Forms.GroupBox gbServersINV;
        private System.Windows.Forms.TextBox txtServersINVDrive;
        private System.Windows.Forms.Label lblServersINVDrive;
        private System.Windows.Forms.Label lblServersSLMDrive;
        private System.Windows.Forms.GroupBox gbServiceMSchedule;
        private System.Windows.Forms.Label lblServiceMTimeSecs;
        private System.Windows.Forms.Label lblServiceMTimeMins;
        private System.Windows.Forms.NumericUpDown numServiceMScheduleTimeSecs;
        private System.Windows.Forms.Label lblServiceMTimeHours;
        private System.Windows.Forms.NumericUpDown numServiceMScheduleTimeMins;
        private System.Windows.Forms.NumericUpDown numServiceMScheduleTimeHours;
        private System.Windows.Forms.Label lblServiceMScheduleTime;
        private System.Windows.Forms.CheckBox cbConfigOffice365Adobe;
        private System.Windows.Forms.Button btnConfigAdvanced;
        private System.Windows.Forms.GroupBox gbConfigAdvanced;
        private System.Windows.Forms.Label lblConfigAdvSLMDeviceThreshold;
        private System.Windows.Forms.NumericUpDown numConfigAdvSLMDeviceThreshold;
        private System.Windows.Forms.NumericUpDown numConfigAdvINVDeviceThreshold;
        private System.Windows.Forms.Label lblConfigAdvINVDeviceThreshold;
        private System.Windows.Forms.NumericUpDown numConfigAdvINVProcessingThreshold;
        private System.Windows.Forms.Label lblConfigAdvINVProcessingThreshold;
        private System.Windows.Forms.Label lblConfigAdvProcessingDirectory;
        private System.Windows.Forms.TextBox txtConfigAdvINVProcessingDirectory;
        private System.Windows.Forms.CheckBox cbConfigLogInterrogator;
        private System.Windows.Forms.PictureBox pbServiceMngrStatus;
        private System.Windows.Forms.Button btnServiceMngrStart;
        private System.Windows.Forms.Button btnServiceMngrStop;
        private System.Windows.Forms.Button btnServiceMngrInstall;
        private System.Windows.Forms.Button btnServiceMngrUninstall;
        private System.Windows.Forms.Button btnHelpExportsDir;
        private System.Windows.Forms.TabPage tabLogging;
        private System.Windows.Forms.GroupBox gbLoggingService;
        private System.Windows.Forms.GroupBox gbLoggingGUI;
        private System.Windows.Forms.Label lblLoggingGUILevel;
        private System.Windows.Forms.ComboBox cbLoggingGUILevel;
        private System.Windows.Forms.ComboBox cbLoggingServiceLevel;
        private System.Windows.Forms.Label lblLoggingServiceLevel;
        private System.Windows.Forms.TextBox txtLoggingGUIFormat;
        private System.Windows.Forms.Label lblLoggingGUIFormat;
        private System.Windows.Forms.Label lblLoggingServiceFormat;
        private System.Windows.Forms.TextBox txtLoggingServiceFormat;
        private System.Windows.Forms.Label lblLoggingGUISizeMB;
        private System.Windows.Forms.NumericUpDown numLoggingGUISize;
        private System.Windows.Forms.Label lblLoggingGUISize;
        private System.Windows.Forms.Label lblLoggingServiceSizeMB;
        private System.Windows.Forms.NumericUpDown numLoggingServiceSize;
        private System.Windows.Forms.Label lblLoggingServiceSize;
        private System.Windows.Forms.Button btnLoggingSave;
        private System.Windows.Forms.LinkLabel linkLoggingFormat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHelpReleases;
        private System.Windows.Forms.Button btnHelpSupport;
        private System.Windows.Forms.Button btnHelpWiki;
        private System.Windows.Forms.Label lblSMTPSubject;
        private System.Windows.Forms.TextBox txtSMTPSubject;
        private System.Windows.Forms.CheckBox cbxSMTPEnableSSL;
        private System.Windows.Forms.NumericUpDown numSMTPPort;
        private System.Windows.Forms.Button btnSMTPTest;
        private System.Windows.Forms.Button btnSMTPSave;
        private System.Windows.Forms.Label lblSMTPcc;
        private System.Windows.Forms.TextBox txtSMTPcc;
        private System.Windows.Forms.Label lbSMTPSendTo;
        private System.Windows.Forms.TextBox txtSMTPSendTo;
        private System.Windows.Forms.Label lblSMTPSender;
        private System.Windows.Forms.TextBox txtSMTPSender;
        private System.Windows.Forms.Label lblSMTPHost;
        private System.Windows.Forms.TextBox txtSMTPHost;
        private System.Windows.Forms.Label lblSMTPPort;
        private System.Windows.Forms.Label lblSMTPPassword;
        private System.Windows.Forms.TextBox txtSMTPPassword;
        private System.Windows.Forms.Label lblSMTPUsername;
        private System.Windows.Forms.TextBox txtSMTPUsername;
        private System.Windows.Forms.CheckBox cbConfigSRSImport;
        private System.Windows.Forms.Label lblSMTPSenderName;
        private System.Windows.Forms.TextBox txtSMTPSenderName;
        private System.Windows.Forms.Button btnServiceMngrRefresh;
        private System.Windows.Forms.Button btnConfigTest;
    }
}

