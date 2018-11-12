namespace PostRig
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caseStudyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.NewRibbon = new System.Windows.Forms.Ribbon();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.DesignRibbonTab = new System.Windows.Forms.RibbonTab();
            this.BuildCarRibbonPanel = new System.Windows.Forms.RibbonPanel();
            this.NewCarRibbonButton = new System.Windows.Forms.RibbonButton();
            this.ExistingCarRibbonButton = new System.Windows.Forms.RibbonButton();
            this.SimSetupRibbonTab = new System.Windows.Forms.RibbonTab();
            this.InputSignalRibbonPanel = new System.Windows.Forms.RibbonPanel();
            this.ResponseToICRibbonButton = new System.Windows.Forms.RibbonButton();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.HarmonicIPRibbonButton = new System.Windows.Forms.RibbonButton();
            this.CombinedIPRibbonButton = new System.Windows.Forms.RibbonButton();
            this.ResultsRibbonTab = new System.Windows.Forms.RibbonTab();
            this.RunRibbonPanel = new System.Windows.Forms.RibbonPanel();
            this.RunRibbonButton = new System.Windows.Forms.RibbonButton();
            this.ribbonSeparator1 = new System.Windows.Forms.RibbonSeparator();
            this.PropertiesPanel = new System.Windows.Forms.Panel();
            this.VehicleParameterLabel = new System.Windows.Forms.Label();
            this.VehicleMassLabel = new System.Windows.Forms.Label();
            this.DampingCoeffTextBox = new System.Windows.Forms.TextBox();
            this.VehicleMassUnitLabel = new System.Windows.Forms.Label();
            this.SpringStiffnessLabel = new System.Windows.Forms.Label();
            this.SpringStiffnessTextBox = new System.Windows.Forms.TextBox();
            this.DampingCoeffLabel = new System.Windows.Forms.Label();
            this.SpringStiffnessUnitLabel = new System.Windows.Forms.Label();
            this.DampingCoeffUnitLabel = new System.Windows.Forms.Label();
            this.VehicleMassTextBox = new System.Windows.Forms.TextBox();
            this.SimulationSetupPanel = new System.Windows.Forms.Panel();
            this.InitializeButton = new System.Windows.Forms.Button();
            this.HarmonicInputDataGroupBox = new System.Windows.Forms.GroupBox();
            this.OscillationFrequencyLabel = new System.Windows.Forms.Label();
            this.ForceAmplitudeLabel = new System.Windows.Forms.Label();
            this.ForceAmplitudeTextBox = new System.Windows.Forms.TextBox();
            this.ForceAmplitudeUnitLabel = new System.Windows.Forms.Label();
            this.OscillationFrequencyUnitLabel = new System.Windows.Forms.Label();
            this.OscillationFrequencyTextBox = new System.Windows.Forms.TextBox();
            this.InitialConditionGroupBox = new System.Windows.Forms.GroupBox();
            this.InitialDisplacementLabel = new System.Windows.Forms.Label();
            this.InitialVelcoityLabel = new System.Windows.Forms.Label();
            this.InitialVelocityUnitLabel = new System.Windows.Forms.Label();
            this.InitialDisplacementTextBox = new System.Windows.Forms.TextBox();
            this.InitialDisplacementUnitLabel = new System.Windows.Forms.Label();
            this.InitialVelocityTextBox = new System.Windows.Forms.TextBox();
            this.TimeSetupPanel = new System.Windows.Forms.Panel();
            this.TimeSetupHeadingLabel = new System.Windows.Forms.Label();
            this.EndTimeTextBox = new System.Windows.Forms.TextBox();
            this.StartTimeLabel = new System.Windows.Forms.Label();
            this.EndTimeLabel = new System.Windows.Forms.Label();
            this.StartTimeTextBox = new System.Windows.Forms.TextBox();
            this.TimeStepLabel = new System.Windows.Forms.Label();
            this.StartTimeUnitLabel = new System.Windows.Forms.Label();
            this.EndTimeUnitLabel = new System.Windows.Forms.Label();
            this.TimeStepUnitLabel = new System.Windows.Forms.Label();
            this.TimeStepTextBox = new System.Windows.Forms.TextBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ResponseToICPanel = new System.Windows.Forms.Panel();
            this.ResponseToICCartesianChart = new LiveCharts.WinForms.CartesianChart();
            this.InputSignalPanel = new System.Windows.Forms.Panel();
            this.HarmonicInputCartesianChart = new LiveCharts.WinForms.CartesianChart();
            this.CombinedResponsePanel = new System.Windows.Forms.Panel();
            this.CombinedResponseCartesianChart = new LiveCharts.WinForms.CartesianChart();
            this.ResponseToHarmonicIPPanel = new System.Windows.Forms.Panel();
            this.ResponseToHarmonicInputCatrtesianChart = new LiveCharts.WinForms.CartesianChart();
            this.menuStrip1.SuspendLayout();
            this.PropertiesPanel.SuspendLayout();
            this.SimulationSetupPanel.SuspendLayout();
            this.HarmonicInputDataGroupBox.SuspendLayout();
            this.InitialConditionGroupBox.SuspendLayout();
            this.TimeSetupPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.ResponseToICPanel.SuspendLayout();
            this.InputSignalPanel.SuspendLayout();
            this.CombinedResponsePanel.SuspendLayout();
            this.ResponseToHarmonicIPPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1268, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readMeToolStripMenuItem,
            this.caseStudyToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // readMeToolStripMenuItem
            // 
            this.readMeToolStripMenuItem.Name = "readMeToolStripMenuItem";
            this.readMeToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.readMeToolStripMenuItem.Text = "Tutorial";
            // 
            // caseStudyToolStripMenuItem
            // 
            this.caseStudyToolStripMenuItem.Name = "caseStudyToolStripMenuItem";
            this.caseStudyToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.caseStudyToolStripMenuItem.Text = "Case Study";
            // 
            // exitToolStripMenu
            // 
            this.exitToolStripMenu.Name = "exitToolStripMenu";
            this.exitToolStripMenu.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenu.Text = "Exit";
            this.exitToolStripMenu.Click += new System.EventHandler(this.exitToolStripMenu_Click_1);
            // 
            // NewRibbon
            // 
            this.NewRibbon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NewRibbon.Location = new System.Drawing.Point(0, 24);
            this.NewRibbon.Minimized = false;
            this.NewRibbon.Name = "NewRibbon";
            // 
            // 
            // 
            this.NewRibbon.OrbDropDown.BorderRoundness = 8;
            this.NewRibbon.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.NewRibbon.OrbDropDown.Name = "";
            this.NewRibbon.OrbDropDown.TabIndex = 0;
            this.NewRibbon.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013;
            this.NewRibbon.OrbVisible = false;
            // 
            // 
            // 
            this.NewRibbon.QuickAccessToolbar.Items.Add(this.ribbonButton1);
            this.NewRibbon.QuickAccessToolbar.Visible = false;
            this.NewRibbon.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.NewRibbon.Size = new System.Drawing.Size(1268, 152);
            this.NewRibbon.TabIndex = 0;
            this.NewRibbon.Tabs.Add(this.DesignRibbonTab);
            this.NewRibbon.Tabs.Add(this.SimSetupRibbonTab);
            this.NewRibbon.Tabs.Add(this.ResultsRibbonTab);
            this.NewRibbon.TabsMargin = new System.Windows.Forms.Padding(5, 26, 20, 0);
            this.NewRibbon.TabSpacing = 4;
            this.NewRibbon.Visible = false;
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.LargeImage")));
            this.ribbonButton1.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton1.Name = "ribbonButton1";
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            // 
            // DesignRibbonTab
            // 
            this.DesignRibbonTab.Name = "DesignRibbonTab";
            this.DesignRibbonTab.Panels.Add(this.BuildCarRibbonPanel);
            this.DesignRibbonTab.Text = "Design";
            this.DesignRibbonTab.ActiveChanged += new System.EventHandler(this.DesignRibbonTab_ActiveChanged);
            // 
            // BuildCarRibbonPanel
            // 
            this.BuildCarRibbonPanel.Items.Add(this.NewCarRibbonButton);
            this.BuildCarRibbonPanel.Items.Add(this.ExistingCarRibbonButton);
            this.BuildCarRibbonPanel.Name = "BuildCarRibbonPanel";
            this.BuildCarRibbonPanel.Text = "Build Car";
            // 
            // NewCarRibbonButton
            // 
            this.NewCarRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("NewCarRibbonButton.Image")));
            this.NewCarRibbonButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("NewCarRibbonButton.LargeImage")));
            this.NewCarRibbonButton.Name = "NewCarRibbonButton";
            this.NewCarRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("NewCarRibbonButton.SmallImage")));
            this.NewCarRibbonButton.Text = "New";
            this.NewCarRibbonButton.Click += new System.EventHandler(this.NewCarRibbonButton_Click);
            // 
            // ExistingCarRibbonButton
            // 
            this.ExistingCarRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("ExistingCarRibbonButton.Image")));
            this.ExistingCarRibbonButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("ExistingCarRibbonButton.LargeImage")));
            this.ExistingCarRibbonButton.Name = "ExistingCarRibbonButton";
            this.ExistingCarRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("ExistingCarRibbonButton.SmallImage")));
            this.ExistingCarRibbonButton.Text = "Existing";
            // 
            // SimSetupRibbonTab
            // 
            this.SimSetupRibbonTab.Name = "SimSetupRibbonTab";
            this.SimSetupRibbonTab.Panels.Add(this.InputSignalRibbonPanel);
            this.SimSetupRibbonTab.Text = "Simulation Setup";
            this.SimSetupRibbonTab.ActiveChanged += new System.EventHandler(this.SimSetupRibbonTab_ActiveChanged);
            // 
            // InputSignalRibbonPanel
            // 
            this.InputSignalRibbonPanel.Items.Add(this.ResponseToICRibbonButton);
            this.InputSignalRibbonPanel.Items.Add(this.HarmonicIPRibbonButton);
            this.InputSignalRibbonPanel.Items.Add(this.CombinedIPRibbonButton);
            this.InputSignalRibbonPanel.Name = "InputSignalRibbonPanel";
            this.InputSignalRibbonPanel.Text = "Input Signal";
            // 
            // ResponseToICRibbonButton
            // 
            this.ResponseToICRibbonButton.DropDownItems.Add(this.ribbonButton2);
            this.ResponseToICRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("ResponseToICRibbonButton.Image")));
            this.ResponseToICRibbonButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("ResponseToICRibbonButton.LargeImage")));
            this.ResponseToICRibbonButton.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large;
            this.ResponseToICRibbonButton.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large;
            this.ResponseToICRibbonButton.Name = "ResponseToICRibbonButton";
            this.ResponseToICRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("ResponseToICRibbonButton.SmallImage")));
            this.ResponseToICRibbonButton.Text = "Initial Condition Response";
            this.ResponseToICRibbonButton.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Right;
            this.ResponseToICRibbonButton.Click += new System.EventHandler(this.ResponseToICRibbonButton_Click);
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.Image")));
            this.ribbonButton2.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.LargeImage")));
            this.ribbonButton2.Name = "ribbonButton2";
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            this.ribbonButton2.Text = "ribbonButton2";
            // 
            // HarmonicIPRibbonButton
            // 
            this.HarmonicIPRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("HarmonicIPRibbonButton.Image")));
            this.HarmonicIPRibbonButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("HarmonicIPRibbonButton.LargeImage")));
            this.HarmonicIPRibbonButton.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large;
            this.HarmonicIPRibbonButton.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large;
            this.HarmonicIPRibbonButton.Name = "HarmonicIPRibbonButton";
            this.HarmonicIPRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("HarmonicIPRibbonButton.SmallImage")));
            this.HarmonicIPRibbonButton.Text = "Harmonic Input";
            this.HarmonicIPRibbonButton.Click += new System.EventHandler(this.HarmonicIPRibbonButton_Click);
            // 
            // CombinedIPRibbonButton
            // 
            this.CombinedIPRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("CombinedIPRibbonButton.Image")));
            this.CombinedIPRibbonButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("CombinedIPRibbonButton.LargeImage")));
            this.CombinedIPRibbonButton.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large;
            this.CombinedIPRibbonButton.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large;
            this.CombinedIPRibbonButton.Name = "CombinedIPRibbonButton";
            this.CombinedIPRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("CombinedIPRibbonButton.SmallImage")));
            this.CombinedIPRibbonButton.Text = "Combined Input";
            // 
            // ResultsRibbonTab
            // 
            this.ResultsRibbonTab.Name = "ResultsRibbonTab";
            this.ResultsRibbonTab.Panels.Add(this.RunRibbonPanel);
            this.ResultsRibbonTab.Text = "Results";
            // 
            // RunRibbonPanel
            // 
            this.RunRibbonPanel.Items.Add(this.RunRibbonButton);
            this.RunRibbonPanel.Name = "RunRibbonPanel";
            this.RunRibbonPanel.Text = "Run";
            // 
            // RunRibbonButton
            // 
            this.RunRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("RunRibbonButton.Image")));
            this.RunRibbonButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("RunRibbonButton.LargeImage")));
            this.RunRibbonButton.Name = "RunRibbonButton";
            this.RunRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("RunRibbonButton.SmallImage")));
            this.RunRibbonButton.Text = "Run";
            // 
            // ribbonSeparator1
            // 
            this.ribbonSeparator1.Name = "ribbonSeparator1";
            // 
            // PropertiesPanel
            // 
            this.PropertiesPanel.BackColor = System.Drawing.Color.Silver;
            this.PropertiesPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PropertiesPanel.Controls.Add(this.VehicleParameterLabel);
            this.PropertiesPanel.Controls.Add(this.VehicleMassLabel);
            this.PropertiesPanel.Controls.Add(this.DampingCoeffTextBox);
            this.PropertiesPanel.Controls.Add(this.VehicleMassUnitLabel);
            this.PropertiesPanel.Controls.Add(this.SpringStiffnessLabel);
            this.PropertiesPanel.Controls.Add(this.SpringStiffnessTextBox);
            this.PropertiesPanel.Controls.Add(this.DampingCoeffLabel);
            this.PropertiesPanel.Controls.Add(this.SpringStiffnessUnitLabel);
            this.PropertiesPanel.Controls.Add(this.DampingCoeffUnitLabel);
            this.PropertiesPanel.Controls.Add(this.VehicleMassTextBox);
            this.PropertiesPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.PropertiesPanel.Location = new System.Drawing.Point(0, 0);
            this.PropertiesPanel.Name = "PropertiesPanel";
            this.PropertiesPanel.Size = new System.Drawing.Size(295, 612);
            this.PropertiesPanel.TabIndex = 2;
            this.PropertiesPanel.Visible = false;
            // 
            // VehicleParameterLabel
            // 
            this.VehicleParameterLabel.AutoSize = true;
            this.VehicleParameterLabel.Location = new System.Drawing.Point(0, 0);
            this.VehicleParameterLabel.Name = "VehicleParameterLabel";
            this.VehicleParameterLabel.Size = new System.Drawing.Size(188, 22);
            this.VehicleParameterLabel.TabIndex = 4;
            this.VehicleParameterLabel.Text = "Vehicle Parameters";
            // 
            // VehicleMassLabel
            // 
            this.VehicleMassLabel.AutoSize = true;
            this.VehicleMassLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleMassLabel.Location = new System.Drawing.Point(3, 39);
            this.VehicleMassLabel.Name = "VehicleMassLabel";
            this.VehicleMassLabel.Size = new System.Drawing.Size(89, 17);
            this.VehicleMassLabel.TabIndex = 0;
            this.VehicleMassLabel.Text = "Vehicle Mass";
            // 
            // DampingCoeffTextBox
            // 
            this.DampingCoeffTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DampingCoeffTextBox.Location = new System.Drawing.Point(153, 104);
            this.DampingCoeffTextBox.Name = "DampingCoeffTextBox";
            this.DampingCoeffTextBox.Size = new System.Drawing.Size(63, 22);
            this.DampingCoeffTextBox.TabIndex = 1;
            this.DampingCoeffTextBox.LostFocus += new System.EventHandler(this.DampingCoeffTextBox_TextChanged);
            // 
            // VehicleMassUnitLabel
            // 
            this.VehicleMassUnitLabel.AutoSize = true;
            this.VehicleMassUnitLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleMassUnitLabel.Location = new System.Drawing.Point(222, 39);
            this.VehicleMassUnitLabel.Name = "VehicleMassUnitLabel";
            this.VehicleMassUnitLabel.Size = new System.Drawing.Size(25, 17);
            this.VehicleMassUnitLabel.TabIndex = 0;
            this.VehicleMassUnitLabel.Text = "Kg";
            // 
            // SpringStiffnessLabel
            // 
            this.SpringStiffnessLabel.AutoSize = true;
            this.SpringStiffnessLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpringStiffnessLabel.Location = new System.Drawing.Point(3, 73);
            this.SpringStiffnessLabel.Name = "SpringStiffnessLabel";
            this.SpringStiffnessLabel.Size = new System.Drawing.Size(99, 17);
            this.SpringStiffnessLabel.TabIndex = 0;
            this.SpringStiffnessLabel.Text = "Spring Stiffness";
            // 
            // SpringStiffnessTextBox
            // 
            this.SpringStiffnessTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpringStiffnessTextBox.Location = new System.Drawing.Point(153, 70);
            this.SpringStiffnessTextBox.Name = "SpringStiffnessTextBox";
            this.SpringStiffnessTextBox.Size = new System.Drawing.Size(63, 22);
            this.SpringStiffnessTextBox.TabIndex = 1;
            this.SpringStiffnessTextBox.LostFocus += new System.EventHandler(this.SpringStiffnessTextBox_TextChanged);
            // 
            // DampingCoeffLabel
            // 
            this.DampingCoeffLabel.AutoSize = true;
            this.DampingCoeffLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DampingCoeffLabel.Location = new System.Drawing.Point(3, 107);
            this.DampingCoeffLabel.Name = "DampingCoeffLabel";
            this.DampingCoeffLabel.Size = new System.Drawing.Size(144, 17);
            this.DampingCoeffLabel.TabIndex = 0;
            this.DampingCoeffLabel.Text = "Damping Coefficient";
            // 
            // SpringStiffnessUnitLabel
            // 
            this.SpringStiffnessUnitLabel.AutoSize = true;
            this.SpringStiffnessUnitLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpringStiffnessUnitLabel.Location = new System.Drawing.Point(222, 73);
            this.SpringStiffnessUnitLabel.Name = "SpringStiffnessUnitLabel";
            this.SpringStiffnessUnitLabel.Size = new System.Drawing.Size(37, 17);
            this.SpringStiffnessUnitLabel.TabIndex = 0;
            this.SpringStiffnessUnitLabel.Text = "N/m";
            // 
            // DampingCoeffUnitLabel
            // 
            this.DampingCoeffUnitLabel.AutoSize = true;
            this.DampingCoeffUnitLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DampingCoeffUnitLabel.Location = new System.Drawing.Point(222, 107);
            this.DampingCoeffUnitLabel.Name = "DampingCoeffUnitLabel";
            this.DampingCoeffUnitLabel.Size = new System.Drawing.Size(57, 17);
            this.DampingCoeffUnitLabel.TabIndex = 0;
            this.DampingCoeffUnitLabel.Text = "N/(m/s)";
            // 
            // VehicleMassTextBox
            // 
            this.VehicleMassTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleMassTextBox.Location = new System.Drawing.Point(153, 36);
            this.VehicleMassTextBox.Name = "VehicleMassTextBox";
            this.VehicleMassTextBox.Size = new System.Drawing.Size(63, 22);
            this.VehicleMassTextBox.TabIndex = 1;
            this.VehicleMassTextBox.LostFocus += new System.EventHandler(this.VehicleMassTextBox_TextChanged);
            // 
            // SimulationSetupPanel
            // 
            this.SimulationSetupPanel.BackColor = System.Drawing.Color.Silver;
            this.SimulationSetupPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SimulationSetupPanel.Controls.Add(this.InitializeButton);
            this.SimulationSetupPanel.Controls.Add(this.HarmonicInputDataGroupBox);
            this.SimulationSetupPanel.Controls.Add(this.InitialConditionGroupBox);
            this.SimulationSetupPanel.Controls.Add(this.TimeSetupPanel);
            this.SimulationSetupPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SimulationSetupPanel.Location = new System.Drawing.Point(295, 0);
            this.SimulationSetupPanel.Name = "SimulationSetupPanel";
            this.SimulationSetupPanel.Size = new System.Drawing.Size(295, 612);
            this.SimulationSetupPanel.TabIndex = 3;
            this.SimulationSetupPanel.Visible = false;
            // 
            // InitializeButton
            // 
            this.InitializeButton.Location = new System.Drawing.Point(7, 361);
            this.InitializeButton.Name = "InitializeButton";
            this.InitializeButton.Size = new System.Drawing.Size(109, 29);
            this.InitializeButton.TabIndex = 8;
            this.InitializeButton.Text = "Initialize";
            this.InitializeButton.UseVisualStyleBackColor = true;
            this.InitializeButton.Click += new System.EventHandler(this.InitializeButton_Click);
            // 
            // HarmonicInputDataGroupBox
            // 
            this.HarmonicInputDataGroupBox.Controls.Add(this.OscillationFrequencyLabel);
            this.HarmonicInputDataGroupBox.Controls.Add(this.ForceAmplitudeLabel);
            this.HarmonicInputDataGroupBox.Controls.Add(this.ForceAmplitudeTextBox);
            this.HarmonicInputDataGroupBox.Controls.Add(this.ForceAmplitudeUnitLabel);
            this.HarmonicInputDataGroupBox.Controls.Add(this.OscillationFrequencyUnitLabel);
            this.HarmonicInputDataGroupBox.Controls.Add(this.OscillationFrequencyTextBox);
            this.HarmonicInputDataGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.HarmonicInputDataGroupBox.Location = new System.Drawing.Point(0, 239);
            this.HarmonicInputDataGroupBox.Name = "HarmonicInputDataGroupBox";
            this.HarmonicInputDataGroupBox.Size = new System.Drawing.Size(291, 100);
            this.HarmonicInputDataGroupBox.TabIndex = 7;
            this.HarmonicInputDataGroupBox.TabStop = false;
            this.HarmonicInputDataGroupBox.Text = "Harmonic Input Data";
            this.HarmonicInputDataGroupBox.Visible = false;
            // 
            // OscillationFrequencyLabel
            // 
            this.OscillationFrequencyLabel.AutoSize = true;
            this.OscillationFrequencyLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OscillationFrequencyLabel.Location = new System.Drawing.Point(6, 36);
            this.OscillationFrequencyLabel.Name = "OscillationFrequencyLabel";
            this.OscillationFrequencyLabel.Size = new System.Drawing.Size(144, 17);
            this.OscillationFrequencyLabel.TabIndex = 0;
            this.OscillationFrequencyLabel.Text = "Oscillation Frequency";
            // 
            // ForceAmplitudeLabel
            // 
            this.ForceAmplitudeLabel.AutoSize = true;
            this.ForceAmplitudeLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForceAmplitudeLabel.Location = new System.Drawing.Point(6, 73);
            this.ForceAmplitudeLabel.Name = "ForceAmplitudeLabel";
            this.ForceAmplitudeLabel.Size = new System.Drawing.Size(114, 17);
            this.ForceAmplitudeLabel.TabIndex = 0;
            this.ForceAmplitudeLabel.Text = "Force Amplitude";
            // 
            // ForceAmplitudeTextBox
            // 
            this.ForceAmplitudeTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForceAmplitudeTextBox.Location = new System.Drawing.Point(156, 70);
            this.ForceAmplitudeTextBox.Name = "ForceAmplitudeTextBox";
            this.ForceAmplitudeTextBox.Size = new System.Drawing.Size(63, 22);
            this.ForceAmplitudeTextBox.TabIndex = 1;
            this.ForceAmplitudeTextBox.LostFocus += new System.EventHandler(this.ForceAmplitudeTextBox_TextChanged);
            // 
            // ForceAmplitudeUnitLabel
            // 
            this.ForceAmplitudeUnitLabel.AutoSize = true;
            this.ForceAmplitudeUnitLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForceAmplitudeUnitLabel.Location = new System.Drawing.Point(225, 73);
            this.ForceAmplitudeUnitLabel.Name = "ForceAmplitudeUnitLabel";
            this.ForceAmplitudeUnitLabel.Size = new System.Drawing.Size(18, 17);
            this.ForceAmplitudeUnitLabel.TabIndex = 0;
            this.ForceAmplitudeUnitLabel.Text = "N";
            // 
            // OscillationFrequencyUnitLabel
            // 
            this.OscillationFrequencyUnitLabel.AutoSize = true;
            this.OscillationFrequencyUnitLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OscillationFrequencyUnitLabel.Location = new System.Drawing.Point(225, 36);
            this.OscillationFrequencyUnitLabel.Name = "OscillationFrequencyUnitLabel";
            this.OscillationFrequencyUnitLabel.Size = new System.Drawing.Size(23, 17);
            this.OscillationFrequencyUnitLabel.TabIndex = 0;
            this.OscillationFrequencyUnitLabel.Text = "Hz";
            // 
            // OscillationFrequencyTextBox
            // 
            this.OscillationFrequencyTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OscillationFrequencyTextBox.Location = new System.Drawing.Point(156, 33);
            this.OscillationFrequencyTextBox.Name = "OscillationFrequencyTextBox";
            this.OscillationFrequencyTextBox.Size = new System.Drawing.Size(63, 22);
            this.OscillationFrequencyTextBox.TabIndex = 1;
            this.OscillationFrequencyTextBox.LostFocus += new System.EventHandler(this.OscillationFrequencyTextBox_TextChanged);
            // 
            // InitialConditionGroupBox
            // 
            this.InitialConditionGroupBox.Controls.Add(this.InitialDisplacementLabel);
            this.InitialConditionGroupBox.Controls.Add(this.InitialVelcoityLabel);
            this.InitialConditionGroupBox.Controls.Add(this.InitialVelocityUnitLabel);
            this.InitialConditionGroupBox.Controls.Add(this.InitialDisplacementTextBox);
            this.InitialConditionGroupBox.Controls.Add(this.InitialDisplacementUnitLabel);
            this.InitialConditionGroupBox.Controls.Add(this.InitialVelocityTextBox);
            this.InitialConditionGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.InitialConditionGroupBox.Location = new System.Drawing.Point(0, 139);
            this.InitialConditionGroupBox.Name = "InitialConditionGroupBox";
            this.InitialConditionGroupBox.Size = new System.Drawing.Size(291, 100);
            this.InitialConditionGroupBox.TabIndex = 6;
            this.InitialConditionGroupBox.TabStop = false;
            this.InitialConditionGroupBox.Text = "Initial Condition";
            // 
            // InitialDisplacementLabel
            // 
            this.InitialDisplacementLabel.AutoSize = true;
            this.InitialDisplacementLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InitialDisplacementLabel.Location = new System.Drawing.Point(6, 36);
            this.InitialDisplacementLabel.Name = "InitialDisplacementLabel";
            this.InitialDisplacementLabel.Size = new System.Drawing.Size(135, 17);
            this.InitialDisplacementLabel.TabIndex = 0;
            this.InitialDisplacementLabel.Text = "Initial Displacement";
            // 
            // InitialVelcoityLabel
            // 
            this.InitialVelcoityLabel.AutoSize = true;
            this.InitialVelcoityLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InitialVelcoityLabel.Location = new System.Drawing.Point(6, 73);
            this.InitialVelcoityLabel.Name = "InitialVelcoityLabel";
            this.InitialVelcoityLabel.Size = new System.Drawing.Size(97, 17);
            this.InitialVelcoityLabel.TabIndex = 0;
            this.InitialVelcoityLabel.Text = "Initial Velocity";
            // 
            // InitialVelocityUnitLabel
            // 
            this.InitialVelocityUnitLabel.AutoSize = true;
            this.InitialVelocityUnitLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InitialVelocityUnitLabel.Location = new System.Drawing.Point(225, 73);
            this.InitialVelocityUnitLabel.Name = "InitialVelocityUnitLabel";
            this.InitialVelocityUnitLabel.Size = new System.Drawing.Size(32, 17);
            this.InitialVelocityUnitLabel.TabIndex = 0;
            this.InitialVelocityUnitLabel.Text = "m/s";
            // 
            // InitialDisplacementTextBox
            // 
            this.InitialDisplacementTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InitialDisplacementTextBox.Location = new System.Drawing.Point(156, 33);
            this.InitialDisplacementTextBox.Name = "InitialDisplacementTextBox";
            this.InitialDisplacementTextBox.Size = new System.Drawing.Size(63, 22);
            this.InitialDisplacementTextBox.TabIndex = 1;
            this.InitialDisplacementTextBox.LostFocus += new System.EventHandler(this.InitialDisplacement_TextChanged);
            // 
            // InitialDisplacementUnitLabel
            // 
            this.InitialDisplacementUnitLabel.AutoSize = true;
            this.InitialDisplacementUnitLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InitialDisplacementUnitLabel.Location = new System.Drawing.Point(225, 36);
            this.InitialDisplacementUnitLabel.Name = "InitialDisplacementUnitLabel";
            this.InitialDisplacementUnitLabel.Size = new System.Drawing.Size(21, 17);
            this.InitialDisplacementUnitLabel.TabIndex = 0;
            this.InitialDisplacementUnitLabel.Text = "m";
            // 
            // InitialVelocityTextBox
            // 
            this.InitialVelocityTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InitialVelocityTextBox.Location = new System.Drawing.Point(156, 70);
            this.InitialVelocityTextBox.Name = "InitialVelocityTextBox";
            this.InitialVelocityTextBox.Size = new System.Drawing.Size(63, 22);
            this.InitialVelocityTextBox.TabIndex = 1;
            this.InitialVelocityTextBox.LostFocus += new System.EventHandler(this.InitialVelocityTextBox_TextChanged);
            // 
            // TimeSetupPanel
            // 
            this.TimeSetupPanel.Controls.Add(this.TimeSetupHeadingLabel);
            this.TimeSetupPanel.Controls.Add(this.EndTimeTextBox);
            this.TimeSetupPanel.Controls.Add(this.StartTimeLabel);
            this.TimeSetupPanel.Controls.Add(this.EndTimeLabel);
            this.TimeSetupPanel.Controls.Add(this.StartTimeTextBox);
            this.TimeSetupPanel.Controls.Add(this.TimeStepLabel);
            this.TimeSetupPanel.Controls.Add(this.StartTimeUnitLabel);
            this.TimeSetupPanel.Controls.Add(this.EndTimeUnitLabel);
            this.TimeSetupPanel.Controls.Add(this.TimeStepUnitLabel);
            this.TimeSetupPanel.Controls.Add(this.TimeStepTextBox);
            this.TimeSetupPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TimeSetupPanel.Location = new System.Drawing.Point(0, 0);
            this.TimeSetupPanel.Name = "TimeSetupPanel";
            this.TimeSetupPanel.Size = new System.Drawing.Size(291, 139);
            this.TimeSetupPanel.TabIndex = 5;
            // 
            // TimeSetupHeadingLabel
            // 
            this.TimeSetupHeadingLabel.AutoSize = true;
            this.TimeSetupHeadingLabel.Location = new System.Drawing.Point(5, 1);
            this.TimeSetupHeadingLabel.Name = "TimeSetupHeadingLabel";
            this.TimeSetupHeadingLabel.Size = new System.Drawing.Size(108, 22);
            this.TimeSetupHeadingLabel.TabIndex = 2;
            this.TimeSetupHeadingLabel.Text = "Time Setup";
            // 
            // EndTimeTextBox
            // 
            this.EndTimeTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndTimeTextBox.Location = new System.Drawing.Point(156, 74);
            this.EndTimeTextBox.Name = "EndTimeTextBox";
            this.EndTimeTextBox.Size = new System.Drawing.Size(63, 22);
            this.EndTimeTextBox.TabIndex = 1;
            this.EndTimeTextBox.LostFocus += new System.EventHandler(this.EndTimeTextBox_TextChanged);
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.AutoSize = true;
            this.StartTimeLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTimeLabel.Location = new System.Drawing.Point(6, 43);
            this.StartTimeLabel.Name = "StartTimeLabel";
            this.StartTimeLabel.Size = new System.Drawing.Size(70, 17);
            this.StartTimeLabel.TabIndex = 0;
            this.StartTimeLabel.Text = "Start Time";
            // 
            // EndTimeLabel
            // 
            this.EndTimeLabel.AutoSize = true;
            this.EndTimeLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndTimeLabel.Location = new System.Drawing.Point(6, 77);
            this.EndTimeLabel.Name = "EndTimeLabel";
            this.EndTimeLabel.Size = new System.Drawing.Size(65, 17);
            this.EndTimeLabel.TabIndex = 0;
            this.EndTimeLabel.Text = "End Time";
            // 
            // StartTimeTextBox
            // 
            this.StartTimeTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTimeTextBox.Location = new System.Drawing.Point(156, 40);
            this.StartTimeTextBox.Name = "StartTimeTextBox";
            this.StartTimeTextBox.Size = new System.Drawing.Size(63, 22);
            this.StartTimeTextBox.TabIndex = 1;
            this.StartTimeTextBox.LostFocus += new System.EventHandler(this.StartTimeTextBox_TextChanged);
            // 
            // TimeStepLabel
            // 
            this.TimeStepLabel.AutoSize = true;
            this.TimeStepLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeStepLabel.Location = new System.Drawing.Point(4, 114);
            this.TimeStepLabel.Name = "TimeStepLabel";
            this.TimeStepLabel.Size = new System.Drawing.Size(69, 17);
            this.TimeStepLabel.TabIndex = 0;
            this.TimeStepLabel.Text = "Time Step";
            // 
            // StartTimeUnitLabel
            // 
            this.StartTimeUnitLabel.AutoSize = true;
            this.StartTimeUnitLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTimeUnitLabel.Location = new System.Drawing.Point(225, 43);
            this.StartTimeUnitLabel.Name = "StartTimeUnitLabel";
            this.StartTimeUnitLabel.Size = new System.Drawing.Size(30, 17);
            this.StartTimeUnitLabel.TabIndex = 0;
            this.StartTimeUnitLabel.Text = "Sec";
            // 
            // EndTimeUnitLabel
            // 
            this.EndTimeUnitLabel.AutoSize = true;
            this.EndTimeUnitLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndTimeUnitLabel.Location = new System.Drawing.Point(225, 77);
            this.EndTimeUnitLabel.Name = "EndTimeUnitLabel";
            this.EndTimeUnitLabel.Size = new System.Drawing.Size(30, 17);
            this.EndTimeUnitLabel.TabIndex = 0;
            this.EndTimeUnitLabel.Text = "Sec";
            // 
            // TimeStepUnitLabel
            // 
            this.TimeStepUnitLabel.AutoSize = true;
            this.TimeStepUnitLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeStepUnitLabel.Location = new System.Drawing.Point(223, 114);
            this.TimeStepUnitLabel.Name = "TimeStepUnitLabel";
            this.TimeStepUnitLabel.Size = new System.Drawing.Size(30, 17);
            this.TimeStepUnitLabel.TabIndex = 0;
            this.TimeStepUnitLabel.Text = "Sec";
            // 
            // TimeStepTextBox
            // 
            this.TimeStepTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeStepTextBox.Location = new System.Drawing.Point(154, 111);
            this.TimeStepTextBox.Name = "TimeStepTextBox";
            this.TimeStepTextBox.Size = new System.Drawing.Size(63, 22);
            this.TimeStepTextBox.TabIndex = 1;
            this.TimeStepTextBox.LostFocus += new System.EventHandler(this.TimeStepTextBox_TextChanged);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.ResponseToICPanel);
            this.MainPanel.Controls.Add(this.InputSignalPanel);
            this.MainPanel.Controls.Add(this.CombinedResponsePanel);
            this.MainPanel.Controls.Add(this.ResponseToHarmonicIPPanel);
            this.MainPanel.Controls.Add(this.SimulationSetupPanel);
            this.MainPanel.Controls.Add(this.PropertiesPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 176);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1268, 612);
            this.MainPanel.TabIndex = 4;
            // 
            // ResponseToICPanel
            // 
            this.ResponseToICPanel.Controls.Add(this.ResponseToICCartesianChart);
            this.ResponseToICPanel.Location = new System.Drawing.Point(596, 233);
            this.ResponseToICPanel.Name = "ResponseToICPanel";
            this.ResponseToICPanel.Size = new System.Drawing.Size(323, 153);
            this.ResponseToICPanel.TabIndex = 7;
            this.ResponseToICPanel.Visible = false;
            // 
            // ResponseToICCartesianChart
            // 
            this.ResponseToICCartesianChart.Location = new System.Drawing.Point(27, 12);
            this.ResponseToICCartesianChart.Name = "ResponseToICCartesianChart";
            this.ResponseToICCartesianChart.Size = new System.Drawing.Size(260, 122);
            this.ResponseToICCartesianChart.TabIndex = 4;
            this.ResponseToICCartesianChart.Text = "Response To Initial Conditions";
            // 
            // InputSignalPanel
            // 
            this.InputSignalPanel.Controls.Add(this.HarmonicInputCartesianChart);
            this.InputSignalPanel.Location = new System.Drawing.Point(590, 0);
            this.InputSignalPanel.Name = "InputSignalPanel";
            this.InputSignalPanel.Size = new System.Drawing.Size(678, 220);
            this.InputSignalPanel.TabIndex = 6;
            this.InputSignalPanel.Visible = false;
            // 
            // HarmonicInputCartesianChart
            // 
            this.HarmonicInputCartesianChart.Location = new System.Drawing.Point(17, 28);
            this.HarmonicInputCartesianChart.Name = "HarmonicInputCartesianChart";
            this.HarmonicInputCartesianChart.Size = new System.Drawing.Size(649, 179);
            this.HarmonicInputCartesianChart.TabIndex = 5;
            this.HarmonicInputCartesianChart.Text = "Harmonic Input";
            // 
            // CombinedResponsePanel
            // 
            this.CombinedResponsePanel.Controls.Add(this.CombinedResponseCartesianChart);
            this.CombinedResponsePanel.Location = new System.Drawing.Point(590, 392);
            this.CombinedResponsePanel.Name = "CombinedResponsePanel";
            this.CombinedResponsePanel.Size = new System.Drawing.Size(678, 220);
            this.CombinedResponsePanel.TabIndex = 9;
            this.CombinedResponsePanel.Visible = false;
            // 
            // CombinedResponseCartesianChart
            // 
            this.CombinedResponseCartesianChart.Location = new System.Drawing.Point(17, 14);
            this.CombinedResponseCartesianChart.Name = "CombinedResponseCartesianChart";
            this.CombinedResponseCartesianChart.Size = new System.Drawing.Size(649, 203);
            this.CombinedResponseCartesianChart.TabIndex = 5;
            this.CombinedResponseCartesianChart.Text = "Harmonic Input";
            // 
            // ResponseToHarmonicIPPanel
            // 
            this.ResponseToHarmonicIPPanel.Controls.Add(this.ResponseToHarmonicInputCatrtesianChart);
            this.ResponseToHarmonicIPPanel.Location = new System.Drawing.Point(933, 233);
            this.ResponseToHarmonicIPPanel.Name = "ResponseToHarmonicIPPanel";
            this.ResponseToHarmonicIPPanel.Size = new System.Drawing.Size(323, 153);
            this.ResponseToHarmonicIPPanel.TabIndex = 8;
            this.ResponseToHarmonicIPPanel.Visible = false;
            // 
            // ResponseToHarmonicInputCatrtesianChart
            // 
            this.ResponseToHarmonicInputCatrtesianChart.Location = new System.Drawing.Point(27, 12);
            this.ResponseToHarmonicInputCatrtesianChart.Name = "ResponseToHarmonicInputCatrtesianChart";
            this.ResponseToHarmonicInputCatrtesianChart.Size = new System.Drawing.Size(260, 122);
            this.ResponseToHarmonicInputCatrtesianChart.TabIndex = 4;
            this.ResponseToHarmonicInputCatrtesianChart.Text = "Response ToHarmonic Input";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1268, 788);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.NewRibbon);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Post Rig";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PropertiesPanel.ResumeLayout(false);
            this.PropertiesPanel.PerformLayout();
            this.SimulationSetupPanel.ResumeLayout(false);
            this.HarmonicInputDataGroupBox.ResumeLayout(false);
            this.HarmonicInputDataGroupBox.PerformLayout();
            this.InitialConditionGroupBox.ResumeLayout(false);
            this.InitialConditionGroupBox.PerformLayout();
            this.TimeSetupPanel.ResumeLayout(false);
            this.TimeSetupPanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.ResponseToICPanel.ResumeLayout(false);
            this.InputSignalPanel.ResumeLayout(false);
            this.CombinedResponsePanel.ResumeLayout(false);
            this.ResponseToHarmonicIPPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.Ribbon NewRibbon;
        private System.Windows.Forms.RibbonTab DesignRibbonTab;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonTab SimSetupRibbonTab;
        private System.Windows.Forms.RibbonTab ResultsRibbonTab;
        private System.Windows.Forms.RibbonPanel BuildCarRibbonPanel;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caseStudyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenu;
        private System.Windows.Forms.Panel PropertiesPanel;
        private System.Windows.Forms.Label DampingCoeffLabel;
        private System.Windows.Forms.Label SpringStiffnessLabel;
        private System.Windows.Forms.Label VehicleMassLabel;
        private System.Windows.Forms.TextBox VehicleMassTextBox;
        private System.Windows.Forms.Label VehicleMassUnitLabel;
        private System.Windows.Forms.TextBox DampingCoeffTextBox;
        private System.Windows.Forms.TextBox SpringStiffnessTextBox;
        private System.Windows.Forms.Label SpringStiffnessUnitLabel;
        private System.Windows.Forms.Label DampingCoeffUnitLabel;
        private System.Windows.Forms.RibbonPanel InputSignalRibbonPanel;
        private System.Windows.Forms.RibbonButton ResponseToICRibbonButton;
        private System.Windows.Forms.RibbonButton HarmonicIPRibbonButton;
        private System.Windows.Forms.RibbonButton CombinedIPRibbonButton;
        private System.Windows.Forms.Label VehicleParameterLabel;
        private System.Windows.Forms.Panel SimulationSetupPanel;
        private System.Windows.Forms.Label TimeSetupHeadingLabel;
        private System.Windows.Forms.Label StartTimeLabel;
        private System.Windows.Forms.TextBox StartTimeTextBox;
        private System.Windows.Forms.Label InitialVelocityUnitLabel;
        private System.Windows.Forms.Label InitialDisplacementUnitLabel;
        private System.Windows.Forms.Label TimeStepUnitLabel;
        private System.Windows.Forms.TextBox InitialVelocityTextBox;
        private System.Windows.Forms.TextBox InitialDisplacementTextBox;
        private System.Windows.Forms.TextBox TimeStepTextBox;
        private System.Windows.Forms.Label InitialVelcoityLabel;
        private System.Windows.Forms.Label EndTimeUnitLabel;
        private System.Windows.Forms.Label InitialDisplacementLabel;
        private System.Windows.Forms.Label StartTimeUnitLabel;
        private System.Windows.Forms.Label TimeStepLabel;
        private System.Windows.Forms.Label EndTimeLabel;
        private System.Windows.Forms.TextBox EndTimeTextBox;
        private System.Windows.Forms.Panel MainPanel;
        private LiveCharts.WinForms.CartesianChart ResponseToICCartesianChart;
        private System.Windows.Forms.Panel TimeSetupPanel;
        private System.Windows.Forms.GroupBox InitialConditionGroupBox;
        private System.Windows.Forms.GroupBox HarmonicInputDataGroupBox;
        private System.Windows.Forms.Label OscillationFrequencyLabel;
        private System.Windows.Forms.Label ForceAmplitudeLabel;
        private System.Windows.Forms.TextBox ForceAmplitudeTextBox;
        private System.Windows.Forms.Label ForceAmplitudeUnitLabel;
        private System.Windows.Forms.Label OscillationFrequencyUnitLabel;
        private System.Windows.Forms.TextBox OscillationFrequencyTextBox;
        private LiveCharts.WinForms.CartesianChart HarmonicInputCartesianChart;
        private System.Windows.Forms.RibbonPanel RunRibbonPanel;
        private System.Windows.Forms.RibbonButton RunRibbonButton;
        private System.Windows.Forms.Button InitializeButton;
        private System.Windows.Forms.Panel CombinedResponsePanel;
        private LiveCharts.WinForms.CartesianChart CombinedResponseCartesianChart;
        private System.Windows.Forms.Panel ResponseToHarmonicIPPanel;
        private LiveCharts.WinForms.CartesianChart ResponseToHarmonicInputCatrtesianChart;
        private System.Windows.Forms.Panel ResponseToICPanel;
        private System.Windows.Forms.Panel InputSignalPanel;
        private System.Windows.Forms.RibbonButton ribbonButton2;
        private System.Windows.Forms.RibbonButton NewCarRibbonButton;
        private System.Windows.Forms.RibbonButton ExistingCarRibbonButton;
        //private System.Windows.Forms.RibbonPanel NewCarRibbonPanel;
    }
}

