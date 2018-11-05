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
            this.CarDrpRibbonButton = new System.Windows.Forms.RibbonButton();
            this.NewCarRibbonButton = new System.Windows.Forms.RibbonButton();
            this.ExisitingCarRibbonButton = new System.Windows.Forms.RibbonButton();
            this.SimSetupRibbonTab = new System.Windows.Forms.RibbonTab();
            this.InputSignalRibbonPanel = new System.Windows.Forms.RibbonPanel();
            this.StepIPRibbonButton = new System.Windows.Forms.RibbonButton();
            this.HarmonicIPRibbonButton = new System.Windows.Forms.RibbonButton();
            this.CustomIPRibbonButton = new System.Windows.Forms.RibbonButton();
            this.ResultsRibbonTab = new System.Windows.Forms.RibbonTab();
            this.ribbonSeparator1 = new System.Windows.Forms.RibbonSeparator();
            this.PropertiesPanel = new System.Windows.Forms.Panel();
            this.StepInputPanel = new System.Windows.Forms.Panel();
            this.StepInputHeadingLabel = new System.Windows.Forms.Label();
            this.StartTimeLabel = new System.Windows.Forms.Label();
            this.StartTimeTextBox = new System.Windows.Forms.TextBox();
            this.StepAmplitudeUnitLabel = new System.Windows.Forms.Label();
            this.StepTimeUnitLabel = new System.Windows.Forms.Label();
            this.TimeStepUnitLabel = new System.Windows.Forms.Label();
            this.StepAmplitudeTextBox = new System.Windows.Forms.TextBox();
            this.StepTimeTextBox = new System.Windows.Forms.TextBox();
            this.TimeStepTextBox = new System.Windows.Forms.TextBox();
            this.StepAmplitudeLabel = new System.Windows.Forms.Label();
            this.EndTimeUnitLabel = new System.Windows.Forms.Label();
            this.StepTimeLabel = new System.Windows.Forms.Label();
            this.StartTimeUnitLabel = new System.Windows.Forms.Label();
            this.TimeStepLabel = new System.Windows.Forms.Label();
            this.EndTimeLabel = new System.Windows.Forms.Label();
            this.EndTimeTextBox = new System.Windows.Forms.TextBox();
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.PropertiesPanel.SuspendLayout();
            this.StepInputPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1055, 24);
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
            this.NewRibbon.Size = new System.Drawing.Size(1055, 152);
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
            // 
            // BuildCarRibbonPanel
            // 
            this.BuildCarRibbonPanel.Items.Add(this.CarDrpRibbonButton);
            this.BuildCarRibbonPanel.Name = "BuildCarRibbonPanel";
            this.BuildCarRibbonPanel.Text = "Build Car";
            // 
            // CarDrpRibbonButton
            // 
            this.CarDrpRibbonButton.DropDownItems.Add(this.NewCarRibbonButton);
            this.CarDrpRibbonButton.DropDownItems.Add(this.ExisitingCarRibbonButton);
            this.CarDrpRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("CarDrpRibbonButton.Image")));
            this.CarDrpRibbonButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("CarDrpRibbonButton.LargeImage")));
            this.CarDrpRibbonButton.Name = "CarDrpRibbonButton";
            this.CarDrpRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("CarDrpRibbonButton.SmallImage")));
            this.CarDrpRibbonButton.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            this.CarDrpRibbonButton.Text = "Car";
            this.CarDrpRibbonButton.Click += new System.EventHandler(this.CarDrpRibbonButton_Click);
            // 
            // NewCarRibbonButton
            // 
            this.NewCarRibbonButton.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.NewCarRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("NewCarRibbonButton.Image")));
            this.NewCarRibbonButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("NewCarRibbonButton.LargeImage")));
            this.NewCarRibbonButton.Name = "NewCarRibbonButton";
            this.NewCarRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("NewCarRibbonButton.SmallImage")));
            this.NewCarRibbonButton.Text = "New";
            this.NewCarRibbonButton.Click += new System.EventHandler(this.NewCarRibbonButton_Click);
            // 
            // ExisitingCarRibbonButton
            // 
            this.ExisitingCarRibbonButton.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ExisitingCarRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("ExisitingCarRibbonButton.Image")));
            this.ExisitingCarRibbonButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("ExisitingCarRibbonButton.LargeImage")));
            this.ExisitingCarRibbonButton.Name = "ExisitingCarRibbonButton";
            this.ExisitingCarRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("ExisitingCarRibbonButton.SmallImage")));
            this.ExisitingCarRibbonButton.Text = "Existing";
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
            this.InputSignalRibbonPanel.Items.Add(this.StepIPRibbonButton);
            this.InputSignalRibbonPanel.Items.Add(this.HarmonicIPRibbonButton);
            this.InputSignalRibbonPanel.Items.Add(this.CustomIPRibbonButton);
            this.InputSignalRibbonPanel.Name = "InputSignalRibbonPanel";
            this.InputSignalRibbonPanel.Text = "Input Signal";
            // 
            // StepIPRibbonButton
            // 
            this.StepIPRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("StepIPRibbonButton.Image")));
            this.StepIPRibbonButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("StepIPRibbonButton.LargeImage")));
            this.StepIPRibbonButton.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large;
            this.StepIPRibbonButton.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large;
            this.StepIPRibbonButton.Name = "StepIPRibbonButton";
            this.StepIPRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("StepIPRibbonButton.SmallImage")));
            this.StepIPRibbonButton.Text = "Step Input";
            this.StepIPRibbonButton.Click += new System.EventHandler(this.StepIPRibbonButton_Click);
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
            // 
            // CustomIPRibbonButton
            // 
            this.CustomIPRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("CustomIPRibbonButton.Image")));
            this.CustomIPRibbonButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("CustomIPRibbonButton.LargeImage")));
            this.CustomIPRibbonButton.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large;
            this.CustomIPRibbonButton.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large;
            this.CustomIPRibbonButton.Name = "CustomIPRibbonButton";
            this.CustomIPRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("CustomIPRibbonButton.SmallImage")));
            this.CustomIPRibbonButton.Text = "Custom Input";
            // 
            // ResultsRibbonTab
            // 
            this.ResultsRibbonTab.Name = "ResultsRibbonTab";
            this.ResultsRibbonTab.Text = "Results";
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
            this.PropertiesPanel.Size = new System.Drawing.Size(295, 559);
            this.PropertiesPanel.TabIndex = 2;
            this.PropertiesPanel.Visible = false;
            // 
            // StepInputPanel
            // 
            this.StepInputPanel.BackColor = System.Drawing.Color.Silver;
            this.StepInputPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StepInputPanel.Controls.Add(this.StepInputHeadingLabel);
            this.StepInputPanel.Controls.Add(this.StartTimeLabel);
            this.StepInputPanel.Controls.Add(this.StartTimeTextBox);
            this.StepInputPanel.Controls.Add(this.StepAmplitudeUnitLabel);
            this.StepInputPanel.Controls.Add(this.StepTimeUnitLabel);
            this.StepInputPanel.Controls.Add(this.TimeStepUnitLabel);
            this.StepInputPanel.Controls.Add(this.StepAmplitudeTextBox);
            this.StepInputPanel.Controls.Add(this.StepTimeTextBox);
            this.StepInputPanel.Controls.Add(this.TimeStepTextBox);
            this.StepInputPanel.Controls.Add(this.StepAmplitudeLabel);
            this.StepInputPanel.Controls.Add(this.EndTimeUnitLabel);
            this.StepInputPanel.Controls.Add(this.StepTimeLabel);
            this.StepInputPanel.Controls.Add(this.StartTimeUnitLabel);
            this.StepInputPanel.Controls.Add(this.TimeStepLabel);
            this.StepInputPanel.Controls.Add(this.EndTimeLabel);
            this.StepInputPanel.Controls.Add(this.EndTimeTextBox);
            this.StepInputPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.StepInputPanel.Location = new System.Drawing.Point(295, 0);
            this.StepInputPanel.Name = "StepInputPanel";
            this.StepInputPanel.Size = new System.Drawing.Size(293, 559);
            this.StepInputPanel.TabIndex = 3;
            this.StepInputPanel.Visible = false;
            // 
            // StepInputHeadingLabel
            // 
            this.StepInputHeadingLabel.AutoSize = true;
            this.StepInputHeadingLabel.Location = new System.Drawing.Point(0, 0);
            this.StepInputHeadingLabel.Name = "StepInputHeadingLabel";
            this.StepInputHeadingLabel.Size = new System.Drawing.Size(105, 22);
            this.StepInputHeadingLabel.TabIndex = 2;
            this.StepInputHeadingLabel.Text = "Step Input";
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.AutoSize = true;
            this.StartTimeLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTimeLabel.Location = new System.Drawing.Point(3, 34);
            this.StartTimeLabel.Name = "StartTimeLabel";
            this.StartTimeLabel.Size = new System.Drawing.Size(70, 17);
            this.StartTimeLabel.TabIndex = 0;
            this.StartTimeLabel.Text = "Start Time";
            // 
            // StartTimeTextBox
            // 
            this.StartTimeTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTimeTextBox.Location = new System.Drawing.Point(153, 31);
            this.StartTimeTextBox.Name = "StartTimeTextBox";
            this.StartTimeTextBox.Size = new System.Drawing.Size(63, 22);
            this.StartTimeTextBox.TabIndex = 1;
            this.StartTimeTextBox.LostFocus += new System.EventHandler(this.StartTimeTextBox_TextChanged);
            // 
            // StepAmplitudeUnitLabel
            // 
            this.StepAmplitudeUnitLabel.AutoSize = true;
            this.StepAmplitudeUnitLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StepAmplitudeUnitLabel.Location = new System.Drawing.Point(220, 179);
            this.StepAmplitudeUnitLabel.Name = "StepAmplitudeUnitLabel";
            this.StepAmplitudeUnitLabel.Size = new System.Drawing.Size(30, 17);
            this.StepAmplitudeUnitLabel.TabIndex = 0;
            this.StepAmplitudeUnitLabel.Text = "Sec";
            // 
            // StepTimeUnitLabel
            // 
            this.StepTimeUnitLabel.AutoSize = true;
            this.StepTimeUnitLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StepTimeUnitLabel.Location = new System.Drawing.Point(220, 142);
            this.StepTimeUnitLabel.Name = "StepTimeUnitLabel";
            this.StepTimeUnitLabel.Size = new System.Drawing.Size(30, 17);
            this.StepTimeUnitLabel.TabIndex = 0;
            this.StepTimeUnitLabel.Text = "Sec";
            // 
            // TimeStepUnitLabel
            // 
            this.TimeStepUnitLabel.AutoSize = true;
            this.TimeStepUnitLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeStepUnitLabel.Location = new System.Drawing.Point(220, 105);
            this.TimeStepUnitLabel.Name = "TimeStepUnitLabel";
            this.TimeStepUnitLabel.Size = new System.Drawing.Size(30, 17);
            this.TimeStepUnitLabel.TabIndex = 0;
            this.TimeStepUnitLabel.Text = "Sec";
            // 
            // StepAmplitudeTextBox
            // 
            this.StepAmplitudeTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StepAmplitudeTextBox.Location = new System.Drawing.Point(151, 176);
            this.StepAmplitudeTextBox.Name = "StepAmplitudeTextBox";
            this.StepAmplitudeTextBox.Size = new System.Drawing.Size(63, 22);
            this.StepAmplitudeTextBox.TabIndex = 1;
            this.StepAmplitudeTextBox.LostFocus += new System.EventHandler(this.StepAmplitudeTextBox_TextChanged);
            // 
            // StepTimeTextBox
            // 
            this.StepTimeTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StepTimeTextBox.Location = new System.Drawing.Point(151, 139);
            this.StepTimeTextBox.Name = "StepTimeTextBox";
            this.StepTimeTextBox.Size = new System.Drawing.Size(63, 22);
            this.StepTimeTextBox.TabIndex = 1;
            this.StepTimeTextBox.TextChanged += new System.EventHandler(this.StepTimeTextBox_TextChanged);
            this.StepTimeTextBox.LostFocus += new System.EventHandler(this.DampingCoeffTextBox_TextChanged);
            // 
            // TimeStepTextBox
            // 
            this.TimeStepTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeStepTextBox.Location = new System.Drawing.Point(151, 102);
            this.TimeStepTextBox.Name = "TimeStepTextBox";
            this.TimeStepTextBox.Size = new System.Drawing.Size(63, 22);
            this.TimeStepTextBox.TabIndex = 1;
            this.TimeStepTextBox.LostFocus += new System.EventHandler(this.TimeStepTextBox_TextChanged);
            // 
            // StepAmplitudeLabel
            // 
            this.StepAmplitudeLabel.AutoSize = true;
            this.StepAmplitudeLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StepAmplitudeLabel.Location = new System.Drawing.Point(1, 179);
            this.StepAmplitudeLabel.Name = "StepAmplitudeLabel";
            this.StepAmplitudeLabel.Size = new System.Drawing.Size(107, 17);
            this.StepAmplitudeLabel.TabIndex = 0;
            this.StepAmplitudeLabel.Text = "Step Amplitude";
            // 
            // EndTimeUnitLabel
            // 
            this.EndTimeUnitLabel.AutoSize = true;
            this.EndTimeUnitLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndTimeUnitLabel.Location = new System.Drawing.Point(222, 68);
            this.EndTimeUnitLabel.Name = "EndTimeUnitLabel";
            this.EndTimeUnitLabel.Size = new System.Drawing.Size(30, 17);
            this.EndTimeUnitLabel.TabIndex = 0;
            this.EndTimeUnitLabel.Text = "Sec";
            // 
            // StepTimeLabel
            // 
            this.StepTimeLabel.AutoSize = true;
            this.StepTimeLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StepTimeLabel.Location = new System.Drawing.Point(1, 142);
            this.StepTimeLabel.Name = "StepTimeLabel";
            this.StepTimeLabel.Size = new System.Drawing.Size(119, 17);
            this.StepTimeLabel.TabIndex = 0;
            this.StepTimeLabel.Text = "Start Time of Step";
            // 
            // StartTimeUnitLabel
            // 
            this.StartTimeUnitLabel.AutoSize = true;
            this.StartTimeUnitLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTimeUnitLabel.Location = new System.Drawing.Point(222, 34);
            this.StartTimeUnitLabel.Name = "StartTimeUnitLabel";
            this.StartTimeUnitLabel.Size = new System.Drawing.Size(30, 17);
            this.StartTimeUnitLabel.TabIndex = 0;
            this.StartTimeUnitLabel.Text = "Sec";
            // 
            // TimeStepLabel
            // 
            this.TimeStepLabel.AutoSize = true;
            this.TimeStepLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeStepLabel.Location = new System.Drawing.Point(1, 105);
            this.TimeStepLabel.Name = "TimeStepLabel";
            this.TimeStepLabel.Size = new System.Drawing.Size(69, 17);
            this.TimeStepLabel.TabIndex = 0;
            this.TimeStepLabel.Text = "Time Step";
            // 
            // EndTimeLabel
            // 
            this.EndTimeLabel.AutoSize = true;
            this.EndTimeLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndTimeLabel.Location = new System.Drawing.Point(3, 68);
            this.EndTimeLabel.Name = "EndTimeLabel";
            this.EndTimeLabel.Size = new System.Drawing.Size(65, 17);
            this.EndTimeLabel.TabIndex = 0;
            this.EndTimeLabel.Text = "End Time";
            // 
            // EndTimeTextBox
            // 
            this.EndTimeTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndTimeTextBox.Location = new System.Drawing.Point(153, 65);
            this.EndTimeTextBox.Name = "EndTimeTextBox";
            this.EndTimeTextBox.Size = new System.Drawing.Size(63, 22);
            this.EndTimeTextBox.TabIndex = 1;
            this.EndTimeTextBox.LostFocus += new System.EventHandler(this.EndTimeTextBox_TextChanged);
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
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.StepInputPanel);
            this.MainPanel.Controls.Add(this.PropertiesPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 176);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1055, 559);
            this.MainPanel.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1055, 735);
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
            this.StepInputPanel.ResumeLayout(false);
            this.StepInputPanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
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
        private System.Windows.Forms.RibbonButton CarDrpRibbonButton;
        private System.Windows.Forms.RibbonButton NewCarRibbonButton;
        private System.Windows.Forms.RibbonButton ExisitingCarRibbonButton;
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
        private System.Windows.Forms.RibbonButton StepIPRibbonButton;
        private System.Windows.Forms.RibbonButton HarmonicIPRibbonButton;
        private System.Windows.Forms.RibbonButton CustomIPRibbonButton;
        private System.Windows.Forms.Label VehicleParameterLabel;
        private System.Windows.Forms.Panel StepInputPanel;
        private System.Windows.Forms.Label StepInputHeadingLabel;
        private System.Windows.Forms.Label StartTimeLabel;
        private System.Windows.Forms.TextBox StartTimeTextBox;
        private System.Windows.Forms.Label StepAmplitudeUnitLabel;
        private System.Windows.Forms.Label StepTimeUnitLabel;
        private System.Windows.Forms.Label TimeStepUnitLabel;
        private System.Windows.Forms.TextBox StepAmplitudeTextBox;
        private System.Windows.Forms.TextBox StepTimeTextBox;
        private System.Windows.Forms.TextBox TimeStepTextBox;
        private System.Windows.Forms.Label StepAmplitudeLabel;
        private System.Windows.Forms.Label EndTimeUnitLabel;
        private System.Windows.Forms.Label StepTimeLabel;
        private System.Windows.Forms.Label StartTimeUnitLabel;
        private System.Windows.Forms.Label TimeStepLabel;
        private System.Windows.Forms.Label EndTimeLabel;
        private System.Windows.Forms.TextBox EndTimeTextBox;
        private System.Windows.Forms.Panel MainPanel;
        //private System.Windows.Forms.RibbonPanel NewCarRibbonPanel;
    }
}

