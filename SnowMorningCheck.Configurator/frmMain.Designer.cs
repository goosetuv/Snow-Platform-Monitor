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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabConfiguration = new System.Windows.Forms.TabPage();
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
            this.btnConfigAdvanced = new System.Windows.Forms.Button();
            this.cbConfigOffice365Adobe = new System.Windows.Forms.CheckBox();
            this.gbServiceMSchedule = new System.Windows.Forms.GroupBox();
            this.lblServiceMTimeSecs = new System.Windows.Forms.Label();
            this.lblServiceMTimeMins = new System.Windows.Forms.Label();
            this.numServiceMScheduleTimeSecs = new System.Windows.Forms.NumericUpDown();
            this.lblServiceMTimeHours = new System.Windows.Forms.Label();
            this.numServiceMScheduleTimeMins = new System.Windows.Forms.NumericUpDown();
            this.numServiceMScheduleTimeHours = new System.Windows.Forms.NumericUpDown();
            this.lblServiceMScheduleTime = new System.Windows.Forms.Label();
            this.btnConfigSave = new System.Windows.Forms.Button();
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
            this.tabServiceManager = new System.Windows.Forms.TabPage();
            this.btnServiceMngrStop = new System.Windows.Forms.Button();
            this.btnServiceMngrStart = new System.Windows.Forms.Button();
            this.pbServiceMngrStatus = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.btnAboutConfigDir = new System.Windows.Forms.Button();
            this.btnAboutLogDir = new System.Windows.Forms.Button();
            this.lblAboutAppInfo = new System.Windows.Forms.Label();
            this.btnServiceMngrInstall = new System.Windows.Forms.Button();
            this.btnServiceMngrUninstall = new System.Windows.Forms.Button();
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
            this.tabServiceManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbServiceMngrStatus)).BeginInit();
            this.tabAbout.SuspendLayout();
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
            this.tabControlMain.Controls.Add(this.tabAbout);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(316, 407);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.TabStop = false;
            // 
            // tabConfiguration
            // 
            this.tabConfiguration.Controls.Add(this.cbConfigLogInterrogator);
            this.tabConfiguration.Controls.Add(this.gbConfigAdvanced);
            this.tabConfiguration.Controls.Add(this.btnConfigAdvanced);
            this.tabConfiguration.Controls.Add(this.cbConfigOffice365Adobe);
            this.tabConfiguration.Controls.Add(this.gbServiceMSchedule);
            this.tabConfiguration.Controls.Add(this.btnConfigSave);
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
            this.tabConfiguration.Size = new System.Drawing.Size(308, 381);
            this.tabConfiguration.TabIndex = 4;
            this.tabConfiguration.Text = "Configuration";
            this.tabConfiguration.UseVisualStyleBackColor = true;
            // 
            // cbConfigLogInterrogator
            // 
            this.cbConfigLogInterrogator.AutoSize = true;
            this.cbConfigLogInterrogator.Enabled = false;
            this.cbConfigLogInterrogator.Location = new System.Drawing.Point(20, 136);
            this.cbConfigLogInterrogator.Name = "cbConfigLogInterrogator";
            this.cbConfigLogInterrogator.Size = new System.Drawing.Size(147, 17);
            this.cbConfigLogInterrogator.TabIndex = 18;
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
            // btnConfigAdvanced
            // 
            this.btnConfigAdvanced.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConfigAdvanced.Location = new System.Drawing.Point(20, 564);
            this.btnConfigAdvanced.Name = "btnConfigAdvanced";
            this.btnConfigAdvanced.Size = new System.Drawing.Size(75, 23);
            this.btnConfigAdvanced.TabIndex = 16;
            this.btnConfigAdvanced.Text = "Advanced";
            this.btnConfigAdvanced.UseVisualStyleBackColor = true;
            this.btnConfigAdvanced.Click += new System.EventHandler(this.btnConfigAdvanced_Click);
            // 
            // cbConfigOffice365Adobe
            // 
            this.cbConfigOffice365Adobe.AutoSize = true;
            this.cbConfigOffice365Adobe.Location = new System.Drawing.Point(20, 113);
            this.cbConfigOffice365Adobe.Name = "cbConfigOffice365Adobe";
            this.cbConfigOffice365Adobe.Size = new System.Drawing.Size(197, 17);
            this.cbConfigOffice365Adobe.TabIndex = 15;
            this.cbConfigOffice365Adobe.TabStop = false;
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
            // btnConfigSave
            // 
            this.btnConfigSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConfigSave.Location = new System.Drawing.Point(213, 564);
            this.btnConfigSave.Name = "btnConfigSave";
            this.btnConfigSave.Size = new System.Drawing.Size(75, 23);
            this.btnConfigSave.TabIndex = 8;
            this.btnConfigSave.TabStop = false;
            this.btnConfigSave.Text = "Save";
            this.btnConfigSave.UseVisualStyleBackColor = true;
            this.btnConfigSave.Click += new System.EventHandler(this.btnConfigSave_Click);
            // 
            // cbConfigINVStorage
            // 
            this.cbConfigINVStorage.AutoSize = true;
            this.cbConfigINVStorage.Enabled = false;
            this.cbConfigINVStorage.Location = new System.Drawing.Point(20, 297);
            this.cbConfigINVStorage.Name = "cbConfigINVStorage";
            this.cbConfigINVStorage.Size = new System.Drawing.Size(174, 17);
            this.cbConfigINVStorage.TabIndex = 7;
            this.cbConfigINVStorage.TabStop = false;
            this.cbConfigINVStorage.Text = "Snow Inventory Server Storage";
            this.cbConfigINVStorage.UseVisualStyleBackColor = true;
            // 
            // cbConfigSLMStorage
            // 
            this.cbConfigSLMStorage.AutoSize = true;
            this.cbConfigSLMStorage.Enabled = false;
            this.cbConfigSLMStorage.Location = new System.Drawing.Point(20, 205);
            this.cbConfigSLMStorage.Name = "cbConfigSLMStorage";
            this.cbConfigSLMStorage.Size = new System.Drawing.Size(212, 17);
            this.cbConfigSLMStorage.TabIndex = 6;
            this.cbConfigSLMStorage.TabStop = false;
            this.cbConfigSLMStorage.Text = "Snow License Manager Server Storage";
            this.cbConfigSLMStorage.UseVisualStyleBackColor = true;
            // 
            // cbConfigINVProcessingDir
            // 
            this.cbConfigINVProcessingDir.AutoSize = true;
            this.cbConfigINVProcessingDir.Location = new System.Drawing.Point(20, 274);
            this.cbConfigINVProcessingDir.Name = "cbConfigINVProcessingDir";
            this.cbConfigINVProcessingDir.Size = new System.Drawing.Size(200, 17);
            this.cbConfigINVProcessingDir.TabIndex = 5;
            this.cbConfigINVProcessingDir.TabStop = false;
            this.cbConfigINVProcessingDir.Text = "Snow Inventory Processing Directory";
            this.cbConfigINVProcessingDir.UseVisualStyleBackColor = true;
            // 
            // cbConfigINVServices
            // 
            this.cbConfigINVServices.AutoSize = true;
            this.cbConfigINVServices.Location = new System.Drawing.Point(20, 228);
            this.cbConfigINVServices.Name = "cbConfigINVServices";
            this.cbConfigINVServices.Size = new System.Drawing.Size(178, 17);
            this.cbConfigINVServices.TabIndex = 4;
            this.cbConfigINVServices.TabStop = false;
            this.cbConfigINVServices.Text = "Snow Inventory Server Services";
            this.cbConfigINVServices.UseVisualStyleBackColor = true;
            // 
            // cbConfigINVDeviceReporting
            // 
            this.cbConfigINVDeviceReporting.AutoSize = true;
            this.cbConfigINVDeviceReporting.Location = new System.Drawing.Point(20, 251);
            this.cbConfigINVDeviceReporting.Name = "cbConfigINVDeviceReporting";
            this.cbConfigINVDeviceReporting.Size = new System.Drawing.Size(186, 17);
            this.cbConfigINVDeviceReporting.TabIndex = 3;
            this.cbConfigINVDeviceReporting.TabStop = false;
            this.cbConfigINVDeviceReporting.Text = "Snow Inventory Device Reporting";
            this.cbConfigINVDeviceReporting.UseVisualStyleBackColor = true;
            // 
            // cbConfigSLMDeviceReporting
            // 
            this.cbConfigSLMDeviceReporting.AutoSize = true;
            this.cbConfigSLMDeviceReporting.Location = new System.Drawing.Point(20, 182);
            this.cbConfigSLMDeviceReporting.Name = "cbConfigSLMDeviceReporting";
            this.cbConfigSLMDeviceReporting.Size = new System.Drawing.Size(224, 17);
            this.cbConfigSLMDeviceReporting.TabIndex = 2;
            this.cbConfigSLMDeviceReporting.TabStop = false;
            this.cbConfigSLMDeviceReporting.Text = "Snow License Manager Device Reporting";
            this.cbConfigSLMDeviceReporting.UseVisualStyleBackColor = true;
            // 
            // cbConfigSLMServices
            // 
            this.cbConfigSLMServices.AutoSize = true;
            this.cbConfigSLMServices.Location = new System.Drawing.Point(20, 159);
            this.cbConfigSLMServices.Name = "cbConfigSLMServices";
            this.cbConfigSLMServices.Size = new System.Drawing.Size(216, 17);
            this.cbConfigSLMServices.TabIndex = 1;
            this.cbConfigSLMServices.TabStop = false;
            this.cbConfigSLMServices.Text = "Snow License Manager Server Services";
            this.cbConfigSLMServices.UseVisualStyleBackColor = true;
            // 
            // cbConfigDUJStatus
            // 
            this.cbConfigDUJStatus.AutoSize = true;
            this.cbConfigDUJStatus.Location = new System.Drawing.Point(20, 90);
            this.cbConfigDUJStatus.Name = "cbConfigDUJStatus";
            this.cbConfigDUJStatus.Size = new System.Drawing.Size(140, 17);
            this.cbConfigDUJStatus.TabIndex = 0;
            this.cbConfigDUJStatus.TabStop = false;
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
            this.tabServers.Size = new System.Drawing.Size(308, 381);
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
            this.btnServersSave.TabIndex = 7;
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
            this.tabSMTP.Location = new System.Drawing.Point(4, 22);
            this.tabSMTP.Name = "tabSMTP";
            this.tabSMTP.Padding = new System.Windows.Forms.Padding(3);
            this.tabSMTP.Size = new System.Drawing.Size(308, 381);
            this.tabSMTP.TabIndex = 1;
            this.tabSMTP.Text = "SMTP";
            this.tabSMTP.UseVisualStyleBackColor = true;
            // 
            // tabServiceManager
            // 
            this.tabServiceManager.Controls.Add(this.btnServiceMngrUninstall);
            this.tabServiceManager.Controls.Add(this.btnServiceMngrInstall);
            this.tabServiceManager.Controls.Add(this.btnServiceMngrStop);
            this.tabServiceManager.Controls.Add(this.btnServiceMngrStart);
            this.tabServiceManager.Controls.Add(this.pbServiceMngrStatus);
            this.tabServiceManager.Controls.Add(this.button1);
            this.tabServiceManager.Location = new System.Drawing.Point(4, 22);
            this.tabServiceManager.Name = "tabServiceManager";
            this.tabServiceManager.Size = new System.Drawing.Size(308, 381);
            this.tabServiceManager.TabIndex = 2;
            this.tabServiceManager.Text = "Service Manager";
            this.tabServiceManager.UseVisualStyleBackColor = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dev";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.btnAboutConfigDir);
            this.tabAbout.Controls.Add(this.btnAboutLogDir);
            this.tabAbout.Controls.Add(this.lblAboutAppInfo);
            this.tabAbout.Location = new System.Drawing.Point(4, 22);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Size = new System.Drawing.Size(308, 381);
            this.tabAbout.TabIndex = 3;
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // btnAboutConfigDir
            // 
            this.btnAboutConfigDir.Location = new System.Drawing.Point(117, 265);
            this.btnAboutConfigDir.Name = "btnAboutConfigDir";
            this.btnAboutConfigDir.Size = new System.Drawing.Size(75, 23);
            this.btnAboutConfigDir.TabIndex = 4;
            this.btnAboutConfigDir.Text = "Configuraton";
            this.btnAboutConfigDir.UseVisualStyleBackColor = true;
            this.btnAboutConfigDir.Click += new System.EventHandler(this.btnAboutConfigDir_Click);
            // 
            // btnAboutLogDir
            // 
            this.btnAboutLogDir.Location = new System.Drawing.Point(117, 236);
            this.btnAboutLogDir.Name = "btnAboutLogDir";
            this.btnAboutLogDir.Size = new System.Drawing.Size(75, 23);
            this.btnAboutLogDir.TabIndex = 3;
            this.btnAboutLogDir.Text = "Logs";
            this.btnAboutLogDir.UseVisualStyleBackColor = true;
            this.btnAboutLogDir.Click += new System.EventHandler(this.btnAboutLogDir_Click);
            // 
            // lblAboutAppInfo
            // 
            this.lblAboutAppInfo.Location = new System.Drawing.Point(3, 166);
            this.lblAboutAppInfo.Name = "lblAboutAppInfo";
            this.lblAboutAppInfo.Size = new System.Drawing.Size(302, 50);
            this.lblAboutAppInfo.TabIndex = 2;
            this.lblAboutAppInfo.Text = "{0}\r\n{1}\r\n{3}";
            this.lblAboutAppInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(340, 431);
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(356, 683);
            this.MinimumSize = new System.Drawing.Size(356, 470);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "{0} - {1}";
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
            this.tabServiceManager.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbServiceMngrStatus)).EndInit();
            this.tabAbout.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblAboutAppInfo;
        private System.Windows.Forms.Button btnAboutLogDir;
        private System.Windows.Forms.Button btnAboutConfigDir;
        private System.Windows.Forms.GroupBox gbServersSLM;
        private System.Windows.Forms.TextBox txtServersSLMDrive;
        private System.Windows.Forms.GroupBox gbServersINV;
        private System.Windows.Forms.TextBox txtServersINVDrive;
        private System.Windows.Forms.Label lblServersINVDrive;
        private System.Windows.Forms.Label lblServersSLMDrive;
        private System.Windows.Forms.Button button1;
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
    }
}

